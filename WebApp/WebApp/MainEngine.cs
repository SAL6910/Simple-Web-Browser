using System.Net;
using System.Text.RegularExpressions;


namespace WebApp
{

    public class MainEngine
    {
        public delegate void AddedToHistoryList(Address url);
      
        public event AddedToHistoryList Changed;

        public delegate void EditInFavoriteList(Address url);
      
        public event EditInFavoriteList Edited;

        private List<Address> history = new List<Address>();
        private Dictionary<String, Address> favorite = new Dictionary<string, Address>();
        private RWFileOperations rwFileOperations = new RWFileOperations();
        private String homePage;
        private String path = System.Windows.Forms.Application.StartupPath;

        /// <summary>
        /// this will load all the txt files on startup
        /// </summary>
        public MainEngine()
        {
            load();
        }
        
        /// <summary>
        /// this  helps to fetch the data from txt files and display in listbox
        /// </summary>
        private void load()
        {
            rwFileOperations.FetchFromFile(ref history, System.IO.Path.Combine(path, "History.txt"), loadToList);
            rwFileOperations.FetchFromFile(ref favorite, System.IO.Path.Combine(path, "Favorite.txt"), loadToDic);
            homePage = rwFileOperations.LoadHomePageURL(System.IO.Path.Combine(path, "Homepage.txt"));
        }

        public static void loadToList(ref List<Address> list, String[] temp, String line)
        {
            temp = line.Split('|');
            list.Add(new Address(temp[0], temp[1], DateTime.FromFileTime(long.Parse(temp[2]))));
        }

        public static void loadToDic(ref Dictionary<String, Address> dictionary, String[] temp, String line)
        {
            temp = line.Split('|');
            dictionary.Add(temp[1], new Address(temp[0], temp[1], DateTime.FromFileTime(long.Parse(temp[2]))));
        }

        public static void loadDownload(ref List<String> list, String[] temp, String line)
        {
            list.Add(line);
        }

        public string HomePage
        {
            get => homePage;
            set
            {
                //we have to keep the changes, so in the next boot, we will not lose it
                homePage = value;
                rwFileOperations.FileUpdate(value, System.IO.Path.Combine(path, "Homepage.txt"), false);
            }
        }

        /// <summary>
        /// this  will bookmark the tab
        /// </summary>
        /// <param name="surl"></param>
        /// <param name="url"></param>
        public void BookmarkTab(String surl, Address url)
        {
            favorite.Add(surl, url);
            writeBackFavorite();
        }

        /// <summary>
        /// this  will remove the bookmark from list
        /// </summary>
        /// <param name="key"></param>
        public void BookmarkRemove(String key)
        {
            favorite.Remove(key);
            writeBackFavorite();
        }

        /// <summary>
        /// this is used to clear the history list
        /// </summary>
        public void ClearHistory()
        {
            String result = "";
            foreach (Address url in history)
            {
                result += "\r\n";
            }
            rwFileOperations.FileUpdate(result, System.IO.Path.Combine(path, "History.txt"), false);
        }

        /// <summary>
        /// this is used to clear the bookmarks list
        /// </summary>
        public void ClearBookmark()
        {
            String result = "";
            foreach (KeyValuePair<String, Address> kv in favorite)
            {
                result += "\r\n";
            }
            rwFileOperations.FileUpdate(result, System.IO.Path.Combine(path, "Favorite.txt"), false);
        }

        /// <summary>
        /// this is used to edit the bookmark
        /// </summary>
        /// <param name="newTitle"></param>
        /// <param name="newkey"></param>
        /// <param name="key"></param>
        public void ChangeBookmark(String newTitle, String newkey, String key)
        {
            DateTime temp = favorite[key].Time;
            favorite.Remove(key);
            Address url = new Address(newTitle, newkey, temp);
            favorite.Add(newkey, url);
            Edited(url);
            writeBackFavorite();
        }

        public Dictionary<String, Address> PullBookmarksList()
        {
            return favorite;
        }

        public bool BookmarkSimilarityCheck(String key)
        {
            return favorite.ContainsKey(key);
        }

        public String PullURLHeader(String key)
        {
            return favorite[key].Title;
        }

        /// <summary>
        /// this  adds the url to history list based on timestamp
        /// </summary>
        /// <param name="url"></param>
        public void addToHistory(Address url)
        {
            history.Insert(0, url);
            writeBackHistory();
            //inform the historyList to do the same thing
            Changed(url);
        }

        /// <summary>
        /// this is used to remove the selected history index
        /// </summary>
        /// <param name="index"></param>
        public void RemoveIndexHistory(int index)
        {
            history.RemoveAt(index);
            writeBackHistory();
        }

        public List<Address> getHistoryList()
        {
            return history;
        }

        public String PullHistoryIndex(int index)
        {
            return history[index].Url;
        }

        private void writeBackFavorite()
        {
            String result = "";
            foreach (KeyValuePair<String, Address> kv in favorite)
            {
                result += kv.Value.ToString();
                result += "\r\n";
            }

            rwFileOperations.FileUpdate(result, System.IO.Path.Combine(path, "Favorite.txt"), false);
        }

        private void writeBackHistory()
        {
            String result = "";
            foreach (Address url in history)
            {
                result += url.ToString();
                result += "\r\n";
            }

            rwFileOperations.FileUpdate(result, System.IO.Path.Combine(path, "History.txt"), false);
        }

        public List<String> getBulkDownloadURLs(String filename)
        {
            List<String> urls = new List<String>();
            rwFileOperations.FetchFromFile(ref urls, filename, loadDownload);
            return urls;
        }
    }

    class MyTabPage : TabPage
    {
        // we display the html code in RichTextBox
        public RichTextBox displayArea = new RichTextBox();

        // address_list will maintain the url to switch between tabs
        public List<String> address_list = new List<string>();

        // we use a int variable to keep the index
        private int pointer_list = -1;

        private MainEngine appHandler;

        public MyTabPage(ref MainEngine appHandler)
        {
            this.appHandler = appHandler;
            displayArea.Multiline = true;
            displayArea.WordWrap = true;
            displayArea.SelectionFont = new Font("Arial", 13);
            displayArea.ReadOnly = true;
            displayArea.Parent = this;
            displayArea.Dock = DockStyle.Fill;
            displayArea.Show();
        }

        public MyTabPage(ref MainEngine appHandler, String url)
        {
            this.appHandler = appHandler;
            displayArea.Multiline = true;
            displayArea.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            displayArea.WordWrap = true;
            displayArea.SelectionFont = new Font("Arial", 13);
            displayArea.ReadOnly = true;
            displayArea.Parent = this;
            displayArea.Dock = DockStyle.Fill;
            ForwardAddressRequest(url);
            displayArea.Show();
        }

        public string title_header;

        /// <summary>
        /// Sending the http request and pulling the html code
        /// </summary>
        /// <param name="url"></param>
        public void ForwardAddressRequest(String url)
        {
            // try and catch is used to detect any errors that may pop
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Method = "Get";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using StreamReader readStream = new StreamReader(response.GetResponseStream());
                String temp = readStream.ReadToEnd();
                this.Text = PullURLHeader(temp).Trim() + " " + Convert.ToInt32(response.StatusCode);
                address_list.Add(url);
                pointer_list = address_list.Count - 1;
                displayArea.Text = temp;
                appHandler.addToHistory(new Address(Text, url, DateTime.Now));
                title_header = this.Text;
            }
            catch (WebException e)
            {
                string pattern = "^\\(+[0-9]*";
                Regex rx = new Regex(pattern);
                displayArea.Text = rx.IsMatch(e.Message.Split(':')[1].Trim()) ? e.Message.Split(':')[1] : e.Message;
                Text = "Web Error";
                address_list.Add(url);
                pointer_list = address_list.Count - 1;
                appHandler.addToHistory(new Address(Text, url, DateTime.Now));
            }
            catch (Exception e)
            {
                displayArea.Text = e.Message;
                Text = "Error";
                address_list.Add(url);
                pointer_list = address_list.Count - 1;
                appHandler.addToHistory(new Address(Text, url, DateTime.Now));
            }
        }

        /// <summary>
        /// we use this to reload the tab
        /// </summary>
        /// <param name="url"></param>
        public void reload(String url)
        {
            int temp = pointer_list;
            ForwardAddressRequest(url);
            pointer_list = temp;
            address_list.RemoveAt(address_list.Count - 1);
        }

        /// <summary>
        /// this is used to load the previous webcontent
        /// </summary>
        /// <returns></returns>
        public int LoadPreviousTabContent()
        {
            if (pointer_list > 0)
            {
                int temp = pointer_list - 1;
                ForwardAddressRequest(address_list[--pointer_list]);
                pointer_list = temp;
                address_list.RemoveAt(address_list.Count - 1);
                return 0;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// this is used to load the webcontent from tab we previously returned from
        /// </summary>
        /// <returns></returns>
        public int next()
        {
            if (pointer_list < address_list.Count - 1)
            {
                int temp = pointer_list + 1;
                ForwardAddressRequest(address_list[++pointer_list]);
                pointer_list = temp;
                address_list.RemoveAt(address_list.Count - 1);
                return 0;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// we use the bulk download to observe to the error status code
        /// </summary>
        /// <param name="url"></param>
        public void bulkDownload(String url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Method = "Get";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                String s = "<" + Convert.ToInt32(response.StatusCode) + "> ";
                using (StreamReader readStream = new StreamReader(response.GetResponseStream()))
                {
                    String temp = readStream.ReadToEnd();
                    s += "<" + System.Text.ASCIIEncoding.ASCII.GetByteCount(temp) + "> ";
                    s += "<" + url + ">" + "\r\n";
                    displayArea.Text += s;
                }
            }
            catch (WebException webException)
            {
                try
                {
                    HttpStatusCode wRespStatusCode = ((HttpWebResponse)webException.Response).StatusCode;
                    displayArea.Text += "<" + Convert.ToInt32(wRespStatusCode) + "> " + "<0> " + "<" + url + "> " + "\r\n";
                }
                catch (Exception e)
                {
                    displayArea.Text += e.Message + "\r\n";
                }
            }
            catch (Exception e)
            {
                displayArea.Text += e.Message + "\r\n";
            }
        }

        /// <summary>
        /// this is used to pull header from url
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public String PullURLHeader(String strUrl)
        {
            String design = @"<title>(?<title>[^<]*)</title>";
            String fetched_header = Regex.Match(strUrl, design).ToString();
            fetched_header = fetched_header.Replace("<title>", "");
            fetched_header = fetched_header.Replace("</title>", "");
            return fetched_header;
        }

        /// <summary>
        /// this is used to pull the current URL
        /// </summary>
        /// <returns></returns>
        public String PullExistingURL()
        {
            return pointer_list != -1 ? address_list[pointer_list] : "";
        }

        public int Index => pointer_list;
    }
}
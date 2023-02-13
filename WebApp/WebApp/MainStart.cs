using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebApp
{
    public partial class Home : Form
    {
        private MainEngine appHandler;

        /// <summary>
        /// this will load the components of the form and also initialize the history and 
        /// bookmark list
        /// </summary>
        /// <param name="appHandler"></param>
        public Home(ref MainEngine appHandler)
        {
            InitializeComponent();
            this.appHandler = appHandler;
            InitializeBrowserHistory();
            InitializeBrowserBookmarks();
            //register Changed event
            appHandler.Changed += PushInHistoryLB;
            //register Edited event
            appHandler.Edited += UpdateBookmarkEdited;
            LoadTab(ref appHandler, appHandler.HomePage);
        }

        /// <summary>
        /// this button will load the previous webpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonIconClick(object sender, EventArgs e)
        {
            MyTabPage BackButtonObject = (MyTabPage)tabControl1.SelectedTab;
            BackButtonObject.LoadPreviousTabContent();
            URL.Text = BackButtonObject.PullExistingURL();
            forward_button.Visible = BackButtonObject.Index < BackButtonObject.address_list.Count - 1;
            // if the index is at -1, back button is not visible
            back_button.Visible = BackButtonObject.Index > 0;
            dynamic_label.Text = BackButtonObject.title_header;
        }

        /// <summary>
        /// this button will load the next webpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForwardButtonIconClick(object sender, EventArgs e)
        {
            MyTabPage ForwardButtonObject = (MyTabPage)tabControl1.SelectedTab;
            ForwardButtonObject.next();
            URL.Text = ForwardButtonObject.PullExistingURL();
            back_button.Visible = ForwardButtonObject.Index > 0;
            forward_button.Visible = ForwardButtonObject.Index < ForwardButtonObject.address_list.Count - 1;
            dynamic_label.Text = ForwardButtonObject.title_header;
        }

        /// <summary>
        /// this button will reload the current page URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadButtonIconClick(object sender, EventArgs e)
        {
            MyTabPage ReloadButtonObject = (MyTabPage)tabControl1.SelectedTab;
            ReloadButtonObject.reload(ReloadButtonObject.PullExistingURL());
            URL.Text = ReloadButtonObject.PullExistingURL();
        }

        /// <summary>
        /// this button will load the home page URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeButtonIconClick(object sender, EventArgs e)
        {
            MyTabPage HomeButtonObject = new MyTabPage(ref appHandler, appHandler.HomePage);
            tabControl1.TabPages.Add(HomeButtonObject);
            tabControl1.SelectedTab = HomeButtonObject;
            URL.Text = HomeButtonObject.PullExistingURL();
            dynamic_label.Text = HomeButtonObject.title_header;
        }

        /// <summary>
        /// the user can enter the URL in text box and click the search button to load the page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButtonIconClick(object sender, EventArgs e)
        {
            clearHistoryToolStripMenuItem.Enabled = true;
            MyTabPage SearchWithButtonObject = (MyTabPage)tabControl1.SelectedTab;
            if (WebsiteAddressCheck(URL.Text))
            {
                SearchWithButtonObject.ForwardAddressRequest(URL.Text);
                back_button.Visible = SearchWithButtonObject.Index > 0;
            }
            else
            {
                SearchWithButtonObject.Text = "Wrong URL";
            }
            dynamic_label.Text = SearchWithButtonObject.title_header;
        }

        /// <summary>
        /// this will enable/disable the next/previous button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabController_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyTabPage TabControllerObject = (MyTabPage)tabControl1.SelectedTab;
            back_button.Visible = TabControllerObject.Index > 0;
            forward_button.Visible = TabControllerObject.Index < TabControllerObject.address_list.Count - 1;
            URL.Text = TabControllerObject.PullExistingURL();
            dynamic_label.Text = TabControllerObject.title_header;
        }

        /// <summary>
        /// this will validate the URL
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool WebsiteAddressCheck(string input)
        {
            // here we check that the url is supposed to start with http:// or https://
            return Regex.IsMatch(input, "(https?)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]");
        }


        /// <summary>
        /// this will load the home page URL in the tab on startup
        /// </summary>
        /// <param name="appHandler"></param>
        /// <param name="url"></param>
        private void LoadTab(ref MainEngine appHandler, String url)
        {
            MyTabPage LoadTabObject = new(ref appHandler, url);
            URL.Text = url;
            tabControl1.TabPages.Add(LoadTabObject);
            tabControl1.SelectedTab = LoadTabObject;
            dynamic_label.Text = LoadTabObject.title_header;
        }

        /// <summary>
        /// this will close the selected tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TerminateCurrentTab(object sender, EventArgs e)
        {
            //the number of tabpage must greater than one
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                MyTabPage TerminateCurrentTabObject = (MyTabPage)tabControl1.SelectedTab;
                URL.Text = TerminateCurrentTabObject.PullExistingURL();
                dynamic_label.Text = TerminateCurrentTabObject.title_header;
            }
            else if (tabControl1.TabPages.Count == 1)
            {
                closeTabToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// this will open a new tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewTabOpen(object sender, EventArgs e)
        {
            closeTabToolStripMenuItem.Enabled = true;
            MyTabPage NewTabOpenObject = new MyTabPage(ref appHandler);
            tabControl1.TabPages.Add(NewTabOpenObject);
            NewTabOpenObject.Text = "New Tab";
            NewTabOpenObject.displayArea.Text = "Enter URL in the text box above to display the HTML code";
            tabControl1.SelectedTab = NewTabOpenObject;
            URL.Text = "";
            
        }

        private int HistoryListIndex;

        /// <summary>
        /// this will load the tab with the history user selects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadTabWithUserHistory(object sender, EventArgs e)
        {
            int index_LoadTabWithUserHistory = historyList.SelectedIndex;
            if (index_LoadTabWithUserHistory != -1)
            {
                historyList.Visible = false;
                EditHistoryPanel.Visible = false;
                DeleteHistoryButton.Visible = false;
                OpenHistoryInNewTabButton.Visible = false;
                viewHistoryToolStripMenuItem.Enabled = true;
                closeHistoryToolStripMenuItem.Enabled = false;
                LoadTab(ref appHandler, appHandler.PullHistoryIndex(index_LoadTabWithUserHistory));
            }
        }

        /// <summary>
        /// this will fetch the history and load in history list on startup
        /// </summary>
        private void InitializeBrowserHistory()
        {
            List<Address> list_history = appHandler.getHistoryList();
            foreach (Address url in list_history)
            {
                historyList.Items.Add(url.Title + " --- " + url.Url);
            }
        }

        /// <summary>
        /// this will push the address URL searched in History list
        /// </summary>
        /// <param name="url"></param>
        public void PushInHistoryLB(Address url)
        {
            historyList.Items.Insert(0, url.Title + " --- " + url.Url);
        }

        /// <summary>
        /// this menuitem will show a panel to delete or open a new tab with selected history list item
        /// when left mouse button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryLeftClickMouse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index_history = historyList.IndexFromPoint(e.Location);
                HistoryListIndex = index_history;
                if (index_history >= 0)
                {
                    EditHistoryPanel.Visible = true;
                    DeleteHistoryButton.Visible = true;
                    OpenHistoryInNewTabButton.Visible = true;
                }
            }
        }

        /// <summary>
        /// this will delete the history when user right clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryDelete(object sender, EventArgs e)
        {
            historyList.Items.RemoveAt(HistoryListIndex);
            appHandler.RemoveIndexHistory(HistoryListIndex);
        }

        /// <summary>
        /// this function will search for the entered address when Enter key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchWithEnterKey(object sender, KeyEventArgs e)
        {
            clearHistoryToolStripMenuItem.Enabled = true;
            MyTabPage SearchWithEnterTemp = (MyTabPage)tabControl1.SelectedTab;
            // this will search when the enter key is pressed on keyboard
            if (e.KeyCode == Keys.Enter)
            {
                if (WebsiteAddressCheck(URL.Text))
                {
                    SearchWithEnterTemp.ForwardAddressRequest(URL.Text);
                    back_button.Visible = SearchWithEnterTemp.Index > 0;
                }
                else
                {
                    SearchWithEnterTemp.Text = "Wrong URL";    
                }
                dynamic_label.Text = SearchWithEnterTemp.title_header;
            }
        }

        /// <summary>
        /// this will open the history list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewHistoryMenuItem(object sender, EventArgs e)
        {
            historyList.Visible = !historyList.Visible;
            viewHistoryToolStripMenuItem.Enabled = false;
            closeHistoryToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// this will close the history list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseHistoryMenuItem(object sender, EventArgs e)
        {
            historyList.Visible = !historyList.Visible;
            closeHistoryToolStripMenuItem.Enabled = false;
            viewHistoryToolStripMenuItem.Enabled = true;
            EditHistoryPanel.Visible = false;
            DeleteHistoryButton.Visible = false;
            OpenHistoryInNewTabButton.Visible = false;
        }

        /// <summary>
        /// this will clear the history list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClearHistoryMenuItem(object sender, EventArgs e)
        {
            historyList.Items.Clear();
            appHandler.ClearHistory();
            clearHistoryToolStripMenuItem.Enabled = false;
            historyList.Visible = false;
            EditHistoryPanel.Visible = false;
            DeleteHistoryButton.Visible = false;
            OpenHistoryInNewTabButton.Visible = false;
            viewHistoryToolStripMenuItem.Enabled = true;
            closeHistoryToolStripMenuItem.Enabled = false;
        }

        // we use the BookmarkListIndex to keep track of which index we are
        private int BookmarkListIndex;
        // we use CoordinateOfMouse to get the position of mouse pointer
        private Point CoordinateOfMouse;

        /// <summary>
        /// this function will enable us to view the bookmark list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBookmarksMenuItem(object sender, EventArgs e)
        {
            bookmarkList.Visible = !bookmarkList.Visible;
            viewBookmarksToolStripMenuItem.Enabled = false;
            closeBookmarksToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// this will close the bookmark list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBookmarksMenuItem(object sender, EventArgs e)
        {
            bookmarkList.Visible = !bookmarkList.Visible;
            viewBookmarksToolStripMenuItem.Enabled = true;
            closeBookmarksToolStripMenuItem.Enabled = false;
            EditBookmarkPanel.Visible = false;
            EditBookmarkButton.Visible = false;
            DeleteBookmarkButton.Visible = false;
            OpenBookmarkInNewTabButton.Visible = false;
        }

        /// <summary>
        /// this function will clear the Bookmark list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBookmarksMenuItem(object sender, EventArgs e)
        {
            bookmarkList.Items.Clear();
            appHandler.ClearBookmark();
            clearBookmarksToolStripMenuItem.Enabled = false;
            EditBookmarkPanel.Visible = false;
            EditBookmarkButton.Visible = false;
            DeleteBookmarkButton.Visible = false;
            OpenBookmarkInNewTabButton.Visible = false;
            bookmarkList.Visible = false;
            closeBookmarksToolStripMenuItem.Enabled = false;
            viewBookmarksToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// if user selects a bookmark from the bookmark list, it will open a tab with that URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadTabWithUserBookmark(object sender, EventArgs e)
        {
            int index_loadTabWithUserBookmark = bookmarkList.SelectedIndex;
            if (index_loadTabWithUserBookmark != -1)
            {
                bookmarkList.Visible = false;
                EditBookmarkPanel.Visible = false;
                EditBookmarkButton.Visible = false;
                DeleteBookmarkButton.Visible = false;
                OpenBookmarkInNewTabButton.Visible = false;
                closeBookmarksToolStripMenuItem.Enabled = false;
                viewBookmarksToolStripMenuItem.Enabled = true;
                String[] LTUserBookmarkTemp = bookmarkList.Items[index_loadTabWithUserBookmark].ToString().Split(' ');
                LoadTab(ref appHandler, LTUserBookmarkTemp[LTUserBookmarkTemp.Length - 1]);
            }
        }

        /// <summary>
        /// this will fetch all the bookmarks from the bookmarks list during startup
        /// </summary>
        private void InitializeBrowserBookmarks()
        {
            Dictionary<String, Address> bookmarks = appHandler.PullBookmarksList();
            var ArrangeByOrder = from list_bookmark in bookmarks
                                 orderby list_bookmark.Value.Time.ToFileTime() 
                                 select list_bookmark.Value;
            foreach (Address bookmark in ArrangeByOrder)
            {
                bookmarkList.Items.Add(bookmark.Title + " --- " + bookmark.Url);
            }
        }

        public int index_bookmark_copy;

        /// <summary>
        /// when the user left click mouse button on any bookmark, edit and delete option will
        /// will pop up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookmarksLeftClickMouse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index_bookmark = bookmarkList.IndexFromPoint(e.Location);
                index_bookmark_copy = index_bookmark;
                CoordinateOfMouse = e.Location;
                BookmarkListIndex = index_bookmark;
                if (index_bookmark >= 0)
                {
                    EditBookmarkPanel.Visible = true;
                    EditBookmarkButton.Visible = true;
                    DeleteBookmarkButton.Visible = true;
                    OpenBookmarkInNewTabButton.Visible = true;
                }
            }
        }

        /// <summary>
        /// this function is used to edit the existing bookmark's title and url
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookmarksEdit(object sender, EventArgs e)
        {
            EditBookmarkPanel.Visible = false;
            EditBookmarkButton.Visible = false;
            DeleteBookmarkButton.Visible = false;
            OpenBookmarkInNewTabButton.Visible = false;
            String[] bookmarkEditTemp = bookmarkList.Items[BookmarkListIndex].ToString().Split(' ');
            EditBookmark editBookmark = new EditBookmark(ref appHandler, bookmarkEditTemp[bookmarkEditTemp.Length - 1],
                appHandler.PullURLHeader(bookmarkEditTemp[bookmarkEditTemp.Length - 1]));
            editBookmark.Location =
                new Point(SystemInformation.WorkingArea.Width / 2 + CoordinateOfMouse.X, CoordinateOfMouse.Y);
            editBookmark.ShowDialog();
        }

        /// <summary>
        /// this is used to delete bookmarks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookmarksDelete(object sender, EventArgs e)
        {
            EditBookmarkPanel.Visible = false;
            EditBookmarkButton.Visible = false;
            DeleteBookmarkButton.Visible = false;
            OpenBookmarkInNewTabButton.Visible = false;
            String[] bookmarkDeleteTemp = bookmarkList.Items[BookmarkListIndex].ToString().Split(' ');
            bookmarkList.Items.RemoveAt(BookmarkListIndex);
            appHandler.BookmarkRemove(bookmarkDeleteTemp[bookmarkDeleteTemp.Length - 1]);
        }

        /// <summary>
        /// this will update the changes made to the title and url in bookmarks
        /// </summary>
        /// <param name="url"></param>
        private void UpdateBookmarkEdited(Address url)
        {
            bookmarkList.Items.RemoveAt(BookmarkListIndex);
            bookmarkList.Items.Insert(BookmarkListIndex, url.Title + " --- " + url.Url);
        }

        /// <summary>
        /// this menuitem is used to bookmark address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookmarkMenuItem(object sender, EventArgs e)
        {
            MyTabPage BookmarkMenuItemObject = (MyTabPage)tabControl1.SelectedTab;
            // here we check whether the url we are trying to enter is already present in List
            // if it is present we delete 
            // if not present we add it
            if (appHandler.BookmarkSimilarityCheck(URL.Text))
            {
                MessageBox.Show("The URL is already bookmarked.", "Information");
            }
            else
            {
                if (WebsiteAddressCheck(URL.Text))
                {
                    appHandler.BookmarkTab(URL.Text, new Address(BookmarkMenuItemObject.Text, URL.Text, DateTime.Now));
                    bookmarkList.Items.Add(BookmarkMenuItemObject.Text + " --- " + URL.Text);
                }
            }
            clearBookmarksToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// this menuitem is used to update the homepage URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomePageEditMenuItem(object sender, EventArgs e)
        {
            EditHomePage homepageForm = new EditHomePage(ref appHandler);
            homepageForm.ShowDialog();
        }

        /// <summary>
        /// this is used to show different status code for error that may encounter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BulkDownloadMenuItem(object sender, EventArgs e)
        {
            dynamic_label.Text = "Bulk Download";
            historyList.Visible = false;
            bookmarkList.Visible = false;
            EditBookmarkPanel.Visible = false;
            EditBookmarkButton.Visible = false;
            DeleteBookmarkButton.Visible = false;
            EditHistoryPanel.Visible = false;
            DeleteHistoryButton.Visible = false;
            OpenHistoryInNewTabButton.Visible = false;
            while (true)
            {
                DialogResult outputDialog = bulkDownload.ShowDialog();
                String filename = bulkDownload.FileName;
                String pattern = @".txt\z";
                if (outputDialog == System.Windows.Forms.DialogResult.OK)
                {
                    // first we check if it is a txt file
                    if (!Regex.IsMatch(filename, pattern))
                    {
                        MessageBox.Show("Not a txt file: " + filename, "Wrong file format", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        List<String> fetchedAddresses = appHandler.getBulkDownloadURLs(filename);
                        MyTabPage BulkDownloadObject = new MyTabPage(ref appHandler);
                        tabControl1.TabPages.Add(BulkDownloadObject);
                        BulkDownloadObject.Text = "Bulk Download";
                        tabControl1.SelectedTab = BulkDownloadObject;
                        URL.Text = "";
                        BulkDownloadObject.displayArea.Text = "<code> <bytes> <URL> \n";
                        foreach (string address in fetchedAddresses)
                        {
                            if (address != "")
                            {
                                if (WebsiteAddressCheck(address))
                                {
                                    BulkDownloadObject.bulkDownload(address);
                                }
                                else
                                {
                                    BulkDownloadObject.displayArea.Text += "Wrong URL" + "\r\n";
                                }
                            }
                            else
                            {
                                BulkDownloadObject.displayArea.Text += "Empty line" + "\r\n";
                            }
                        }

                        break;
                    }
                }
                else if (outputDialog == DialogResult.Cancel || outputDialog == DialogResult.No)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// this will close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplicationClose(object sender, EventArgs e)
        {
            string confirmationPrompt = "Do you want to close the application?";
            string confirmationMessage = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult userResponse = MessageBox.Show(confirmationPrompt, confirmationMessage, buttons);
            if (userResponse == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
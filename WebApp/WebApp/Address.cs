namespace WebApp
{
    public class Address
    {
        private String title; // Used to store the title of the webpage
        private String url; // Used to store the Address of the webpage
        private DateTime time; // time is used to order the Urls

        public Address(String title, String url, DateTime time)
        {
            this.time = time;
            this.title = title;
            this.url = url;
        }
   
        // The ToString Method returns the title along with the url
        public override String ToString()
        {
            // This is actually used as a split sign, it won't show in the URL
            return title + "|" + url + "|" + time.ToFileTime();
        }

        public string Title
        {
            get => title;  
            set => title = value; 
        }

        public string Url
        {
            get => url;
            set => url = value;
        }

        public DateTime Time
        {
            get => time;
            set => time = value;
        }
    }
}
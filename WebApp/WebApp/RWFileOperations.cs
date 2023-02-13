namespace WebApp

{
    public delegate void SpecificStructure<T>(ref T t,String[] temp_operations,String line);

    public class RWFileOperations
    {
        private String[] temp_operations = new string[3];
        
        /// <summary>
        /// this is used to add the url and title into bookmarks and history list
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fileName"></param>
        /// <param name="append"></param>
        public void FileUpdate(String text, String fileName,bool append)
        {
            try
            {
                StreamWriter streamwriter = new StreamWriter(fileName, append);
                streamwriter.WriteLine(text);
                streamwriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e+" Failed to load "+fileName);
                throw;
            }
        }
        
        /// <summary>
        /// this is used to read the data from file and loading it from history and favorite
        /// at startup
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fileName"></param>
        /// <param name="structure"></param>
        public void FetchFromFile<T>(ref T t, String fileName, SpecificStructure<T> structure)
        {
            String line;
            try
            {
                using (StreamReader streamreader = new StreamReader(fileName))
                {
                    while ((line = streamreader.ReadLine()) != null)
                    {
                        //because it is reference, so we can change the original data structure
                        structure(ref t, temp_operations, line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file ( "+fileName+" ) could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        // The LoadHomePageURL is used to read the home page address from Homepage.txt and load
        // the page on startup of application
        /// <summary>
        /// this is used to fetch the url from HomePage.txt and start the tab with the fetched url
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public String LoadHomePageURL(String fileName)
        {
            try
            {
                using (StreamReader streamreader = new StreamReader(fileName))
                {
                    //only read one line
                    return streamreader.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file ( "+fileName+" ) could not be read:");
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
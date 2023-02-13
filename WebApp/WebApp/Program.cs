namespace WebApp
{
    internal static class Program
    {
        // This is the main starting point of the program
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            MainEngine appHandler = new MainEngine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(ref appHandler));
        }
    }
}
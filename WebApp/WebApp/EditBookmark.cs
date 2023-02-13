using System.Text.RegularExpressions;


namespace WebApp
{
    public partial class EditBookmark : Form
    {
        private MainEngine appHandler;
        private String url; // We create a string variable named url to store URL
        private String title; // We create a string variable named title to store title of Tab

        // It references browser manager and also pass url and title. Here we do the initialization
        // of all the components present inside the form
        public EditBookmark(ref MainEngine appHandler, String url, String title)
        {
            InitializeComponent();
            this.appHandler = appHandler;
            this.url = url;
            this.title = title;
            Header.Text = title;
            Address.Text = url;
        }

        // This is the save button in the Edit favourite form and used to save the changes if made any.
        private void SaveButtonEditForm(object sender, EventArgs e)
        {
            //because we will use "|" as spilt sign, so title must not contain this
            if (WebsiteAddressCheck(Address.Text) && !Header.Text.Contains('|') && Header.Text.Length != 0)
            {
                appHandler.ChangeBookmark(Header.Text, Address.Text, url);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Address", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // This is the cancel button to discard any changes and close form
        private void CancelButtonEditForm(object sender, EventArgs e)
        {
            Close();
        }

        // This will validate the URL entered using regular expression 
        private bool WebsiteAddressCheck(string input)
        {
            return Regex.IsMatch(input, "(https?)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]");
        }
    }
}

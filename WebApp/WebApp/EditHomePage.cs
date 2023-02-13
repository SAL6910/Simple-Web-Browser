using System.Text.RegularExpressions;

namespace WebApp
{
    public partial class EditHomePage : Form
    {
        private MainEngine appHandler;

        // Here we initialize the main components of the Home page edit form.
        public EditHomePage(ref MainEngine appHandler)
        {
            InitializeComponent();
            this.appHandler = appHandler;
        }

        // This is the save button on the Edit Home Page. This will update the existing home page
        // in Homepage.txt 
        private void SaveButtonHomePageEdit(object sender, EventArgs e)
        {
            String UpdateHomePage = tb1.Text;
            if (validateURL(UpdateHomePage))
            {
                appHandler.HomePage = UpdateHomePage;
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This button will close the form and discard any changes
        private void CancelButtonHomePageEdit(object sender, EventArgs e)
        {
            Close();
        }

        //This function will validate the Address
        private bool validateURL(string input)
        {
            return Regex.IsMatch(input, "(https?)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]");
        }
    }
}

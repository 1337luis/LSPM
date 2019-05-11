using System.Windows.Forms;

namespace LSPM
{
    public partial class LSPMPassword : Form
    {
        public LSPMPassword()
        {
            InitializeComponent();
        }

        private void loginButton_Click( object sender, System.EventArgs e )
        {
            if( validatePwd( passwordTextBox.Text ) )
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void loginSaveButton_Click( object sender, System.EventArgs e )
        {
            if( validatePwd( passwordTextBox.Text ) )
            {
                Properties.Settings.Default.useLastPwd = true;
                Properties.Settings.Default.Save();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool validatePwd( string pwd )
        {
            bool result = false;

            if( LSPMDatabase.hashString( pwd ) == Properties.Settings.Default.pwdHash )
            {
                result = true;
            } else
            {
                MessageBox.Show( "La contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            return result;
        }

        private void LSPMPassword_Load( object sender, System.EventArgs e )
        {
            if( Properties.Settings.Default.useLastPwd )
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

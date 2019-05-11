using System;
using System.IO;
using System.Windows.Forms;

namespace LSPM
{
    public partial class LSPMStart : Form
    {
        public LSPMStart()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            

        }

        private void startButton_Click( object sender, EventArgs e )
        {
            if( passwordInput1.Text == "" || passwordInput2.Text == "" )
            {
                MessageBox.Show( "La contraseña no puede estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            } else if( passwordInput1.Text != passwordInput2.Text )
            {
                MessageBox.Show( "Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            } else
            {
                Properties.Settings.Default.pwdHash = LSPMDatabase.hashString( passwordInput1.Text );
                Properties.Settings.Default.Save();
                LSPMDatabase ndb = new LSPMDatabase( Properties.Settings.Default.pwdHash );
                ndb.getDBCollection().Insert( new LSPMData( "admin", "1234", "Acceso Prueba", true, true ) );
                
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

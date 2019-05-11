using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPM
{
    public partial class LSPMSettings : Form
    {
        public LSPMSettings()
        {
            InitializeComponent();
            minTBCheckBox.Checked = Properties.Settings.Default.minimTray;
        }

        private void forgPasButton_Click( object sender, EventArgs e )
        {
            if( MessageBox.Show("¿Realmente desea borrar la contraseña de LSPM?\r\nTendrá que introducirla de nuevo en la próxima ejecución.", "¿Olvidar Contraseña?",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK )
            {
                Properties.Settings.Default.useLastPwd = false;
                Properties.Settings.Default.Save();
            }
        }

        private void minTBCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            Properties.Settings.Default.minimTray = minTBCheckBox.Checked;
            Properties.Settings.Default.Save();

        }

        private void clearDBButton_Click( object sender, EventArgs e )
        {
            string clearMsg = "¿Realmente desea vaciar la base de datos de LSPM?\r\nSe borrarán todos sus datos pero mantendrá su contraseña de acceso.";
            if( MessageBox.Show( clearMsg, "¿Vaciar Base de Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk ) == DialogResult.OK )
            {
                clearDB();
            }
        }

        private void deleteDBButton_Click( object sender, EventArgs e )
        {
            string delMsg = "¿Realmente desea borrar la base de datos de LSPM?\r\nSe borrarán todos sus datos, la aplicación se cerrará.";
            if( MessageBox.Show( delMsg, "¿Borrar base de Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk ) == DialogResult.OK )
            {
                deleteDB();
            }
        }

        private void clearDB()
        {
            LSPMDatabase database = new LSPMDatabase( Properties.Settings.Default.pwdHash );
            LiteCollection<LSPMData> col = database.getDBCollection();

            col.EnsureIndex( x => x.lAlias );
            List<LSPMData> credentials = col.FindAll().ToList();
            foreach( LSPMData data in credentials )
            {
                col.Delete( data.Id );
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void deleteDB()
        {
            File.Delete( @"./LSPM.db" );
            Application.Exit();
        }
    }
}

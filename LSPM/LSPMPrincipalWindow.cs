using LiteDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LSPM
{
    public partial class LSPMPrincipalWindow : Form
    {
        List<LSPMData> credentials = new List<LSPMData>();
        LSPMFloatingWindow floatingWindow = new LSPMFloatingWindow();

        public LSPMPrincipalWindow() => InitializeComponent();

        private void LSPMPrincipalWindow_Load( object sender, EventArgs e )
        {
            DialogResult r;
            if( File.Exists( @"./LSPM.db" ) )
            {
                r = new LSPMPassword().ShowDialog();
            }
            else
            {
                Properties.Settings.Default.pwdHash = "";
                Properties.Settings.Default.useLastPwd = false;
                Properties.Settings.Default.Save();
                r = new LSPMStart().ShowDialog();

            }

            if( r == DialogResult.OK )
            {
                TaskbarHandler.Visible = true;
                loadData();
                if (Properties.Settings.Default.runMinim) toTray();
            }
            else
            {
                Application.Exit();
            }


        }

        private void addDataButton_Click( object sender, EventArgs e )
        {
            if( new newDataForm().ShowDialog() == DialogResult.OK )
            {
                loadData();
            }
        }

        private void addCredsButton_Click( object sender, EventArgs e )
        {
            if( new newDataForm().ShowDialog() == DialogResult.OK )
            {
                loadData();
            }
        }

        private void loadData()
        {
            floatingWindow.setContextMenuStrip( dataMenu );
            checkSelectedItems();

            LSPMDatabase database = new LSPMDatabase( Properties.Settings.Default.pwdHash );
            LiteCollection<LSPMData> col = database.getDBCollection();

            col.EnsureIndex( x => x.lAlias );

            credentials = col.FindAll().ToList();

            credsView.Clear();
            dataMenu.Items.Clear();
            foreach( LSPMData data in credentials )
            {
                bool addSeparator = false;
                ListViewItem a = new ListViewItem( data.lAlias );
                a.ImageIndex = ( int )data.lDataIcon;
                credsView.Items.Add( a );

                ToolStripMenuItem mSup = new ToolStripMenuItem(data.lAlias, icons.Images[(int)data.lDataIcon]);
                mSup.BackColor = Color.FromArgb(33, 33, 33);
                
                mSup.ForeColor = Color.FromArgb(100, 200, 255);
                mSup.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                if ( data.lUserFastAccess )
                {
                    LSPMMenuItem tItem = new LSPMMenuItem( "Usuario", Properties.Resources.user, data.lUser, TaskbarHandler );
                    tItem.BackColor = Color.FromArgb(33, 33, 33);
                    mSup.DropDownItems.Add( tItem );
                    addSeparator = true;
                }
                if( data.lPasswordFastAccess )
                {
                    LSPMMenuItem tItem = new LSPMMenuItem( "Clave", Properties.Resources.key, data.lPass, TaskbarHandler );
                    tItem.BackColor = Color.FromArgb(33, 33, 33);
                    mSup.DropDownItems.Add( tItem );
                    addSeparator = true;
                }
                if(data.lPasswordFastAccess || data.lUserFastAccess) dataMenu.Items.Add(mSup);
                //if ( addSeparator ) dataMenu.Items.Add( new ToolStripSeparator() );
            }
            dataMenu.Items.Add( toolStripSeparator1 );
            dataMenu.Items.Add( generarPass );
            dataMenu.Items.Add( mostrarLSPMToolStripMenuItem );
            dataMenu.Items.Add( salirToolStripMenuItem );
        }

        private void salirToolStripMenuItem_Click( object sender, EventArgs e ) => Application.Exit();

        private void mostrarLSPMToolStripMenuItem_Click( object sender, EventArgs e ) => Show();

        private void LSPMPrincipalWindow_FormClosing( object sender, FormClosingEventArgs e )
        {
            if( e.CloseReason == CloseReason.UserClosing && Properties.Settings.Default.minimTray )
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void toTray()
        {
            Hide();
            Close();
        }

        private void credsView_ItemSelectionChanged( object sender, ListViewItemSelectionChangedEventArgs e )
        {
            checkSelectedItems();
        }

        private void configButton_Click( object sender, EventArgs e )
        {
            if( new LSPMSettings().ShowDialog() == DialogResult.OK )
            {
                loadData();
            }
        }

        private void credsView_ItemActivate( object sender, EventArgs e )
        {
            string alias = credsView.SelectedItems[ 0 ].Text;
            if( new editDataForm( alias ).ShowDialog() == DialogResult.OK )
            {
                loadData();
            }
        }

        private void editCredsButton_Click( object sender, EventArgs e )
        {
            string alias = credsView.SelectedItems[ 0 ].Text;
            if( new editDataForm( alias ).ShowDialog() == DialogResult.OK )
            {
                loadData();
            }
        }

        private void deleteCredsButton_Click( object sender, EventArgs e )
        {
            string alias = credsView.SelectedItems[ 0 ].Text;
            if( MessageBox.Show( "¿Realmente desea eliminar la información seleccionada?", "¿Eliminar?", MessageBoxButtons.OKCancel ) == DialogResult.OK )
            {
                LSPMDatabase database = new LSPMDatabase( Properties.Settings.Default.pwdHash );
                LiteCollection<LSPMData> col = database.getDBCollection();
                col.EnsureIndex( x => x.lAlias );

                col.Delete( x => x.lAlias.Equals( alias ) );
                loadData();
            }
        }

        private void checkSelectedItems()
        {
            if( credsView.SelectedItems.Count > 0 )
            {
                itemOptionsEnabled( true );
            }
            else
            {
                itemOptionsEnabled( false );
            }
        }

        private void itemOptionsEnabled( bool enable )
        {
            editCredsButton.Enabled = enable;
            deleteCredsButton.Enabled = enable;
        }

        private void TaskbarHandler_DoubleClick( object sender, EventArgs e ) => Show();

        private void showLSPMFloatingWindow_Click( object sender, EventArgs e )
        {
            if( showLSPMFloatingWindow.Checked )
            {
                floatingWindow.Show();
            }
            else
            {
                floatingWindow.Hide();
            }
        }

        private void TaskbarHandler_MouseClick(object sender, MouseEventArgs e)
        {
//            TaskbarHandler.ContextMenuStrip.Show(e.X, e.Y);
        }

        private void GenerarPass_Click(object sender, EventArgs e)
        {
            List< char > chars = new List< char >();
            Random rand = new Random( DateTime.Now.Millisecond );
            String pass = "";
            for( int x = 32; x <= 126; x++ ) chars.Add( ( char )x );
            for(int x = 0; x < 10; x++ ) pass += chars.ToArray()[rand.Next( chars.Count )].ToString();
            Clipboard.SetText( pass );
            TaskbarHandler.ShowBalloonTip(500, "Contraseña Aleatoria Copiada", pass, ToolTipIcon.Info);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPM
{
    public partial class editDataForm : Form
    {
        LSPMDatabase db;
        LSPMData editable;
        LSPMData.DataIcon lIcon;
        public editDataForm()
        {
            InitializeComponent();
        }

        public editDataForm( string alias )
        {
            InitializeComponent();

            db = new LSPMDatabase( Properties.Settings.Default.pwdHash );
            LiteDB.LiteCollection<LSPMData> col = db.getDBCollection();

            col.EnsureIndex( x => x.lAlias );
            editable = col.FindOne( x => x.lAlias.Equals( alias ) );

            aliasInput.Text = editable.lAlias;
            userInput.Text = editable.lUser;
            passwordInput.Text = editable.lPass;
            userAccessCheck.Checked = editable.lUserFastAccess;
            passwordAccessCheck.Checked = editable.lPasswordFastAccess;
            markColor( editable.lDataIcon );
        }

        private void editDataForm_Load( object sender, EventArgs e )
        {
            
        }

        private bool validateLSPM()
        {
            bool result = false;

            db.getDBCollection().EnsureIndex( x => x.lAlias );

            if( aliasInput.Text == "" )
            {
                MessageBox.Show( "Error, el Alias no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else if( userInput.Text == "" )
            {
                MessageBox.Show( "Error, el Usuario no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else if( passwordInput.Text == "" )
            {
                MessageBox.Show( "Error, la Contraseña no puede estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                result = true;
            }

            return result;
        }

        private void markColor( LSPMData.DataIcon icon )
        {
            clearColor();
            lIcon = icon;
            switch( icon )
            {
                case LSPMData.DataIcon.Black:
                    blackColorPanel.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case LSPMData.DataIcon.Blue:
                    blueColorPanel.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case LSPMData.DataIcon.Green:
                    greenColorPanel.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case LSPMData.DataIcon.Orange:
                    orangeColorPanel.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case LSPMData.DataIcon.Pink:
                    pinkColorPanel.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case LSPMData.DataIcon.Purple:
                    purpleColorPanel.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case LSPMData.DataIcon.Red:
                    redColorPanel.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case LSPMData.DataIcon.White:
                    whiteColorPanel.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        }

        private void clearColor()
        {
            Control.ControlCollection coms = colorSelectorContainer.Controls;

            foreach( Component c in coms )
            {
                ( ( Panel )c ).BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void blackColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            blackColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.Black;
        }

        private void purpleColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            purpleColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.Purple;
        }

        private void pinkColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            pinkColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.Pink;
        }

        private void redColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            redColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.Red;
        }

        private void orangeColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            orangeColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.Orange;
        }

        private void yellowColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            yellowColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.Yellow;
        }

        private void greenColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            greenColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.Green;
        }

        private void blueColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            blueColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.Blue;
        }

        private void whiteColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            whiteColorPanel.BorderStyle = BorderStyle.Fixed3D;
            editable.lDataIcon = LSPMData.DataIcon.White;
        }

        private void performEditButton_Click( object sender, EventArgs e )
        {
            if( validateLSPM() )
            {
                editable.lAlias = aliasInput.Text;
                editable.lPass = passwordInput.Text;
                editable.lUser = userInput.Text;
                editable.lPasswordFastAccess = passwordAccessCheck.Checked;
                editable.lUserFastAccess = userAccessCheck.Checked;

                db.getDBCollection().Update( editable.Id, editable );
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

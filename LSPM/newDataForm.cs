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
    public partial class newDataForm : Form
    {
        LSPMData.DataIcon icon = LSPMData.DataIcon.Pink;
        LSPMDatabase db;

        public newDataForm()
        {
            InitializeComponent();
        }

        private void performAddButton_Click( object sender, EventArgs e )
        {
            if( validateLSPM() )
            {
                LSPMData insert = new LSPMData( userInput.Text, passwordInput.Text, aliasInput.Text, passwordAccessCheck.Checked, userAccessCheck.Checked, icon );
                
                db.insert( insert );
                DialogResult = DialogResult.OK;
                Close();
            }
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
            else if( db.getDBCollection().Find( x => x.lAlias.Equals( aliasInput.Text ) ).Count() > 0 )
            {
                MessageBox.Show( "Error, el Alias ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                result = true;
            }

            return result;
        }

        private void blackColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            blackColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.Black;
        }

        private void clearColor()
        {
            Control.ControlCollection coms = colorSelectorContainer.Controls;

            foreach( Component c in coms )
            {
                ( ( Panel )c ).BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void purpleColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            purpleColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.Purple;
        }

        private void pinkColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            pinkColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.Pink;
        }

        private void redColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            redColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.Red;
        }

        private void orangeColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            orangeColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.Orange;
        }

        private void yellowColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            yellowColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.Yellow;
        }

        private void greenColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            greenColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.Green;
        }

        private void blueColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            blueColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.Blue;
        }

        private void whiteColorPanel_Click( object sender, EventArgs e )
        {
            clearColor();
            whiteColorPanel.BorderStyle = BorderStyle.Fixed3D;
            icon = LSPMData.DataIcon.White;
        }

        private void newDataForm_Load( object sender, EventArgs e )
        {
            db = new LSPMDatabase( Properties.Settings.Default.pwdHash );
        }
    }
}

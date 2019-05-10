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
    public partial class LSPMPrincipalWindow : Form
    {
        public LSPMPrincipalWindow()
        {
            InitializeComponent();
        }

        private void LSPMPrincipalWindow_Load( object sender, EventArgs e )
        {
            if( File.Exists( @"./LSPM.db" ) )
            {
                new LSPMPassword().ShowDialog();
            } else
            {
                new LSPMStart().ShowDialog();
            }
            TaskbarHandler.Visible = true;
        }

        private void addDataButton_Click( object sender, EventArgs e )
        {
            new newDataForm().ShowDialog();
        }
    }
}

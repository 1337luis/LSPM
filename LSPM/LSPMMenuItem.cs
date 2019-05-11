using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPM
{
    public class LSPMMenuItem : ToolStripMenuItem
    {
        public string copyText { get; set; }
        private NotifyIcon taskbarHandler;

        public LSPMMenuItem( string text, Image lImage, string toCopy )
        {
            Text = text;
            Image = lImage;
            Click += LSPMMenuItem_Click;
            copyText = toCopy;
        }

        public LSPMMenuItem( string text, Image lImage, string toCopy, NotifyIcon tb )
        {
            Text = text;
            Image = lImage;
            Click += LSPMMenuItem_Click;
            copyText = toCopy;
            taskbarHandler = tb;
        }

        private void LSPMMenuItem_Click( object sender, EventArgs e )
        {
            if( copyText != null && copyText != "" ) Clipboard.SetText( copyText );
            if( taskbarHandler != null ) taskbarHandler.ShowBalloonTip( 1000, "Copiado al portapapeles", Text, ToolTipIcon.Info );
        }
    }
}

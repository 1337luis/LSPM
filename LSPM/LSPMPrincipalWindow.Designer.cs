namespace LSPM
{
    partial class LSPMPrincipalWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LSPMPrincipalWindow));
            this.TaskbarHandler = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lateralDataView = new System.Windows.Forms.TableLayoutPanel();
            this.addDataButton = new System.Windows.Forms.Button();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prueba2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.dataMenu.SuspendLayout();
            this.lateralDataView.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskbarHandler
            // 
            this.TaskbarHandler.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TaskbarHandler.BalloonTipText = "LSPM se está ejecutando aquí";
            this.TaskbarHandler.BalloonTipTitle = "LSPM";
            this.TaskbarHandler.ContextMenuStrip = this.dataMenu;
            this.TaskbarHandler.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskbarHandler.Icon")));
            this.TaskbarHandler.Tag = "LSPM";
            this.TaskbarHandler.Text = "LSPM";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lateralDataView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(260, 399);
            this.treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataMenu
            // 
            this.dataMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dataMenu.DropShadowEnabled = false;
            this.dataMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem,
            this.prueba2ToolStripMenuItem});
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.dataMenu.Size = new System.Drawing.Size(121, 48);
            this.dataMenu.Text = "LSPM";
            // 
            // lateralDataView
            // 
            this.lateralDataView.ColumnCount = 1;
            this.lateralDataView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lateralDataView.Controls.Add(this.treeView1, 0, 0);
            this.lateralDataView.Controls.Add(this.addDataButton, 0, 1);
            this.lateralDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lateralDataView.Location = new System.Drawing.Point(0, 0);
            this.lateralDataView.Name = "lateralDataView";
            this.lateralDataView.RowCount = 2;
            this.lateralDataView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.lateralDataView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lateralDataView.Size = new System.Drawing.Size(266, 450);
            this.lateralDataView.TabIndex = 0;
            // 
            // addDataButton
            // 
            this.addDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDataButton.Location = new System.Drawing.Point(3, 408);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(260, 39);
            this.addDataButton.TabIndex = 1;
            this.addDataButton.Text = "Añadir datos";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pruebaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pruebaToolStripMenuItem.Image = global::LSPM.Properties.Resources.blue;
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pruebaToolStripMenuItem.Text = "Prueba";
            // 
            // prueba2ToolStripMenuItem
            // 
            this.prueba2ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prueba2ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.prueba2ToolStripMenuItem.Image = global::LSPM.Properties.Resources.pink;
            this.prueba2ToolStripMenuItem.Name = "prueba2ToolStripMenuItem";
            this.prueba2ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.prueba2ToolStripMenuItem.Text = "Prueba 2";
            // 
            // LSPMPrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LSPMPrincipalWindow";
            this.Text = "LSPMPrincipalWindow";
            this.Load += new System.EventHandler(this.LSPMPrincipalWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.dataMenu.ResumeLayout(false);
            this.lateralDataView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TaskbarHandler;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip dataMenu;
        private System.Windows.Forms.TableLayoutPanel lateralDataView;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prueba2ToolStripMenuItem;
    }
}
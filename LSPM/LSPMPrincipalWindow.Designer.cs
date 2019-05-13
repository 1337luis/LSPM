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
            this.dataMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarLSPMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superiorMenu = new System.Windows.Forms.ToolStrip();
            this.addCredsButton = new System.Windows.Forms.ToolStripButton();
            this.editCredsButton = new System.Windows.Forms.ToolStripButton();
            this.deleteCredsButton = new System.Windows.Forms.ToolStripButton();
            this.configButton = new System.Windows.Forms.ToolStripButton();
            this.credsView = new System.Windows.Forms.ListView();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.dataMenu.SuspendLayout();
            this.superiorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskbarHandler
            // 
            this.TaskbarHandler.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TaskbarHandler.ContextMenuStrip = this.dataMenu;
            this.TaskbarHandler.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskbarHandler.Icon")));
            this.TaskbarHandler.Tag = "LSPM";
            this.TaskbarHandler.Text = "LSPM";
            this.TaskbarHandler.DoubleClick += new System.EventHandler(this.TaskbarHandler_DoubleClick);
            // 
            // dataMenu
            // 
            this.dataMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dataMenu.DropShadowEnabled = false;
            this.dataMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mostrarLSPMToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.dataMenu.Size = new System.Drawing.Size(149, 54);
            this.dataMenu.Text = "LSPM";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // mostrarLSPMToolStripMenuItem
            // 
            this.mostrarLSPMToolStripMenuItem.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.mostrarLSPMToolStripMenuItem.Name = "mostrarLSPMToolStripMenuItem";
            this.mostrarLSPMToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.mostrarLSPMToolStripMenuItem.Text = "Mostrar LSPM";
            this.mostrarLSPMToolStripMenuItem.Click += new System.EventHandler(this.mostrarLSPMToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // superiorMenu
            // 
            this.superiorMenu.AutoSize = false;
            this.superiorMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.superiorMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.superiorMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.superiorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCredsButton,
            this.editCredsButton,
            this.deleteCredsButton,
            this.configButton});
            this.superiorMenu.Location = new System.Drawing.Point(0, 0);
            this.superiorMenu.Name = "superiorMenu";
            this.superiorMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.superiorMenu.Size = new System.Drawing.Size(275, 37);
            this.superiorMenu.TabIndex = 1;
            this.superiorMenu.Text = "toolStrip1";
            // 
            // addCredsButton
            // 
            this.addCredsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCredsButton.Image = global::LSPM.Properties.Resources.add;
            this.addCredsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCredsButton.Name = "addCredsButton";
            this.addCredsButton.Size = new System.Drawing.Size(28, 34);
            this.addCredsButton.Text = "Añadir Acceso";
            this.addCredsButton.Click += new System.EventHandler(this.addCredsButton_Click);
            // 
            // editCredsButton
            // 
            this.editCredsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editCredsButton.Enabled = false;
            this.editCredsButton.Image = global::LSPM.Properties.Resources.edit;
            this.editCredsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCredsButton.Name = "editCredsButton";
            this.editCredsButton.Size = new System.Drawing.Size(28, 34);
            this.editCredsButton.Text = "Modificar Credenciales";
            this.editCredsButton.Click += new System.EventHandler(this.editCredsButton_Click);
            // 
            // deleteCredsButton
            // 
            this.deleteCredsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteCredsButton.Enabled = false;
            this.deleteCredsButton.Image = global::LSPM.Properties.Resources.del;
            this.deleteCredsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteCredsButton.Name = "deleteCredsButton";
            this.deleteCredsButton.Size = new System.Drawing.Size(28, 34);
            this.deleteCredsButton.Text = "Eliminar Credenciales";
            this.deleteCredsButton.Click += new System.EventHandler(this.deleteCredsButton_Click);
            // 
            // configButton
            // 
            this.configButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.configButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configButton.Image = global::LSPM.Properties.Resources.config1;
            this.configButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(28, 34);
            this.configButton.Text = "toolStripButton1";
            this.configButton.ToolTipText = "Configuración";
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // credsView
            // 
            this.credsView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.credsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.credsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.credsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.credsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credsView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.credsView.GridLines = true;
            this.credsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.credsView.LargeImageList = this.icons;
            this.credsView.Location = new System.Drawing.Point(0, 33);
            this.credsView.MultiSelect = false;
            this.credsView.Name = "credsView";
            this.credsView.ShowGroups = false;
            this.credsView.Size = new System.Drawing.Size(275, 417);
            this.credsView.SmallImageList = this.icons;
            this.credsView.TabIndex = 2;
            this.credsView.UseCompatibleStateImageBehavior = false;
            this.credsView.View = System.Windows.Forms.View.SmallIcon;
            this.credsView.ItemActivate += new System.EventHandler(this.credsView_ItemActivate);
            this.credsView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.credsView_ItemSelectionChanged);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "black.png");
            this.icons.Images.SetKeyName(1, "blue.png");
            this.icons.Images.SetKeyName(2, "green.png");
            this.icons.Images.SetKeyName(3, "orange.png");
            this.icons.Images.SetKeyName(4, "pink.png");
            this.icons.Images.SetKeyName(5, "purple.png");
            this.icons.Images.SetKeyName(6, "red.png");
            this.icons.Images.SetKeyName(7, "white.png");
            this.icons.Images.SetKeyName(8, "yellow.png");
            // 
            // LSPMPrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.credsView);
            this.Controls.Add(this.superiorMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LSPMPrincipalWindow";
            this.Text = "LSPM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LSPMPrincipalWindow_FormClosing);
            this.Load += new System.EventHandler(this.LSPMPrincipalWindow_Load);
            this.dataMenu.ResumeLayout(false);
            this.superiorMenu.ResumeLayout(false);
            this.superiorMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TaskbarHandler;
        private System.Windows.Forms.ContextMenuStrip dataMenu;
        private System.Windows.Forms.ToolStrip superiorMenu;
        private System.Windows.Forms.ToolStripButton addCredsButton;
        private System.Windows.Forms.ListView credsView;
        private System.Windows.Forms.ToolStripButton editCredsButton;
        private System.Windows.Forms.ToolStripButton deleteCredsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mostrarLSPMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton configButton;
        private System.Windows.Forms.ImageList icons;
    }
}
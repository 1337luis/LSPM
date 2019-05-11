namespace LSPM
{
    partial class LSPMSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LSPMSettings));
            this.LSPMTabs = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.checkBoxPanel = new System.Windows.Forms.Panel();
            this.minTBCheckBox = new System.Windows.Forms.CheckBox();
            this.forgPasButton = new System.Windows.Forms.Button();
            this.DBTab = new System.Windows.Forms.TabPage();
            this.deleteDBButton = new System.Windows.Forms.Button();
            this.clearDBButton = new System.Windows.Forms.Button();
            this.LSPMTabs.SuspendLayout();
            this.UserTab.SuspendLayout();
            this.checkBoxPanel.SuspendLayout();
            this.DBTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LSPMTabs
            // 
            this.LSPMTabs.Controls.Add(this.UserTab);
            this.LSPMTabs.Controls.Add(this.DBTab);
            this.LSPMTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSPMTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSPMTabs.Location = new System.Drawing.Point(0, 0);
            this.LSPMTabs.Multiline = true;
            this.LSPMTabs.Name = "LSPMTabs";
            this.LSPMTabs.SelectedIndex = 0;
            this.LSPMTabs.Size = new System.Drawing.Size(295, 180);
            this.LSPMTabs.TabIndex = 0;
            // 
            // UserTab
            // 
            this.UserTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.UserTab.Controls.Add(this.checkBoxPanel);
            this.UserTab.Controls.Add(this.forgPasButton);
            this.UserTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.UserTab.Location = new System.Drawing.Point(4, 25);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(287, 151);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "Usuario";
            // 
            // checkBoxPanel
            // 
            this.checkBoxPanel.Controls.Add(this.minTBCheckBox);
            this.checkBoxPanel.Location = new System.Drawing.Point(8, 78);
            this.checkBoxPanel.Name = "checkBoxPanel";
            this.checkBoxPanel.Size = new System.Drawing.Size(271, 66);
            this.checkBoxPanel.TabIndex = 2;
            // 
            // minTBCheckBox
            // 
            this.minTBCheckBox.AutoSize = true;
            this.minTBCheckBox.Location = new System.Drawing.Point(29, 23);
            this.minTBCheckBox.Name = "minTBCheckBox";
            this.minTBCheckBox.Size = new System.Drawing.Size(213, 20);
            this.minTBCheckBox.TabIndex = 1;
            this.minTBCheckBox.Text = "Minimizar a la bandeja al cerrar";
            this.minTBCheckBox.UseVisualStyleBackColor = true;
            this.minTBCheckBox.CheckedChanged += new System.EventHandler(this.minTBCheckBox_CheckedChanged);
            // 
            // forgPasButton
            // 
            this.forgPasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgPasButton.ForeColor = System.Drawing.Color.Aqua;
            this.forgPasButton.Location = new System.Drawing.Point(8, 6);
            this.forgPasButton.Name = "forgPasButton";
            this.forgPasButton.Size = new System.Drawing.Size(271, 66);
            this.forgPasButton.TabIndex = 0;
            this.forgPasButton.Text = "Olvidar Contraseña";
            this.forgPasButton.UseVisualStyleBackColor = true;
            this.forgPasButton.Click += new System.EventHandler(this.forgPasButton_Click);
            // 
            // DBTab
            // 
            this.DBTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DBTab.Controls.Add(this.deleteDBButton);
            this.DBTab.Controls.Add(this.clearDBButton);
            this.DBTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.DBTab.Location = new System.Drawing.Point(4, 25);
            this.DBTab.Name = "DBTab";
            this.DBTab.Padding = new System.Windows.Forms.Padding(3);
            this.DBTab.Size = new System.Drawing.Size(287, 151);
            this.DBTab.TabIndex = 1;
            this.DBTab.Text = "DB";
            // 
            // deleteDBButton
            // 
            this.deleteDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDBButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteDBButton.Location = new System.Drawing.Point(8, 78);
            this.deleteDBButton.Name = "deleteDBButton";
            this.deleteDBButton.Size = new System.Drawing.Size(271, 66);
            this.deleteDBButton.TabIndex = 1;
            this.deleteDBButton.Text = "Eliminar Base de Datos";
            this.deleteDBButton.UseVisualStyleBackColor = true;
            this.deleteDBButton.Click += new System.EventHandler(this.deleteDBButton_Click);
            // 
            // clearDBButton
            // 
            this.clearDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDBButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearDBButton.Location = new System.Drawing.Point(8, 6);
            this.clearDBButton.Name = "clearDBButton";
            this.clearDBButton.Size = new System.Drawing.Size(271, 66);
            this.clearDBButton.TabIndex = 0;
            this.clearDBButton.Text = "Vaciar Base de Datos";
            this.clearDBButton.UseVisualStyleBackColor = true;
            this.clearDBButton.Click += new System.EventHandler(this.clearDBButton_Click);
            // 
            // LSPMSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(295, 180);
            this.Controls.Add(this.LSPMTabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LSPMSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.LSPMTabs.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            this.checkBoxPanel.ResumeLayout(false);
            this.checkBoxPanel.PerformLayout();
            this.DBTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LSPMTabs;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage DBTab;
        private System.Windows.Forms.Panel checkBoxPanel;
        private System.Windows.Forms.CheckBox minTBCheckBox;
        private System.Windows.Forms.Button forgPasButton;
        private System.Windows.Forms.Button deleteDBButton;
        private System.Windows.Forms.Button clearDBButton;
    }
}
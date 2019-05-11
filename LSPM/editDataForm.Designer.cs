namespace LSPM
{
    partial class editDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editDataForm));
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passInputLabel = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.userInput = new System.Windows.Forms.TextBox();
            this.userInputLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aliasInput = new System.Windows.Forms.TextBox();
            this.aliasInputlabel = new System.Windows.Forms.Label();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.userAccessCheck = new System.Windows.Forms.CheckBox();
            this.passwordAccessCheck = new System.Windows.Forms.CheckBox();
            this.colorSelectorContainer = new System.Windows.Forms.Panel();
            this.whiteColorPanel = new System.Windows.Forms.Panel();
            this.yellowColorPanel = new System.Windows.Forms.Panel();
            this.blackColorPanel = new System.Windows.Forms.Panel();
            this.blueColorPanel = new System.Windows.Forms.Panel();
            this.purpleColorPanel = new System.Windows.Forms.Panel();
            this.orangeColorPanel = new System.Windows.Forms.Panel();
            this.redColorPanel = new System.Windows.Forms.Panel();
            this.greenColorPanel = new System.Windows.Forms.Panel();
            this.pinkColorPanel = new System.Windows.Forms.Panel();
            this.performEditButton = new System.Windows.Forms.Button();
            this.infoGroupBox.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.viewGroupBox.SuspendLayout();
            this.colorSelectorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.panel12);
            this.infoGroupBox.Controls.Add(this.panel11);
            this.infoGroupBox.Controls.Add(this.panel1);
            this.infoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(290, 219);
            this.infoGroupBox.TabIndex = 0;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Información";
            this.infoGroupBox.UseCompatibleTextRendering = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.passwordInput);
            this.panel12.Controls.Add(this.passInputLabel);
            this.panel12.Location = new System.Drawing.Point(6, 145);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(277, 56);
            this.panel12.TabIndex = 4;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.passwordInput.Location = new System.Drawing.Point(5, 25);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(266, 26);
            this.passwordInput.TabIndex = 0;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // passInputLabel
            // 
            this.passInputLabel.AutoSize = true;
            this.passInputLabel.Location = new System.Drawing.Point(8, 6);
            this.passInputLabel.Name = "passInputLabel";
            this.passInputLabel.Size = new System.Drawing.Size(77, 16);
            this.passInputLabel.TabIndex = 2;
            this.passInputLabel.Text = "Contraseña";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.userInput);
            this.panel11.Controls.Add(this.userInputLabel);
            this.panel11.Location = new System.Drawing.Point(6, 83);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(277, 56);
            this.panel11.TabIndex = 4;
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.userInput.Location = new System.Drawing.Point(5, 25);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(266, 26);
            this.userInput.TabIndex = 0;
            // 
            // userInputLabel
            // 
            this.userInputLabel.AutoSize = true;
            this.userInputLabel.Location = new System.Drawing.Point(8, 6);
            this.userInputLabel.Name = "userInputLabel";
            this.userInputLabel.Size = new System.Drawing.Size(126, 16);
            this.userInputLabel.TabIndex = 2;
            this.userInputLabel.Text = "Nombre de Usuario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aliasInput);
            this.panel1.Controls.Add(this.aliasInputlabel);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 56);
            this.panel1.TabIndex = 3;
            // 
            // aliasInput
            // 
            this.aliasInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.aliasInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aliasInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aliasInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.aliasInput.Location = new System.Drawing.Point(5, 25);
            this.aliasInput.Name = "aliasInput";
            this.aliasInput.Size = new System.Drawing.Size(266, 26);
            this.aliasInput.TabIndex = 0;
            // 
            // aliasInputlabel
            // 
            this.aliasInputlabel.AutoSize = true;
            this.aliasInputlabel.Location = new System.Drawing.Point(8, 6);
            this.aliasInputlabel.Name = "aliasInputlabel";
            this.aliasInputlabel.Size = new System.Drawing.Size(101, 16);
            this.aliasInputlabel.TabIndex = 2;
            this.aliasInputlabel.Text = "Nombre o Alias";
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Controls.Add(this.userAccessCheck);
            this.viewGroupBox.Controls.Add(this.passwordAccessCheck);
            this.viewGroupBox.Controls.Add(this.colorSelectorContainer);
            this.viewGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viewGroupBox.Location = new System.Drawing.Point(12, 237);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(290, 113);
            this.viewGroupBox.TabIndex = 1;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "Visualización";
            this.viewGroupBox.UseCompatibleTextRendering = true;
            // 
            // userAccessCheck
            // 
            this.userAccessCheck.AutoSize = true;
            this.userAccessCheck.Location = new System.Drawing.Point(6, 61);
            this.userAccessCheck.Name = "userAccessCheck";
            this.userAccessCheck.Size = new System.Drawing.Size(176, 20);
            this.userAccessCheck.TabIndex = 3;
            this.userAccessCheck.Text = "Acceso rápido a Usuario";
            this.userAccessCheck.UseVisualStyleBackColor = true;
            // 
            // passwordAccessCheck
            // 
            this.passwordAccessCheck.AutoSize = true;
            this.passwordAccessCheck.Location = new System.Drawing.Point(6, 87);
            this.passwordAccessCheck.Name = "passwordAccessCheck";
            this.passwordAccessCheck.Size = new System.Drawing.Size(198, 20);
            this.passwordAccessCheck.TabIndex = 2;
            this.passwordAccessCheck.Text = "Acceso rápido a Contraseña";
            this.passwordAccessCheck.UseVisualStyleBackColor = true;
            // 
            // colorSelectorContainer
            // 
            this.colorSelectorContainer.Controls.Add(this.whiteColorPanel);
            this.colorSelectorContainer.Controls.Add(this.yellowColorPanel);
            this.colorSelectorContainer.Controls.Add(this.blackColorPanel);
            this.colorSelectorContainer.Controls.Add(this.blueColorPanel);
            this.colorSelectorContainer.Controls.Add(this.purpleColorPanel);
            this.colorSelectorContainer.Controls.Add(this.orangeColorPanel);
            this.colorSelectorContainer.Controls.Add(this.redColorPanel);
            this.colorSelectorContainer.Controls.Add(this.greenColorPanel);
            this.colorSelectorContainer.Controls.Add(this.pinkColorPanel);
            this.colorSelectorContainer.Location = new System.Drawing.Point(6, 21);
            this.colorSelectorContainer.Name = "colorSelectorContainer";
            this.colorSelectorContainer.Size = new System.Drawing.Size(278, 34);
            this.colorSelectorContainer.TabIndex = 2;
            // 
            // whiteColorPanel
            // 
            this.whiteColorPanel.BackColor = System.Drawing.Color.White;
            this.whiteColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whiteColorPanel.Location = new System.Drawing.Point(247, 4);
            this.whiteColorPanel.Name = "whiteColorPanel";
            this.whiteColorPanel.Size = new System.Drawing.Size(24, 24);
            this.whiteColorPanel.TabIndex = 5;
            // 
            // yellowColorPanel
            // 
            this.yellowColorPanel.BackColor = System.Drawing.Color.Yellow;
            this.yellowColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowColorPanel.Location = new System.Drawing.Point(157, 4);
            this.yellowColorPanel.Name = "yellowColorPanel";
            this.yellowColorPanel.Size = new System.Drawing.Size(24, 24);
            this.yellowColorPanel.TabIndex = 5;
            // 
            // blackColorPanel
            // 
            this.blackColorPanel.BackColor = System.Drawing.Color.Black;
            this.blackColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackColorPanel.Location = new System.Drawing.Point(7, 4);
            this.blackColorPanel.Name = "blackColorPanel";
            this.blackColorPanel.Size = new System.Drawing.Size(24, 24);
            this.blackColorPanel.TabIndex = 3;
            // 
            // blueColorPanel
            // 
            this.blueColorPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.blueColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueColorPanel.Location = new System.Drawing.Point(217, 4);
            this.blueColorPanel.Name = "blueColorPanel";
            this.blueColorPanel.Size = new System.Drawing.Size(24, 24);
            this.blueColorPanel.TabIndex = 7;
            // 
            // purpleColorPanel
            // 
            this.purpleColorPanel.BackColor = System.Drawing.Color.Purple;
            this.purpleColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purpleColorPanel.Location = new System.Drawing.Point(37, 4);
            this.purpleColorPanel.Name = "purpleColorPanel";
            this.purpleColorPanel.Size = new System.Drawing.Size(24, 24);
            this.purpleColorPanel.TabIndex = 4;
            // 
            // orangeColorPanel
            // 
            this.orangeColorPanel.BackColor = System.Drawing.Color.Orange;
            this.orangeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orangeColorPanel.Location = new System.Drawing.Point(127, 4);
            this.orangeColorPanel.Name = "orangeColorPanel";
            this.orangeColorPanel.Size = new System.Drawing.Size(24, 24);
            this.orangeColorPanel.TabIndex = 7;
            // 
            // redColorPanel
            // 
            this.redColorPanel.BackColor = System.Drawing.Color.Red;
            this.redColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redColorPanel.Location = new System.Drawing.Point(97, 4);
            this.redColorPanel.Name = "redColorPanel";
            this.redColorPanel.Size = new System.Drawing.Size(24, 24);
            this.redColorPanel.TabIndex = 6;
            // 
            // greenColorPanel
            // 
            this.greenColorPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.greenColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenColorPanel.Location = new System.Drawing.Point(187, 4);
            this.greenColorPanel.Name = "greenColorPanel";
            this.greenColorPanel.Size = new System.Drawing.Size(24, 24);
            this.greenColorPanel.TabIndex = 6;
            // 
            // pinkColorPanel
            // 
            this.pinkColorPanel.BackColor = System.Drawing.Color.DeepPink;
            this.pinkColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pinkColorPanel.Location = new System.Drawing.Point(67, 4);
            this.pinkColorPanel.Name = "pinkColorPanel";
            this.pinkColorPanel.Size = new System.Drawing.Size(24, 24);
            this.pinkColorPanel.TabIndex = 3;
            // 
            // performEditButton
            // 
            this.performEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.performEditButton.ForeColor = System.Drawing.Color.LightGreen;
            this.performEditButton.Location = new System.Drawing.Point(12, 356);
            this.performEditButton.Name = "performEditButton";
            this.performEditButton.Size = new System.Drawing.Size(290, 33);
            this.performEditButton.TabIndex = 2;
            this.performEditButton.Text = "Modificar";
            this.performEditButton.UseVisualStyleBackColor = true;
            // 
            // editDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(314, 401);
            this.Controls.Add(this.performEditButton);
            this.Controls.Add(this.viewGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "editDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Datos";
            this.infoGroupBox.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.viewGroupBox.ResumeLayout(false);
            this.viewGroupBox.PerformLayout();
            this.colorSelectorContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.Panel colorSelectorContainer;
        private System.Windows.Forms.Panel whiteColorPanel;
        private System.Windows.Forms.Panel yellowColorPanel;
        private System.Windows.Forms.Panel blackColorPanel;
        private System.Windows.Forms.Panel blueColorPanel;
        private System.Windows.Forms.Panel purpleColorPanel;
        private System.Windows.Forms.Panel orangeColorPanel;
        private System.Windows.Forms.Panel redColorPanel;
        private System.Windows.Forms.Panel greenColorPanel;
        private System.Windows.Forms.Panel pinkColorPanel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label passInputLabel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox aliasInput;
        private System.Windows.Forms.Label aliasInputlabel;
        private System.Windows.Forms.CheckBox userAccessCheck;
        private System.Windows.Forms.CheckBox passwordAccessCheck;
        private System.Windows.Forms.Button performEditButton;
    }
}

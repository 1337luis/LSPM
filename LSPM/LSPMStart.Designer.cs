namespace LSPM
{
    partial class LSPMStart
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LSPMStart));
            this.startButton = new System.Windows.Forms.Button();
            this.passwordInput2 = new System.Windows.Forms.TextBox();
            this.passwordInput1 = new System.Windows.Forms.TextBox();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.startButton.Location = new System.Drawing.Point(12, 155);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(375, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "¡Comenzamos!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // passwordInput2
            // 
            this.passwordInput2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.passwordInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.passwordInput2.Location = new System.Drawing.Point(55, 98);
            this.passwordInput2.Name = "passwordInput2";
            this.passwordInput2.Size = new System.Drawing.Size(292, 26);
            this.passwordInput2.TabIndex = 1;
            this.passwordInput2.UseSystemPasswordChar = true;
            // 
            // passwordInput1
            // 
            this.passwordInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.passwordInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.passwordInput1.Location = new System.Drawing.Point(55, 47);
            this.passwordInput1.Name = "passwordInput1";
            this.passwordInput1.Size = new System.Drawing.Size(292, 26);
            this.passwordInput1.TabIndex = 2;
            this.passwordInput1.UseSystemPasswordChar = true;
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.passwordLabel1.Location = new System.Drawing.Point(52, 28);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(154, 16);
            this.passwordLabel1.TabIndex = 3;
            this.passwordLabel1.Text = "Elige una contraseña";
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.passwordLabel2.Location = new System.Drawing.Point(52, 79);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(140, 16);
            this.passwordLabel2.TabIndex = 4;
            this.passwordLabel2.Text = "Repetir contraseña";
            // 
            // LSPMStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(399, 201);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.passwordInput1);
            this.Controls.Add(this.passwordInput2);
            this.Controls.Add(this.startButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LSPMStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenid@ a LSPM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox passwordInput2;
        private System.Windows.Forms.TextBox passwordInput1;
        private System.Windows.Forms.Label passwordLabel1;
        private System.Windows.Forms.Label passwordLabel2;
    }
}


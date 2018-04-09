namespace LIC_KIHD_GUI
{
    partial class loginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelForID = new System.Windows.Forms.Label();
            this.labelForPassword = new System.Windows.Forms.Label();
            this.barForID = new System.Windows.Forms.TextBox();
            this.barForPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(561, 447);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(87, 43);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(654, 447);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 43);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelForID
            // 
            this.labelForID.AutoSize = true;
            this.labelForID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForID.Location = new System.Drawing.Point(557, 236);
            this.labelForID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForID.Name = "labelForID";
            this.labelForID.Size = new System.Drawing.Size(80, 22);
            this.labelForID.TabIndex = 3;
            this.labelForID.Text = "Login ID";
            this.labelForID.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelForPassword
            // 
            this.labelForPassword.AutoSize = true;
            this.labelForPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForPassword.Location = new System.Drawing.Point(558, 329);
            this.labelForPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForPassword.Name = "labelForPassword";
            this.labelForPassword.Size = new System.Drawing.Size(88, 22);
            this.labelForPassword.TabIndex = 4;
            this.labelForPassword.Text = "Password";
            // 
            // barForID
            // 
            this.barForID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barForID.Location = new System.Drawing.Point(561, 274);
            this.barForID.Margin = new System.Windows.Forms.Padding(4);
            this.barForID.Name = "barForID";
            this.barForID.Size = new System.Drawing.Size(174, 30);
            this.barForID.TabIndex = 5;
            this.barForID.TextChanged += new System.EventHandler(this.barForID_TextChanged);
            // 
            // barForPassword
            // 
            this.barForPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barForPassword.Location = new System.Drawing.Point(558, 367);
            this.barForPassword.Margin = new System.Windows.Forms.Padding(4);
            this.barForPassword.Name = "barForPassword";
            this.barForPassword.Size = new System.Drawing.Size(174, 30);
            this.barForPassword.TabIndex = 6;
            this.barForPassword.UseSystemPasswordChar = true;
            this.barForPassword.TextChanged += new System.EventHandler(this.barForPassword_TextChanged);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1213, 974);
            this.Controls.Add(this.barForPassword);
            this.Controls.Add(this.barForID);
            this.Controls.Add(this.labelForPassword);
            this.Controls.Add(this.labelForID);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginPage";
            this.Text = "LIC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label labelForID;
        private System.Windows.Forms.Label labelForPassword;
        private System.Windows.Forms.TextBox barForID;
        private System.Windows.Forms.TextBox barForPassword;
    }
}


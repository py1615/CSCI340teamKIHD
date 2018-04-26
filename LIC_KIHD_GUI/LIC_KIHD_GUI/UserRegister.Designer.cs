namespace LIC_KIHD_GUI
{
    partial class UserRegister
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Agent = new System.Windows.Forms.CheckBox();
            this.Manager = new System.Windows.Forms.CheckBox();
            this.IDBOX = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Agent UserName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 440);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agent Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 505);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 595);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "User Type:";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(396, 685);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(103, 41);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Agent
            // 
            this.Agent.AutoSize = true;
            this.Agent.Location = new System.Drawing.Point(634, 588);
            this.Agent.Margin = new System.Windows.Forms.Padding(4);
            this.Agent.Name = "Agent";
            this.Agent.Size = new System.Drawing.Size(64, 23);
            this.Agent.TabIndex = 9;
            this.Agent.Text = "Agent";
            this.Agent.UseVisualStyleBackColor = true;
            this.Agent.CheckedChanged += new System.EventHandler(this.UtYes_CheckedChanged);
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.Location = new System.Drawing.Point(634, 622);
            this.Manager.Margin = new System.Windows.Forms.Padding(4);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(82, 23);
            this.Manager.TabIndex = 10;
            this.Manager.Text = "Manager";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.CheckedChanged += new System.EventHandler(this.UtNo_CheckedChanged);
            // 
            // IDBOX
            // 
            this.IDBOX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBOX.Location = new System.Drawing.Point(634, 176);
            this.IDBOX.Margin = new System.Windows.Forms.Padding(4);
            this.IDBOX.MaxLength = 20;
            this.IDBOX.Name = "IDBOX";
            this.IDBOX.Size = new System.Drawing.Size(136, 26);
            this.IDBOX.TabIndex = 11;
            this.IDBOX.TextChanged += new System.EventHandler(this.IDBOX_TextChanged);
            // 
            // FNameBox
            // 
            this.FNameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameBox.Location = new System.Drawing.Point(634, 241);
            this.FNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.FNameBox.MaxLength = 100;
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(136, 26);
            this.FNameBox.TabIndex = 12;
            this.FNameBox.TextChanged += new System.EventHandler(this.FNameBox_TextChanged);
            // 
            // LNameBox
            // 
            this.LNameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameBox.Location = new System.Drawing.Point(634, 305);
            this.LNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.LNameBox.MaxLength = 100;
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(136, 26);
            this.LNameBox.TabIndex = 13;
            this.LNameBox.TextChanged += new System.EventHandler(this.LNameBox_TextChanged);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(634, 370);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameBox.MaxLength = 20;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(136, 26);
            this.UserNameBox.TabIndex = 14;
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(634, 435);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.MaxLength = 255;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(136, 26);
            this.PasswordBox.TabIndex = 15;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Obfuscation",
            "Finance",
            "Legal",
            "Macekting",
            "Human Resource",
            "Sales",
            "Claims",
            "Customer Service"});
            this.comboBox1.Location = new System.Drawing.Point(634, 503);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1213, 974);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.IDBOX);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.Agent);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserRegister";
            this.Text = "UserRegister";
            this.Load += new System.EventHandler(this.UserRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.CheckBox Agent;
        private System.Windows.Forms.CheckBox Manager;
        private System.Windows.Forms.TextBox IDBOX;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
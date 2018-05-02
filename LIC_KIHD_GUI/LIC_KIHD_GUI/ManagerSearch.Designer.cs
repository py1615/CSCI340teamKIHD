namespace LIC_KIHD_GUI
{
    partial class managerSearch
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
            this.logOutButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.agentSearchButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.Label();
            this.policyNumber = new System.Windows.Forms.Label();
            this.managerSearchTitle = new System.Windows.Forms.Label();
            this.agentName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserRegistrationButton = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logOutButton.Location = new System.Drawing.Point(1338, 13);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(103, 43);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registrationButton.Location = new System.Drawing.Point(1147, 13);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(183, 43);
            this.registrationButton.TabIndex = 3;
            this.registrationButton.Text = "Policy Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // agentSearchButton
            // 
            this.agentSearchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentSearchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.agentSearchButton.Location = new System.Drawing.Point(363, 405);
            this.agentSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.agentSearchButton.Name = "agentSearchButton";
            this.agentSearchButton.Size = new System.Drawing.Size(103, 38);
            this.agentSearchButton.TabIndex = 11;
            this.agentSearchButton.Text = "Search";
            this.agentSearchButton.UseVisualStyleBackColor = true;
            this.agentSearchButton.Click += new System.EventHandler(this.agentSearchButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox2.Location = new System.Drawing.Point(553, 278);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox1.Location = new System.Drawing.Point(553, 208);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 10;
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClientName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClientName.Location = new System.Drawing.Point(359, 348);
            this.ClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(88, 19);
            this.ClientName.TabIndex = 7;
            this.ClientName.Text = "Client Name:";
            // 
            // policyNumber
            // 
            this.policyNumber.AutoSize = true;
            this.policyNumber.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.policyNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.policyNumber.Location = new System.Drawing.Point(359, 208);
            this.policyNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.policyNumber.Name = "policyNumber";
            this.policyNumber.Size = new System.Drawing.Size(103, 19);
            this.policyNumber.TabIndex = 8;
            this.policyNumber.Text = "Policy Number:";
            // 
            // managerSearchTitle
            // 
            this.managerSearchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerSearchTitle.AutoSize = true;
            this.managerSearchTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F);
            this.managerSearchTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.managerSearchTitle.Location = new System.Drawing.Point(447, 110);
            this.managerSearchTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managerSearchTitle.Name = "managerSearchTitle";
            this.managerSearchTitle.Size = new System.Drawing.Size(196, 31);
            this.managerSearchTitle.TabIndex = 12;
            this.managerSearchTitle.Text = "Manager Search:";
            // 
            // agentName
            // 
            this.agentName.AutoSize = true;
            this.agentName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentName.Location = new System.Drawing.Point(359, 278);
            this.agentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentName.Name = "agentName";
            this.agentName.Size = new System.Drawing.Size(89, 19);
            this.agentName.TabIndex = 13;
            this.agentName.Text = "Agent Name:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(553, 348);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 26);
            this.textBox3.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.ViewButton});
            this.dataGridView1.Location = new System.Drawing.Point(-6, 451);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1455, 528);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserRegistrationButton
            // 
            this.UserRegistrationButton.Location = new System.Drawing.Point(979, 13);
            this.UserRegistrationButton.Name = "UserRegistrationButton";
            this.UserRegistrationButton.Size = new System.Drawing.Size(161, 43);
            this.UserRegistrationButton.TabIndex = 16;
            this.UserRegistrationButton.Text = "User Registration";
            this.UserRegistrationButton.UseVisualStyleBackColor = true;
            this.UserRegistrationButton.Click += new System.EventHandler(this.UserRegistrationButton_Click);
            // 
            // P
            // 
            this.P.HeaderText = "Policy Number";
            this.P.Name = "P";
            this.P.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Client Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Agent ID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Agent Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Policy Start Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Payment";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Monthly Premium";
            this.Column7.Name = "Column7";
            // 
            // ViewButton
            // 
            this.ViewButton.HeaderText = "View";
            this.ViewButton.Name = "ViewButton";
            // 
            // managerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1454, 974);
            this.Controls.Add(this.UserRegistrationButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.agentName);
            this.Controls.Add(this.managerSearchTitle);
            this.Controls.Add(this.agentSearchButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.policyNumber);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.registrationButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "managerSearch";
            this.Text = "LIC";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button agentSearchButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label policyNumber;
        private System.Windows.Forms.Label managerSearchTitle;
        private System.Windows.Forms.Label agentName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UserRegistrationButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn ViewButton;
    }
}
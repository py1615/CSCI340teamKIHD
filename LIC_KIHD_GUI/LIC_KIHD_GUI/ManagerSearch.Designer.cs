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
            this.barForAgentFirstName = new System.Windows.Forms.TextBox();
            this.barForPolicyNumber = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.Label();
            this.policyNumber = new System.Windows.Forms.Label();
            this.managerSearchTitle = new System.Windows.Forms.Label();
            this.agentName = new System.Windows.Forms.Label();
            this.barForClientFirstName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UserRegistrationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BarForAgentLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barForClientLastN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logOutButton.Location = new System.Drawing.Point(1189, 13);
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
            this.registrationButton.Location = new System.Drawing.Point(998, 13);
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
            this.agentSearchButton.Location = new System.Drawing.Point(367, 405);
            this.agentSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.agentSearchButton.Name = "agentSearchButton";
            this.agentSearchButton.Size = new System.Drawing.Size(103, 38);
            this.agentSearchButton.TabIndex = 11;
            this.agentSearchButton.Text = "Search";
            this.agentSearchButton.UseVisualStyleBackColor = true;
            this.agentSearchButton.Click += new System.EventHandler(this.agentSearchButton_Click);
            // 
            // barForAgentFirstName
            // 
            this.barForAgentFirstName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.barForAgentFirstName.Location = new System.Drawing.Point(553, 206);
            this.barForAgentFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.barForAgentFirstName.Name = "barForAgentFirstName";
            this.barForAgentFirstName.Size = new System.Drawing.Size(240, 26);
            this.barForAgentFirstName.TabIndex = 9;
            this.barForAgentFirstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // barForPolicyNumber
            // 
            this.barForPolicyNumber.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.barForPolicyNumber.Location = new System.Drawing.Point(553, 169);
            this.barForPolicyNumber.Margin = new System.Windows.Forms.Padding(4);
            this.barForPolicyNumber.Name = "barForPolicyNumber";
            this.barForPolicyNumber.Size = new System.Drawing.Size(240, 26);
            this.barForPolicyNumber.TabIndex = 10;
            this.barForPolicyNumber.TextChanged += new System.EventHandler(this.barForPolicyNumber_TextChanged);
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClientName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClientName.Location = new System.Drawing.Point(363, 289);
            this.ClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(119, 19);
            this.ClientName.TabIndex = 7;
            this.ClientName.Text = "Client First Name:";
            // 
            // policyNumber
            // 
            this.policyNumber.AutoSize = true;
            this.policyNumber.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.policyNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.policyNumber.Location = new System.Drawing.Point(363, 169);
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
            this.managerSearchTitle.Location = new System.Drawing.Point(473, 95);
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
            this.agentName.Location = new System.Drawing.Point(363, 209);
            this.agentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentName.Name = "agentName";
            this.agentName.Size = new System.Drawing.Size(117, 19);
            this.agentName.TabIndex = 13;
            this.agentName.Text = "Agent First Name";
            // 
            // barForClientFirstName
            // 
            this.barForClientFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barForClientFirstName.Location = new System.Drawing.Point(553, 284);
            this.barForClientFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.barForClientFirstName.Name = "barForClientFirstName";
            this.barForClientFirstName.Size = new System.Drawing.Size(240, 26);
            this.barForClientFirstName.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P,
            this.Column1,
            this.Column9,
            this.Column8,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column10,
            this.ViewButton});
            this.dataGridView1.Location = new System.Drawing.Point(0, 451);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 528);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // P
            // 
            this.P.HeaderText = "Policy Number";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            this.P.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Client First Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Client Last Name";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Birth of Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Policy Start Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Payoff Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Monthly Premium";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Agent ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Agent First Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Agent Last Name";
            this.Column10.Name = "Column10";
            // 
            // ViewButton
            // 
            this.ViewButton.HeaderText = "View";
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Text = "View";
            this.ViewButton.UseColumnTextForButtonValue = true;
            this.ViewButton.Width = 50;
            // 
            // UserRegistrationButton
            // 
            this.UserRegistrationButton.Location = new System.Drawing.Point(830, 13);
            this.UserRegistrationButton.Name = "UserRegistrationButton";
            this.UserRegistrationButton.Size = new System.Drawing.Size(161, 43);
            this.UserRegistrationButton.TabIndex = 16;
            this.UserRegistrationButton.Text = "User Registration";
            this.UserRegistrationButton.UseVisualStyleBackColor = true;
            this.UserRegistrationButton.Click += new System.EventHandler(this.UserRegistrationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agent Last Name";
            // 
            // BarForAgentLastName
            // 
            this.BarForAgentLastName.Location = new System.Drawing.Point(553, 246);
            this.BarForAgentLastName.Name = "BarForAgentLastName";
            this.BarForAgentLastName.Size = new System.Drawing.Size(240, 26);
            this.BarForAgentLastName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Client Last Name";
            // 
            // barForClientLastN
            // 
            this.barForClientLastN.Location = new System.Drawing.Point(553, 326);
            this.barForClientLastN.Name = "barForClientLastN";
            this.barForClientLastN.Size = new System.Drawing.Size(240, 26);
            this.barForClientLastN.TabIndex = 21;
            // 
            // managerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1355, 974);
            this.Controls.Add(this.barForClientLastN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarForAgentLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserRegistrationButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.barForClientFirstName);
            this.Controls.Add(this.agentName);
            this.Controls.Add(this.managerSearchTitle);
            this.Controls.Add(this.agentSearchButton);
            this.Controls.Add(this.barForAgentFirstName);
            this.Controls.Add(this.barForPolicyNumber);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.policyNumber);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.registrationButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "managerSearch";
            this.Text = "LIC";
            this.Load += new System.EventHandler(this.managerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button agentSearchButton;
        private System.Windows.Forms.TextBox barForAgentFirstName;
        private System.Windows.Forms.TextBox barForPolicyNumber;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label policyNumber;
        private System.Windows.Forms.Label managerSearchTitle;
        private System.Windows.Forms.Label agentName;
        private System.Windows.Forms.TextBox barForClientFirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UserRegistrationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BarForAgentLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barForClientLastN;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn ViewButton;
    }
}
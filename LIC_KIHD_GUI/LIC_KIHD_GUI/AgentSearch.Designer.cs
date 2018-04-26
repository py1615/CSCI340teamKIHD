namespace LIC_KIHD_GUI
{
    partial class AgentSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentSearch));
            this.registrationButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.searchTitle = new System.Windows.Forms.Label();
            this.policyNumber = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.policyNumBox = new System.Windows.Forms.TextBox();
            this.clientNameBox = new System.Windows.Forms.TextBox();
            this.agentSearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            resources.ApplyResources(this.registrationButton, "registrationButton");
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // logOutButton
            // 
            resources.ApplyResources(this.logOutButton, "logOutButton");
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // searchTitle
            // 
            resources.ApplyResources(this.searchTitle, "searchTitle");
            this.searchTitle.Name = "searchTitle";
            // 
            // policyNumber
            // 
            resources.ApplyResources(this.policyNumber, "policyNumber");
            this.policyNumber.Name = "policyNumber";
            // 
            // ClientName
            // 
            resources.ApplyResources(this.ClientName, "ClientName");
            this.ClientName.Name = "ClientName";
            // 
            // policyNumBox
            // 
            resources.ApplyResources(this.policyNumBox, "policyNumBox");
            this.policyNumBox.Name = "policyNumBox";
            // 
            // clientNameBox
            // 
            resources.ApplyResources(this.clientNameBox, "clientNameBox");
            this.clientNameBox.Name = "clientNameBox";
            this.clientNameBox.TextChanged += new System.EventHandler(this.clientNameBox_TextChanged);
            // 
            // agentSearchButton
            // 
            resources.ApplyResources(this.agentSearchButton, "agentSearchButton");
            this.agentSearchButton.Name = "agentSearchButton";
            this.agentSearchButton.UseVisualStyleBackColor = true;
            this.agentSearchButton.Click += new System.EventHandler(this.agentSearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // View
            // 
            resources.ApplyResources(this.View, "View");
            this.View.Name = "View";
            this.View.Text = "View";
            // 
            // warning
            // 
            resources.ApplyResources(this.warning, "warning");
            this.warning.Name = "warning";
            // 
            // AgentSearch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.warning);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.agentSearchButton);
            this.Controls.Add(this.clientNameBox);
            this.Controls.Add(this.policyNumBox);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.policyNumber);
            this.Controls.Add(this.searchTitle);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.registrationButton);
            this.Name = "AgentSearch";
            this.Load += new System.EventHandler(this.AgentSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.Label policyNumber;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.TextBox policyNumBox;
        private System.Windows.Forms.TextBox clientNameBox;
        private System.Windows.Forms.Button agentSearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.Label warning;
    }
}
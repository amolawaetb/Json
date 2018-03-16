namespace Json2Text
{
    partial class frmJson2TextFromEmail
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
            this.btnGetSubmittedApps = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvWPSubmittedApplication = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWPSubmittedApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetSubmittedApps
            // 
            this.btnGetSubmittedApps.Location = new System.Drawing.Point(238, 43);
            this.btnGetSubmittedApps.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetSubmittedApps.Name = "btnGetSubmittedApps";
            this.btnGetSubmittedApps.Size = new System.Drawing.Size(137, 29);
            this.btnGetSubmittedApps.TabIndex = 0;
            this.btnGetSubmittedApps.Text = "Get Submitted Application";
            this.btnGetSubmittedApps.UseVisualStyleBackColor = true;
            this.btnGetSubmittedApps.Click += new System.EventHandler(this.btnGetSubmittedApps_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 14);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(188, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Enter Supervisor/Chairperson Email ID";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 14);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // dgvWPSubmittedApplication
            // 
            this.dgvWPSubmittedApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWPSubmittedApplication.Location = new System.Drawing.Point(5, 87);
            this.dgvWPSubmittedApplication.Name = "dgvWPSubmittedApplication";
            this.dgvWPSubmittedApplication.Size = new System.Drawing.Size(579, 254);
            this.dgvWPSubmittedApplication.TabIndex = 3;
            this.dgvWPSubmittedApplication.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWPSubmittedApplication_CellContentClick);
            // 
            // frmJson2TextFromEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 346);
            this.Controls.Add(this.dgvWPSubmittedApplication);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnGetSubmittedApps);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmJson2TextFromEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get WP Submitted Application";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWPSubmittedApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSubmittedApps;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgvWPSubmittedApplication;
    }
}
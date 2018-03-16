namespace Json2Text
{
    partial class frmGetJson2TextFromAppID
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
            this.btnGetJson = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAppNo = new System.Windows.Forms.Label();
            this.txtWPApplicationID = new System.Windows.Forms.TextBox();
            this.lnkGetAppFromEmail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGetJson
            // 
            this.btnGetJson.Location = new System.Drawing.Point(17, 32);
            this.btnGetJson.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetJson.Name = "btnGetJson";
            this.btnGetJson.Size = new System.Drawing.Size(97, 27);
            this.btnGetJson.TabIndex = 1;
            this.btnGetJson.Text = "Get Json Data";
            this.btnGetJson.UseVisualStyleBackColor = true;
            this.btnGetJson.Click += new System.EventHandler(this.btnGetJson_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 33);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAppNo
            // 
            this.lblAppNo.AutoSize = true;
            this.lblAppNo.Location = new System.Drawing.Point(15, 10);
            this.lblAppNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppNo.Name = "lblAppNo";
            this.lblAppNo.Size = new System.Drawing.Size(122, 13);
            this.lblAppNo.TabIndex = 3;
            this.lblAppNo.Text = "Enter WP Application ID";
            // 
            // txtWPApplicationID
            // 
            this.txtWPApplicationID.Location = new System.Drawing.Point(155, 6);
            this.txtWPApplicationID.Margin = new System.Windows.Forms.Padding(2);
            this.txtWPApplicationID.Name = "txtWPApplicationID";
            this.txtWPApplicationID.Size = new System.Drawing.Size(329, 20);
            this.txtWPApplicationID.TabIndex = 5;
            // 
            // lnkGetAppFromEmail
            // 
            this.lnkGetAppFromEmail.AutoSize = true;
            this.lnkGetAppFromEmail.Location = new System.Drawing.Point(15, 73);
            this.lnkGetAppFromEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkGetAppFromEmail.Name = "lnkGetAppFromEmail";
            this.lnkGetAppFromEmail.Size = new System.Drawing.Size(227, 13);
            this.lnkGetAppFromEmail.TabIndex = 6;
            this.lnkGetAppFromEmail.TabStop = true;
            this.lnkGetAppFromEmail.Text = "Click here if you don\'t know WP Application ID";
            this.lnkGetAppFromEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGetAppFromEmail_LinkClicked);
            // 
            // frmGetJson2TextFromAppID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 96);
            this.Controls.Add(this.lnkGetAppFromEmail);
            this.Controls.Add(this.txtWPApplicationID);
            this.Controls.Add(this.lblAppNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetJson);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGetJson2TextFromAppID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get JSON2Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetJson;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAppNo;
        private System.Windows.Forms.TextBox txtWPApplicationID;
        private System.Windows.Forms.LinkLabel lnkGetAppFromEmail;
    }
}


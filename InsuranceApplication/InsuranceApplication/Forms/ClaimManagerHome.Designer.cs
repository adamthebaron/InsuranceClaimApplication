﻿namespace InsuranceApplication.Forms
{
    partial class ClaimManagerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimManagerHome));
            this.lblClaimManagerTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblCurUserInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewClear = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.txtViewUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvMessages = new System.Windows.Forms.ListView();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvClients = new System.Windows.Forms.ListView();
            this.btnManageClaims = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClaimManagerTitle
            // 
            this.lblClaimManagerTitle.AutoSize = true;
            this.lblClaimManagerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblClaimManagerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimManagerTitle.ForeColor = System.Drawing.Color.White;
            this.lblClaimManagerTitle.Location = new System.Drawing.Point(12, 19);
            this.lblClaimManagerTitle.Name = "lblClaimManagerTitle";
            this.lblClaimManagerTitle.Size = new System.Drawing.Size(418, 24);
            this.lblClaimManagerTitle.TabIndex = 0;
            this.lblClaimManagerTitle.Text = "Welcome to the Claim Manager Home Page";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(676, 518);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurUserInfo
            // 
            this.lblCurUserInfo.AutoSize = true;
            this.lblCurUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCurUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblCurUserInfo.Location = new System.Drawing.Point(13, 54);
            this.lblCurUserInfo.Name = "lblCurUserInfo";
            this.lblCurUserInfo.Size = new System.Drawing.Size(0, 13);
            this.lblCurUserInfo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(60, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "VIEW/EDIT PROFILE";
            // 
            // btnViewClear
            // 
            this.btnViewClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClear.Location = new System.Drawing.Point(141, 164);
            this.btnViewClear.Name = "btnViewClear";
            this.btnViewClear.Size = new System.Drawing.Size(62, 27);
            this.btnViewClear.TabIndex = 39;
            this.btnViewClear.Text = "Clear";
            this.btnViewClear.UseVisualStyleBackColor = true;
            this.btnViewClear.Click += new System.EventHandler(this.btnViewClear_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(34, 164);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(82, 27);
            this.btnViewProfile.TabIndex = 38;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // txtViewUsername
            // 
            this.txtViewUsername.Location = new System.Drawing.Point(114, 123);
            this.txtViewUsername.Name = "txtViewUsername";
            this.txtViewUsername.Size = new System.Drawing.Size(154, 20);
            this.txtViewUsername.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Username: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(364, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "VIEW MESSAGES";
            // 
            // lvMessages
            // 
            this.lvMessages.Location = new System.Drawing.Point(368, 116);
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.Size = new System.Drawing.Size(383, 154);
            this.lvMessages.TabIndex = 54;
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.SelectedIndexChanged += new System.EventHandler(this.lvMessages_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(368, 276);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 28);
            this.btnSend.TabIndex = 70;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "VIEW CLIENTS";
            // 
            // lvClients
            // 
            this.lvClients.Location = new System.Drawing.Point(368, 340);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(383, 154);
            this.lvClients.TabIndex = 84;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            // 
            // btnManageClaims
            // 
            this.btnManageClaims.Location = new System.Drawing.Point(89, 293);
            this.btnManageClaims.Name = "btnManageClaims";
            this.btnManageClaims.Size = new System.Drawing.Size(94, 32);
            this.btnManageClaims.TabIndex = 86;
            this.btnManageClaims.Text = "Manage Claims";
            this.btnManageClaims.UseVisualStyleBackColor = true;
            this.btnManageClaims.Click += new System.EventHandler(this.btnManageClaims_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(95, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "CLAIMS";
            // 
            // ClaimManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(789, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManageClaims);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvClients);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvMessages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnViewClear);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.txtViewUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurUserInfo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblClaimManagerTitle);
            this.Name = "ClaimManagerHome";
            this.Text = "ClaimManagerHome";
            this.Load += new System.EventHandler(this.ClaimManagerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaimManagerTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblCurUserInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewClear;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.TextBox txtViewUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvMessages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.Button btnManageClaims;
        private System.Windows.Forms.Label label2;
    }
}
﻿namespace InsuranceApplication.Forms
{
    partial class ClientList
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
            this.lstClientList = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClientList
            // 
            this.lstClientList.FormattingEnabled = true;
            this.lstClientList.Location = new System.Drawing.Point(58, 31);
            this.lstClientList.Name = "lstClientList";
            this.lstClientList.Size = new System.Drawing.Size(401, 225);
            this.lstClientList.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(384, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 352);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstClientList);
            this.Name = "ClientList";
            this.Text = "ClientList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstClientList;
        private System.Windows.Forms.Button btnExit;
    }
}
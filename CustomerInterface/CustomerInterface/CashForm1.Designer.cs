﻿namespace CustomerInterface
{
    partial class CashForm1
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
            this.cash_received = new System.Windows.Forms.Label();
            this.Due = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.due_amount = new System.Windows.Forms.Label();
            this.received_amount = new System.Windows.Forms.Label();
            this.change_amount = new System.Windows.Forms.Label();
            this.emailReceiptCheck = new System.Windows.Forms.CheckBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.emailAddressText = new System.Windows.Forms.TextBox();
            this.checkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NSA RESTAURANT";
            // 
            // cash_received
            // 
            this.cash_received.AutoSize = true;
            this.cash_received.Location = new System.Drawing.Point(24, 110);
            this.cash_received.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cash_received.Name = "cash_received";
            this.cash_received.Size = new System.Drawing.Size(224, 25);
            this.cash_received.TabIndex = 1;
            this.cash_received.Text = "Total Cash Received: ";
            // 
            // Due
            // 
            this.Due.AutoSize = true;
            this.Due.Location = new System.Drawing.Point(24, 67);
            this.Due.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Due.Name = "Due";
            this.Due.Size = new System.Drawing.Size(111, 25);
            this.Due.TabIndex = 2;
            this.Due.Text = "Total Due:";
            this.Due.Click += new System.EventHandler(this.Due_Click);
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(24, 152);
            this.change.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(99, 25);
            this.change.TabIndex = 3;
            this.change.Text = "Change: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // due_amount
            // 
            this.due_amount.AutoSize = true;
            this.due_amount.Location = new System.Drawing.Point(406, 67);
            this.due_amount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.due_amount.Name = "due_amount";
            this.due_amount.Size = new System.Drawing.Size(0, 25);
            this.due_amount.TabIndex = 5;
            this.due_amount.Click += new System.EventHandler(this.due_amount_Click);
            // 
            // received_amount
            // 
            this.received_amount.AutoSize = true;
            this.received_amount.Location = new System.Drawing.Point(406, 110);
            this.received_amount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.received_amount.Name = "received_amount";
            this.received_amount.Size = new System.Drawing.Size(0, 25);
            this.received_amount.TabIndex = 6;
            // 
            // change_amount
            // 
            this.change_amount.AutoSize = true;
            this.change_amount.Location = new System.Drawing.Point(406, 152);
            this.change_amount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.change_amount.Name = "change_amount";
            this.change_amount.Size = new System.Drawing.Size(0, 25);
            this.change_amount.TabIndex = 7;
            // 
            // emailReceiptCheck
            // 
            this.emailReceiptCheck.AutoSize = true;
            this.emailReceiptCheck.Location = new System.Drawing.Point(30, 198);
            this.emailReceiptCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emailReceiptCheck.Name = "emailReceiptCheck";
            this.emailReceiptCheck.Size = new System.Drawing.Size(188, 29);
            this.emailReceiptCheck.TabIndex = 11;
            this.emailReceiptCheck.Text = "Email Receipt?";
            this.emailReceiptCheck.UseVisualStyleBackColor = true;
            this.emailReceiptCheck.CheckedChanged += new System.EventHandler(this.emailReceiptCheck_CheckedChanged);
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(30, 244);
            this.emailAddressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(156, 25);
            this.emailAddressLabel.TabIndex = 12;
            this.emailAddressLabel.Text = "Email Address:";
            this.emailAddressLabel.Visible = false;
            // 
            // emailAddressText
            // 
            this.emailAddressText.Location = new System.Drawing.Point(194, 238);
            this.emailAddressText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emailAddressText.Name = "emailAddressText";
            this.emailAddressText.Size = new System.Drawing.Size(304, 31);
            this.emailAddressText.TabIndex = 13;
            this.emailAddressText.Visible = false;
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.ForeColor = System.Drawing.Color.Red;
            this.checkLabel.Location = new System.Drawing.Point(30, 308);
            this.checkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(0, 25);
            this.checkLabel.TabIndex = 14;
            this.checkLabel.Visible = false;
            // 
            // CashForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 365);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.emailAddressText);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.emailReceiptCheck);
            this.Controls.Add(this.change_amount);
            this.Controls.Add(this.received_amount);
            this.Controls.Add(this.due_amount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.Due);
            this.Controls.Add(this.cash_received);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CashForm1";
            this.Text = "Cash Payment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cash_received;
        private System.Windows.Forms.Label Due;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label due_amount;
        private System.Windows.Forms.Label received_amount;
        private System.Windows.Forms.Label change_amount;
        private System.Windows.Forms.CheckBox emailReceiptCheck;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox emailAddressText;
        private System.Windows.Forms.Label checkLabel;
    }
}


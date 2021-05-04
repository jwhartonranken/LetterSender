
namespace LB1
{
    partial class FormLetterDelivery
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
            this.groupBoxLetterInfo = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelAdditionalFee = new System.Windows.Forms.Label();
            this.labelTrackingNumber = new System.Windows.Forms.Label();
            this.labelSentDate = new System.Windows.Forms.Label();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.textBoxTrackingNumber = new System.Windows.Forms.TextBox();
            this.textBoxSentDate = new System.Windows.Forms.TextBox();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.groupBoxLetterHistory = new System.Windows.Forms.GroupBox();
            this.textBoxLetterHistory = new System.Windows.Forms.TextBox();
            this.groupBoxLetterInfo.SuspendLayout();
            this.groupBoxLetterHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLetterInfo
            // 
            this.groupBoxLetterInfo.BackColor = System.Drawing.Color.MistyRose;
            this.groupBoxLetterInfo.Controls.Add(this.buttonExit);
            this.groupBoxLetterInfo.Controls.Add(this.buttonClear);
            this.groupBoxLetterInfo.Controls.Add(this.buttonSend);
            this.groupBoxLetterInfo.Controls.Add(this.labelAdditionalFee);
            this.groupBoxLetterInfo.Controls.Add(this.labelTrackingNumber);
            this.groupBoxLetterInfo.Controls.Add(this.labelSentDate);
            this.groupBoxLetterInfo.Controls.Add(this.labelRecipient);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxTrackingNumber);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxSentDate);
            this.groupBoxLetterInfo.Controls.Add(this.textBoxRecipient);
            this.groupBoxLetterInfo.Location = new System.Drawing.Point(39, 39);
            this.groupBoxLetterInfo.Name = "groupBoxLetterInfo";
            this.groupBoxLetterInfo.Size = new System.Drawing.Size(502, 553);
            this.groupBoxLetterInfo.TabIndex = 0;
            this.groupBoxLetterInfo.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SeaShell;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(334, 376);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(143, 70);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SeaShell;
            this.buttonClear.Location = new System.Drawing.Point(180, 376);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(143, 70);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.SeaShell;
            this.buttonSend.Location = new System.Drawing.Point(26, 376);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(143, 70);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelAdditionalFee
            // 
            this.labelAdditionalFee.AutoSize = true;
            this.labelAdditionalFee.Location = new System.Drawing.Point(69, 241);
            this.labelAdditionalFee.Name = "labelAdditionalFee";
            this.labelAdditionalFee.Size = new System.Drawing.Size(365, 27);
            this.labelAdditionalFee.TabIndex = 6;
            this.labelAdditionalFee.Text = "(Additional Fee For Certified Letter)";
            this.labelAdditionalFee.Visible = false;
            // 
            // labelTrackingNumber
            // 
            this.labelTrackingNumber.AutoSize = true;
            this.labelTrackingNumber.Location = new System.Drawing.Point(18, 170);
            this.labelTrackingNumber.Name = "labelTrackingNumber";
            this.labelTrackingNumber.Size = new System.Drawing.Size(186, 27);
            this.labelTrackingNumber.TabIndex = 5;
            this.labelTrackingNumber.Text = "Tracking Number:";
            // 
            // labelSentDate
            // 
            this.labelSentDate.AutoSize = true;
            this.labelSentDate.Location = new System.Drawing.Point(92, 109);
            this.labelSentDate.Name = "labelSentDate";
            this.labelSentDate.Size = new System.Drawing.Size(112, 27);
            this.labelSentDate.TabIndex = 4;
            this.labelSentDate.Text = "Sent Date:";
            // 
            // labelRecipient
            // 
            this.labelRecipient.AutoSize = true;
            this.labelRecipient.Location = new System.Drawing.Point(94, 48);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(110, 27);
            this.labelRecipient.TabIndex = 3;
            this.labelRecipient.Text = "Recipient:";
            // 
            // textBoxTrackingNumber
            // 
            this.textBoxTrackingNumber.Location = new System.Drawing.Point(210, 167);
            this.textBoxTrackingNumber.Name = "textBoxTrackingNumber";
            this.textBoxTrackingNumber.Size = new System.Drawing.Size(260, 34);
            this.textBoxTrackingNumber.TabIndex = 2;
            // 
            // textBoxSentDate
            // 
            this.textBoxSentDate.Location = new System.Drawing.Point(210, 106);
            this.textBoxSentDate.Name = "textBoxSentDate";
            this.textBoxSentDate.Size = new System.Drawing.Size(260, 34);
            this.textBoxSentDate.TabIndex = 1;
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Location = new System.Drawing.Point(210, 45);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(260, 34);
            this.textBoxRecipient.TabIndex = 0;
            // 
            // groupBoxLetterHistory
            // 
            this.groupBoxLetterHistory.BackColor = System.Drawing.Color.SeaShell;
            this.groupBoxLetterHistory.Controls.Add(this.textBoxLetterHistory);
            this.groupBoxLetterHistory.Location = new System.Drawing.Point(580, 39);
            this.groupBoxLetterHistory.Name = "groupBoxLetterHistory";
            this.groupBoxLetterHistory.Size = new System.Drawing.Size(502, 553);
            this.groupBoxLetterHistory.TabIndex = 1;
            this.groupBoxLetterHistory.TabStop = false;
            // 
            // textBoxLetterHistory
            // 
            this.textBoxLetterHistory.Location = new System.Drawing.Point(28, 27);
            this.textBoxLetterHistory.Multiline = true;
            this.textBoxLetterHistory.Name = "textBoxLetterHistory";
            this.textBoxLetterHistory.Size = new System.Drawing.Size(446, 499);
            this.textBoxLetterHistory.TabIndex = 0;
            // 
            // FormLetterDelivery
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(1120, 631);
            this.Controls.Add(this.groupBoxLetterHistory);
            this.Controls.Add(this.groupBoxLetterInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLetterDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Delivery";
            this.Load += new System.EventHandler(this.FormLetterDelivery_Load);
            this.groupBoxLetterInfo.ResumeLayout(false);
            this.groupBoxLetterInfo.PerformLayout();
            this.groupBoxLetterHistory.ResumeLayout(false);
            this.groupBoxLetterHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLetterInfo;
        private System.Windows.Forms.GroupBox groupBoxLetterHistory;
        private System.Windows.Forms.Label labelTrackingNumber;
        private System.Windows.Forms.Label labelSentDate;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.TextBox textBoxTrackingNumber;
        private System.Windows.Forms.TextBox textBoxSentDate;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.TextBox textBoxLetterHistory;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelAdditionalFee;
    }
}


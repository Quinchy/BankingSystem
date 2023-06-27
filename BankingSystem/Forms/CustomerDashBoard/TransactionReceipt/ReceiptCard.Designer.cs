namespace BankingSystem.Forms.CustomerDashBoard.TransactionReceipt
{
    partial class ReceiptCard
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            appLogoIcon = new Panel();
            receiverNameValue = new Label();
            accountIdLabel = new Label();
            accountIdPanel = new Utils.Components.RoundedPanel();
            transactionTypeLabel = new Label();
            line1 = new Panel();
            amountLabel = new Label();
            transactionAmountLabel = new Label();
            panel1 = new Panel();
            amountPanel = new Panel();
            referenceNumberLabel = new Label();
            transactionDateLabel = new Label();
            transactionReferenceNumberLabel = new Label();
            receiverName = new Label();
            label2 = new Label();
            senderName = new Label();
            senderNameValue = new Label();
            accountIdPanel.SuspendLayout();
            amountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // appLogoIcon
            // 
            appLogoIcon.BackColor = Color.Transparent;
            appLogoIcon.BackgroundImage = Properties.Resources.OnlyFundsLogoDashboard;
            appLogoIcon.Location = new Point(135, 13);
            appLogoIcon.Name = "appLogoIcon";
            appLogoIcon.Size = new Size(61, 50);
            appLogoIcon.TabIndex = 8;
            // 
            // receiverNameValue
            // 
            receiverNameValue.AutoSize = true;
            receiverNameValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            receiverNameValue.ForeColor = SystemColors.WindowFrame;
            receiverNameValue.Location = new Point(110, 376);
            receiverNameValue.Name = "receiverNameValue";
            receiverNameValue.Size = new Size(106, 21);
            receiverNameValue.TabIndex = 9;
            receiverNameValue.Text = "Samuel Cruz";
            receiverNameValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            accountIdLabel.Location = new Point(17, 3);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new Size(92, 18);
            accountIdLabel.TabIndex = 10;
            accountIdLabel.Text = "#CYAN5081";
            // 
            // accountIdPanel
            // 
            accountIdPanel.BackColor = Color.Transparent;
            accountIdPanel.BorderColor = Color.FromArgb(92, 184, 92);
            accountIdPanel.Controls.Add(accountIdLabel);
            accountIdPanel.CornerRadius = 10;
            accountIdPanel.ForeColor = Color.Transparent;
            accountIdPanel.Location = new Point(102, 69);
            accountIdPanel.Name = "accountIdPanel";
            accountIdPanel.Size = new Size(127, 25);
            accountIdPanel.TabIndex = 33;
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            transactionTypeLabel.Location = new Point(70, 130);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(181, 24);
            transactionTypeLabel.TabIndex = 34;
            transactionTypeLabel.Text = "Cash Withdrawal";
            // 
            // line1
            // 
            line1.BackColor = Color.Gainsboro;
            line1.Location = new Point(25, 180);
            line1.Name = "line1";
            line1.Size = new Size(275, 1);
            line1.TabIndex = 41;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.ForeColor = Color.White;
            amountLabel.Location = new Point(48, 54);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(99, 25);
            amountLabel.TabIndex = 42;
            amountLabel.Text = "Amount:";
            // 
            // transactionAmountLabel
            // 
            transactionAmountLabel.AutoSize = true;
            transactionAmountLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            transactionAmountLabel.ForeColor = Color.White;
            transactionAmountLabel.Location = new Point(207, 55);
            transactionAmountLabel.Name = "transactionAmountLabel";
            transactionAmountLabel.Size = new Size(71, 23);
            transactionAmountLabel.TabIndex = 43;
            transactionAmountLabel.Text = "₱ 1000";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(25, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 1);
            panel1.TabIndex = 42;
            // 
            // amountPanel
            // 
            amountPanel.BackColor = Color.FromArgb(92, 184, 92);
            amountPanel.Controls.Add(amountLabel);
            amountPanel.Controls.Add(transactionAmountLabel);
            amountPanel.Location = new Point(0, 188);
            amountPanel.Name = "amountPanel";
            amountPanel.Size = new Size(326, 137);
            amountPanel.TabIndex = 44;
            // 
            // referenceNumberLabel
            // 
            referenceNumberLabel.AutoSize = true;
            referenceNumberLabel.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            referenceNumberLabel.Location = new Point(25, 405);
            referenceNumberLabel.Name = "referenceNumberLabel";
            referenceNumberLabel.Size = new Size(162, 19);
            referenceNumberLabel.TabIndex = 46;
            referenceNumberLabel.Text = "Reference Number:";
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            transactionDateLabel.ForeColor = SystemColors.WindowFrame;
            transactionDateLabel.Location = new Point(84, 433);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new Size(112, 19);
            transactionDateLabel.TabIndex = 47;
            transactionDateLabel.Text = "June 22, 2023";
            // 
            // transactionReferenceNumberLabel
            // 
            transactionReferenceNumberLabel.AutoSize = true;
            transactionReferenceNumberLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transactionReferenceNumberLabel.ForeColor = SystemColors.WindowFrame;
            transactionReferenceNumberLabel.Location = new Point(188, 405);
            transactionReferenceNumberLabel.Name = "transactionReferenceNumberLabel";
            transactionReferenceNumberLabel.Size = new Size(119, 21);
            transactionReferenceNumberLabel.TabIndex = 48;
            transactionReferenceNumberLabel.Text = "0000-000-0000";
            // 
            // receiverName
            // 
            receiverName.AutoSize = true;
            receiverName.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            receiverName.Location = new Point(25, 377);
            receiverName.Name = "receiverName";
            receiverName.Size = new Size(86, 19);
            receiverName.TabIndex = 49;
            receiverName.Text = "Receiver: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(25, 433);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 50;
            label2.Text = "Date: ";
            // 
            // senderName
            // 
            senderName.AutoSize = true;
            senderName.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            senderName.Location = new Point(25, 349);
            senderName.Name = "senderName";
            senderName.Size = new Size(72, 19);
            senderName.TabIndex = 52;
            senderName.Text = "Sender: ";
            // 
            // senderNameValue
            // 
            senderNameValue.AutoSize = true;
            senderNameValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            senderNameValue.ForeColor = SystemColors.WindowFrame;
            senderNameValue.Location = new Point(95, 349);
            senderNameValue.Name = "senderNameValue";
            senderNameValue.Size = new Size(106, 21);
            senderNameValue.TabIndex = 51;
            senderNameValue.Text = "Samuel Cruz";
            senderNameValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReceiptCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(senderName);
            Controls.Add(senderNameValue);
            Controls.Add(label2);
            Controls.Add(receiverName);
            Controls.Add(receiverNameValue);
            Controls.Add(transactionReferenceNumberLabel);
            Controls.Add(transactionDateLabel);
            Controls.Add(referenceNumberLabel);
            Controls.Add(panel1);
            Controls.Add(line1);
            Controls.Add(transactionTypeLabel);
            Controls.Add(accountIdPanel);
            Controls.Add(appLogoIcon);
            Controls.Add(amountPanel);
            Name = "ReceiptCard";
            Size = new Size(326, 468);
            accountIdPanel.ResumeLayout(false);
            accountIdPanel.PerformLayout();
            amountPanel.ResumeLayout(false);
            amountPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel appLogoIcon;
        public Label receiverNameValue;
        public Label accountIdLabel;
        private Utils.Components.RoundedPanel accountIdPanel;
        public Label transactionTypeLabel;
        private Panel line1;
        private Label amountLabel;
        public Label transactionAmountLabel;
        private Panel panel1;
        private Panel amountPanel;
        private Label referenceNumberLabel;
        public Label transactionDateLabel;
        public Label transactionReferenceNumberLabel;
        public Label receiverName;
        private Label label2;
        public Label senderName;
        public Label senderNameValue;
    }
}

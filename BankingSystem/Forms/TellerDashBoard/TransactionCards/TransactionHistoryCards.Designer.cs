using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.TellerDashBoard.TransactionCards
{
    partial class TransactionHistoryCards
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
            transactionRequestPanel = new RoundedPanel();
            viewReceipt = new LinkLabel();
            processStatusValue = new Label();
            transactionStatusLabel = new Label();
            transactionTypeValue = new Label();
            transactionTypeLabel = new Label();
            amountValue = new Label();
            receiverAccountIdValue = new Label();
            receiverFullNameValue = new Label();
            line2 = new Panel();
            panel4 = new Panel();
            receiverLabel = new Label();
            amountLabel = new Label();
            transactionDateValue = new Label();
            senderAccountIdValue = new Label();
            senderFullNameValue = new Label();
            transactionDateLabel = new Label();
            senderLabel = new Label();
            line1 = new Panel();
            panel2 = new Panel();
            transactionRequestPictureBackground = new Panel();
            transactionHistoryPicture = new PictureBox();
            transactionRequestPanel.SuspendLayout();
            line2.SuspendLayout();
            line1.SuspendLayout();
            transactionRequestPictureBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionHistoryPicture).BeginInit();
            SuspendLayout();
            // 
            // transactionRequestPanel
            // 
            transactionRequestPanel.BackColor = Color.Transparent;
            transactionRequestPanel.BorderColor = Color.White;
            transactionRequestPanel.Controls.Add(viewReceipt);
            transactionRequestPanel.Controls.Add(processStatusValue);
            transactionRequestPanel.Controls.Add(transactionStatusLabel);
            transactionRequestPanel.Controls.Add(transactionTypeValue);
            transactionRequestPanel.Controls.Add(transactionTypeLabel);
            transactionRequestPanel.Controls.Add(amountValue);
            transactionRequestPanel.Controls.Add(receiverAccountIdValue);
            transactionRequestPanel.Controls.Add(receiverFullNameValue);
            transactionRequestPanel.Controls.Add(line2);
            transactionRequestPanel.Controls.Add(receiverLabel);
            transactionRequestPanel.Controls.Add(amountLabel);
            transactionRequestPanel.Controls.Add(transactionDateValue);
            transactionRequestPanel.Controls.Add(senderAccountIdValue);
            transactionRequestPanel.Controls.Add(senderFullNameValue);
            transactionRequestPanel.Controls.Add(transactionDateLabel);
            transactionRequestPanel.Controls.Add(senderLabel);
            transactionRequestPanel.Controls.Add(line1);
            transactionRequestPanel.Controls.Add(transactionRequestPictureBackground);
            transactionRequestPanel.CornerRadius = 10;
            transactionRequestPanel.Location = new Point(3, 3);
            transactionRequestPanel.Name = "transactionRequestPanel";
            transactionRequestPanel.Size = new Size(944, 119);
            transactionRequestPanel.TabIndex = 0;
            // 
            // viewReceipt
            // 
            viewReceipt.ActiveLinkColor = Color.FromArgb(124, 205, 124);
            viewReceipt.AutoSize = true;
            viewReceipt.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viewReceipt.LinkColor = Color.FromArgb(50, 125, 50);
            viewReceipt.Location = new Point(817, 87);
            viewReceipt.Name = "viewReceipt";
            viewReceipt.Size = new Size(109, 19);
            viewReceipt.TabIndex = 80;
            viewReceipt.TabStop = true;
            viewReceipt.Text = "View Receipt";
            viewReceipt.VisitedLinkColor = Color.FromArgb(92, 184, 92);
            viewReceipt.LinkClicked += viewReceipt_LinkClicked;
            // 
            // processStatusValue
            // 
            processStatusValue.AutoSize = true;
            processStatusValue.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            processStatusValue.ForeColor = Color.Black;
            processStatusValue.Location = new Point(646, 87);
            processStatusValue.Name = "processStatusValue";
            processStatusValue.Size = new Size(74, 19);
            processStatusValue.TabIndex = 78;
            processStatusValue.Text = "Pending";
            // 
            // transactionStatusLabel
            // 
            transactionStatusLabel.AutoSize = true;
            transactionStatusLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionStatusLabel.ForeColor = Color.Black;
            transactionStatusLabel.Location = new Point(521, 87);
            transactionStatusLabel.Name = "transactionStatusLabel";
            transactionStatusLabel.Size = new Size(56, 19);
            transactionStatusLabel.TabIndex = 77;
            transactionStatusLabel.Text = "Status:";
            // 
            // transactionTypeValue
            // 
            transactionTypeValue.AutoSize = true;
            transactionTypeValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transactionTypeValue.ForeColor = Color.Black;
            transactionTypeValue.Location = new Point(298, 64);
            transactionTypeValue.Name = "transactionTypeValue";
            transactionTypeValue.Size = new Size(86, 21);
            transactionTypeValue.TabIndex = 76;
            transactionTypeValue.Text = "Withdraw";
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionTypeLabel.ForeColor = Color.Black;
            transactionTypeLabel.Location = new Point(154, 64);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(142, 19);
            transactionTypeLabel.TabIndex = 75;
            transactionTypeLabel.Text = "Transaction Type:";
            // 
            // amountValue
            // 
            amountValue.AutoSize = true;
            amountValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountValue.ForeColor = Color.Black;
            amountValue.Location = new Point(646, 63);
            amountValue.Name = "amountValue";
            amountValue.Size = new Size(61, 21);
            amountValue.TabIndex = 74;
            amountValue.Text = "₱ 1000";
            // 
            // receiverAccountIdValue
            // 
            receiverAccountIdValue.AutoSize = true;
            receiverAccountIdValue.BackColor = Color.Transparent;
            receiverAccountIdValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            receiverAccountIdValue.ForeColor = Color.Black;
            receiverAccountIdValue.Location = new Point(646, 34);
            receiverAccountIdValue.Name = "receiverAccountIdValue";
            receiverAccountIdValue.Size = new Size(95, 21);
            receiverAccountIdValue.TabIndex = 73;
            receiverAccountIdValue.Text = "CYAN5081";
            // 
            // receiverFullNameValue
            // 
            receiverFullNameValue.AutoSize = true;
            receiverFullNameValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            receiverFullNameValue.ForeColor = Color.Black;
            receiverFullNameValue.Location = new Point(646, 13);
            receiverFullNameValue.Name = "receiverFullNameValue";
            receiverFullNameValue.Size = new Size(193, 21);
            receiverFullNameValue.TabIndex = 72;
            receiverFullNameValue.Text = "Cyril James De Guzman";
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Controls.Add(panel4);
            line2.Location = new Point(557, 24);
            line2.Name = "line2";
            line2.Size = new Size(105, 1);
            line2.TabIndex = 71;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(105, 1);
            panel4.TabIndex = 62;
            // 
            // receiverLabel
            // 
            receiverLabel.AutoSize = true;
            receiverLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            receiverLabel.ForeColor = Color.Black;
            receiverLabel.Location = new Point(521, 13);
            receiverLabel.Name = "receiverLabel";
            receiverLabel.Size = new Size(30, 19);
            receiverLabel.TabIndex = 70;
            receiverLabel.Text = "To:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.ForeColor = Color.Black;
            amountLabel.Location = new Point(521, 64);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(75, 19);
            amountLabel.TabIndex = 69;
            amountLabel.Text = "Amount:";
            // 
            // transactionDateValue
            // 
            transactionDateValue.AutoSize = true;
            transactionDateValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transactionDateValue.ForeColor = Color.Black;
            transactionDateValue.Location = new Point(298, 87);
            transactionDateValue.Name = "transactionDateValue";
            transactionDateValue.Size = new Size(114, 21);
            transactionDateValue.TabIndex = 68;
            transactionDateValue.Text = "June 23, 2023";
            // 
            // senderAccountIdValue
            // 
            senderAccountIdValue.AutoSize = true;
            senderAccountIdValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            senderAccountIdValue.ForeColor = Color.Black;
            senderAccountIdValue.Location = new Point(298, 34);
            senderAccountIdValue.Name = "senderAccountIdValue";
            senderAccountIdValue.Size = new Size(95, 21);
            senderAccountIdValue.TabIndex = 67;
            senderAccountIdValue.Text = "CYAN5081";
            // 
            // senderFullNameValue
            // 
            senderFullNameValue.AutoSize = true;
            senderFullNameValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            senderFullNameValue.ForeColor = Color.Black;
            senderFullNameValue.Location = new Point(298, 13);
            senderFullNameValue.Name = "senderFullNameValue";
            senderFullNameValue.Size = new Size(193, 21);
            senderFullNameValue.TabIndex = 66;
            senderFullNameValue.Text = "Cyril James De Guzman";
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionDateLabel.ForeColor = Color.Black;
            transactionDateLabel.Location = new Point(154, 87);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new Size(141, 19);
            transactionDateLabel.TabIndex = 65;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // senderLabel
            // 
            senderLabel.AutoSize = true;
            senderLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            senderLabel.ForeColor = Color.Black;
            senderLabel.Location = new Point(154, 13);
            senderLabel.Name = "senderLabel";
            senderLabel.Size = new Size(52, 19);
            senderLabel.TabIndex = 64;
            senderLabel.Text = "From:";
            // 
            // line1
            // 
            line1.BackColor = Color.Gainsboro;
            line1.Controls.Add(panel2);
            line1.Location = new Point(209, 24);
            line1.Name = "line1";
            line1.Size = new Size(105, 1);
            line1.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 1);
            panel2.TabIndex = 62;
            // 
            // transactionRequestPictureBackground
            // 
            transactionRequestPictureBackground.BackColor = Color.FromArgb(92, 184, 92);
            transactionRequestPictureBackground.Controls.Add(transactionHistoryPicture);
            transactionRequestPictureBackground.Location = new Point(-67, -20);
            transactionRequestPictureBackground.Name = "transactionRequestPictureBackground";
            transactionRequestPictureBackground.Size = new Size(200, 240);
            transactionRequestPictureBackground.TabIndex = 79;
            // 
            // transactionHistoryPicture
            // 
            transactionHistoryPicture.BackgroundImage = Properties.Resources.withdraw1;
            transactionHistoryPicture.BackgroundImageLayout = ImageLayout.Stretch;
            transactionHistoryPicture.Location = new Point(82, 31);
            transactionHistoryPicture.Name = "transactionHistoryPicture";
            transactionHistoryPicture.Size = new Size(100, 100);
            transactionHistoryPicture.TabIndex = 8;
            transactionHistoryPicture.TabStop = false;
            // 
            // TransactionHistoryCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(transactionRequestPanel);
            Name = "TransactionHistoryCards";
            Size = new Size(950, 125);
            transactionRequestPanel.ResumeLayout(false);
            transactionRequestPanel.PerformLayout();
            line2.ResumeLayout(false);
            line1.ResumeLayout(false);
            transactionRequestPictureBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transactionHistoryPicture).EndInit();
            ResumeLayout(false);
        }

        private RoundedPanel transactionRequestPanel;
        public PictureBox transactionHistoryPicture;
        private Panel line1;
        public Label senderAccountIdValue;
        public Label senderFullNameValue;
        public Label transactionDateLabel;
        private Label senderLabel;
        public Label amountValue;
        public Label receiverAccountIdValue;
        public Label receiverFullNameValue;
        public Panel line2;
        private Panel panel4;
        public Label receiverLabel;
        private Label amountLabel;
        public Label transactionDateValue;
        private Panel panel2;
        public Label processStatusValue;
        private Label transactionStatusLabel;
        public Label transactionTypeValue;
        private Label transactionTypeLabel;
        private Panel transactionRequestPictureBackground;
        public LinkLabel viewReceipt;
    }
}

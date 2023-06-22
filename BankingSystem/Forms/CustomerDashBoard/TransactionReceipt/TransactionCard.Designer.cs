using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.CustomerDashBoard.TransactionReceipt
{
    partial class TransactionCard
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
            panel1 = new RoundedPanel();
            transactionPicture = new PictureBox();
            date = new Label();
            transactionType = new Label();
            viewReceipt = new LinkLabel();
            transactionTypeLabel = new Label();
            transactionDateLabel = new Label();
            transactionAmountLabel = new Label();
            amount = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderColor = Color.White;
            panel1.Controls.Add(transactionPicture);
            panel1.Controls.Add(date);
            panel1.Controls.Add(transactionType);
            panel1.Controls.Add(viewReceipt);
            panel1.Controls.Add(transactionTypeLabel);
            panel1.Controls.Add(transactionDateLabel);
            panel1.Controls.Add(transactionAmountLabel);
            panel1.Controls.Add(amount);
            panel1.CornerRadius = 5;
            panel1.Location = new Point(18, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 77);
            panel1.TabIndex = 0;
            // 
            // transactionPicture
            // 
            transactionPicture.BackgroundImage = Properties.Resources.withdraw;
            transactionPicture.BackgroundImageLayout = ImageLayout.Stretch;
            transactionPicture.Location = new Point(25, 14);
            transactionPicture.Name = "transactionPicture";
            transactionPicture.Size = new Size(50, 50);
            transactionPicture.TabIndex = 7;
            transactionPicture.TabStop = false;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(150, 40);
            date.Name = "date";
            date.Size = new Size(108, 21);
            date.TabIndex = 6;
            date.Text = "2023 - 06 - 13";
            date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // transactionType
            // 
            transactionType.AutoSize = true;
            transactionType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transactionType.Location = new Point(370, 40);
            transactionType.Name = "transactionType";
            transactionType.Size = new Size(86, 21);
            transactionType.TabIndex = 5;
            transactionType.Text = "Withdraw";
            transactionType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewReceipt
            // 
            viewReceipt.ActiveLinkColor = Color.FromArgb(124, 205, 124);
            viewReceipt.AutoSize = true;
            viewReceipt.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viewReceipt.LinkColor = Color.FromArgb(50, 125, 50);
            viewReceipt.Location = new Point(720, 30);
            viewReceipt.Name = "viewReceipt";
            viewReceipt.Size = new Size(109, 19);
            viewReceipt.TabIndex = 3;
            viewReceipt.TabStop = true;
            viewReceipt.Text = "View Receipt";
            viewReceipt.VisitedLinkColor = Color.FromArgb(92, 184, 92);
            viewReceipt.LinkClicked += viewReceipt_LinkClicked;
            // 
            // transactionTypeLabel
            // 
            transactionTypeLabel.AutoSize = true;
            transactionTypeLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionTypeLabel.Location = new Point(335, 20);
            transactionTypeLabel.Name = "transactionTypeLabel";
            transactionTypeLabel.Size = new Size(156, 19);
            transactionTypeLabel.TabIndex = 2;
            transactionTypeLabel.Text = "Type of Transaction";
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionDateLabel.Location = new Point(178, 20);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new Size(45, 19);
            transactionDateLabel.TabIndex = 1;
            transactionDateLabel.Text = "Date";
            // 
            // transactionAmountLabel
            // 
            transactionAmountLabel.AutoSize = true;
            transactionAmountLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionAmountLabel.Location = new Point(572, 20);
            transactionAmountLabel.Name = "transactionAmountLabel";
            transactionAmountLabel.Size = new Size(71, 19);
            transactionAmountLabel.TabIndex = 0;
            transactionAmountLabel.Text = "Amount";
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amount.Location = new Point(576, 40);
            amount.Name = "amount";
            amount.Size = new Size(61, 21);
            amount.TabIndex = 4;
            amount.Text = "₱ 1000";
            amount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TransactionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TransactionCard";
            Size = new Size(900, 83);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionPicture).EndInit();
            ResumeLayout(false);
        }

        private RoundedPanel panel1;
        private Label transactionTypeLabel;
        private Label transactionDateLabel;
        private Label transactionAmountLabel;
        private LinkLabel viewReceipt;
        public Label transactionType;
        public Label amount;
        public Label date;
        public PictureBox transactionPicture;
    }
}

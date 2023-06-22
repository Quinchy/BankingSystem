namespace BankingSystem.Forms.CustomerDashBoard
{
    partial class TransactionHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistoryForm));
            transactionHistoryLabel = new Label();
            transactionHistoryFlowPanel = new FlowLayoutPanel();
            nextButton = new Button();
            previousButton = new Button();
            pageCountLabel = new Label();
            SuspendLayout();
            // 
            // transactionHistoryLabel
            // 
            transactionHistoryLabel.AutoSize = true;
            transactionHistoryLabel.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            transactionHistoryLabel.ForeColor = Color.White;
            transactionHistoryLabel.Location = new Point(75, 27);
            transactionHistoryLabel.Name = "transactionHistoryLabel";
            transactionHistoryLabel.Size = new Size(351, 44);
            transactionHistoryLabel.TabIndex = 27;
            transactionHistoryLabel.Text = "Transaction History";
            // 
            // transactionHistoryFlowPanel
            // 
            transactionHistoryFlowPanel.FlowDirection = FlowDirection.TopDown;
            transactionHistoryFlowPanel.Location = new Point(65, 90);
            transactionHistoryFlowPanel.Name = "transactionHistoryFlowPanel";
            transactionHistoryFlowPanel.Size = new Size(928, 537);
            transactionHistoryFlowPanel.TabIndex = 28;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Transparent;
            nextButton.BackgroundImage = (Image)resources.GetObject("nextButton.BackgroundImage");
            nextButton.BackgroundImageLayout = ImageLayout.Stretch;
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            nextButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Location = new Point(916, 652);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(35, 35);
            nextButton.TabIndex = 29;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.BackColor = Color.Transparent;
            previousButton.BackgroundImage = (Image)resources.GetObject("previousButton.BackgroundImage");
            previousButton.BackgroundImageLayout = ImageLayout.Stretch;
            previousButton.Cursor = Cursors.Hand;
            previousButton.FlatAppearance.BorderSize = 0;
            previousButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            previousButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Location = new Point(875, 652);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(35, 35);
            previousButton.TabIndex = 30;
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // pageCountLabel
            // 
            pageCountLabel.AutoSize = true;
            pageCountLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            pageCountLabel.ForeColor = Color.White;
            pageCountLabel.Location = new Point(740, 659);
            pageCountLabel.Name = "pageCountLabel";
            pageCountLabel.Size = new Size(114, 22);
            pageCountLabel.TabIndex = 31;
            pageCountLabel.Text = "Page 1 of 1";
            // 
            // TransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(pageCountLabel);
            Controls.Add(previousButton);
            Controls.Add(transactionHistoryFlowPanel);
            Controls.Add(nextButton);
            Controls.Add(transactionHistoryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionHistoryForm";
            Text = "TransactionHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label transactionHistoryLabel;
        private FlowLayoutPanel transactionHistoryFlowPanel;
        private Button nextButton;
        private Button previousButton;
        private Label pageCountLabel;
    }
}
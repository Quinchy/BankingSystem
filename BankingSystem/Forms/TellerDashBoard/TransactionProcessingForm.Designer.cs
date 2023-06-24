using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.TellerDashBoard
{
    partial class TransactionProcessingForm
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
            profileUpdateCardPanel = new RoundedPanel();
            transactionProcessingPanel = new RoundedPanel();
            transactionProcessingLabel = new Label();
            pageCountLabel = new Label();
            previousButton = new Button();
            nextButton = new Button();
            transactionFlowPanel = new FlowLayoutPanel();
            line1 = new Panel();
            transactionHistoryButton = new Button();
            transactionRequestButton = new Button();
            profileUpdateCardPanel.SuspendLayout();
            transactionProcessingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // profileUpdateCardPanel
            // 
            profileUpdateCardPanel.BackColor = Color.Transparent;
            profileUpdateCardPanel.BorderColor = Color.WhiteSmoke;
            profileUpdateCardPanel.Controls.Add(transactionProcessingPanel);
            profileUpdateCardPanel.Controls.Add(pageCountLabel);
            profileUpdateCardPanel.Controls.Add(previousButton);
            profileUpdateCardPanel.Controls.Add(nextButton);
            profileUpdateCardPanel.Controls.Add(transactionFlowPanel);
            profileUpdateCardPanel.Controls.Add(line1);
            profileUpdateCardPanel.Controls.Add(transactionHistoryButton);
            profileUpdateCardPanel.Controls.Add(transactionRequestButton);
            profileUpdateCardPanel.CornerRadius = 5;
            profileUpdateCardPanel.ForeColor = Color.Transparent;
            profileUpdateCardPanel.Location = new Point(30, 12);
            profileUpdateCardPanel.Name = "profileUpdateCardPanel";
            profileUpdateCardPanel.Size = new Size(979, 699);
            profileUpdateCardPanel.TabIndex = 60;
            // 
            // transactionProcessingPanel
            // 
            transactionProcessingPanel.BackColor = Color.Transparent;
            transactionProcessingPanel.BorderColor = Color.FromArgb(92, 184, 92);
            transactionProcessingPanel.Controls.Add(transactionProcessingLabel);
            transactionProcessingPanel.CornerRadius = 5;
            transactionProcessingPanel.ForeColor = Color.Transparent;
            transactionProcessingPanel.Location = new Point(17, 10);
            transactionProcessingPanel.Name = "transactionProcessingPanel";
            transactionProcessingPanel.Size = new Size(943, 45);
            transactionProcessingPanel.TabIndex = 62;
            // 
            // transactionProcessingLabel
            // 
            transactionProcessingLabel.AutoSize = true;
            transactionProcessingLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            transactionProcessingLabel.ForeColor = Color.White;
            transactionProcessingLabel.Location = new Point(24, 10);
            transactionProcessingLabel.Name = "transactionProcessingLabel";
            transactionProcessingLabel.Size = new Size(242, 25);
            transactionProcessingLabel.TabIndex = 37;
            transactionProcessingLabel.Text = "Transaction Processing";
            // 
            // pageCountLabel
            // 
            pageCountLabel.AutoSize = true;
            pageCountLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            pageCountLabel.ForeColor = Color.Black;
            pageCountLabel.Location = new Point(750, 655);
            pageCountLabel.Name = "pageCountLabel";
            pageCountLabel.Size = new Size(114, 22);
            pageCountLabel.TabIndex = 64;
            pageCountLabel.Text = "Page 1 of 1";
            // 
            // previousButton
            // 
            previousButton.BackColor = Color.Transparent;
            previousButton.BackgroundImage = Properties.Resources.left;
            previousButton.BackgroundImageLayout = ImageLayout.Stretch;
            previousButton.Cursor = Cursors.Hand;
            previousButton.FlatAppearance.BorderSize = 0;
            previousButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            previousButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Location = new Point(885, 648);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(35, 35);
            previousButton.TabIndex = 63;
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Transparent;
            nextButton.BackgroundImage = Properties.Resources.right;
            nextButton.BackgroundImageLayout = ImageLayout.Stretch;
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            nextButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Location = new Point(926, 648);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(35, 35);
            nextButton.TabIndex = 62;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // transactionFlowPanel
            // 
            transactionFlowPanel.Location = new Point(8, 105);
            transactionFlowPanel.Name = "transactionFlowPanel";
            transactionFlowPanel.Size = new Size(965, 537);
            transactionFlowPanel.TabIndex = 61;
            // 
            // line1
            // 
            line1.BackColor = Color.Gainsboro;
            line1.Location = new Point(17, 98);
            line1.Name = "line1";
            line1.Size = new Size(943, 1);
            line1.TabIndex = 60;
            // 
            // transactionHistoryButton
            // 
            transactionHistoryButton.Cursor = Cursors.Hand;
            transactionHistoryButton.FlatAppearance.BorderSize = 0;
            transactionHistoryButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            transactionHistoryButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            transactionHistoryButton.FlatStyle = FlatStyle.Flat;
            transactionHistoryButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionHistoryButton.ForeColor = Color.FromArgb(34, 33, 46);
            transactionHistoryButton.Location = new Point(486, 66);
            transactionHistoryButton.Name = "transactionHistoryButton";
            transactionHistoryButton.Size = new Size(160, 26);
            transactionHistoryButton.TabIndex = 59;
            transactionHistoryButton.Text = "Transaction History";
            transactionHistoryButton.UseVisualStyleBackColor = true;
            transactionHistoryButton.Click += transactionHistoryButton_Click;
            // 
            // transactionRequestButton
            // 
            transactionRequestButton.Cursor = Cursors.Hand;
            transactionRequestButton.FlatAppearance.BorderSize = 0;
            transactionRequestButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            transactionRequestButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            transactionRequestButton.FlatStyle = FlatStyle.Flat;
            transactionRequestButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionRequestButton.ForeColor = Color.FromArgb(92, 184, 92);
            transactionRequestButton.Location = new Point(308, 66);
            transactionRequestButton.Name = "transactionRequestButton";
            transactionRequestButton.Size = new Size(172, 26);
            transactionRequestButton.TabIndex = 58;
            transactionRequestButton.Text = "Transaction Request";
            transactionRequestButton.UseVisualStyleBackColor = true;
            transactionRequestButton.Click += transactionRequestButton_Click;
            // 
            // TransactionProcessingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(profileUpdateCardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionProcessingForm";
            Text = "UserProfileForm";
            profileUpdateCardPanel.ResumeLayout(false);
            profileUpdateCardPanel.PerformLayout();
            transactionProcessingPanel.ResumeLayout(false);
            transactionProcessingPanel.PerformLayout();
            ResumeLayout(false);
        }

        private RoundedPanel profileUpdateCardPanel;
        private RoundedPanel transactionProcessingPanel;
        private Label transactionProcessingLabel;
        private Label pageCountLabel;
        private Button previousButton;
        private Button nextButton;
        private FlowLayoutPanel transactionFlowPanel;
        private Panel line1;
        private Button transactionHistoryButton;
        private Button transactionRequestButton;
    }
}
using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.TellerDashBoard
{
    partial class AccountManagementForm
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
            homeScreenPanel = new Panel();
            profileUpdateCardPanel = new RoundedPanel();
            accountManagementPanel = new RoundedPanel();
            accountManagementLabel = new Label();
            pageCountLabel = new Label();
            previousButton = new Button();
            nextButton = new Button();
            accountFlowPanel = new FlowLayoutPanel();
            line1 = new Panel();
            accountListButton = new Button();
            accountRequestButton = new Button();
            homeScreenPanel.SuspendLayout();
            profileUpdateCardPanel.SuspendLayout();
            accountManagementPanel.SuspendLayout();
            SuspendLayout();
            // 
            // homeScreenPanel
            // 
            homeScreenPanel.AutoScroll = true;
            homeScreenPanel.BackColor = Color.FromArgb(34, 33, 46);
            homeScreenPanel.Controls.Add(profileUpdateCardPanel);
            homeScreenPanel.Location = new Point(0, 0);
            homeScreenPanel.Name = "homeScreenPanel";
            homeScreenPanel.Size = new Size(1039, 723);
            homeScreenPanel.TabIndex = 45;
            // 
            // profileUpdateCardPanel
            // 
            profileUpdateCardPanel.BackColor = Color.Transparent;
            profileUpdateCardPanel.BorderColor = Color.WhiteSmoke;
            profileUpdateCardPanel.Controls.Add(accountManagementPanel);
            profileUpdateCardPanel.Controls.Add(pageCountLabel);
            profileUpdateCardPanel.Controls.Add(previousButton);
            profileUpdateCardPanel.Controls.Add(nextButton);
            profileUpdateCardPanel.Controls.Add(accountFlowPanel);
            profileUpdateCardPanel.Controls.Add(line1);
            profileUpdateCardPanel.Controls.Add(accountListButton);
            profileUpdateCardPanel.Controls.Add(accountRequestButton);
            profileUpdateCardPanel.CornerRadius = 5;
            profileUpdateCardPanel.ForeColor = Color.Transparent;
            profileUpdateCardPanel.Location = new Point(29, 12);
            profileUpdateCardPanel.Name = "profileUpdateCardPanel";
            profileUpdateCardPanel.Size = new Size(979, 699);
            profileUpdateCardPanel.TabIndex = 59;
            // 
            // accountManagementPanel
            // 
            accountManagementPanel.BackColor = Color.Transparent;
            accountManagementPanel.BorderColor = Color.FromArgb(92, 184, 92);
            accountManagementPanel.Controls.Add(accountManagementLabel);
            accountManagementPanel.CornerRadius = 5;
            accountManagementPanel.ForeColor = Color.Transparent;
            accountManagementPanel.Location = new Point(17, 10);
            accountManagementPanel.Name = "accountManagementPanel";
            accountManagementPanel.Size = new Size(943, 45);
            accountManagementPanel.TabIndex = 62;
            // 
            // accountManagementLabel
            // 
            accountManagementLabel.AutoSize = true;
            accountManagementLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            accountManagementLabel.ForeColor = Color.White;
            accountManagementLabel.Location = new Point(24, 10);
            accountManagementLabel.Name = "accountManagementLabel";
            accountManagementLabel.Size = new Size(244, 25);
            accountManagementLabel.TabIndex = 37;
            accountManagementLabel.Text = "Account Management";
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
            // accountFlowPanel
            // 
            accountFlowPanel.Location = new Point(8, 117);
            accountFlowPanel.Name = "accountFlowPanel";
            accountFlowPanel.Size = new Size(965, 526);
            accountFlowPanel.TabIndex = 61;
            // 
            // line1
            // 
            line1.BackColor = Color.Gainsboro;
            line1.Location = new Point(17, 98);
            line1.Name = "line1";
            line1.Size = new Size(943, 1);
            line1.TabIndex = 60;
            // 
            // accountListButton
            // 
            accountListButton.Cursor = Cursors.Hand;
            accountListButton.FlatAppearance.BorderSize = 0;
            accountListButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            accountListButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            accountListButton.FlatStyle = FlatStyle.Flat;
            accountListButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accountListButton.ForeColor = Color.FromArgb(34, 33, 46);
            accountListButton.Location = new Point(486, 66);
            accountListButton.Name = "accountListButton";
            accountListButton.Size = new Size(115, 26);
            accountListButton.TabIndex = 59;
            accountListButton.Text = "Account List";
            accountListButton.UseVisualStyleBackColor = true;
            accountListButton.Click += accountListButton_Click;
            // 
            // accountRequestButton
            // 
            accountRequestButton.Cursor = Cursors.Hand;
            accountRequestButton.FlatAppearance.BorderSize = 0;
            accountRequestButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            accountRequestButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            accountRequestButton.FlatStyle = FlatStyle.Flat;
            accountRequestButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accountRequestButton.ForeColor = Color.FromArgb(92, 184, 92);
            accountRequestButton.Location = new Point(332, 66);
            accountRequestButton.Name = "accountRequestButton";
            accountRequestButton.Size = new Size(148, 26);
            accountRequestButton.TabIndex = 58;
            accountRequestButton.Text = "Account Request";
            accountRequestButton.UseVisualStyleBackColor = true;
            accountRequestButton.Click += accountRequestButton_Click;
            // 
            // AccountManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(homeScreenPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1039, 723);
            Name = "AccountManagementForm";
            Text = "HomeScreenForm";
            homeScreenPanel.ResumeLayout(false);
            profileUpdateCardPanel.ResumeLayout(false);
            profileUpdateCardPanel.PerformLayout();
            accountManagementPanel.ResumeLayout(false);
            accountManagementPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel homeScreenPanel;
        private Button accountRequestButton;
        private RoundedPanel profileUpdateCardPanel;
        private Button accountListButton;
        private Panel line1;
        private FlowLayoutPanel accountFlowPanel;
        private RoundedPanel accountManagementPanel;
        private Label accountManagementLabel;
        private Label pageCountLabel;
        private Button previousButton;
        private Button nextButton;
    }
}
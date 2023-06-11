namespace BankingSystem.Forms.CustomerDashBoard
{
    partial class CustomerUpdateForm
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
            backButton = new Button();
            accountInfoCardPanel = new Utils.Components.RoundedPanel();
            requestButton = new Utils.Components.RoundedButton();
            profilePanel = new Utils.Components.RoundedPanel();
            profileTitleLabel = new Label();
            line2 = new Panel();
            accountInfoCardPanel.SuspendLayout();
            profilePanel.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackgroundImage = Properties.Resources.back_button;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            backButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(20, 21);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 50);
            backButton.TabIndex = 1;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // accountInfoCardPanel
            // 
            accountInfoCardPanel.BackColor = Color.Transparent;
            accountInfoCardPanel.BorderColor = Color.White;
            accountInfoCardPanel.Controls.Add(line2);
            accountInfoCardPanel.Controls.Add(profilePanel);
            accountInfoCardPanel.Controls.Add(requestButton);
            accountInfoCardPanel.Controls.Add(backButton);
            accountInfoCardPanel.CornerRadius = 10;
            accountInfoCardPanel.ForeColor = Color.Transparent;
            accountInfoCardPanel.Location = new Point(64, 47);
            accountInfoCardPanel.Name = "accountInfoCardPanel";
            accountInfoCardPanel.Size = new Size(916, 625);
            accountInfoCardPanel.TabIndex = 37;
            // 
            // requestButton
            // 
            requestButton.BorderColor = Color.Transparent;
            requestButton.ButtonColor = Color.FromArgb(92, 184, 92);
            requestButton.CornerRadius = 10;
            requestButton.Cursor = Cursors.Hand;
            requestButton.FlatAppearance.BorderSize = 0;
            requestButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            requestButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            requestButton.FlatStyle = FlatStyle.Flat;
            requestButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            requestButton.Location = new Point(657, 538);
            requestButton.Name = "requestButton";
            requestButton.OnHoverBorderColor = Color.Transparent;
            requestButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            requestButton.OnHoverTextColor = Color.WhiteSmoke;
            requestButton.Size = new Size(226, 55);
            requestButton.TabIndex = 55;
            requestButton.Text = "UPDATE";
            requestButton.TextColor = Color.WhiteSmoke;
            requestButton.UseVisualStyleBackColor = true;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.Transparent;
            profilePanel.BorderColor = Color.FromArgb(34, 33, 46);
            profilePanel.Controls.Add(profileTitleLabel);
            profilePanel.CornerRadius = 20;
            profilePanel.ForeColor = Color.Transparent;
            profilePanel.Location = new Point(91, 21);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(792, 50);
            profilePanel.TabIndex = 38;
            // 
            // profileTitleLabel
            // 
            profileTitleLabel.AutoSize = true;
            profileTitleLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            profileTitleLabel.ForeColor = Color.White;
            profileTitleLabel.Location = new Point(42, 13);
            profileTitleLabel.Name = "profileTitleLabel";
            profileTitleLabel.Size = new Size(154, 25);
            profileTitleLabel.TabIndex = 37;
            profileTitleLabel.Text = "Profile Update";
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(91, 85);
            line2.Name = "line2";
            line2.Size = new Size(792, 1);
            line2.TabIndex = 56;
            // 
            // CustomerUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(accountInfoCardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerUpdateForm";
            Text = "CustomerUpdateForm";
            accountInfoCardPanel.ResumeLayout(false);
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ResumeLayout(false);
        }

        private Button backButton;
        private Utils.Components.RoundedPanel accountInfoCardPanel;
        private Utils.Components.RoundedButton requestButton;
        private Utils.Components.RoundedPanel profilePanel;
        private Label profileTitleLabel;
        private Panel line2;
    }
}
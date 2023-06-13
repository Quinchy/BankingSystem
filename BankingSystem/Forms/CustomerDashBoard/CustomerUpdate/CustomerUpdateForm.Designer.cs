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
            profileUpdateCardPanel = new Utils.Components.RoundedPanel();
            line1 = new Panel();
            customerUpdatePanel = new Panel();
            passwordUpdateButton = new Button();
            phoneNumberUpdateButton = new Button();
            emailUpdateButton = new Button();
            line2 = new Panel();
            profileUpdatePanel = new Utils.Components.RoundedPanel();
            profileUpdateTitleLabel = new Label();
            profileUpdateCardPanel.SuspendLayout();
            profileUpdatePanel.SuspendLayout();
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
            // profileUpdateCardPanel
            // 
            profileUpdateCardPanel.BackColor = Color.Transparent;
            profileUpdateCardPanel.BorderColor = Color.WhiteSmoke;
            profileUpdateCardPanel.Controls.Add(line1);
            profileUpdateCardPanel.Controls.Add(customerUpdatePanel);
            profileUpdateCardPanel.Controls.Add(passwordUpdateButton);
            profileUpdateCardPanel.Controls.Add(phoneNumberUpdateButton);
            profileUpdateCardPanel.Controls.Add(emailUpdateButton);
            profileUpdateCardPanel.Controls.Add(line2);
            profileUpdateCardPanel.Controls.Add(profileUpdatePanel);
            profileUpdateCardPanel.Controls.Add(backButton);
            profileUpdateCardPanel.CornerRadius = 10;
            profileUpdateCardPanel.ForeColor = Color.Transparent;
            profileUpdateCardPanel.Location = new Point(64, 47);
            profileUpdateCardPanel.Name = "profileUpdateCardPanel";
            profileUpdateCardPanel.Size = new Size(916, 625);
            profileUpdateCardPanel.TabIndex = 37;
            // 
            // line1
            // 
            line1.BackColor = Color.Gainsboro;
            line1.Location = new Point(133, 170);
            line1.Name = "line1";
            line1.Size = new Size(648, 1);
            line1.TabIndex = 57;
            // 
            // customerUpdatePanel
            // 
            customerUpdatePanel.Location = new Point(133, 190);
            customerUpdatePanel.Name = "customerUpdatePanel";
            customerUpdatePanel.Size = new Size(648, 316);
            customerUpdatePanel.TabIndex = 60;
            // 
            // passwordUpdateButton
            // 
            passwordUpdateButton.Cursor = Cursors.Hand;
            passwordUpdateButton.FlatAppearance.BorderSize = 0;
            passwordUpdateButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            passwordUpdateButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            passwordUpdateButton.FlatStyle = FlatStyle.Flat;
            passwordUpdateButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            passwordUpdateButton.Location = new Point(530, 125);
            passwordUpdateButton.Name = "passwordUpdateButton";
            passwordUpdateButton.Size = new Size(124, 44);
            passwordUpdateButton.TabIndex = 59;
            passwordUpdateButton.Text = "Password";
            passwordUpdateButton.UseVisualStyleBackColor = true;
            passwordUpdateButton.Click += passwordUpdateButton_Click;
            // 
            // phoneNumberUpdateButton
            // 
            phoneNumberUpdateButton.Cursor = Cursors.Hand;
            phoneNumberUpdateButton.FlatAppearance.BorderSize = 0;
            phoneNumberUpdateButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            phoneNumberUpdateButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            phoneNumberUpdateButton.FlatStyle = FlatStyle.Flat;
            phoneNumberUpdateButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberUpdateButton.ForeColor = Color.FromArgb(34, 33, 46);
            phoneNumberUpdateButton.Location = new Point(372, 125);
            phoneNumberUpdateButton.Name = "phoneNumberUpdateButton";
            phoneNumberUpdateButton.Size = new Size(139, 44);
            phoneNumberUpdateButton.TabIndex = 58;
            phoneNumberUpdateButton.Text = "Phone Number";
            phoneNumberUpdateButton.UseVisualStyleBackColor = true;
            phoneNumberUpdateButton.Click += phoneNumberUpdateButton_Click;
            // 
            // emailUpdateButton
            // 
            emailUpdateButton.Cursor = Cursors.Hand;
            emailUpdateButton.FlatAppearance.BorderSize = 0;
            emailUpdateButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            emailUpdateButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            emailUpdateButton.FlatStyle = FlatStyle.Flat;
            emailUpdateButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailUpdateButton.ForeColor = Color.FromArgb(92, 184, 92);
            emailUpdateButton.Location = new Point(225, 125);
            emailUpdateButton.Name = "emailUpdateButton";
            emailUpdateButton.Size = new Size(124, 44);
            emailUpdateButton.TabIndex = 57;
            emailUpdateButton.Text = "Email";
            emailUpdateButton.UseVisualStyleBackColor = true;
            emailUpdateButton.Click += emailUpdateButton_Click;
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(91, 85);
            line2.Name = "line2";
            line2.Size = new Size(792, 1);
            line2.TabIndex = 56;
            // 
            // profileUpdatePanel
            // 
            profileUpdatePanel.BackColor = Color.Transparent;
            profileUpdatePanel.BorderColor = Color.FromArgb(92, 184, 92);
            profileUpdatePanel.Controls.Add(profileUpdateTitleLabel);
            profileUpdatePanel.CornerRadius = 20;
            profileUpdatePanel.ForeColor = Color.Transparent;
            profileUpdatePanel.Location = new Point(91, 21);
            profileUpdatePanel.Name = "profileUpdatePanel";
            profileUpdatePanel.Size = new Size(792, 50);
            profileUpdatePanel.TabIndex = 38;
            // 
            // profileUpdateTitleLabel
            // 
            profileUpdateTitleLabel.AutoSize = true;
            profileUpdateTitleLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            profileUpdateTitleLabel.ForeColor = Color.White;
            profileUpdateTitleLabel.Location = new Point(24, 13);
            profileUpdateTitleLabel.Name = "profileUpdateTitleLabel";
            profileUpdateTitleLabel.Size = new Size(154, 25);
            profileUpdateTitleLabel.TabIndex = 37;
            profileUpdateTitleLabel.Text = "Profile Update";
            // 
            // CustomerUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(profileUpdateCardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerUpdateForm";
            Text = "CustomerUpdateForm";
            profileUpdateCardPanel.ResumeLayout(false);
            profileUpdatePanel.ResumeLayout(false);
            profileUpdatePanel.PerformLayout();
            ResumeLayout(false);
        }

        private Button backButton;
        private Utils.Components.RoundedPanel profileUpdateCardPanel;
        private Utils.Components.RoundedPanel profileUpdatePanel;
        private Label profileUpdateTitleLabel;
        private Panel line2;
        private Button emailUpdateButton;
        private Button passwordUpdateButton;
        private Button phoneNumberUpdateButton;
        private Panel line1;
        private static Panel customerUpdatePanel;
    }
}
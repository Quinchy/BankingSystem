using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.TellerDashBoard.AccountCards
{
    partial class AccountListCards
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
            requestPicture = new PictureBox();
            accountRequestCardPanel = new Panel();
            closeButton = new RoundedButton();
            openButton = new RoundedButton();
            balanceValueLabel = new Label();
            balanceLabel = new Label();
            accountIdValueLabel = new Label();
            statusValueLabel = new Label();
            passwordValueLabel = new Label();
            phoneValueLabel = new Label();
            line2 = new Panel();
            emailValueLabel = new Label();
            lastNameValueLabel = new Label();
            firstNameValueLabel = new Label();
            accountIdLabel = new Label();
            statusLabel = new Label();
            line1 = new Panel();
            accountInfoLabel = new Label();
            passwordLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)requestPicture).BeginInit();
            accountRequestCardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // requestPicture
            // 
            requestPicture.BackgroundImage = Properties.Resources.user1;
            requestPicture.BackgroundImageLayout = ImageLayout.Stretch;
            requestPicture.Location = new Point(10, 23);
            requestPicture.Name = "requestPicture";
            requestPicture.Size = new Size(40, 40);
            requestPicture.TabIndex = 8;
            requestPicture.TabStop = false;
            // 
            // accountRequestCardPanel
            // 
            accountRequestCardPanel.BackColor = Color.White;
            accountRequestCardPanel.Controls.Add(closeButton);
            accountRequestCardPanel.Controls.Add(openButton);
            accountRequestCardPanel.Controls.Add(balanceValueLabel);
            accountRequestCardPanel.Controls.Add(balanceLabel);
            accountRequestCardPanel.Controls.Add(accountIdValueLabel);
            accountRequestCardPanel.Controls.Add(statusValueLabel);
            accountRequestCardPanel.Controls.Add(passwordValueLabel);
            accountRequestCardPanel.Controls.Add(phoneValueLabel);
            accountRequestCardPanel.Controls.Add(line2);
            accountRequestCardPanel.Controls.Add(emailValueLabel);
            accountRequestCardPanel.Controls.Add(lastNameValueLabel);
            accountRequestCardPanel.Controls.Add(firstNameValueLabel);
            accountRequestCardPanel.Controls.Add(accountIdLabel);
            accountRequestCardPanel.Controls.Add(statusLabel);
            accountRequestCardPanel.Controls.Add(line1);
            accountRequestCardPanel.Controls.Add(accountInfoLabel);
            accountRequestCardPanel.Controls.Add(passwordLabel);
            accountRequestCardPanel.Controls.Add(phoneLabel);
            accountRequestCardPanel.Controls.Add(emailLabel);
            accountRequestCardPanel.Controls.Add(lastNameLabel);
            accountRequestCardPanel.Controls.Add(firstNameLabel);
            accountRequestCardPanel.Controls.Add(requestPicture);
            accountRequestCardPanel.Location = new Point(3, 3);
            accountRequestCardPanel.Name = "accountRequestCardPanel";
            accountRequestCardPanel.Size = new Size(308, 244);
            accountRequestCardPanel.TabIndex = 9;
            // 
            // closeButton
            // 
            closeButton.BorderColor = Color.Transparent;
            closeButton.ButtonColor = Color.FromArgb(171, 64, 64);
            closeButton.CornerRadius = 5;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(225, 215);
            closeButton.Name = "closeButton";
            closeButton.OnHoverBorderColor = Color.Transparent;
            closeButton.OnHoverButtonColor = Color.FromArgb(204, 85, 85);
            closeButton.OnHoverTextColor = Color.White;
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 58;
            closeButton.Text = "CLOSE";
            closeButton.TextColor = Color.White;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // openButton
            // 
            openButton.BorderColor = Color.Transparent;
            openButton.ButtonColor = Color.FromArgb(92, 184, 92);
            openButton.CornerRadius = 5;
            openButton.Cursor = Cursors.Hand;
            openButton.FlatAppearance.BorderSize = 0;
            openButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            openButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openButton.Location = new Point(149, 215);
            openButton.Name = "openButton";
            openButton.OnHoverBorderColor = Color.Transparent;
            openButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            openButton.OnHoverTextColor = Color.White;
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 57;
            openButton.Text = "OPEN";
            openButton.TextColor = Color.White;
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // balanceValueLabel
            // 
            balanceValueLabel.AutoSize = true;
            balanceValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            balanceValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            balanceValueLabel.Location = new Point(122, 58);
            balanceValueLabel.Name = "balanceValueLabel";
            balanceValueLabel.Size = new Size(36, 17);
            balanceValueLabel.TabIndex = 56;
            balanceValueLabel.Text = "1000";
            balanceValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            balanceLabel.ForeColor = Color.Black;
            balanceLabel.Location = new Point(56, 58);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(65, 16);
            balanceLabel.TabIndex = 55;
            balanceLabel.Text = "Balance:";
            balanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // accountIdValueLabel
            // 
            accountIdValueLabel.AutoSize = true;
            accountIdValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            accountIdValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            accountIdValueLabel.Location = new Point(139, 37);
            accountIdValueLabel.Name = "accountIdValueLabel";
            accountIdValueLabel.Size = new Size(73, 17);
            accountIdValueLabel.TabIndex = 54;
            accountIdValueLabel.Text = "CYAN5081";
            accountIdValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusValueLabel
            // 
            statusValueLabel.AutoSize = true;
            statusValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            statusValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            statusValueLabel.Location = new Point(106, 16);
            statusValueLabel.Name = "statusValueLabel";
            statusValueLabel.Size = new Size(43, 16);
            statusValueLabel.TabIndex = 53;
            statusValueLabel.Text = "Open";
            statusValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordValueLabel
            // 
            passwordValueLabel.AutoSize = true;
            passwordValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            passwordValueLabel.Location = new Point(82, 195);
            passwordValueLabel.Name = "passwordValueLabel";
            passwordValueLabel.Size = new Size(64, 17);
            passwordValueLabel.TabIndex = 50;
            passwordValueLabel.Text = "12345678";
            passwordValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneValueLabel
            // 
            phoneValueLabel.AutoSize = true;
            phoneValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            phoneValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            phoneValueLabel.Location = new Point(117, 174);
            phoneValueLabel.Name = "phoneValueLabel";
            phoneValueLabel.Size = new Size(85, 17);
            phoneValueLabel.TabIndex = 49;
            phoneValueLabel.Text = "09959185081";
            phoneValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(225, 92);
            line2.Name = "line2";
            line2.Size = new Size(75, 1);
            line2.TabIndex = 43;
            // 
            // emailValueLabel
            // 
            emailValueLabel.AutoSize = true;
            emailValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            emailValueLabel.Location = new Point(58, 152);
            emailValueLabel.Name = "emailValueLabel";
            emailValueLabel.Size = new Size(222, 17);
            emailValueLabel.TabIndex = 48;
            emailValueLabel.Text = "deguzmancyriljames@gmail.com";
            emailValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastNameValueLabel
            // 
            lastNameValueLabel.AutoSize = true;
            lastNameValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            lastNameValueLabel.Location = new Point(90, 132);
            lastNameValueLabel.Name = "lastNameValueLabel";
            lastNameValueLabel.Size = new Size(85, 17);
            lastNameValueLabel.TabIndex = 47;
            lastNameValueLabel.Text = "De Guzman";
            lastNameValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstNameValueLabel
            // 
            firstNameValueLabel.AutoSize = true;
            firstNameValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            firstNameValueLabel.Location = new Point(90, 111);
            firstNameValueLabel.Name = "firstNameValueLabel";
            firstNameValueLabel.Size = new Size(80, 17);
            firstNameValueLabel.TabIndex = 46;
            firstNameValueLabel.Text = "Cyril James";
            firstNameValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            accountIdLabel.ForeColor = Color.Black;
            accountIdLabel.Location = new Point(56, 37);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new Size(82, 16);
            accountIdLabel.TabIndex = 45;
            accountIdLabel.Text = "Account ID:";
            accountIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.Black;
            statusLabel.Location = new Point(56, 16);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(49, 16);
            statusLabel.TabIndex = 44;
            statusLabel.Text = "Status:";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // line1
            // 
            line1.BackColor = Color.Gainsboro;
            line1.Location = new Point(3, 92);
            line1.Name = "line1";
            line1.Size = new Size(75, 1);
            line1.TabIndex = 42;
            // 
            // accountInfoLabel
            // 
            accountInfoLabel.AutoSize = true;
            accountInfoLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            accountInfoLabel.ForeColor = Color.FromArgb(48, 48, 51);
            accountInfoLabel.Location = new Point(82, 84);
            accountInfoLabel.Name = "accountInfoLabel";
            accountInfoLabel.Size = new Size(142, 17);
            accountInfoLabel.TabIndex = 41;
            accountInfoLabel.Text = "Account Information";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(10, 195);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(71, 16);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.ForeColor = Color.Black;
            phoneLabel.Location = new Point(10, 174);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(106, 16);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Phone Number:";
            phoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.Black;
            emailLabel.Location = new Point(10, 153);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(47, 16);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.Black;
            lastNameLabel.Location = new Point(10, 132);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 16);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.Black;
            firstNameLabel.Location = new Point(10, 111);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(79, 16);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccountListCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(accountRequestCardPanel);
            Name = "AccountListCards";
            Size = new Size(314, 249);
            ((System.ComponentModel.ISupportInitialize)requestPicture).EndInit();
            accountRequestCardPanel.ResumeLayout(false);
            accountRequestCardPanel.PerformLayout();
            ResumeLayout(false);
        }

        public PictureBox requestPicture;
        private Panel accountRequestCardPanel;
        public Label emailLabel;
        public Label lastNameLabel;
        public Label firstNameLabel;
        public Label passwordLabel;
        public Label phoneLabel;
        public Label statusLabel;
        private Panel line1;
        private Label accountInfoLabel;
        public Label accountIdLabel;
        public Label emailValueLabel;
        public Label lastNameValueLabel;
        public Label firstNameValueLabel;
        public Label passwordValueLabel;
        public Label phoneValueLabel;
        private Panel line2;
        public Label accountIdValueLabel;
        public Label statusValueLabel;
        public Label balanceValueLabel;
        public Label balanceLabel;
        private RoundedButton closeButton;
        private RoundedButton openButton;
    }
}

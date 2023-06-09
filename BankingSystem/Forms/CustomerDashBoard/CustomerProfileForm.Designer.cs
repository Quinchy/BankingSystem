using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.CustomerDashBoard
{
    partial class CustomerProfileForm
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
            line1 = new Panel();
            line2 = new Panel();
            profilePanel = new RoundedPanel();
            profileTitleLabel = new Label();
            accountInfoCardPanel = new RoundedPanel();
            copyButton = new Button();
            accountIDPanel = new RoundedBorderPanel();
            accountIDTextBox = new TextBox();
            accountIDLabel = new Label();
            showPasswordCheckbox = new CheckBox();
            passwordPanel = new RoundedBorderPanel();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            phoneNumberPanel = new RoundedBorderPanel();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            emailPanel = new RoundedBorderPanel();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNamePanel = new RoundedBorderPanel();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNamePanel = new RoundedBorderPanel();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            accountInfoLabel = new Label();
            profilePanel.SuspendLayout();
            accountInfoCardPanel.SuspendLayout();
            accountIDPanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            phoneNumberPanel.SuspendLayout();
            emailPanel.SuspendLayout();
            lastNamePanel.SuspendLayout();
            firstNamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // line1
            // 
            line1.BackColor = Color.Gainsboro;
            line1.Location = new Point(21, 25);
            line1.Name = "line1";
            line1.Size = new Size(25, 1);
            line1.TabIndex = 40;
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(190, 25);
            line2.Name = "line2";
            line2.Size = new Size(465, 1);
            line2.TabIndex = 39;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.Transparent;
            profilePanel.BorderColor = Color.WhiteSmoke;
            profilePanel.Controls.Add(profileTitleLabel);
            profilePanel.CornerRadius = 5;
            profilePanel.ForeColor = Color.Transparent;
            profilePanel.Location = new Point(27, 27);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(969, 55);
            profilePanel.TabIndex = 32;
            // 
            // profileTitleLabel
            // 
            profileTitleLabel.AutoSize = true;
            profileTitleLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            profileTitleLabel.ForeColor = Color.FromArgb(48, 48, 51);
            profileTitleLabel.Location = new Point(42, 16);
            profileTitleLabel.Name = "profileTitleLabel";
            profileTitleLabel.Size = new Size(166, 25);
            profileTitleLabel.TabIndex = 37;
            profileTitleLabel.Text = "Account Profile";
            // 
            // accountInfoCardPanel
            // 
            accountInfoCardPanel.BackColor = Color.Transparent;
            accountInfoCardPanel.BorderColor = Color.WhiteSmoke;
            accountInfoCardPanel.Controls.Add(copyButton);
            accountInfoCardPanel.Controls.Add(accountIDPanel);
            accountInfoCardPanel.Controls.Add(accountIDLabel);
            accountInfoCardPanel.Controls.Add(showPasswordCheckbox);
            accountInfoCardPanel.Controls.Add(passwordPanel);
            accountInfoCardPanel.Controls.Add(passwordLabel);
            accountInfoCardPanel.Controls.Add(phoneNumberPanel);
            accountInfoCardPanel.Controls.Add(phoneNumberLabel);
            accountInfoCardPanel.Controls.Add(emailPanel);
            accountInfoCardPanel.Controls.Add(emailLabel);
            accountInfoCardPanel.Controls.Add(lastNamePanel);
            accountInfoCardPanel.Controls.Add(lastNameLabel);
            accountInfoCardPanel.Controls.Add(firstNamePanel);
            accountInfoCardPanel.Controls.Add(firstNameLabel);
            accountInfoCardPanel.Controls.Add(line1);
            accountInfoCardPanel.Controls.Add(line2);
            accountInfoCardPanel.Controls.Add(accountInfoLabel);
            accountInfoCardPanel.CornerRadius = 10;
            accountInfoCardPanel.ForeColor = Color.Transparent;
            accountInfoCardPanel.Location = new Point(27, 109);
            accountInfoCardPanel.Name = "accountInfoCardPanel";
            accountInfoCardPanel.Size = new Size(673, 586);
            accountInfoCardPanel.TabIndex = 36;
            // 
            // copyButton
            // 
            copyButton.BackgroundImage = Properties.Resources.duplicate;
            copyButton.BackgroundImageLayout = ImageLayout.Stretch;
            copyButton.Cursor = Cursors.Hand;
            copyButton.FlatAppearance.BorderSize = 0;
            copyButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            copyButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.Location = new Point(320, 107);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(30, 30);
            copyButton.TabIndex = 38;
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // accountIDPanel
            // 
            accountIDPanel.Controls.Add(accountIDTextBox);
            accountIDPanel.Location = new Point(46, 101);
            accountIDPanel.Name = "accountIDPanel";
            accountIDPanel.Size = new Size(263, 42);
            accountIDPanel.TabIndex = 52;
            // 
            // accountIDTextBox
            // 
            accountIDTextBox.BackColor = Color.WhiteSmoke;
            accountIDTextBox.BorderStyle = BorderStyle.None;
            accountIDTextBox.Enabled = false;
            accountIDTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountIDTextBox.ForeColor = Color.FromArgb(48, 46, 65);
            accountIDTextBox.Location = new Point(16, 11);
            accountIDTextBox.Name = "accountIDTextBox";
            accountIDTextBox.Size = new Size(234, 20);
            accountIDTextBox.TabIndex = 0;
            // 
            // accountIDLabel
            // 
            accountIDLabel.AutoSize = true;
            accountIDLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accountIDLabel.ForeColor = Color.FromArgb(48, 48, 51);
            accountIDLabel.Location = new Point(47, 79);
            accountIDLabel.Name = "accountIDLabel";
            accountIDLabel.Size = new Size(94, 19);
            accountIDLabel.TabIndex = 51;
            accountIDLabel.Text = "Account ID";
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(92, 184, 92);
            showPasswordCheckbox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheckbox.ForeColor = Color.FromArgb(48, 48, 51);
            showPasswordCheckbox.Location = new Point(58, 516);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(124, 21);
            showPasswordCheckbox.TabIndex = 37;
            showPasswordCheckbox.Text = "Show Password?";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            showPasswordCheckbox.CheckedChanged += showPasswordCheckbox_CheckedChanged;
            // 
            // passwordPanel
            // 
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Location = new Point(46, 468);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(263, 42);
            passwordPanel.TabIndex = 50;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Enabled = false;
            passwordTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(48, 46, 65);
            passwordTextBox.Location = new Point(16, 11);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(234, 20);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(48, 48, 51);
            passwordLabel.Location = new Point(46, 446);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 19);
            passwordLabel.TabIndex = 49;
            passwordLabel.Text = "Password";
            // 
            // phoneNumberPanel
            // 
            phoneNumberPanel.Controls.Add(phoneNumberTextBox);
            phoneNumberPanel.Location = new Point(46, 375);
            phoneNumberPanel.Name = "phoneNumberPanel";
            phoneNumberPanel.Size = new Size(263, 42);
            phoneNumberPanel.TabIndex = 48;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.WhiteSmoke;
            phoneNumberTextBox.BorderStyle = BorderStyle.None;
            phoneNumberTextBox.Enabled = false;
            phoneNumberTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberTextBox.ForeColor = Color.FromArgb(48, 46, 65);
            phoneNumberTextBox.Location = new Point(16, 11);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(234, 20);
            phoneNumberTextBox.TabIndex = 0;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = Color.FromArgb(48, 48, 51);
            phoneNumberLabel.Location = new Point(46, 353);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(126, 19);
            phoneNumberLabel.TabIndex = 47;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // emailPanel
            // 
            emailPanel.Controls.Add(emailTextBox);
            emailPanel.Location = new Point(46, 286);
            emailPanel.Name = "emailPanel";
            emailPanel.Size = new Size(263, 42);
            emailPanel.TabIndex = 46;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.WhiteSmoke;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Enabled = false;
            emailTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.ForeColor = Color.FromArgb(48, 46, 65);
            emailTextBox.Location = new Point(16, 11);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(234, 20);
            emailTextBox.TabIndex = 0;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(48, 48, 51);
            emailLabel.Location = new Point(47, 264);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 19);
            emailLabel.TabIndex = 45;
            emailLabel.Text = "Email";
            // 
            // lastNamePanel
            // 
            lastNamePanel.Controls.Add(lastNameTextBox);
            lastNamePanel.Location = new Point(360, 196);
            lastNamePanel.Name = "lastNamePanel";
            lastNamePanel.Size = new Size(263, 42);
            lastNamePanel.TabIndex = 44;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.WhiteSmoke;
            lastNameTextBox.BorderStyle = BorderStyle.None;
            lastNameTextBox.Enabled = false;
            lastNameTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.ForeColor = Color.FromArgb(48, 46, 65);
            lastNameTextBox.Location = new Point(16, 11);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(234, 20);
            lastNameTextBox.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(48, 48, 51);
            lastNameLabel.Location = new Point(360, 174);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(90, 19);
            lastNameLabel.TabIndex = 43;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNamePanel
            // 
            firstNamePanel.Controls.Add(firstNameTextBox);
            firstNamePanel.Location = new Point(46, 196);
            firstNamePanel.Name = "firstNamePanel";
            firstNamePanel.Size = new Size(263, 42);
            firstNamePanel.TabIndex = 42;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.WhiteSmoke;
            firstNameTextBox.BorderStyle = BorderStyle.None;
            firstNameTextBox.Enabled = false;
            firstNameTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.ForeColor = Color.FromArgb(48, 46, 65);
            firstNameTextBox.Location = new Point(16, 11);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(234, 20);
            firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(48, 48, 51);
            firstNameLabel.Location = new Point(46, 174);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(89, 19);
            firstNameLabel.TabIndex = 41;
            firstNameLabel.Text = "First Name";
            // 
            // accountInfoLabel
            // 
            accountInfoLabel.AutoSize = true;
            accountInfoLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            accountInfoLabel.ForeColor = Color.FromArgb(48, 48, 51);
            accountInfoLabel.Location = new Point(47, 17);
            accountInfoLabel.Name = "accountInfoLabel";
            accountInfoLabel.Size = new Size(142, 17);
            accountInfoLabel.TabIndex = 38;
            accountInfoLabel.Text = "Account Information";
            // 
            // CustomerProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(accountInfoCardPanel);
            Controls.Add(profilePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerProfileForm";
            Text = "UserProfileForm";
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            accountInfoCardPanel.ResumeLayout(false);
            accountInfoCardPanel.PerformLayout();
            accountIDPanel.ResumeLayout(false);
            accountIDPanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            phoneNumberPanel.ResumeLayout(false);
            phoneNumberPanel.PerformLayout();
            emailPanel.ResumeLayout(false);
            emailPanel.PerformLayout();
            lastNamePanel.ResumeLayout(false);
            lastNamePanel.PerformLayout();
            firstNamePanel.ResumeLayout(false);
            firstNamePanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel line1;
        private Panel line2;
        private RoundedPanel profilePanel;
        private RoundedPanel accountInfoCardPanel;
        private RoundedBorderPanel firstNamePanel;
        private RoundedBorderPanel lastNamePanel;
        private RoundedBorderPanel emailPanel;
        private RoundedBorderPanel phoneNumberPanel;
        private RoundedBorderPanel passwordPanel;
        private Label profileTitleLabel;
        private Label accountInfoLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Label passwordLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox passwordTextBox;
        private CheckBox showPasswordCheckbox;
        private RoundedBorderPanel accountIDPanel;
        private TextBox accountIDTextBox;
        private Label accountIDLabel;
        private Button copyButton;
    }
}
using BankingSystem.Utils.Components;

namespace BankingSystem.Forms
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
            profilePictureBox = new PictureBox();
            profilePanel = new RoundedPanel();
            editButton = new Button();
            profileTitleLabel = new Label();
            profileCardPanel = new RoundedPanel();
            changePhotoButton = new RoundedButton();
            accountInfoCardPanel = new RoundedPanel();
            roundedButton2 = new RoundedButton();
            roundedButton1 = new RoundedButton();
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
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            profilePanel.SuspendLayout();
            profileCardPanel.SuspendLayout();
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
            line1.Size = new Size(70, 2);
            line1.TabIndex = 40;
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(299, 25);
            line2.Name = "line2";
            line2.Size = new Size(355, 2);
            line2.TabIndex = 39;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackgroundImageLayout = ImageLayout.None;
            profilePictureBox.Image = Properties.Resources.blank;
            profilePictureBox.Location = new Point(12, 15);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(200, 200);
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePictureBox.TabIndex = 33;
            profilePictureBox.TabStop = false;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.Transparent;
            profilePanel.BorderColor = Color.WhiteSmoke;
            profilePanel.Controls.Add(editButton);
            profilePanel.Controls.Add(profileTitleLabel);
            profilePanel.CornerRadius = 5;
            profilePanel.ForeColor = Color.Transparent;
            profilePanel.Location = new Point(27, 27);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(969, 55);
            profilePanel.TabIndex = 32;
            // 
            // editButton
            // 
            editButton.BackgroundImage = Properties.Resources.edit;
            editButton.BackgroundImageLayout = ImageLayout.Stretch;
            editButton.Cursor = Cursors.Hand;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            editButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(918, 11);
            editButton.Name = "editButton";
            editButton.Size = new Size(30, 30);
            editButton.TabIndex = 33;
            editButton.UseVisualStyleBackColor = true;
            // 
            // profileTitleLabel
            // 
            profileTitleLabel.AutoSize = true;
            profileTitleLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            profileTitleLabel.ForeColor = Color.FromArgb(48, 48, 51);
            profileTitleLabel.Location = new Point(13, 16);
            profileTitleLabel.Name = "profileTitleLabel";
            profileTitleLabel.Size = new Size(149, 23);
            profileTitleLabel.TabIndex = 37;
            profileTitleLabel.Text = "Account Profile";
            // 
            // profileCardPanel
            // 
            profileCardPanel.BackColor = Color.Transparent;
            profileCardPanel.BorderColor = Color.WhiteSmoke;
            profileCardPanel.Controls.Add(changePhotoButton);
            profileCardPanel.Controls.Add(profilePictureBox);
            profileCardPanel.CornerRadius = 10;
            profileCardPanel.ForeColor = Color.Transparent;
            profileCardPanel.Location = new Point(40, 106);
            profileCardPanel.Name = "profileCardPanel";
            profileCardPanel.Size = new Size(226, 291);
            profileCardPanel.TabIndex = 35;
            // 
            // changePhotoButton
            // 
            changePhotoButton.BorderColor = Color.Transparent;
            changePhotoButton.ButtonColor = Color.FromArgb(48, 46, 65);
            changePhotoButton.CornerRadius = 5;
            changePhotoButton.Cursor = Cursors.Hand;
            changePhotoButton.FlatAppearance.BorderSize = 0;
            changePhotoButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            changePhotoButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            changePhotoButton.FlatStyle = FlatStyle.Flat;
            changePhotoButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            changePhotoButton.ForeColor = Color.FromArgb(48, 48, 51);
            changePhotoButton.Location = new Point(12, 232);
            changePhotoButton.Name = "changePhotoButton";
            changePhotoButton.OnHoverBorderColor = Color.Transparent;
            changePhotoButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            changePhotoButton.OnHoverTextColor = Color.WhiteSmoke;
            changePhotoButton.Size = new Size(200, 40);
            changePhotoButton.TabIndex = 34;
            changePhotoButton.Text = "CHANGE PHOTO";
            changePhotoButton.TextColor = Color.WhiteSmoke;
            changePhotoButton.UseVisualStyleBackColor = false;
            // 
            // accountInfoCardPanel
            // 
            accountInfoCardPanel.BackColor = Color.Transparent;
            accountInfoCardPanel.BorderColor = Color.WhiteSmoke;
            accountInfoCardPanel.Controls.Add(roundedButton2);
            accountInfoCardPanel.Controls.Add(roundedButton1);
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
            accountInfoCardPanel.Location = new Point(302, 106);
            accountInfoCardPanel.Name = "accountInfoCardPanel";
            accountInfoCardPanel.Size = new Size(673, 586);
            accountInfoCardPanel.TabIndex = 36;
            // 
            // roundedButton2
            // 
            roundedButton2.BorderColor = Color.Transparent;
            roundedButton2.ButtonColor = Color.FromArgb(48, 46, 65);
            roundedButton2.CornerRadius = 5;
            roundedButton2.Cursor = Cursors.Hand;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            roundedButton2.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton2.ForeColor = Color.FromArgb(48, 48, 51);
            roundedButton2.Location = new Point(360, 467);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.OnHoverBorderColor = Color.Transparent;
            roundedButton2.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            roundedButton2.OnHoverTextColor = Color.WhiteSmoke;
            roundedButton2.Size = new Size(128, 40);
            roundedButton2.TabIndex = 53;
            roundedButton2.Text = "CANCEL";
            roundedButton2.TextColor = Color.WhiteSmoke;
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Visible = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.ButtonColor = Color.FromArgb(92, 184, 92);
            roundedButton1.CornerRadius = 5;
            roundedButton1.Cursor = Cursors.Hand;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            roundedButton1.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.FromArgb(48, 48, 51);
            roundedButton1.Location = new Point(494, 467);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.OnHoverBorderColor = Color.Transparent;
            roundedButton1.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            roundedButton1.OnHoverTextColor = Color.WhiteSmoke;
            roundedButton1.Size = new Size(128, 40);
            roundedButton1.TabIndex = 35;
            roundedButton1.Text = "SAVE";
            roundedButton1.TextColor = Color.WhiteSmoke;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Visible = false;
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
            accountIDLabel.Location = new Point(46, 65);
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
            passwordLabel.Location = new Point(46, 432);
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
            phoneNumberLabel.Location = new Point(46, 339);
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
            emailLabel.Location = new Point(46, 250);
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
            lastNameLabel.Location = new Point(360, 160);
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
            firstNameLabel.Location = new Point(46, 160);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(89, 19);
            firstNameLabel.TabIndex = 41;
            firstNameLabel.Text = "First Name";
            // 
            // accountInfoLabel
            // 
            accountInfoLabel.AutoSize = true;
            accountInfoLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            accountInfoLabel.ForeColor = Color.FromArgb(48, 48, 51);
            accountInfoLabel.Location = new Point(97, 15);
            accountInfoLabel.Name = "accountInfoLabel";
            accountInfoLabel.Size = new Size(196, 24);
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
            Controls.Add(profileCardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerProfileForm";
            Text = "UserProfileForm";
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            profileCardPanel.ResumeLayout(false);
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
        private PictureBox profilePictureBox;
        private RoundedPanel profilePanel;
        private RoundedPanel profileCardPanel;
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
        private RoundedButton changePhotoButton;
        private Button editButton;
        private RoundedBorderPanel accountIDPanel;
        private TextBox accountIDTextBox;
        private Label accountIDLabel;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
    }
}
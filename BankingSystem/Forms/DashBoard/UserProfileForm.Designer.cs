namespace BankingSystem.Forms
{
    partial class UserProfileForm
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
            profilePanel = new Utils.Components.RoundedPanel();
            editButton = new Button();
            profileTitleLabel = new Label();
            profilePictureBox = new PictureBox();
            changePhotoButton = new Utils.Components.RoundedButton();
            profileCardPanel = new Utils.Components.RoundedPanel();
            accountInfoCardPanel = new Utils.Components.RoundedPanel();
            passwordPanel = new Utils.Components.RoundedBorderPanel();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            phoneNumberPanel = new Utils.Components.RoundedBorderPanel();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            emailPanel = new Utils.Components.RoundedBorderPanel();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNamePanel = new Utils.Components.RoundedBorderPanel();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNamePanel = new Utils.Components.RoundedBorderPanel();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            panel1 = new Panel();
            line2 = new Panel();
            accountInfoLabel = new Label();
            showPasswordCheckbox = new CheckBox();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            profileCardPanel.SuspendLayout();
            accountInfoCardPanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            phoneNumberPanel.SuspendLayout();
            emailPanel.SuspendLayout();
            lastNamePanel.SuspendLayout();
            firstNamePanel.SuspendLayout();
            SuspendLayout();
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
            profileTitleLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            profileTitleLabel.ForeColor = Color.FromArgb(48, 48, 51);
            profileTitleLabel.Location = new Point(13, 16);
            profileTitleLabel.Name = "profileTitleLabel";
            profileTitleLabel.Size = new Size(152, 24);
            profileTitleLabel.TabIndex = 37;
            profileTitleLabel.Text = "Account Profile";
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
            // changePhotoButton
            // 
            changePhotoButton.BorderColor = Color.Transparent;
            changePhotoButton.ButtonColor = Color.FromArgb(38, 38, 41);
            changePhotoButton.CornerRadius = 5;
            changePhotoButton.Cursor = Cursors.Hand;
            changePhotoButton.FlatAppearance.BorderSize = 0;
            changePhotoButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            changePhotoButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            changePhotoButton.FlatStyle = FlatStyle.Flat;
            changePhotoButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            changePhotoButton.ForeColor = Color.FromArgb(48, 48, 51);
            changePhotoButton.Location = new Point(12, 232);
            changePhotoButton.Name = "changePhotoButton";
            changePhotoButton.OnHoverBorderColor = Color.Transparent;
            changePhotoButton.OnHoverButtonColor = Color.FromArgb(48, 48, 51);
            changePhotoButton.OnHoverTextColor = Color.WhiteSmoke;
            changePhotoButton.Size = new Size(200, 40);
            changePhotoButton.TabIndex = 34;
            changePhotoButton.Text = "Change Photo";
            changePhotoButton.TextColor = Color.WhiteSmoke;
            changePhotoButton.UseVisualStyleBackColor = false;
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
            // accountInfoCardPanel
            // 
            accountInfoCardPanel.BackColor = Color.Transparent;
            accountInfoCardPanel.BorderColor = Color.WhiteSmoke;
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
            accountInfoCardPanel.Controls.Add(panel1);
            accountInfoCardPanel.Controls.Add(line2);
            accountInfoCardPanel.Controls.Add(accountInfoLabel);
            accountInfoCardPanel.CornerRadius = 10;
            accountInfoCardPanel.ForeColor = Color.Transparent;
            accountInfoCardPanel.Location = new Point(302, 106);
            accountInfoCardPanel.Name = "accountInfoCardPanel";
            accountInfoCardPanel.Size = new Size(673, 586);
            accountInfoCardPanel.TabIndex = 36;
            // 
            // passwordPanel
            // 
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Location = new Point(43, 496);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(263, 42);
            passwordPanel.TabIndex = 50;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(16, 11);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(234, 19);
            passwordTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(48, 48, 51);
            passwordLabel.Location = new Point(43, 460);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(78, 20);
            passwordLabel.TabIndex = 49;
            passwordLabel.Text = "Password";
            // 
            // phoneNumberPanel
            // 
            phoneNumberPanel.Controls.Add(phoneNumberTextBox);
            phoneNumberPanel.Location = new Point(43, 367);
            phoneNumberPanel.Name = "phoneNumberPanel";
            phoneNumberPanel.Size = new Size(263, 42);
            phoneNumberPanel.TabIndex = 48;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.WhiteSmoke;
            phoneNumberTextBox.BorderStyle = BorderStyle.None;
            phoneNumberTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberTextBox.Location = new Point(16, 11);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(234, 19);
            phoneNumberTextBox.TabIndex = 0;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = Color.FromArgb(48, 48, 51);
            phoneNumberLabel.Location = new Point(43, 331);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(115, 20);
            phoneNumberLabel.TabIndex = 47;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // emailPanel
            // 
            emailPanel.Controls.Add(emailTextBox);
            emailPanel.Location = new Point(43, 240);
            emailPanel.Name = "emailPanel";
            emailPanel.Size = new Size(263, 42);
            emailPanel.TabIndex = 46;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.WhiteSmoke;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(16, 11);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(234, 19);
            emailTextBox.TabIndex = 0;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(48, 48, 51);
            emailLabel.Location = new Point(43, 204);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 20);
            emailLabel.TabIndex = 45;
            emailLabel.Text = "Email";
            // 
            // lastNamePanel
            // 
            lastNamePanel.Controls.Add(lastNameTextBox);
            lastNamePanel.Location = new Point(357, 116);
            lastNamePanel.Name = "lastNamePanel";
            lastNamePanel.Size = new Size(263, 42);
            lastNamePanel.TabIndex = 44;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.WhiteSmoke;
            lastNameTextBox.BorderStyle = BorderStyle.None;
            lastNameTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(16, 11);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(234, 19);
            lastNameTextBox.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(48, 48, 51);
            lastNameLabel.Location = new Point(357, 80);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(86, 20);
            lastNameLabel.TabIndex = 43;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNamePanel
            // 
            firstNamePanel.Controls.Add(firstNameTextBox);
            firstNamePanel.Location = new Point(43, 116);
            firstNamePanel.Name = "firstNamePanel";
            firstNamePanel.Size = new Size(263, 42);
            firstNamePanel.TabIndex = 42;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.WhiteSmoke;
            firstNameTextBox.BorderStyle = BorderStyle.None;
            firstNameTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(16, 11);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(234, 19);
            firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(48, 48, 51);
            firstNameLabel.Location = new Point(43, 80);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 20);
            firstNameLabel.TabIndex = 41;
            firstNameLabel.Text = "First Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(21, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(70, 2);
            panel1.TabIndex = 40;
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(299, 25);
            line2.Name = "line2";
            line2.Size = new Size(355, 2);
            line2.TabIndex = 39;
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
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(92, 184, 92);
            showPasswordCheckbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheckbox.ForeColor = Color.FromArgb(48, 48, 51);
            showPasswordCheckbox.Location = new Point(55, 544);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(121, 19);
            showPasswordCheckbox.TabIndex = 37;
            showPasswordCheckbox.Text = "Show Password?";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 51);
            ClientSize = new Size(1039, 723);
            Controls.Add(accountInfoCardPanel);
            Controls.Add(profilePanel);
            Controls.Add(profileCardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            profileCardPanel.ResumeLayout(false);
            accountInfoCardPanel.ResumeLayout(false);
            accountInfoCardPanel.PerformLayout();
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

        private Utils.Components.RoundedPanel profilePanel;
        private Label profileTitleLabel;
        private Button editButton;
        private PictureBox profilePictureBox;
        private Utils.Components.RoundedButton changePhotoButton;
        private Utils.Components.RoundedPanel profileCardPanel;
        private Utils.Components.RoundedPanel accountInfoCardPanel;
        private Label accountInfoLabel;
        private Panel panel1;
        private Panel line2;
        private Label firstNameLabel;
        private Utils.Components.RoundedBorderPanel firstNamePanel;
        private TextBox firstNameTextBox;
        private Utils.Components.RoundedBorderPanel lastNamePanel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private Utils.Components.RoundedBorderPanel passwordPanel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Utils.Components.RoundedBorderPanel phoneNumberPanel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private Utils.Components.RoundedBorderPanel emailPanel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private CheckBox showPasswordCheckbox;
    }
}
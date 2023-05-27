namespace BankingSystem.Forms
{
    partial class RegistrationForm
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
            submitButton = new Utils.Components.RoundedButton();
            registrationPanel = new Panel();
            phoneNumberIcon = new Panel();
            lastNameIcon = new Panel();
            firstNameIcon = new Panel();
            confirmPasswordIcon = new Panel();
            passwordIconLabel = new Panel();
            emailIconLabel = new Panel();
            showPasswordCheckbox = new CheckBox();
            line7 = new Panel();
            registrationLabel = new Label();
            registrationDescriptionLabel = new Label();
            line3 = new Panel();
            confirmPasswordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            roundedPanel4 = new Utils.Components.RoundedPanel();
            passwordLabel = new Label();
            line4 = new Panel();
            line2 = new Panel();
            phoneNumberLabel = new Label();
            passwordTextBox = new TextBox();
            roundedPanel3 = new Utils.Components.RoundedPanel();
            phoneNumberTextBox = new TextBox();
            roundedPanel5 = new Utils.Components.RoundedPanel();
            emailLabel = new Label();
            lastNameLabel = new Label();
            line5 = new Panel();
            line6 = new Panel();
            lastNameTextBox = new TextBox();
            roundedPanel1 = new Utils.Components.RoundedPanel();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            line1 = new Panel();
            roundedPanel6 = new Utils.Components.RoundedPanel();
            emailTextBox = new TextBox();
            roundedPanel2 = new Utils.Components.RoundedPanel();
            registerBackgroundLabel = new Panel();
            registrationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.BorderColor = Color.Transparent;
            submitButton.ButtonColor = Color.FromArgb(92, 184, 92);
            submitButton.CornerRadius = 10;
            submitButton.Cursor = Cursors.Hand;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            submitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.Location = new Point(246, 575);
            submitButton.Name = "submitButton";
            submitButton.OnHoverBorderColor = Color.Transparent;
            submitButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            submitButton.OnHoverTextColor = Color.WhiteSmoke;
            submitButton.Size = new Size(149, 65);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.TextColor = Color.WhiteSmoke;
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // registrationPanel
            // 
            registrationPanel.BackColor = Color.FromArgb(48, 48, 51);
            registrationPanel.Controls.Add(phoneNumberIcon);
            registrationPanel.Controls.Add(lastNameIcon);
            registrationPanel.Controls.Add(firstNameIcon);
            registrationPanel.Controls.Add(confirmPasswordIcon);
            registrationPanel.Controls.Add(passwordIconLabel);
            registrationPanel.Controls.Add(emailIconLabel);
            registrationPanel.Controls.Add(showPasswordCheckbox);
            registrationPanel.Controls.Add(line7);
            registrationPanel.Controls.Add(registrationLabel);
            registrationPanel.Controls.Add(registrationDescriptionLabel);
            registrationPanel.Controls.Add(line3);
            registrationPanel.Controls.Add(submitButton);
            registrationPanel.Controls.Add(confirmPasswordLabel);
            registrationPanel.Controls.Add(confirmPasswordTextBox);
            registrationPanel.Controls.Add(roundedPanel4);
            registrationPanel.Controls.Add(passwordLabel);
            registrationPanel.Controls.Add(line4);
            registrationPanel.Controls.Add(line2);
            registrationPanel.Controls.Add(phoneNumberLabel);
            registrationPanel.Controls.Add(passwordTextBox);
            registrationPanel.Controls.Add(roundedPanel3);
            registrationPanel.Controls.Add(phoneNumberTextBox);
            registrationPanel.Controls.Add(roundedPanel5);
            registrationPanel.Controls.Add(emailLabel);
            registrationPanel.Controls.Add(lastNameLabel);
            registrationPanel.Controls.Add(line5);
            registrationPanel.Controls.Add(line6);
            registrationPanel.Controls.Add(lastNameTextBox);
            registrationPanel.Controls.Add(roundedPanel1);
            registrationPanel.Controls.Add(firstNameLabel);
            registrationPanel.Controls.Add(firstNameTextBox);
            registrationPanel.Controls.Add(line1);
            registrationPanel.Controls.Add(roundedPanel6);
            registrationPanel.Controls.Add(emailTextBox);
            registrationPanel.Controls.Add(roundedPanel2);
            registrationPanel.Location = new Point(640, 0);
            registrationPanel.Name = "registrationPanel";
            registrationPanel.Size = new Size(640, 720);
            registrationPanel.TabIndex = 3;
            // 
            // phoneNumberIcon
            // 
            phoneNumberIcon.BackgroundImage = Properties.Resources.telephone;
            phoneNumberIcon.BackgroundImageLayout = ImageLayout.Stretch;
            phoneNumberIcon.Location = new Point(340, 322);
            phoneNumberIcon.Name = "phoneNumberIcon";
            phoneNumberIcon.Size = new Size(20, 20);
            phoneNumberIcon.TabIndex = 36;
            // 
            // lastNameIcon
            // 
            lastNameIcon.BackgroundImage = Properties.Resources.id_card;
            lastNameIcon.BackgroundImageLayout = ImageLayout.Stretch;
            lastNameIcon.Location = new Point(340, 222);
            lastNameIcon.Name = "lastNameIcon";
            lastNameIcon.Size = new Size(20, 20);
            lastNameIcon.TabIndex = 35;
            // 
            // firstNameIcon
            // 
            firstNameIcon.BackgroundImage = Properties.Resources.id_card;
            firstNameIcon.BackgroundImageLayout = ImageLayout.Stretch;
            firstNameIcon.Location = new Point(36, 222);
            firstNameIcon.Name = "firstNameIcon";
            firstNameIcon.Size = new Size(20, 20);
            firstNameIcon.TabIndex = 34;
            // 
            // confirmPasswordIcon
            // 
            confirmPasswordIcon.BackgroundImage = Properties.Resources.locked_computer;
            confirmPasswordIcon.BackgroundImageLayout = ImageLayout.Stretch;
            confirmPasswordIcon.Location = new Point(340, 430);
            confirmPasswordIcon.Name = "confirmPasswordIcon";
            confirmPasswordIcon.Size = new Size(20, 20);
            confirmPasswordIcon.TabIndex = 35;
            // 
            // passwordIconLabel
            // 
            passwordIconLabel.BackgroundImage = Properties.Resources.locked_computer;
            passwordIconLabel.BackgroundImageLayout = ImageLayout.Stretch;
            passwordIconLabel.Location = new Point(36, 430);
            passwordIconLabel.Name = "passwordIconLabel";
            passwordIconLabel.Size = new Size(20, 20);
            passwordIconLabel.TabIndex = 34;
            // 
            // emailIconLabel
            // 
            emailIconLabel.BackgroundImage = Properties.Resources.envelope;
            emailIconLabel.BackgroundImageLayout = ImageLayout.Stretch;
            emailIconLabel.Location = new Point(36, 322);
            emailIconLabel.Name = "emailIconLabel";
            emailIconLabel.Size = new Size(20, 20);
            emailIconLabel.TabIndex = 33;
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(92, 184, 92);
            showPasswordCheckbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheckbox.ForeColor = Color.WhiteSmoke;
            showPasswordCheckbox.Location = new Point(47, 518);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(121, 19);
            showPasswordCheckbox.TabIndex = 32;
            showPasswordCheckbox.Text = "Show Password?";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            // 
            // line7
            // 
            line7.BackColor = Color.WhiteSmoke;
            line7.Location = new Point(25, 130);
            line7.Name = "line7";
            line7.Size = new Size(571, 2);
            line7.TabIndex = 31;
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            registrationLabel.ForeColor = Color.FromArgb(92, 184, 92);
            registrationLabel.Location = new Point(25, 73);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(229, 42);
            registrationLabel.TabIndex = 3;
            registrationLabel.Text = "Registration";
            // 
            // registrationDescriptionLabel
            // 
            registrationDescriptionLabel.AutoSize = true;
            registrationDescriptionLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registrationDescriptionLabel.ForeColor = Color.WhiteSmoke;
            registrationDescriptionLabel.Location = new Point(36, 149);
            registrationDescriptionLabel.Name = "registrationDescriptionLabel";
            registrationDescriptionLabel.Size = new Size(345, 24);
            registrationDescriptionLabel.TabIndex = 4;
            registrationDescriptionLabel.Text = "Please provide your basic details below.";
            // 
            // line3
            // 
            line3.BackColor = Color.Silver;
            line3.Location = new Point(351, 497);
            line3.Name = "line3";
            line3.Size = new Size(245, 2);
            line3.TabIndex = 17;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordLabel.ForeColor = Color.WhiteSmoke;
            confirmPasswordLabel.Location = new Point(366, 430);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(137, 20);
            confirmPasswordLabel.TabIndex = 30;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = Color.WhiteSmoke;
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            confirmPasswordTextBox.Location = new Point(351, 477);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(245, 19);
            confirmPasswordTextBox.TabIndex = 19;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.BorderColor = Color.WhiteSmoke;
            roundedPanel4.CornerRadius = 5;
            roundedPanel4.ForeColor = Color.Transparent;
            roundedPanel4.Location = new Point(340, 469);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(267, 34);
            roundedPanel4.TabIndex = 18;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.WhiteSmoke;
            passwordLabel.Location = new Point(62, 430);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(78, 20);
            passwordLabel.TabIndex = 29;
            passwordLabel.Text = "Password";
            // 
            // line4
            // 
            line4.BackColor = Color.Silver;
            line4.Location = new Point(351, 392);
            line4.Name = "line4";
            line4.Size = new Size(245, 2);
            line4.TabIndex = 20;
            // 
            // line2
            // 
            line2.BackColor = Color.Silver;
            line2.Location = new Point(47, 497);
            line2.Name = "line2";
            line2.Size = new Size(245, 2);
            line2.TabIndex = 14;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = Color.WhiteSmoke;
            phoneNumberLabel.Location = new Point(366, 322);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(115, 20);
            phoneNumberLabel.TabIndex = 28;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            passwordTextBox.Location = new Point(47, 477);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(245, 19);
            passwordTextBox.TabIndex = 16;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.BorderColor = Color.WhiteSmoke;
            roundedPanel3.CornerRadius = 5;
            roundedPanel3.ForeColor = Color.Transparent;
            roundedPanel3.Location = new Point(36, 469);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(267, 34);
            roundedPanel3.TabIndex = 15;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.WhiteSmoke;
            phoneNumberTextBox.BorderStyle = BorderStyle.None;
            phoneNumberTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            phoneNumberTextBox.Location = new Point(351, 372);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(245, 19);
            phoneNumberTextBox.TabIndex = 22;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.BorderColor = Color.WhiteSmoke;
            roundedPanel5.CornerRadius = 5;
            roundedPanel5.ForeColor = Color.Transparent;
            roundedPanel5.Location = new Point(340, 364);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(267, 34);
            roundedPanel5.TabIndex = 21;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.WhiteSmoke;
            emailLabel.Location = new Point(62, 322);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 20);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.WhiteSmoke;
            lastNameLabel.Location = new Point(366, 222);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(86, 20);
            lastNameLabel.TabIndex = 26;
            lastNameLabel.Text = "Last Name";
            // 
            // line5
            // 
            line5.BackColor = Color.Silver;
            line5.Location = new Point(351, 290);
            line5.Name = "line5";
            line5.Size = new Size(245, 2);
            line5.TabIndex = 23;
            // 
            // line6
            // 
            line6.BackColor = Color.Silver;
            line6.Location = new Point(47, 290);
            line6.Name = "line6";
            line6.Size = new Size(245, 2);
            line6.TabIndex = 23;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.WhiteSmoke;
            lastNameTextBox.BorderStyle = BorderStyle.None;
            lastNameTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            lastNameTextBox.Location = new Point(351, 270);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(245, 19);
            lastNameTextBox.TabIndex = 25;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BorderColor = Color.WhiteSmoke;
            roundedPanel1.CornerRadius = 5;
            roundedPanel1.ForeColor = Color.Transparent;
            roundedPanel1.Location = new Point(340, 262);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(267, 34);
            roundedPanel1.TabIndex = 24;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.WhiteSmoke;
            firstNameLabel.Location = new Point(62, 222);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 20);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.WhiteSmoke;
            firstNameTextBox.BorderStyle = BorderStyle.None;
            firstNameTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            firstNameTextBox.Location = new Point(47, 270);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(245, 19);
            firstNameTextBox.TabIndex = 25;
            // 
            // line1
            // 
            line1.BackColor = Color.Silver;
            line1.Location = new Point(47, 392);
            line1.Name = "line1";
            line1.Size = new Size(245, 2);
            line1.TabIndex = 11;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.BorderColor = Color.WhiteSmoke;
            roundedPanel6.CornerRadius = 5;
            roundedPanel6.ForeColor = Color.Transparent;
            roundedPanel6.Location = new Point(36, 262);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(267, 34);
            roundedPanel6.TabIndex = 24;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.WhiteSmoke;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            emailTextBox.Location = new Point(47, 372);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(245, 19);
            emailTextBox.TabIndex = 13;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.BorderColor = Color.WhiteSmoke;
            roundedPanel2.CornerRadius = 5;
            roundedPanel2.ForeColor = Color.Transparent;
            roundedPanel2.Location = new Point(36, 364);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(267, 34);
            roundedPanel2.TabIndex = 12;
            // 
            // registerBackgroundLabel
            // 
            registerBackgroundLabel.Location = new Point(0, 0);
            registerBackgroundLabel.Name = "registerBackgroundLabel";
            registerBackgroundLabel.Size = new Size(640, 720);
            registerBackgroundLabel.TabIndex = 4;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1280, 720);
            Controls.Add(registerBackgroundLabel);
            Controls.Add(registrationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            registrationPanel.ResumeLayout(false);
            registrationPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Utils.Components.RoundedButton submitButton;
        private Panel registrationPanel;
        private Panel registerBackgroundLabel;
        private Label registrationLabel;
        private Label registrationDescriptionLabel;
        private Label firstNameLabel;
        private Panel line1;
        private TextBox emailTextBox;
        private Utils.Components.RoundedPanel roundedPanel2;
        private Panel line2;
        private TextBox passwordTextBox;
        private Utils.Components.RoundedPanel roundedPanel3;
        private Panel line3;
        private TextBox confirmPasswordTextBox;
        private Utils.Components.RoundedPanel roundedPanel4;
        private Panel line4;
        private TextBox phoneNumberTextBox;
        private Utils.Components.RoundedPanel roundedPanel5;
        private Label lastNameLabel;
        private Panel line5;
        private Panel line6;
        private TextBox lastNameTextBox;
        private Utils.Components.RoundedPanel roundedPanel1;
        private TextBox firstNameTextBox;
        private Utils.Components.RoundedPanel roundedPanel6;
        private Label confirmPasswordLabel;
        private Label passwordLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Panel line7;
        private CheckBox showPasswordCheckbox;
        private Panel emailIconLabel;
        private Panel passwordIconLabel;
        private Panel phoneNumberIcon;
        private Panel lastNameIcon;
        private Panel firstNameIcon;
        private Panel confirmPasswordIcon;
    }
}
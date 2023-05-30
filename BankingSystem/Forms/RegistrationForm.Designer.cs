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
            line1 = new Panel();
            line2 = new Panel();
            line3 = new Panel();
            line4 = new Panel();
            line5 = new Panel();
            line6 = new Panel();
            line7 = new Panel();
            registrationPanel = new Panel();
            phoneNumberIcon = new Panel();
            lastNameIcon = new Panel();
            firstNameIcon = new Panel();
            confirmPasswordIcon = new Panel();
            passwordIcon = new Panel();
            emailIcon = new Panel();
            showPasswordCheckbox = new CheckBox();
            registrationLabel = new Label();
            registrationDescriptionLabel = new Label();
            submitButton = new Utils.Components.RoundedButton();
            confirmPasswordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            passwordLabel = new Label();
            phoneNumberLabel = new Label();
            passwordTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            emailLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            firstNameLabel = new Label();
            emailTextBox = new TextBox();
            firstNamePanel = new Utils.Components.RoundedPanel();
            firstNameTextBox = new TextBox();
            registrationBackgroundPanel = new Panel();
            lastNamePanel = new Utils.Components.RoundedPanel();
            textBox1 = new TextBox();
            emailPanel = new Utils.Components.RoundedPanel();
            textBox2 = new TextBox();
            passwordPanel = new Utils.Components.RoundedPanel();
            textBox3 = new TextBox();
            phoneNumberPanel = new Utils.Components.RoundedPanel();
            textBox4 = new TextBox();
            confirmPasswordPanel = new Utils.Components.RoundedPanel();
            textBox5 = new TextBox();
            registrationPanel.SuspendLayout();
            firstNamePanel.SuspendLayout();
            lastNamePanel.SuspendLayout();
            emailPanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            phoneNumberPanel.SuspendLayout();
            confirmPasswordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // line1
            // 
            line1.BackColor = Color.Silver;
            line1.Location = new Point(47, 392);
            line1.Name = "line1";
            line1.Size = new Size(245, 2);
            line1.TabIndex = 11;
            // 
            // line2
            // 
            line2.BackColor = Color.Silver;
            line2.Location = new Point(47, 497);
            line2.Name = "line2";
            line2.Size = new Size(245, 2);
            line2.TabIndex = 14;
            // 
            // line3
            // 
            line3.BackColor = Color.Silver;
            line3.Location = new Point(351, 497);
            line3.Name = "line3";
            line3.Size = new Size(245, 2);
            line3.TabIndex = 17;
            // 
            // line4
            // 
            line4.BackColor = Color.Silver;
            line4.Location = new Point(351, 392);
            line4.Name = "line4";
            line4.Size = new Size(245, 2);
            line4.TabIndex = 20;
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
            // line7
            // 
            line7.BackColor = Color.WhiteSmoke;
            line7.Location = new Point(25, 130);
            line7.Name = "line7";
            line7.Size = new Size(571, 2);
            line7.TabIndex = 31;
            // 
            // registrationPanel
            // 
            registrationPanel.BackColor = Color.FromArgb(48, 48, 51);
            registrationPanel.Controls.Add(phoneNumberIcon);
            registrationPanel.Controls.Add(lastNameIcon);
            registrationPanel.Controls.Add(firstNameIcon);
            registrationPanel.Controls.Add(confirmPasswordIcon);
            registrationPanel.Controls.Add(passwordIcon);
            registrationPanel.Controls.Add(emailIcon);
            registrationPanel.Controls.Add(showPasswordCheckbox);
            registrationPanel.Controls.Add(line7);
            registrationPanel.Controls.Add(registrationLabel);
            registrationPanel.Controls.Add(registrationDescriptionLabel);
            registrationPanel.Controls.Add(line3);
            registrationPanel.Controls.Add(submitButton);
            registrationPanel.Controls.Add(confirmPasswordLabel);
            registrationPanel.Controls.Add(confirmPasswordTextBox);
            registrationPanel.Controls.Add(passwordLabel);
            registrationPanel.Controls.Add(line4);
            registrationPanel.Controls.Add(line2);
            registrationPanel.Controls.Add(phoneNumberLabel);
            registrationPanel.Controls.Add(passwordTextBox);
            registrationPanel.Controls.Add(phoneNumberTextBox);
            registrationPanel.Controls.Add(emailLabel);
            registrationPanel.Controls.Add(lastNameLabel);
            registrationPanel.Controls.Add(line5);
            registrationPanel.Controls.Add(line6);
            registrationPanel.Controls.Add(lastNameTextBox);
            registrationPanel.Controls.Add(firstNameLabel);
            registrationPanel.Controls.Add(line1);
            registrationPanel.Controls.Add(emailTextBox);
            registrationPanel.Controls.Add(firstNamePanel);
            registrationPanel.Controls.Add(lastNamePanel);
            registrationPanel.Controls.Add(emailPanel);
            registrationPanel.Controls.Add(passwordPanel);
            registrationPanel.Controls.Add(phoneNumberPanel);
            registrationPanel.Controls.Add(confirmPasswordPanel);
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
            // passwordIcon
            // 
            passwordIcon.BackgroundImage = Properties.Resources.locked_computer;
            passwordIcon.BackgroundImageLayout = ImageLayout.Stretch;
            passwordIcon.Location = new Point(36, 430);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(20, 20);
            passwordIcon.TabIndex = 34;
            // 
            // emailIcon
            // 
            emailIcon.BackgroundImage = Properties.Resources.envelope;
            emailIcon.BackgroundImageLayout = ImageLayout.Stretch;
            emailIcon.Location = new Point(36, 322);
            emailIcon.Name = "emailIcon";
            emailIcon.Size = new Size(20, 20);
            emailIcon.TabIndex = 33;
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
            // firstNamePanel
            // 
            firstNamePanel.BackColor = Color.Transparent;
            firstNamePanel.BorderColor = Color.WhiteSmoke;
            firstNamePanel.Controls.Add(firstNameTextBox);
            firstNamePanel.CornerRadius = 10;
            firstNamePanel.Location = new Point(36, 263);
            firstNamePanel.Name = "firstNamePanel";
            firstNamePanel.Size = new Size(266, 34);
            firstNamePanel.TabIndex = 37;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.WhiteSmoke;
            firstNameTextBox.BorderStyle = BorderStyle.None;
            firstNameTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            firstNameTextBox.Location = new Point(11, 7);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(245, 19);
            firstNameTextBox.TabIndex = 25;
            // 
            // registrationBackgroundPanel
            // 
            registrationBackgroundPanel.Location = new Point(0, 0);
            registrationBackgroundPanel.Name = "registrationBackgroundPanel";
            registrationBackgroundPanel.Size = new Size(640, 720);
            registrationBackgroundPanel.TabIndex = 4;
            // 
            // lastNamePanel
            // 
            lastNamePanel.BackColor = Color.Transparent;
            lastNamePanel.BorderColor = Color.WhiteSmoke;
            lastNamePanel.Controls.Add(textBox1);
            lastNamePanel.CornerRadius = 10;
            lastNamePanel.Location = new Point(340, 263);
            lastNamePanel.Name = "lastNamePanel";
            lastNamePanel.Size = new Size(266, 34);
            lastNamePanel.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(48, 48, 51);
            textBox1.Location = new Point(11, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 19);
            textBox1.TabIndex = 25;
            // 
            // emailPanel
            // 
            emailPanel.BackColor = Color.Transparent;
            emailPanel.BorderColor = Color.WhiteSmoke;
            emailPanel.Controls.Add(textBox2);
            emailPanel.CornerRadius = 10;
            emailPanel.Location = new Point(36, 365);
            emailPanel.Name = "emailPanel";
            emailPanel.Size = new Size(266, 34);
            emailPanel.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(48, 48, 51);
            textBox2.Location = new Point(11, 7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 19);
            textBox2.TabIndex = 25;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.Transparent;
            passwordPanel.BorderColor = Color.WhiteSmoke;
            passwordPanel.Controls.Add(textBox3);
            passwordPanel.CornerRadius = 10;
            passwordPanel.Location = new Point(36, 470);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(266, 34);
            passwordPanel.TabIndex = 40;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(48, 48, 51);
            textBox3.Location = new Point(11, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 19);
            textBox3.TabIndex = 25;
            // 
            // phoneNumberPanel
            // 
            phoneNumberPanel.BackColor = Color.Transparent;
            phoneNumberPanel.BorderColor = Color.WhiteSmoke;
            phoneNumberPanel.Controls.Add(textBox4);
            phoneNumberPanel.CornerRadius = 10;
            phoneNumberPanel.Location = new Point(340, 365);
            phoneNumberPanel.Name = "phoneNumberPanel";
            phoneNumberPanel.Size = new Size(266, 34);
            phoneNumberPanel.TabIndex = 40;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.FromArgb(48, 48, 51);
            textBox4.Location = new Point(11, 7);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 19);
            textBox4.TabIndex = 25;
            // 
            // confirmPasswordPanel
            // 
            confirmPasswordPanel.BackColor = Color.Transparent;
            confirmPasswordPanel.BorderColor = Color.WhiteSmoke;
            confirmPasswordPanel.Controls.Add(textBox5);
            confirmPasswordPanel.CornerRadius = 10;
            confirmPasswordPanel.Location = new Point(340, 470);
            confirmPasswordPanel.Name = "confirmPasswordPanel";
            confirmPasswordPanel.Size = new Size(266, 34);
            confirmPasswordPanel.TabIndex = 41;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.WhiteSmoke;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.FromArgb(48, 48, 51);
            textBox5.Location = new Point(11, 7);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 19);
            textBox5.TabIndex = 25;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1280, 720);
            Controls.Add(registrationBackgroundPanel);
            Controls.Add(registrationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            registrationPanel.ResumeLayout(false);
            registrationPanel.PerformLayout();
            firstNamePanel.ResumeLayout(false);
            firstNamePanel.PerformLayout();
            lastNamePanel.ResumeLayout(false);
            lastNamePanel.PerformLayout();
            emailPanel.ResumeLayout(false);
            emailPanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            phoneNumberPanel.ResumeLayout(false);
            phoneNumberPanel.PerformLayout();
            confirmPasswordPanel.ResumeLayout(false);
            confirmPasswordPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel line1;
        private Panel line2;
        private Panel line3;
        private Panel line4;
        private Panel line5;
        private Panel line6;
        private Panel line7;
        private Panel registrationPanel;
        private Panel registrationBackgroundPanel;
        private Panel firstNameIcon;
        private Panel lastNameIcon;
        private Panel emailIcon;
        private Panel phoneNumberIcon;
        private Panel passwordIcon;
        private Panel confirmPasswordIcon;
        private Label registrationLabel;
        private Label registrationDescriptionLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Label passwordLabel;
        private Label confirmPasswordLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTextBox;
        private CheckBox showPasswordCheckbox;
        private Utils.Components.RoundedButton submitButton;
        private Utils.Components.RoundedPanel firstNamePanel;
        private Utils.Components.RoundedPanel lastNamePanel;
        private TextBox textBox1;
        private Utils.Components.RoundedPanel emailPanel;
        private TextBox textBox2;
        private Utils.Components.RoundedPanel passwordPanel;
        private TextBox textBox3;
        private Utils.Components.RoundedPanel phoneNumberPanel;
        private TextBox textBox4;
        private Utils.Components.RoundedPanel confirmPasswordPanel;
        private TextBox textBox5;
    }
}
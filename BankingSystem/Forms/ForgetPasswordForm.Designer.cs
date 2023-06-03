namespace BankingSystem.Forms
{
    partial class ForgetPasswordForm
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
            forgetPasswordBackgroundPanel = new Panel();
            backButton = new Button();
            registrationPanel = new Panel();
            forgetPasswordDescriptionLabel2 = new Label();
            line8 = new Panel();
            confirmPasswordIcon = new Panel();
            newPasswordIcon = new Panel();
            emailIcon = new Panel();
            showPasswordCheckbox = new CheckBox();
            line7 = new Panel();
            registrationLabel = new Label();
            forgetPasswordDescriptionLabel = new Label();
            line3 = new Panel();
            resetButton = new Utils.Components.RoundedButton();
            confirmPasswordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            newPasswordLabel = new Label();
            line2 = new Panel();
            passwordTextBox = new TextBox();
            emailLabel = new Label();
            line1 = new Panel();
            emailTextBox = new TextBox();
            emailPanel = new Utils.Components.RoundedPanel();
            textBox2 = new TextBox();
            newPasswordPanel = new Utils.Components.RoundedPanel();
            textBox3 = new TextBox();
            confirmPasswordPanel = new Utils.Components.RoundedPanel();
            textBox5 = new TextBox();
            forgetPasswordBackgroundPanel.SuspendLayout();
            registrationPanel.SuspendLayout();
            emailPanel.SuspendLayout();
            newPasswordPanel.SuspendLayout();
            confirmPasswordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // forgetPasswordBackgroundPanel
            // 
            forgetPasswordBackgroundPanel.BackgroundImage = Properties.Resources.forgetpasswordbackground;
            forgetPasswordBackgroundPanel.BackgroundImageLayout = ImageLayout.Stretch;
            forgetPasswordBackgroundPanel.Controls.Add(backButton);
            forgetPasswordBackgroundPanel.Location = new Point(0, 0);
            forgetPasswordBackgroundPanel.Name = "forgetPasswordBackgroundPanel";
            forgetPasswordBackgroundPanel.Size = new Size(640, 720);
            forgetPasswordBackgroundPanel.TabIndex = 5;
            // 
            // backButton
            // 
            backButton.BackColor = Color.WhiteSmoke;
            backButton.BackgroundImage = Properties.Resources.back_button;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            backButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(20, 20);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 50);
            backButton.TabIndex = 0;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // registrationPanel
            // 
            registrationPanel.BackColor = Color.FromArgb(48, 46, 65);
            registrationPanel.Controls.Add(forgetPasswordDescriptionLabel2);
            registrationPanel.Controls.Add(line8);
            registrationPanel.Controls.Add(confirmPasswordIcon);
            registrationPanel.Controls.Add(newPasswordIcon);
            registrationPanel.Controls.Add(emailIcon);
            registrationPanel.Controls.Add(showPasswordCheckbox);
            registrationPanel.Controls.Add(line7);
            registrationPanel.Controls.Add(registrationLabel);
            registrationPanel.Controls.Add(forgetPasswordDescriptionLabel);
            registrationPanel.Controls.Add(line3);
            registrationPanel.Controls.Add(resetButton);
            registrationPanel.Controls.Add(confirmPasswordLabel);
            registrationPanel.Controls.Add(confirmPasswordTextBox);
            registrationPanel.Controls.Add(newPasswordLabel);
            registrationPanel.Controls.Add(line2);
            registrationPanel.Controls.Add(passwordTextBox);
            registrationPanel.Controls.Add(emailLabel);
            registrationPanel.Controls.Add(line1);
            registrationPanel.Controls.Add(emailTextBox);
            registrationPanel.Controls.Add(emailPanel);
            registrationPanel.Controls.Add(newPasswordPanel);
            registrationPanel.Controls.Add(confirmPasswordPanel);
            registrationPanel.Location = new Point(640, 0);
            registrationPanel.Name = "registrationPanel";
            registrationPanel.Size = new Size(640, 720);
            registrationPanel.TabIndex = 4;
            // 
            // forgetPasswordDescriptionLabel2
            // 
            forgetPasswordDescriptionLabel2.AutoSize = true;
            forgetPasswordDescriptionLabel2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            forgetPasswordDescriptionLabel2.ForeColor = Color.WhiteSmoke;
            forgetPasswordDescriptionLabel2.Location = new Point(44, 362);
            forgetPasswordDescriptionLabel2.Name = "forgetPasswordDescriptionLabel2";
            forgetPasswordDescriptionLabel2.Size = new Size(289, 24);
            forgetPasswordDescriptionLabel2.TabIndex = 42;
            forgetPasswordDescriptionLabel2.Text = "Please enter your new password.";
            // 
            // line8
            // 
            line8.BackColor = Color.WhiteSmoke;
            line8.Location = new Point(33, 336);
            line8.Name = "line8";
            line8.Size = new Size(571, 2);
            line8.TabIndex = 32;
            // 
            // confirmPasswordIcon
            // 
            confirmPasswordIcon.BackgroundImage = Properties.Resources.locked_computer;
            confirmPasswordIcon.BackgroundImageLayout = ImageLayout.Stretch;
            confirmPasswordIcon.Location = new Point(348, 416);
            confirmPasswordIcon.Name = "confirmPasswordIcon";
            confirmPasswordIcon.Size = new Size(20, 20);
            confirmPasswordIcon.TabIndex = 35;
            // 
            // newPasswordIcon
            // 
            newPasswordIcon.BackgroundImage = Properties.Resources.locked_computer;
            newPasswordIcon.BackgroundImageLayout = ImageLayout.Stretch;
            newPasswordIcon.Location = new Point(44, 416);
            newPasswordIcon.Name = "newPasswordIcon";
            newPasswordIcon.Size = new Size(20, 20);
            newPasswordIcon.TabIndex = 34;
            // 
            // emailIcon
            // 
            emailIcon.BackgroundImage = Properties.Resources.envelope;
            emailIcon.BackgroundImageLayout = ImageLayout.Stretch;
            emailIcon.Location = new Point(44, 221);
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
            showPasswordCheckbox.Location = new Point(55, 504);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(121, 19);
            showPasswordCheckbox.TabIndex = 32;
            showPasswordCheckbox.Text = "Show Password?";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            showPasswordCheckbox.CheckedChanged += showPasswordCheckbox_CheckedChanged;
            // 
            // line7
            // 
            line7.BackColor = Color.WhiteSmoke;
            line7.Location = new Point(33, 151);
            line7.Name = "line7";
            line7.Size = new Size(571, 2);
            line7.TabIndex = 31;
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            registrationLabel.ForeColor = Color.FromArgb(92, 184, 92);
            registrationLabel.Location = new Point(33, 94);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(338, 42);
            registrationLabel.TabIndex = 3;
            registrationLabel.Text = "Forget Password?";
            // 
            // forgetPasswordDescriptionLabel
            // 
            forgetPasswordDescriptionLabel.AutoSize = true;
            forgetPasswordDescriptionLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            forgetPasswordDescriptionLabel.ForeColor = Color.WhiteSmoke;
            forgetPasswordDescriptionLabel.Location = new Point(44, 170);
            forgetPasswordDescriptionLabel.Name = "forgetPasswordDescriptionLabel";
            forgetPasswordDescriptionLabel.Size = new Size(465, 24);
            forgetPasswordDescriptionLabel.TabIndex = 4;
            forgetPasswordDescriptionLabel.Text = "Please enter your email and we'll reset your password.";
            // 
            // line3
            // 
            line3.BackColor = Color.Silver;
            line3.Location = new Point(359, 483);
            line3.Name = "line3";
            line3.Size = new Size(245, 2);
            line3.TabIndex = 17;
            // 
            // resetButton
            // 
            resetButton.BorderColor = Color.Transparent;
            resetButton.ButtonColor = Color.FromArgb(92, 184, 92);
            resetButton.CornerRadius = 10;
            resetButton.Cursor = Cursors.Hand;
            resetButton.FlatAppearance.BorderSize = 0;
            resetButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            resetButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            resetButton.Location = new Point(207, 564);
            resetButton.Name = "resetButton";
            resetButton.OnHoverBorderColor = Color.Transparent;
            resetButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            resetButton.OnHoverTextColor = Color.WhiteSmoke;
            resetButton.Size = new Size(226, 55);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset Password";
            resetButton.TextColor = Color.WhiteSmoke;
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordLabel.ForeColor = Color.WhiteSmoke;
            confirmPasswordLabel.Location = new Point(374, 416);
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
            confirmPasswordTextBox.Location = new Point(359, 463);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(245, 19);
            confirmPasswordTextBox.TabIndex = 19;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordLabel.ForeColor = Color.WhiteSmoke;
            newPasswordLabel.Location = new Point(70, 416);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(113, 20);
            newPasswordLabel.TabIndex = 29;
            newPasswordLabel.Text = "New Password";
            // 
            // line2
            // 
            line2.BackColor = Color.Silver;
            line2.Location = new Point(55, 483);
            line2.Name = "line2";
            line2.Size = new Size(245, 2);
            line2.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            passwordTextBox.Location = new Point(55, 463);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(245, 19);
            passwordTextBox.TabIndex = 16;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.WhiteSmoke;
            emailLabel.Location = new Point(70, 221);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 20);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email";
            // 
            // line1
            // 
            line1.BackColor = Color.Silver;
            line1.Location = new Point(55, 291);
            line1.Name = "line1";
            line1.Size = new Size(245, 2);
            line1.TabIndex = 11;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.WhiteSmoke;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            emailTextBox.Location = new Point(55, 271);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(245, 19);
            emailTextBox.TabIndex = 13;
            // 
            // emailPanel
            // 
            emailPanel.BackColor = Color.Transparent;
            emailPanel.BorderColor = Color.WhiteSmoke;
            emailPanel.Controls.Add(textBox2);
            emailPanel.CornerRadius = 10;
            emailPanel.Location = new Point(44, 264);
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
            // newPasswordPanel
            // 
            newPasswordPanel.BackColor = Color.Transparent;
            newPasswordPanel.BorderColor = Color.WhiteSmoke;
            newPasswordPanel.Controls.Add(textBox3);
            newPasswordPanel.CornerRadius = 10;
            newPasswordPanel.Location = new Point(44, 456);
            newPasswordPanel.Name = "newPasswordPanel";
            newPasswordPanel.Size = new Size(266, 34);
            newPasswordPanel.TabIndex = 40;
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
            // confirmPasswordPanel
            // 
            confirmPasswordPanel.BackColor = Color.Transparent;
            confirmPasswordPanel.BorderColor = Color.WhiteSmoke;
            confirmPasswordPanel.Controls.Add(textBox5);
            confirmPasswordPanel.CornerRadius = 10;
            confirmPasswordPanel.Location = new Point(348, 456);
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
            // ForgetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(registrationPanel);
            Controls.Add(forgetPasswordBackgroundPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetPasswordForm";
            Text = "ForgetPasswordForm";
            forgetPasswordBackgroundPanel.ResumeLayout(false);
            registrationPanel.ResumeLayout(false);
            registrationPanel.PerformLayout();
            emailPanel.ResumeLayout(false);
            emailPanel.PerformLayout();
            newPasswordPanel.ResumeLayout(false);
            newPasswordPanel.PerformLayout();
            confirmPasswordPanel.ResumeLayout(false);
            confirmPasswordPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel forgetPasswordBackgroundPanel;
        private Button backButton;
        private Panel registrationPanel;
        private Panel confirmPasswordIcon;
        private Panel newPasswordIcon;
        private Panel emailIcon;
        private CheckBox showPasswordCheckbox;
        private Panel line7;
        private Label registrationLabel;
        private Label forgetPasswordDescriptionLabel;
        private Panel line3;
        private Utils.Components.RoundedButton resetButton;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordTextBox;
        private Label newPasswordLabel;
        private Panel line2;
        private TextBox passwordTextBox;
        private Label emailLabel;
        private Panel line1;
        private TextBox emailTextBox;
        private Utils.Components.RoundedPanel emailPanel;
        private TextBox textBox2;
        private Utils.Components.RoundedPanel newPasswordPanel;
        private TextBox textBox3;
        private Utils.Components.RoundedPanel confirmPasswordPanel;
        private TextBox textBox5;
        private Label forgetPasswordDescriptionLabel2;
        private Panel line8;
    }
}
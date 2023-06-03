using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;
using BankingSystem.Utils.Components;

namespace BankingSystem.Forms
{
    partial class LoginForm
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
            loginButton = new RoundedButton();
            loginFormLeftPanel = new Panel();
            passwordIconLabel = new Panel();
            emailIconLabel = new Panel();
            createAccountLinkLabel = new LinkLabel();
            noAccountLabel = new Label();
            forgetPasswordLinkLabel = new LinkLabel();
            showPasswordCheckbox = new CheckBox();
            loginDescriptionLabel = new Label();
            loginLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            emailLabel = new Label();
            passwordPanel = new RoundedPanel();
            line2 = new Panel();
            emailTextBox = new TextBox();
            emailPanel = new RoundedPanel();
            line1 = new Panel();
            registrationBackgroundPanel = new Panel();
            loginFormLeftPanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            emailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BorderColor = Color.Transparent;
            loginButton.ButtonColor = Color.FromArgb(92, 184, 92);
            loginButton.CornerRadius = 10;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 48, 51);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 51);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.WhiteSmoke;
            loginButton.Location = new Point(229, 482);
            loginButton.Name = "loginButton";
            loginButton.OnHoverBorderColor = Color.Transparent;
            loginButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            loginButton.OnHoverTextColor = Color.WhiteSmoke;
            loginButton.Size = new Size(161, 65);
            loginButton.TabIndex = 0;
            loginButton.Text = "LOGIN";
            loginButton.TextColor = Color.WhiteSmoke;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginFormLeftPanel
            // 
            loginFormLeftPanel.BackColor = Color.FromArgb(48, 46, 65);
            loginFormLeftPanel.Controls.Add(passwordIconLabel);
            loginFormLeftPanel.Controls.Add(emailIconLabel);
            loginFormLeftPanel.Controls.Add(createAccountLinkLabel);
            loginFormLeftPanel.Controls.Add(noAccountLabel);
            loginFormLeftPanel.Controls.Add(forgetPasswordLinkLabel);
            loginFormLeftPanel.Controls.Add(showPasswordCheckbox);
            loginFormLeftPanel.Controls.Add(loginDescriptionLabel);
            loginFormLeftPanel.Controls.Add(loginLabel);
            loginFormLeftPanel.Controls.Add(passwordLabel);
            loginFormLeftPanel.Controls.Add(passwordTextBox);
            loginFormLeftPanel.Controls.Add(emailLabel);
            loginFormLeftPanel.Controls.Add(passwordPanel);
            loginFormLeftPanel.Controls.Add(emailTextBox);
            loginFormLeftPanel.Controls.Add(emailPanel);
            loginFormLeftPanel.Controls.Add(loginButton);
            loginFormLeftPanel.Location = new Point(0, 0);
            loginFormLeftPanel.Name = "loginFormLeftPanel";
            loginFormLeftPanel.Size = new Size(640, 720);
            loginFormLeftPanel.TabIndex = 3;
            // 
            // passwordIconLabel
            // 
            passwordIconLabel.BackgroundImage = Properties.Resources.locked_computer;
            passwordIconLabel.BackgroundImageLayout = ImageLayout.Stretch;
            passwordIconLabel.Location = new Point(121, 337);
            passwordIconLabel.Name = "passwordIconLabel";
            passwordIconLabel.Size = new Size(20, 20);
            passwordIconLabel.TabIndex = 18;
            // 
            // emailIconLabel
            // 
            emailIconLabel.BackgroundImage = Properties.Resources.envelope;
            emailIconLabel.BackgroundImageLayout = ImageLayout.Stretch;
            emailIconLabel.Location = new Point(121, 239);
            emailIconLabel.Name = "emailIconLabel";
            emailIconLabel.Size = new Size(20, 20);
            emailIconLabel.TabIndex = 17;
            // 
            // createAccountLinkLabel
            // 
            createAccountLinkLabel.ActiveLinkColor = Color.FromArgb(124, 205, 124);
            createAccountLinkLabel.AutoSize = true;
            createAccountLinkLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountLinkLabel.LinkColor = Color.FromArgb(92, 184, 92);
            createAccountLinkLabel.Location = new Point(336, 603);
            createAccountLinkLabel.Name = "createAccountLinkLabel";
            createAccountLinkLabel.Size = new Size(103, 16);
            createAccountLinkLabel.TabIndex = 15;
            createAccountLinkLabel.TabStop = true;
            createAccountLinkLabel.Text = "Create Account.";
            createAccountLinkLabel.LinkClicked += createAccountLinkLabel_LinkClicked;
            // 
            // noAccountLabel
            // 
            noAccountLabel.AutoSize = true;
            noAccountLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            noAccountLabel.ForeColor = Color.WhiteSmoke;
            noAccountLabel.Location = new Point(181, 603);
            noAccountLabel.Name = "noAccountLabel";
            noAccountLabel.Size = new Size(152, 17);
            noAccountLabel.TabIndex = 14;
            noAccountLabel.Text = "Don't have an account?";
            // 
            // forgetPasswordLinkLabel
            // 
            forgetPasswordLinkLabel.ActiveLinkColor = Color.FromArgb(124, 205, 124);
            forgetPasswordLinkLabel.AutoSize = true;
            forgetPasswordLinkLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            forgetPasswordLinkLabel.LinkColor = Color.FromArgb(92, 184, 92);
            forgetPasswordLinkLabel.Location = new Point(374, 427);
            forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
            forgetPasswordLinkLabel.Size = new Size(109, 16);
            forgetPasswordLinkLabel.TabIndex = 13;
            forgetPasswordLinkLabel.TabStop = true;
            forgetPasswordLinkLabel.Text = "Forgot Password?";
            forgetPasswordLinkLabel.LinkClicked += forgetPasswordLinkLabel_LinkClicked;
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(92, 184, 92);
            showPasswordCheckbox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheckbox.ForeColor = Color.WhiteSmoke;
            showPasswordCheckbox.Location = new Point(132, 427);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(124, 21);
            showPasswordCheckbox.TabIndex = 12;
            showPasswordCheckbox.Text = "Show Password?";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            showPasswordCheckbox.CheckedChanged += showPasswordCheckbox_CheckedChanged;
            // 
            // loginDescriptionLabel
            // 
            loginDescriptionLabel.AutoSize = true;
            loginDescriptionLabel.BackColor = Color.Transparent;
            loginDescriptionLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginDescriptionLabel.ForeColor = Color.WhiteSmoke;
            loginDescriptionLabel.Location = new Point(119, 145);
            loginDescriptionLabel.Name = "loginDescriptionLabel";
            loginDescriptionLabel.Size = new Size(276, 22);
            loginDescriptionLabel.TabIndex = 10;
            loginDescriptionLabel.Text = "Please login to your account.";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(92, 184, 92);
            loginLabel.Location = new Point(113, 92);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(416, 44);
            loginLabel.TabIndex = 9;
            loginLabel.Text = "Hello! Welcome back.";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.WhiteSmoke;
            passwordLabel.Location = new Point(147, 337);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 19);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(48, 46, 65);
            passwordTextBox.Location = new Point(132, 382);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(355, 19);
            passwordTextBox.TabIndex = 7;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.WhiteSmoke;
            emailLabel.Location = new Point(147, 239);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 19);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.Transparent;
            passwordPanel.BorderColor = Color.WhiteSmoke;
            passwordPanel.Controls.Add(line2);
            passwordPanel.CornerRadius = 5;
            passwordPanel.Location = new Point(121, 369);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(376, 45);
            passwordPanel.TabIndex = 6;
            // 
            // line2
            // 
            line2.BackColor = Color.Silver;
            line2.Location = new Point(11, 38);
            line2.Name = "line2";
            line2.Size = new Size(355, 2);
            line2.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.WhiteSmoke;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.ForeColor = Color.FromArgb(48, 46, 65);
            emailTextBox.Location = new Point(132, 284);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(355, 19);
            emailTextBox.TabIndex = 4;
            // 
            // emailPanel
            // 
            emailPanel.BackColor = Color.Transparent;
            emailPanel.BorderColor = Color.WhiteSmoke;
            emailPanel.Controls.Add(line1);
            emailPanel.CornerRadius = 5;
            emailPanel.ForeColor = Color.Transparent;
            emailPanel.Location = new Point(121, 271);
            emailPanel.Name = "emailPanel";
            emailPanel.Size = new Size(376, 45);
            emailPanel.TabIndex = 0;
            // 
            // line1
            // 
            line1.BackColor = Color.Silver;
            line1.Location = new Point(11, 38);
            line1.Name = "line1";
            line1.Size = new Size(355, 2);
            line1.TabIndex = 1;
            // 
            // registrationBackgroundPanel
            // 
            registrationBackgroundPanel.BackgroundImage = Properties.Resources.OnlyFundsLoginBackground;
            registrationBackgroundPanel.BackgroundImageLayout = ImageLayout.Stretch;
            registrationBackgroundPanel.Location = new Point(640, 0);
            registrationBackgroundPanel.Name = "registrationBackgroundPanel";
            registrationBackgroundPanel.Size = new Size(640, 720);
            registrationBackgroundPanel.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1280, 720);
            Controls.Add(registrationBackgroundPanel);
            Controls.Add(loginFormLeftPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            loginFormLeftPanel.ResumeLayout(false);
            loginFormLeftPanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            emailPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel line1;
        private Panel line2;
        private Panel loginFormLeftPanel;
        private Label loginLabel;
        private Label loginDescriptionLabel;
        private Panel emailIconLabel;
        private Panel passwordIconLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private Label noAccountLabel;
        private RoundedPanel emailPanel;
        private RoundedPanel passwordPanel;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private CheckBox showPasswordCheckbox;
        private LinkLabel forgetPasswordLinkLabel;
        private LinkLabel createAccountLinkLabel;
        private RoundedButton loginButton;
        private Panel registrationBackgroundPanel;
    }
}
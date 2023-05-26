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
            loginFormPanel = new Panel();
            loginFormLeftPanel = new Panel();
            panel1 = new Panel();
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
            textBox1 = new TextBox();
            emailPanel = new RoundedPanel();
            line1 = new Panel();
            loginFormPanel.SuspendLayout();
            loginFormLeftPanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            emailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BorderColor = Color.Transparent;
            loginButton.ButtonColor = Color.FromArgb(92, 184, 92);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 48, 51);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 51);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.WhiteSmoke;
            loginButton.Location = new Point(240, 485);
            loginButton.Name = "loginButton";
            loginButton.OnHoverBorderColor = Color.Transparent;
            loginButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            loginButton.OnHoverTextColor = Color.WhiteSmoke;
            loginButton.Size = new Size(161, 65);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.TextColor = Color.WhiteSmoke;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginFormPanel
            // 
            loginFormPanel.BackColor = Color.FromArgb(92, 184, 92);
            loginFormPanel.BackgroundImage = Properties.Resources.OnlyFundsLoginBackground;
            loginFormPanel.BackgroundImageLayout = ImageLayout.Center;
            loginFormPanel.Controls.Add(loginFormLeftPanel);
            loginFormPanel.Location = new Point(0, 0);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(1280, 720);
            loginFormPanel.TabIndex = 2;
            // 
            // loginFormLeftPanel
            // 
            loginFormLeftPanel.BackColor = Color.FromArgb(48, 48, 51);
            loginFormLeftPanel.Controls.Add(panel1);
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
            loginFormLeftPanel.Controls.Add(textBox1);
            loginFormLeftPanel.Controls.Add(emailPanel);
            loginFormLeftPanel.Controls.Add(loginButton);
            loginFormLeftPanel.Location = new Point(0, 0);
            loginFormLeftPanel.Name = "loginFormLeftPanel";
            loginFormLeftPanel.Size = new Size(640, 720);
            loginFormLeftPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(132, 580);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 1);
            panel1.TabIndex = 16;
            // 
            // createAccountLinkLabel
            // 
            createAccountLinkLabel.ActiveLinkColor = Color.FromArgb(124, 205, 124);
            createAccountLinkLabel.AutoSize = true;
            createAccountLinkLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountLinkLabel.LinkColor = Color.FromArgb(92, 184, 92);
            createAccountLinkLabel.Location = new Point(351, 606);
            createAccountLinkLabel.Name = "createAccountLinkLabel";
            createAccountLinkLabel.Size = new Size(108, 16);
            createAccountLinkLabel.TabIndex = 15;
            createAccountLinkLabel.TabStop = true;
            createAccountLinkLabel.Text = "Create Account.";
            createAccountLinkLabel.LinkClicked += createAccountLinkLabel_LinkClicked;
            // 
            // noAccountLabel
            // 
            noAccountLabel.AutoSize = true;
            noAccountLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            noAccountLabel.ForeColor = Color.WhiteSmoke;
            noAccountLabel.Location = new Point(189, 606);
            noAccountLabel.Name = "noAccountLabel";
            noAccountLabel.Size = new Size(156, 16);
            noAccountLabel.TabIndex = 14;
            noAccountLabel.Text = "Don't have an account?";
            // 
            // forgetPasswordLinkLabel
            // 
            forgetPasswordLinkLabel.ActiveLinkColor = Color.FromArgb(124, 205, 124);
            forgetPasswordLinkLabel.AutoSize = true;
            forgetPasswordLinkLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            forgetPasswordLinkLabel.LinkColor = Color.FromArgb(92, 184, 92);
            forgetPasswordLinkLabel.Location = new Point(400, 430);
            forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
            forgetPasswordLinkLabel.Size = new Size(111, 15);
            forgetPasswordLinkLabel.TabIndex = 13;
            forgetPasswordLinkLabel.TabStop = true;
            forgetPasswordLinkLabel.Text = "Forgot Password?";
            forgetPasswordLinkLabel.LinkClicked += forgetPasswordLinkLabel_LinkClicked;
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(92, 184, 92);
            showPasswordCheckbox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            showPasswordCheckbox.ForeColor = Color.WhiteSmoke;
            showPasswordCheckbox.Location = new Point(132, 430);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(126, 19);
            showPasswordCheckbox.TabIndex = 12;
            showPasswordCheckbox.Text = "Show Password?";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            showPasswordCheckbox.CheckedChanged += showPasswordCheckbox_CheckedChanged;
            // 
            // loginDescriptionLabel
            // 
            loginDescriptionLabel.AutoSize = true;
            loginDescriptionLabel.BackColor = Color.Transparent;
            loginDescriptionLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginDescriptionLabel.ForeColor = Color.WhiteSmoke;
            loginDescriptionLabel.Location = new Point(132, 148);
            loginDescriptionLabel.Name = "loginDescriptionLabel";
            loginDescriptionLabel.Size = new Size(281, 24);
            loginDescriptionLabel.TabIndex = 10;
            loginDescriptionLabel.Text = "Please login to your account.";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(92, 184, 92);
            loginLabel.Location = new Point(122, 93);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(400, 44);
            loginLabel.TabIndex = 9;
            loginLabel.Text = "Hello! Welcome back.";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.WhiteSmoke;
            passwordLabel.Location = new Point(132, 340);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(86, 19);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(48, 48, 51);
            passwordTextBox.Location = new Point(143, 385);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(355, 19);
            passwordTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.WhiteSmoke;
            emailLabel.Location = new Point(132, 240);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 19);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.Transparent;
            passwordPanel.BorderColor = Color.WhiteSmoke;
            passwordPanel.Controls.Add(line2);
            passwordPanel.CornerRadius = 10;
            passwordPanel.Location = new Point(132, 372);
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
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(48, 48, 51);
            textBox1.Location = new Point(143, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 19);
            textBox1.TabIndex = 4;
            // 
            // emailPanel
            // 
            emailPanel.BackColor = Color.Transparent;
            emailPanel.BorderColor = Color.WhiteSmoke;
            emailPanel.Controls.Add(line1);
            emailPanel.CornerRadius = 10;
            emailPanel.ForeColor = Color.Transparent;
            emailPanel.Location = new Point(132, 274);
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1280, 720);
            Controls.Add(loginFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            loginFormPanel.ResumeLayout(false);
            loginFormLeftPanel.ResumeLayout(false);
            loginFormLeftPanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            emailPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private RoundedButton loginButton;
        private Panel loginFormPanel;
        private RoundedPanel emailPanel;
        private Panel loginFormLeftPanel;
        private TextBox textBox1;
        private Panel line1;
        private Label emailLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private RoundedPanel passwordPanel;
        private Panel line2;
        private Label loginLabel;
        private Label loginDescriptionLabel;
        private LinkLabel forgetPasswordLinkLabel;
        private CheckBox showPasswordCheckbox;
        private Panel panel1;
        private LinkLabel createAccountLinkLabel;
        private Label noAccountLabel;
    }
}
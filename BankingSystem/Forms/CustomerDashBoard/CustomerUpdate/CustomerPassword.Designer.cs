using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.CustomerDashBoard.CustomerUpdate
{
    partial class CustomerPasswordForm
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
            requestButton = new RoundedButton();
            passwordPanel = new RoundedBorderPanel();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            passwordCardPanel = new RoundedPanel();
            showPasswordCheckbox = new CheckBox();
            customerPasswordLabel = new Label();
            passwordPanel.SuspendLayout();
            passwordCardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // requestButton
            // 
            requestButton.BackColor = Color.Transparent;
            requestButton.BorderColor = Color.Transparent;
            requestButton.ButtonColor = Color.FromArgb(92, 184, 92);
            requestButton.CornerRadius = 10;
            requestButton.Cursor = Cursors.Hand;
            requestButton.FlatAppearance.BorderSize = 0;
            requestButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            requestButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            requestButton.FlatStyle = FlatStyle.Flat;
            requestButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            requestButton.Location = new Point(189, 234);
            requestButton.Name = "requestButton";
            requestButton.OnHoverBorderColor = Color.Transparent;
            requestButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            requestButton.OnHoverTextColor = Color.WhiteSmoke;
            requestButton.Size = new Size(226, 55);
            requestButton.TabIndex = 56;
            requestButton.Text = "UPDATE";
            requestButton.TextColor = Color.WhiteSmoke;
            requestButton.UseVisualStyleBackColor = false;
            requestButton.Click += requestButton_Click;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.Transparent;
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Location = new Point(171, 115);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(263, 42);
            passwordPanel.TabIndex = 58;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderStyle = BorderStyle.None;
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
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(48, 48, 51);
            passwordLabel.Location = new Point(172, 93);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 19);
            passwordLabel.TabIndex = 57;
            passwordLabel.Text = "Password";
            // 
            // passwordCardPanel
            // 
            passwordCardPanel.BackColor = Color.Transparent;
            passwordCardPanel.BorderColor = Color.White;
            passwordCardPanel.Controls.Add(showPasswordCheckbox);
            passwordCardPanel.Controls.Add(customerPasswordLabel);
            passwordCardPanel.Controls.Add(passwordLabel);
            passwordCardPanel.Controls.Add(requestButton);
            passwordCardPanel.Controls.Add(passwordPanel);
            passwordCardPanel.CornerRadius = 20;
            passwordCardPanel.Location = new Point(12, 12);
            passwordCardPanel.Name = "passwordCardPanel";
            passwordCardPanel.Size = new Size(608, 307);
            passwordCardPanel.TabIndex = 59;
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(92, 184, 92);
            showPasswordCheckbox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheckbox.ForeColor = Color.FromArgb(48, 48, 51);
            showPasswordCheckbox.Location = new Point(176, 160);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(124, 21);
            showPasswordCheckbox.TabIndex = 60;
            showPasswordCheckbox.Text = "Show Password?";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            showPasswordCheckbox.CheckedChanged += showPasswordCheckbox_CheckedChanged;
            // 
            // customerPasswordLabel
            // 
            customerPasswordLabel.AutoSize = true;
            customerPasswordLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customerPasswordLabel.ForeColor = SystemColors.ControlDark;
            customerPasswordLabel.Location = new Point(65, 15);
            customerPasswordLabel.Name = "customerPasswordLabel";
            customerPasswordLabel.Size = new Size(489, 17);
            customerPasswordLabel.TabIndex = 59;
            customerPasswordLabel.Text = "Your updated password will only appear once the Bank has approve your request.";
            // 
            // CustomerPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(632, 331);
            Controls.Add(passwordCardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerPasswordForm";
            Text = "CustomerEmailForm";
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            passwordCardPanel.ResumeLayout(false);
            passwordCardPanel.PerformLayout();
            ResumeLayout(false);
        }

        private RoundedButton requestButton;
        private RoundedBorderPanel passwordPanel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private RoundedPanel passwordCardPanel;
        private Label customerPasswordLabel;
        private CheckBox showPasswordCheckbox;
    }
}
using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.CustomerDashBoard.CustomerUpdate
{
    partial class CustomerEmailForm
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
            emailPanel = new RoundedBorderPanel();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            panel1 = new RoundedPanel();
            label1 = new Label();
            emailPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            // emailPanel
            // 
            emailPanel.BackColor = Color.Transparent;
            emailPanel.Controls.Add(emailTextBox);
            emailPanel.Location = new Point(171, 115);
            emailPanel.Name = "emailPanel";
            emailPanel.Size = new Size(263, 42);
            emailPanel.TabIndex = 58;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.White;
            emailTextBox.BorderStyle = BorderStyle.None;
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
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(48, 48, 51);
            emailLabel.Location = new Point(172, 93);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 19);
            emailLabel.TabIndex = 57;
            emailLabel.Text = "Email";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(requestButton);
            panel1.Controls.Add(emailPanel);
            panel1.CornerRadius = 20;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 307);
            panel1.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(77, 15);
            label1.Name = "label1";
            label1.Size = new Size(466, 17);
            label1.TabIndex = 59;
            label1.Text = "Your updated email will only appear once the Bank has approve your request.";
            // 
            // CustomerEmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(632, 331);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerEmailForm";
            Text = "CustomerEmailForm";
            emailPanel.ResumeLayout(false);
            emailPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private RoundedButton requestButton;
        private RoundedBorderPanel emailPanel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private RoundedPanel panel1;
        private Label label1;
    }
}
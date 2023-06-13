using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.CustomerDashBoard.CustomerUpdate
{
    partial class CustomerPhoneNumberForm
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
            phoneNumberPanel = new RoundedBorderPanel();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            phoneNumberCardPanel = new RoundedPanel();
            label1 = new Label();
            phoneNumberPanel.SuspendLayout();
            phoneNumberCardPanel.SuspendLayout();
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
            // phoneNumberPanel
            // 
            phoneNumberPanel.BackColor = Color.Transparent;
            phoneNumberPanel.Controls.Add(phoneNumberTextBox);
            phoneNumberPanel.Location = new Point(171, 115);
            phoneNumberPanel.Name = "phoneNumberPanel";
            phoneNumberPanel.Size = new Size(263, 42);
            phoneNumberPanel.TabIndex = 58;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.White;
            phoneNumberTextBox.BorderStyle = BorderStyle.None;
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
            phoneNumberLabel.BackColor = Color.Transparent;
            phoneNumberLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = Color.FromArgb(48, 48, 51);
            phoneNumberLabel.Location = new Point(172, 93);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(126, 19);
            phoneNumberLabel.TabIndex = 57;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberCardPanel
            // 
            phoneNumberCardPanel.BackColor = Color.Transparent;
            phoneNumberCardPanel.BorderColor = Color.White;
            phoneNumberCardPanel.Controls.Add(label1);
            phoneNumberCardPanel.Controls.Add(phoneNumberLabel);
            phoneNumberCardPanel.Controls.Add(requestButton);
            phoneNumberCardPanel.Controls.Add(phoneNumberPanel);
            phoneNumberCardPanel.CornerRadius = 20;
            phoneNumberCardPanel.Location = new Point(12, 12);
            phoneNumberCardPanel.Name = "phoneNumberCardPanel";
            phoneNumberCardPanel.Size = new Size(608, 307);
            phoneNumberCardPanel.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(519, 17);
            label1.TabIndex = 59;
            label1.Text = "Your updated phone number will only appear once the Bank has approve your request.";
            // 
            // CustomerPhoneNumberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(632, 331);
            Controls.Add(phoneNumberCardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerPhoneNumberForm";
            Text = "CustomerEmailForm";
            phoneNumberPanel.ResumeLayout(false);
            phoneNumberPanel.PerformLayout();
            phoneNumberCardPanel.ResumeLayout(false);
            phoneNumberCardPanel.PerformLayout();
            ResumeLayout(false);
        }

        private RoundedButton requestButton;
        private RoundedBorderPanel phoneNumberPanel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private RoundedPanel phoneNumberCardPanel;
        private Label label1;
    }
}
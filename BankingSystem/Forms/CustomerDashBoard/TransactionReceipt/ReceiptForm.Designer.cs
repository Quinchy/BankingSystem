using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.CustomerDashBoard.TransactionReceipt
{
    partial class ReceiptForm
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
            receiptPanel = new Panel();
            exitButton = new Button();
            saveButton = new RoundedButton();
            SuspendLayout();
            // 
            // receiptPanel
            // 
            receiptPanel.BackColor = Color.White;
            receiptPanel.Location = new Point(36, 75);
            receiptPanel.Name = "receiptPanel";
            receiptPanel.Size = new Size(326, 468);
            receiptPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackgroundImage = Properties.Resources.cancel;
            exitButton.BackgroundImageLayout = ImageLayout.Stretch;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(338, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(50, 50);
            exitButton.TabIndex = 1;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveButton
            // 
            saveButton.BorderColor = Color.Transparent;
            saveButton.ButtonColor = Color.FromArgb(92, 184, 92);
            saveButton.CornerRadius = 5;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 46, 65);
            saveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 46, 65);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = Color.WhiteSmoke;
            saveButton.Location = new Point(93, 570);
            saveButton.Name = "saveButton";
            saveButton.OnHoverBorderColor = Color.Transparent;
            saveButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            saveButton.OnHoverTextColor = Color.WhiteSmoke;
            saveButton.Size = new Size(215, 40);
            saveButton.TabIndex = 2;
            saveButton.Text = "SAVE";
            saveButton.TextColor = Color.WhiteSmoke;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 46, 65);
            ClientSize = new Size(400, 630);
            Controls.Add(saveButton);
            Controls.Add(exitButton);
            Controls.Add(receiptPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceiptForm";
            Text = "Receipt";
            ResumeLayout(false);
        }

        public Panel receiptPanel;
        private Button exitButton;
        private RoundedButton saveButton;
    }
}
using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.TellerDashBoard
{
    partial class DashboardForm
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
            appLogoIcon = new Panel();
            dashboardPanel = new Panel();
            accountScreenButton = new RoundedButton();
            transactionScreenButton = new RoundedButton();
            logoutButton = new RoundedButton();
            label1 = new Label();
            informationUpdateButton = new RoundedButton();
            SuspendLayout();
            // 
            // line1
            // 
            line1.BackColor = Color.FromArgb(65, 64, 89);
            line1.Location = new Point(12, 85);
            line1.Name = "line1";
            line1.Size = new Size(215, 1);
            line1.TabIndex = 5;
            // 
            // line2
            // 
            line2.BackColor = Color.FromArgb(65, 64, 89);
            line2.Location = new Point(12, 625);
            line2.Name = "line2";
            line2.Size = new Size(215, 1);
            line2.TabIndex = 6;
            // 
            // appLogoIcon
            // 
            appLogoIcon.BackColor = Color.Transparent;
            appLogoIcon.BackgroundImage = Properties.Resources.OnlyFundsLogoDashboard;
            appLogoIcon.Location = new Point(19, 12);
            appLogoIcon.Name = "appLogoIcon";
            appLogoIcon.Size = new Size(61, 50);
            appLogoIcon.TabIndex = 7;
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = Color.White;
            dashboardPanel.Location = new Point(242, -1);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1039, 723);
            dashboardPanel.TabIndex = 2;
            // 
            // accountScreenButton
            // 
            accountScreenButton.BorderColor = Color.Transparent;
            accountScreenButton.ButtonColor = Color.FromArgb(92, 184, 92);
            accountScreenButton.CornerRadius = 5;
            accountScreenButton.Cursor = Cursors.Hand;
            accountScreenButton.FlatAppearance.BorderSize = 0;
            accountScreenButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 46, 65);
            accountScreenButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 46, 65);
            accountScreenButton.FlatStyle = FlatStyle.Flat;
            accountScreenButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            accountScreenButton.ForeColor = Color.WhiteSmoke;
            accountScreenButton.Location = new Point(12, 107);
            accountScreenButton.Name = "accountScreenButton";
            accountScreenButton.OnHoverBorderColor = Color.Transparent;
            accountScreenButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            accountScreenButton.OnHoverTextColor = Color.WhiteSmoke;
            accountScreenButton.Size = new Size(215, 40);
            accountScreenButton.TabIndex = 1;
            accountScreenButton.Text = "ACCOUNTS";
            accountScreenButton.TextColor = Color.WhiteSmoke;
            accountScreenButton.UseVisualStyleBackColor = false;
            accountScreenButton.Click += accountScreenButton_Click;
            // 
            // transactionScreenButton
            // 
            transactionScreenButton.BorderColor = Color.Transparent;
            transactionScreenButton.ButtonColor = Color.FromArgb(48, 46, 65);
            transactionScreenButton.CornerRadius = 5;
            transactionScreenButton.Cursor = Cursors.Hand;
            transactionScreenButton.FlatAppearance.BorderSize = 0;
            transactionScreenButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 46, 65);
            transactionScreenButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 46, 65);
            transactionScreenButton.FlatStyle = FlatStyle.Flat;
            transactionScreenButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            transactionScreenButton.ForeColor = Color.FromArgb(48, 48, 51);
            transactionScreenButton.Location = new Point(12, 163);
            transactionScreenButton.Name = "transactionScreenButton";
            transactionScreenButton.OnHoverBorderColor = Color.Transparent;
            transactionScreenButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            transactionScreenButton.OnHoverTextColor = Color.WhiteSmoke;
            transactionScreenButton.Size = new Size(215, 40);
            transactionScreenButton.TabIndex = 3;
            transactionScreenButton.Text = "TRANSACTIONS";
            transactionScreenButton.TextColor = Color.WhiteSmoke;
            transactionScreenButton.UseVisualStyleBackColor = false;
            transactionScreenButton.Click += transactionScreenButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BorderColor = Color.Transparent;
            logoutButton.ButtonColor = Color.FromArgb(92, 184, 92);
            logoutButton.CornerRadius = 5;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 46, 65);
            logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 46, 65);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.WhiteSmoke;
            logoutButton.Location = new Point(12, 655);
            logoutButton.Name = "logoutButton";
            logoutButton.OnHoverBorderColor = Color.Transparent;
            logoutButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            logoutButton.OnHoverTextColor = Color.WhiteSmoke;
            logoutButton.Size = new Size(215, 40);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "LOGOUT";
            logoutButton.TextColor = Color.WhiteSmoke;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(83, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 22);
            label1.TabIndex = 8;
            label1.Text = "Administrator";
            // 
            // informationUpdateButton
            // 
            informationUpdateButton.BorderColor = Color.Transparent;
            informationUpdateButton.ButtonColor = Color.FromArgb(48, 46, 65);
            informationUpdateButton.CornerRadius = 5;
            informationUpdateButton.Cursor = Cursors.Hand;
            informationUpdateButton.FlatAppearance.BorderSize = 0;
            informationUpdateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 46, 65);
            informationUpdateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 46, 65);
            informationUpdateButton.FlatStyle = FlatStyle.Flat;
            informationUpdateButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            informationUpdateButton.ForeColor = Color.FromArgb(48, 48, 51);
            informationUpdateButton.Location = new Point(12, 221);
            informationUpdateButton.Name = "informationUpdateButton";
            informationUpdateButton.OnHoverBorderColor = Color.Transparent;
            informationUpdateButton.OnHoverButtonColor = Color.FromArgb(65, 64, 89);
            informationUpdateButton.OnHoverTextColor = Color.WhiteSmoke;
            informationUpdateButton.Size = new Size(215, 40);
            informationUpdateButton.TabIndex = 9;
            informationUpdateButton.Text = "INFORMATIONS";
            informationUpdateButton.TextColor = Color.WhiteSmoke;
            informationUpdateButton.UseVisualStyleBackColor = false;
            informationUpdateButton.Click += informationUpdateButton_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 46, 65);
            ClientSize = new Size(1280, 720);
            Controls.Add(informationUpdateButton);
            Controls.Add(label1);
            Controls.Add(logoutButton);
            Controls.Add(transactionScreenButton);
            Controls.Add(line2);
            Controls.Add(appLogoIcon);
            Controls.Add(line1);
            Controls.Add(accountScreenButton);
            Controls.Add(dashboardPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel line1;
        private Panel line2;
        private Panel appLogoIcon;
        private RoundedButton accountScreenButton;
        private RoundedButton transactionScreenButton;
        private RoundedButton logoutButton;
        private Label label1;
        private RoundedButton informationUpdateButton;
        public static Panel dashboardPanel;
    }
}
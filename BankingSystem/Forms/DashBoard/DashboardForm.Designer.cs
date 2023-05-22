namespace BankingSystem.Forms.DashBoard
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
            homeButton = new Button();
            userButton = new Button();
            dashboardPanel = new Panel();
            homeScreenForm = new HomeScreenForm();
            dashboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // homeButton
            // 
            homeButton.Location = new Point(12, 85);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(86, 82);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // userButton
            // 
            userButton.Location = new Point(12, 197);
            userButton.Name = "userButton";
            userButton.Size = new Size(86, 82);
            userButton.TabIndex = 1;
            userButton.Text = "User";
            userButton.UseVisualStyleBackColor = true;
            userButton.Click += userButton_Click;
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = Color.White;
            dashboardPanel.Location = new Point(171, -1);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1110, 723);
            dashboardPanel.TabIndex = 2;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1280, 720);
            Controls.Add(dashboardPanel);
            Controls.Add(userButton);
            Controls.Add(homeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            dashboardPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button homeButton;
        private Button userButton;
        public static Panel dashboardPanel;
    }
}
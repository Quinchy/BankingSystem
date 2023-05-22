namespace BankingSystem.Forms
{
    partial class BaseForm
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
            mainPanel = new Panel();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1280, 720);
            mainPanel.TabIndex = 0;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(loginForm);
            loginForm.Show();
            Controls.Add(mainPanel);
            Name = "BaseForm";
            Text = "BANKING SYSTEM";
            ResumeLayout(false);
        }
        public static Panel GetContentPanel()
        {
            return mainPanel;
        }
        public static Panel mainPanel;
        private LoginForm loginForm;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            mainPanel = new Panel();
            loginForm = new LoginForm();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginForm
            // 
            loginForm.BackColor = Color.WhiteSmoke;
            loginForm.ClientSize = new Size(1280, 720);
            loginForm.Dock = DockStyle.Fill;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Location = new Point(0, 0);
            loginForm.Name = "loginForm";
            loginForm.Text = "LoginForm";
            loginForm.Visible = false;
            // 
            // mainPanel
            // 
            loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(loginForm);
            loginForm.Show();
            mainPanel.Controls.Add(loginForm);
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
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BaseForm";
            Text = "OnlyFunds";
            mainPanel.ResumeLayout(false);
            this.StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        public static Panel GetContentPanel()
        {
            return mainPanel;
        }
        private LoginForm loginForm;
        public static Panel mainPanel;
    }
}
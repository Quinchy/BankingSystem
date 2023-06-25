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
            exitButton = new Button();
            minimizeButton = new Button();
            appLogo = new PictureBox();
            appTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)appLogo).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 35);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1280, 720);
            mainPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(34, 33, 46);
            exitButton.BackgroundImage = Properties.Resources.close3;
            exitButton.BackgroundImageLayout = ImageLayout.None;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(1220, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(60, 35);
            exitButton.TabIndex = 1;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = Color.FromArgb(34, 33, 46);
            minimizeButton.BackgroundImage = Properties.Resources.minimize1;
            minimizeButton.BackgroundImageLayout = ImageLayout.None;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Location = new Point(1160, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(60, 35);
            minimizeButton.TabIndex = 2;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // appLogo
            // 
            appLogo.BackgroundImage = Properties.Resources.OnlyFundsLogo;
            appLogo.BackgroundImageLayout = ImageLayout.Stretch;
            appLogo.Location = new Point(12, 10);
            appLogo.Name = "appLogo";
            appLogo.Size = new Size(20, 15);
            appLogo.TabIndex = 3;
            appLogo.TabStop = false;
            // 
            // appTitle
            // 
            appTitle.AutoSize = true;
            appTitle.BackColor = Color.Transparent;
            appTitle.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            appTitle.ForeColor = Color.WhiteSmoke;
            appTitle.Location = new Point(35, 9);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(68, 16);
            appTitle.TabIndex = 4;
            appTitle.Text = "OnlyFunds";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1280, 755);
            Controls.Add(appLogo);
            Controls.Add(minimizeButton);
            Controls.Add(exitButton);
            Controls.Add(mainPanel);
            Controls.Add(appTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OnlyFunds";
            ((System.ComponentModel.ISupportInitialize)appLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public static Panel GetContentPanel()
        {
            return mainPanel;
        }

        private Button exitButton;
        private Button minimizeButton;
        private PictureBox appLogo;
        private Label appTitle;
        public static Panel mainPanel;
    }
}
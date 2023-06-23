namespace BankingSystem.Forms.TellerDashBoard.AccountCards
{
    partial class AccountRequestCards
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
            requestPicture = new PictureBox();
            accountRequestCardPanel = new Panel();
            dateValueLabel = new Label();
            statusValueLabel = new Label();
            rejectButton = new Button();
            acceptButton = new Button();
            passwordValueLabel = new Label();
            phoneValueLabel = new Label();
            line2 = new Panel();
            emailValueLabel = new Label();
            lastNameValueLabel = new Label();
            firstNameValueLabel = new Label();
            dateLabel = new Label();
            statusLabel = new Label();
            line1 = new Panel();
            accountInfoLabel = new Label();
            passwordLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)requestPicture).BeginInit();
            accountRequestCardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // requestPicture
            // 
            requestPicture.BackgroundImage = Properties.Resources.quote_request;
            requestPicture.BackgroundImageLayout = ImageLayout.Stretch;
            requestPicture.Location = new Point(10, 16);
            requestPicture.Name = "requestPicture";
            requestPicture.Size = new Size(40, 40);
            requestPicture.TabIndex = 8;
            requestPicture.TabStop = false;
            // 
            // accountRequestCardPanel
            // 
            accountRequestCardPanel.BackColor = Color.White;
            accountRequestCardPanel.Controls.Add(dateValueLabel);
            accountRequestCardPanel.Controls.Add(statusValueLabel);
            accountRequestCardPanel.Controls.Add(rejectButton);
            accountRequestCardPanel.Controls.Add(acceptButton);
            accountRequestCardPanel.Controls.Add(passwordValueLabel);
            accountRequestCardPanel.Controls.Add(phoneValueLabel);
            accountRequestCardPanel.Controls.Add(line2);
            accountRequestCardPanel.Controls.Add(emailValueLabel);
            accountRequestCardPanel.Controls.Add(lastNameValueLabel);
            accountRequestCardPanel.Controls.Add(firstNameValueLabel);
            accountRequestCardPanel.Controls.Add(dateLabel);
            accountRequestCardPanel.Controls.Add(statusLabel);
            accountRequestCardPanel.Controls.Add(line1);
            accountRequestCardPanel.Controls.Add(accountInfoLabel);
            accountRequestCardPanel.Controls.Add(passwordLabel);
            accountRequestCardPanel.Controls.Add(phoneLabel);
            accountRequestCardPanel.Controls.Add(emailLabel);
            accountRequestCardPanel.Controls.Add(lastNameLabel);
            accountRequestCardPanel.Controls.Add(firstNameLabel);
            accountRequestCardPanel.Controls.Add(requestPicture);
            accountRequestCardPanel.Location = new Point(3, 3);
            accountRequestCardPanel.Name = "accountRequestCardPanel";
            accountRequestCardPanel.Size = new Size(308, 244);
            accountRequestCardPanel.TabIndex = 9;
            // 
            // dateValueLabel
            // 
            dateValueLabel.AutoSize = true;
            dateValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            dateValueLabel.Location = new Point(98, 37);
            dateValueLabel.Name = "dateValueLabel";
            dateValueLabel.Size = new Size(88, 17);
            dateValueLabel.TabIndex = 54;
            dateValueLabel.Text = "23 - 06 - 2023";
            dateValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusValueLabel
            // 
            statusValueLabel.AutoSize = true;
            statusValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            statusValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            statusValueLabel.Location = new Point(106, 16);
            statusValueLabel.Name = "statusValueLabel";
            statusValueLabel.Size = new Size(60, 16);
            statusValueLabel.TabIndex = 53;
            statusValueLabel.Text = "Pending";
            statusValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rejectButton
            // 
            rejectButton.BackColor = Color.Transparent;
            rejectButton.BackgroundImage = Properties.Resources.cross_button;
            rejectButton.BackgroundImageLayout = ImageLayout.Stretch;
            rejectButton.Cursor = Cursors.Hand;
            rejectButton.FlatAppearance.BorderSize = 0;
            rejectButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rejectButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rejectButton.FlatStyle = FlatStyle.Flat;
            rejectButton.Location = new Point(260, 201);
            rejectButton.Name = "rejectButton";
            rejectButton.Size = new Size(40, 40);
            rejectButton.TabIndex = 52;
            rejectButton.UseVisualStyleBackColor = false;
            rejectButton.Click += rejectButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.Transparent;
            acceptButton.BackgroundImage = Properties.Resources.check_mark;
            acceptButton.BackgroundImageLayout = ImageLayout.Stretch;
            acceptButton.Cursor = Cursors.Hand;
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            acceptButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Location = new Point(214, 201);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(40, 40);
            acceptButton.TabIndex = 51;
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // passwordValueLabel
            // 
            passwordValueLabel.AutoSize = true;
            passwordValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            passwordValueLabel.Location = new Point(82, 185);
            passwordValueLabel.Name = "passwordValueLabel";
            passwordValueLabel.Size = new Size(64, 17);
            passwordValueLabel.TabIndex = 50;
            passwordValueLabel.Text = "12345678";
            passwordValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneValueLabel
            // 
            phoneValueLabel.AutoSize = true;
            phoneValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            phoneValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            phoneValueLabel.Location = new Point(117, 164);
            phoneValueLabel.Name = "phoneValueLabel";
            phoneValueLabel.Size = new Size(85, 17);
            phoneValueLabel.TabIndex = 49;
            phoneValueLabel.Text = "09959185081";
            phoneValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(225, 80);
            line2.Name = "line2";
            line2.Size = new Size(75, 1);
            line2.TabIndex = 43;
            // 
            // emailValueLabel
            // 
            emailValueLabel.AutoSize = true;
            emailValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            emailValueLabel.Location = new Point(58, 142);
            emailValueLabel.Name = "emailValueLabel";
            emailValueLabel.Size = new Size(222, 17);
            emailValueLabel.TabIndex = 48;
            emailValueLabel.Text = "deguzmancyriljames@gmail.com";
            emailValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastNameValueLabel
            // 
            lastNameValueLabel.AutoSize = true;
            lastNameValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            lastNameValueLabel.Location = new Point(90, 122);
            lastNameValueLabel.Name = "lastNameValueLabel";
            lastNameValueLabel.Size = new Size(85, 17);
            lastNameValueLabel.TabIndex = 47;
            lastNameValueLabel.Text = "De Guzman";
            lastNameValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstNameValueLabel
            // 
            firstNameValueLabel.AutoSize = true;
            firstNameValueLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameValueLabel.ForeColor = Color.FromArgb(48, 48, 51);
            firstNameValueLabel.Location = new Point(90, 101);
            firstNameValueLabel.Name = "firstNameValueLabel";
            firstNameValueLabel.Size = new Size(80, 17);
            firstNameValueLabel.TabIndex = 46;
            firstNameValueLabel.Text = "Cyril James";
            firstNameValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.ForeColor = Color.Black;
            dateLabel.Location = new Point(56, 37);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(41, 16);
            dateLabel.TabIndex = 45;
            dateLabel.Text = "Date:";
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.Black;
            statusLabel.Location = new Point(56, 16);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(49, 16);
            statusLabel.TabIndex = 44;
            statusLabel.Text = "Status:";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // line1
            // 
            line1.BackColor = Color.Gainsboro;
            line1.Location = new Point(3, 80);
            line1.Name = "line1";
            line1.Size = new Size(75, 1);
            line1.TabIndex = 42;
            // 
            // accountInfoLabel
            // 
            accountInfoLabel.AutoSize = true;
            accountInfoLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            accountInfoLabel.ForeColor = Color.FromArgb(48, 48, 51);
            accountInfoLabel.Location = new Point(82, 72);
            accountInfoLabel.Name = "accountInfoLabel";
            accountInfoLabel.Size = new Size(142, 17);
            accountInfoLabel.TabIndex = 41;
            accountInfoLabel.Text = "Account Information";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(10, 185);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(71, 16);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.ForeColor = Color.Black;
            phoneLabel.Location = new Point(10, 164);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(106, 16);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Phone Number:";
            phoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.Black;
            emailLabel.Location = new Point(10, 143);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(47, 16);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.Black;
            lastNameLabel.Location = new Point(10, 122);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 16);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.Black;
            firstNameLabel.Location = new Point(10, 101);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(79, 16);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccountRequestCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(accountRequestCardPanel);
            Name = "AccountRequestCards";
            Size = new Size(314, 249);
            ((System.ComponentModel.ISupportInitialize)requestPicture).EndInit();
            accountRequestCardPanel.ResumeLayout(false);
            accountRequestCardPanel.PerformLayout();
            ResumeLayout(false);
        }

        public PictureBox requestPicture;
        private Panel accountRequestCardPanel;
        public Label emailLabel;
        public Label lastNameLabel;
        public Label firstNameLabel;
        public Label passwordLabel;
        public Label phoneLabel;
        public Label statusLabel;
        private Panel line1;
        private Label accountInfoLabel;
        public Label dateLabel;
        public Label emailValueLabel;
        public Label lastNameValueLabel;
        public Label firstNameValueLabel;
        public Label passwordValueLabel;
        public Label phoneValueLabel;
        private Panel line2;
        private Button rejectButton;
        private Button acceptButton;
        public Label dateValueLabel;
        public Label statusValueLabel;
    }
}

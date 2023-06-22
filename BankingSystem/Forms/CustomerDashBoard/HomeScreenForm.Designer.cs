namespace BankingSystem.Forms.CustomerDashBoard
{
    partial class HomeScreenForm
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
            line3 = new Panel();
            line4 = new Panel();
            line5 = new Panel();
            line6 = new Panel();
            homeScreenPanel = new Panel();
            greetUserLabel = new Label();
            balanceCardPanel = new Utils.Components.RoundedPanel();
            cardPicture = new PictureBox();
            balanceLabel = new Label();
            availableBalanceLabel = new Label();
            transferCardPanel = new Utils.Components.RoundedPanel();
            arrowDownIcon = new Panel();
            transferLabel = new Label();
            receiverIDPanel = new Utils.Components.RoundedPanel();
            receiverIDTextBox = new TextBox();
            receiverIDLabel = new Label();
            amountTransferLabel = new Label();
            yourIDLabel = new Label();
            yourIDPanel = new Utils.Components.RoundedPanel();
            yourIDTextBox = new TextBox();
            confirmButton = new Utils.Components.RoundedButton();
            amountTransferPanel = new Utils.Components.RoundedPanel();
            amountTransferNumeric = new NumericUpDown();
            transactionCardPanel = new Utils.Components.RoundedPanel();
            yourIDTransactionLabel = new Label();
            yourIDTransactionPanel = new Utils.Components.RoundedPanel();
            yourIDTransactionTextBox = new TextBox();
            panel1 = new Panel();
            transactionLabel = new Label();
            amountTransactionLabel = new Label();
            amountTransactionPanel = new Utils.Components.RoundedPanel();
            amountTransactionNumeric = new NumericUpDown();
            withdrawButton = new Utils.Components.RoundedButton();
            depositButton = new Utils.Components.RoundedButton();
            homeScreenPanel.SuspendLayout();
            balanceCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardPicture).BeginInit();
            transferCardPanel.SuspendLayout();
            receiverIDPanel.SuspendLayout();
            yourIDPanel.SuspendLayout();
            amountTransferPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountTransferNumeric).BeginInit();
            transactionCardPanel.SuspendLayout();
            yourIDTransactionPanel.SuspendLayout();
            amountTransactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountTransactionNumeric).BeginInit();
            SuspendLayout();
            // 
            // line1
            // 
            line1.BackColor = Color.FromArgb(65, 64, 89);
            line1.Location = new Point(13, 37);
            line1.Name = "line1";
            line1.Size = new Size(226, 2);
            line1.TabIndex = 1;
            // 
            // line2
            // 
            line2.BackColor = Color.Gainsboro;
            line2.Location = new Point(35, 224);
            line2.Name = "line2";
            line2.Size = new Size(380, 1);
            line2.TabIndex = 38;
            // 
            // line3
            // 
            line3.BackColor = Color.Gainsboro;
            line3.Location = new Point(39, 460);
            line3.Name = "line3";
            line3.Size = new Size(353, 1);
            line3.TabIndex = 37;
            // 
            // line4
            // 
            line4.BackColor = Color.FromArgb(65, 64, 89);
            line4.Location = new Point(11, 38);
            line4.Name = "line4";
            line4.Size = new Size(226, 2);
            line4.TabIndex = 1;
            // 
            // line5
            // 
            line5.BackColor = Color.FromArgb(65, 64, 89);
            line5.Location = new Point(13, 37);
            line5.Name = "line5";
            line5.Size = new Size(226, 2);
            line5.TabIndex = 1;
            // 
            // line6
            // 
            line6.BackColor = Color.FromArgb(65, 64, 89);
            line6.Location = new Point(11, 38);
            line6.Name = "line6";
            line6.Size = new Size(226, 2);
            line6.TabIndex = 1;
            // 
            // homeScreenPanel
            // 
            homeScreenPanel.BackColor = Color.FromArgb(34, 33, 46);
            homeScreenPanel.Controls.Add(greetUserLabel);
            homeScreenPanel.Controls.Add(balanceCardPanel);
            homeScreenPanel.Controls.Add(transferCardPanel);
            homeScreenPanel.Controls.Add(transactionCardPanel);
            homeScreenPanel.Location = new Point(0, 0);
            homeScreenPanel.Name = "homeScreenPanel";
            homeScreenPanel.Size = new Size(1039, 723);
            homeScreenPanel.TabIndex = 30;
            // 
            // greetUserLabel
            // 
            greetUserLabel.AutoSize = true;
            greetUserLabel.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            greetUserLabel.ForeColor = Color.White;
            greetUserLabel.Location = new Point(61, 26);
            greetUserLabel.Name = "greetUserLabel";
            greetUserLabel.Size = new Size(288, 44);
            greetUserLabel.TabIndex = 26;
            greetUserLabel.Text = "Welcome, User";
            // 
            // balanceCardPanel
            // 
            balanceCardPanel.BackColor = Color.Transparent;
            balanceCardPanel.BorderColor = Color.FromArgb(92, 184, 92);
            balanceCardPanel.Controls.Add(cardPicture);
            balanceCardPanel.Controls.Add(balanceLabel);
            balanceCardPanel.Controls.Add(availableBalanceLabel);
            balanceCardPanel.CornerRadius = 15;
            balanceCardPanel.ForeColor = Color.Transparent;
            balanceCardPanel.Location = new Point(61, 96);
            balanceCardPanel.Name = "balanceCardPanel";
            balanceCardPanel.Size = new Size(451, 208);
            balanceCardPanel.TabIndex = 25;
            // 
            // cardPicture
            // 
            cardPicture.BackgroundImage = Properties.Resources.credit_cards;
            cardPicture.BackgroundImageLayout = ImageLayout.Stretch;
            cardPicture.Location = new Point(35, 63);
            cardPicture.Name = "cardPicture";
            cardPicture.Size = new Size(80, 80);
            cardPicture.TabIndex = 29;
            cardPicture.TabStop = false;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Century Gothic", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.ForeColor = Color.White;
            balanceLabel.Location = new Point(139, 90);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(142, 52);
            balanceLabel.TabIndex = 0;
            balanceLabel.Text = "₱ 0.00";
            // 
            // availableBalanceLabel
            // 
            availableBalanceLabel.AutoSize = true;
            availableBalanceLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            availableBalanceLabel.ForeColor = Color.White;
            availableBalanceLabel.Location = new Point(147, 70);
            availableBalanceLabel.Name = "availableBalanceLabel";
            availableBalanceLabel.Size = new Size(183, 23);
            availableBalanceLabel.TabIndex = 28;
            availableBalanceLabel.Text = "Available Balance";
            // 
            // transferCardPanel
            // 
            transferCardPanel.BackColor = Color.Transparent;
            transferCardPanel.BorderColor = Color.White;
            transferCardPanel.Controls.Add(line3);
            transferCardPanel.Controls.Add(arrowDownIcon);
            transferCardPanel.Controls.Add(transferLabel);
            transferCardPanel.Controls.Add(receiverIDPanel);
            transferCardPanel.Controls.Add(receiverIDLabel);
            transferCardPanel.Controls.Add(amountTransferLabel);
            transferCardPanel.Controls.Add(yourIDLabel);
            transferCardPanel.Controls.Add(yourIDPanel);
            transferCardPanel.Controls.Add(confirmButton);
            transferCardPanel.Controls.Add(amountTransferPanel);
            transferCardPanel.CornerRadius = 10;
            transferCardPanel.ForeColor = Color.Transparent;
            transferCardPanel.Location = new Point(540, 96);
            transferCardPanel.Name = "transferCardPanel";
            transferCardPanel.Size = new Size(422, 548);
            transferCardPanel.TabIndex = 27;
            // 
            // arrowDownIcon
            // 
            arrowDownIcon.BackgroundImage = Properties.Resources.down_arrow;
            arrowDownIcon.BackgroundImageLayout = ImageLayout.Stretch;
            arrowDownIcon.Location = new Point(191, 285);
            arrowDownIcon.Name = "arrowDownIcon";
            arrowDownIcon.Size = new Size(50, 50);
            arrowDownIcon.TabIndex = 36;
            // 
            // transferLabel
            // 
            transferLabel.AutoSize = true;
            transferLabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            transferLabel.ForeColor = Color.FromArgb(48, 48, 51);
            transferLabel.Location = new Point(91, 23);
            transferLabel.Name = "transferLabel";
            transferLabel.Size = new Size(227, 36);
            transferLabel.TabIndex = 30;
            transferLabel.Text = "Transfer Money";
            // 
            // receiverIDPanel
            // 
            receiverIDPanel.BackColor = Color.Transparent;
            receiverIDPanel.BorderColor = Color.FromArgb(48, 46, 65);
            receiverIDPanel.Controls.Add(receiverIDTextBox);
            receiverIDPanel.Controls.Add(line6);
            receiverIDPanel.CornerRadius = 10;
            receiverIDPanel.ForeColor = Color.Transparent;
            receiverIDPanel.Location = new Point(91, 395);
            receiverIDPanel.Name = "receiverIDPanel";
            receiverIDPanel.Size = new Size(248, 45);
            receiverIDPanel.TabIndex = 33;
            // 
            // receiverIDTextBox
            // 
            receiverIDTextBox.BackColor = Color.FromArgb(48, 46, 65);
            receiverIDTextBox.BorderStyle = BorderStyle.None;
            receiverIDTextBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            receiverIDTextBox.ForeColor = Color.WhiteSmoke;
            receiverIDTextBox.Location = new Point(11, 13);
            receiverIDTextBox.Name = "receiverIDTextBox";
            receiverIDTextBox.Size = new Size(226, 19);
            receiverIDTextBox.TabIndex = 32;
            receiverIDTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // receiverIDLabel
            // 
            receiverIDLabel.AutoSize = true;
            receiverIDLabel.BackColor = Color.Transparent;
            receiverIDLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            receiverIDLabel.ForeColor = Color.FromArgb(48, 48, 51);
            receiverIDLabel.Location = new Point(91, 374);
            receiverIDLabel.Name = "receiverIDLabel";
            receiverIDLabel.Size = new Size(102, 18);
            receiverIDLabel.TabIndex = 35;
            receiverIDLabel.Text = "Receiver's ID";
            // 
            // amountTransferLabel
            // 
            amountTransferLabel.AutoSize = true;
            amountTransferLabel.BackColor = Color.Transparent;
            amountTransferLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            amountTransferLabel.ForeColor = Color.FromArgb(48, 48, 51);
            amountTransferLabel.Location = new Point(91, 181);
            amountTransferLabel.Name = "amountTransferLabel";
            amountTransferLabel.Size = new Size(65, 18);
            amountTransferLabel.TabIndex = 34;
            amountTransferLabel.Text = "Amount";
            // 
            // yourIDLabel
            // 
            yourIDLabel.AutoSize = true;
            yourIDLabel.BackColor = Color.Transparent;
            yourIDLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            yourIDLabel.ForeColor = Color.FromArgb(48, 48, 51);
            yourIDLabel.Location = new Point(91, 90);
            yourIDLabel.Name = "yourIDLabel";
            yourIDLabel.Size = new Size(127, 18);
            yourIDLabel.TabIndex = 29;
            yourIDLabel.Text = "Your Account ID";
            // 
            // yourIDPanel
            // 
            yourIDPanel.BackColor = Color.Transparent;
            yourIDPanel.BorderColor = Color.FromArgb(48, 46, 65);
            yourIDPanel.Controls.Add(yourIDTextBox);
            yourIDPanel.Controls.Add(line4);
            yourIDPanel.CornerRadius = 10;
            yourIDPanel.ForeColor = Color.Transparent;
            yourIDPanel.Location = new Point(91, 111);
            yourIDPanel.Name = "yourIDPanel";
            yourIDPanel.Size = new Size(248, 45);
            yourIDPanel.TabIndex = 31;
            // 
            // yourIDTextBox
            // 
            yourIDTextBox.BackColor = Color.FromArgb(48, 46, 65);
            yourIDTextBox.BorderStyle = BorderStyle.None;
            yourIDTextBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yourIDTextBox.ForeColor = Color.WhiteSmoke;
            yourIDTextBox.Location = new Point(11, 13);
            yourIDTextBox.Name = "yourIDTextBox";
            yourIDTextBox.Size = new Size(226, 19);
            yourIDTextBox.TabIndex = 32;
            yourIDTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // confirmButton
            // 
            confirmButton.BorderColor = Color.Transparent;
            confirmButton.ButtonColor = Color.FromArgb(92, 184, 92);
            confirmButton.CornerRadius = 10;
            confirmButton.Cursor = Cursors.Hand;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatAppearance.MouseDownBackColor = Color.White;
            confirmButton.FlatAppearance.MouseOverBackColor = Color.White;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(136, 477);
            confirmButton.Name = "confirmButton";
            confirmButton.OnHoverBorderColor = Color.Transparent;
            confirmButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            confirmButton.OnHoverTextColor = Color.WhiteSmoke;
            confirmButton.Size = new Size(166, 45);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "CONFIRM";
            confirmButton.TextColor = Color.WhiteSmoke;
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // amountTransferPanel
            // 
            amountTransferPanel.BackColor = Color.Transparent;
            amountTransferPanel.BorderColor = Color.FromArgb(48, 46, 65);
            amountTransferPanel.Controls.Add(amountTransferNumeric);
            amountTransferPanel.Controls.Add(line5);
            amountTransferPanel.CornerRadius = 10;
            amountTransferPanel.ForeColor = Color.Transparent;
            amountTransferPanel.Location = new Point(91, 202);
            amountTransferPanel.Name = "amountTransferPanel";
            amountTransferPanel.Size = new Size(250, 45);
            amountTransferPanel.TabIndex = 33;
            // 
            // amountTransferNumeric
            // 
            amountTransferNumeric.BackColor = Color.FromArgb(48, 46, 65);
            amountTransferNumeric.BorderStyle = BorderStyle.None;
            amountTransferNumeric.DecimalPlaces = 2;
            amountTransferNumeric.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountTransferNumeric.ForeColor = Color.White;
            amountTransferNumeric.Location = new Point(13, 9);
            amountTransferNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            amountTransferNumeric.Name = "amountTransferNumeric";
            amountTransferNumeric.RightToLeft = RightToLeft.No;
            amountTransferNumeric.Size = new Size(226, 23);
            amountTransferNumeric.TabIndex = 1;
            amountTransferNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // transactionCardPanel
            // 
            transactionCardPanel.BackColor = Color.Transparent;
            transactionCardPanel.BorderColor = Color.White;
            transactionCardPanel.Controls.Add(yourIDTransactionLabel);
            transactionCardPanel.Controls.Add(yourIDTransactionPanel);
            transactionCardPanel.Controls.Add(line2);
            transactionCardPanel.Controls.Add(transactionLabel);
            transactionCardPanel.Controls.Add(amountTransactionLabel);
            transactionCardPanel.Controls.Add(amountTransactionPanel);
            transactionCardPanel.Controls.Add(withdrawButton);
            transactionCardPanel.Controls.Add(depositButton);
            transactionCardPanel.CornerRadius = 10;
            transactionCardPanel.ForeColor = Color.Transparent;
            transactionCardPanel.Location = new Point(61, 332);
            transactionCardPanel.Name = "transactionCardPanel";
            transactionCardPanel.Size = new Size(451, 312);
            transactionCardPanel.TabIndex = 26;
            // 
            // yourIDTransactionLabel
            // 
            yourIDTransactionLabel.AutoSize = true;
            yourIDTransactionLabel.BackColor = Color.Transparent;
            yourIDTransactionLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            yourIDTransactionLabel.ForeColor = Color.FromArgb(48, 48, 51);
            yourIDTransactionLabel.Location = new Point(97, 65);
            yourIDTransactionLabel.Name = "yourIDTransactionLabel";
            yourIDTransactionLabel.Size = new Size(127, 18);
            yourIDTransactionLabel.TabIndex = 38;
            yourIDTransactionLabel.Text = "Your Account ID";
            // 
            // yourIDTransactionPanel
            // 
            yourIDTransactionPanel.BackColor = Color.Transparent;
            yourIDTransactionPanel.BorderColor = Color.FromArgb(48, 46, 65);
            yourIDTransactionPanel.Controls.Add(yourIDTransactionTextBox);
            yourIDTransactionPanel.Controls.Add(panel1);
            yourIDTransactionPanel.CornerRadius = 10;
            yourIDTransactionPanel.ForeColor = Color.Transparent;
            yourIDTransactionPanel.Location = new Point(97, 86);
            yourIDTransactionPanel.Name = "yourIDTransactionPanel";
            yourIDTransactionPanel.Size = new Size(248, 45);
            yourIDTransactionPanel.TabIndex = 39;
            // 
            // yourIDTransactionTextBox
            // 
            yourIDTransactionTextBox.BackColor = Color.FromArgb(48, 46, 65);
            yourIDTransactionTextBox.BorderStyle = BorderStyle.None;
            yourIDTransactionTextBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yourIDTransactionTextBox.ForeColor = Color.WhiteSmoke;
            yourIDTransactionTextBox.Location = new Point(11, 13);
            yourIDTransactionTextBox.Name = "yourIDTransactionTextBox";
            yourIDTransactionTextBox.Size = new Size(226, 19);
            yourIDTransactionTextBox.TabIndex = 32;
            yourIDTransactionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(65, 64, 89);
            panel1.Location = new Point(11, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 2);
            panel1.TabIndex = 1;
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            transactionLabel.ForeColor = Color.FromArgb(48, 48, 51);
            transactionLabel.Location = new Point(93, 15);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Size = new Size(175, 36);
            transactionLabel.TabIndex = 36;
            transactionLabel.Text = "Transaction";
            // 
            // amountTransactionLabel
            // 
            amountTransactionLabel.AutoSize = true;
            amountTransactionLabel.BackColor = Color.Transparent;
            amountTransactionLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            amountTransactionLabel.ForeColor = Color.FromArgb(48, 48, 51);
            amountTransactionLabel.Location = new Point(97, 140);
            amountTransactionLabel.Name = "amountTransactionLabel";
            amountTransactionLabel.Size = new Size(65, 18);
            amountTransactionLabel.TabIndex = 36;
            amountTransactionLabel.Text = "Amount";
            // 
            // amountTransactionPanel
            // 
            amountTransactionPanel.BackColor = Color.Transparent;
            amountTransactionPanel.BorderColor = Color.FromArgb(48, 46, 65);
            amountTransactionPanel.Controls.Add(amountTransactionNumeric);
            amountTransactionPanel.Controls.Add(line1);
            amountTransactionPanel.CornerRadius = 10;
            amountTransactionPanel.ForeColor = Color.Transparent;
            amountTransactionPanel.Location = new Point(97, 159);
            amountTransactionPanel.Name = "amountTransactionPanel";
            amountTransactionPanel.Size = new Size(250, 45);
            amountTransactionPanel.TabIndex = 29;
            // 
            // amountTransactionNumeric
            // 
            amountTransactionNumeric.BackColor = Color.FromArgb(48, 46, 65);
            amountTransactionNumeric.BorderStyle = BorderStyle.None;
            amountTransactionNumeric.DecimalPlaces = 2;
            amountTransactionNumeric.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountTransactionNumeric.ForeColor = Color.White;
            amountTransactionNumeric.Location = new Point(13, 9);
            amountTransactionNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            amountTransactionNumeric.Name = "amountTransactionNumeric";
            amountTransactionNumeric.RightToLeft = RightToLeft.No;
            amountTransactionNumeric.Size = new Size(226, 23);
            amountTransactionNumeric.TabIndex = 1;
            amountTransactionNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // withdrawButton
            // 
            withdrawButton.BorderColor = Color.Transparent;
            withdrawButton.ButtonColor = Color.FromArgb(92, 184, 92);
            withdrawButton.CornerRadius = 10;
            withdrawButton.Cursor = Cursors.Hand;
            withdrawButton.FlatAppearance.BorderSize = 0;
            withdrawButton.FlatAppearance.MouseDownBackColor = Color.White;
            withdrawButton.FlatAppearance.MouseOverBackColor = Color.White;
            withdrawButton.FlatStyle = FlatStyle.Flat;
            withdrawButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            withdrawButton.ForeColor = Color.White;
            withdrawButton.Location = new Point(235, 241);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.OnHoverBorderColor = Color.Transparent;
            withdrawButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            withdrawButton.OnHoverTextColor = Color.WhiteSmoke;
            withdrawButton.Size = new Size(166, 45);
            withdrawButton.TabIndex = 6;
            withdrawButton.Text = "WITHDRAW";
            withdrawButton.TextColor = Color.WhiteSmoke;
            withdrawButton.UseVisualStyleBackColor = false;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.BorderColor = Color.Transparent;
            depositButton.ButtonColor = Color.FromArgb(92, 184, 92);
            depositButton.CornerRadius = 10;
            depositButton.Cursor = Cursors.Hand;
            depositButton.FlatAppearance.BorderSize = 0;
            depositButton.FlatAppearance.MouseDownBackColor = Color.White;
            depositButton.FlatAppearance.MouseOverBackColor = Color.White;
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            depositButton.ForeColor = Color.White;
            depositButton.Location = new Point(48, 241);
            depositButton.Name = "depositButton";
            depositButton.OnHoverBorderColor = Color.Transparent;
            depositButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            depositButton.OnHoverTextColor = Color.WhiteSmoke;
            depositButton.Size = new Size(166, 45);
            depositButton.TabIndex = 5;
            depositButton.Text = "DEPOSIT";
            depositButton.TextColor = Color.WhiteSmoke;
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // HomeScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1039, 723);
            Controls.Add(homeScreenPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1039, 723);
            Name = "HomeScreenForm";
            Text = "HomeScreenForm";
            homeScreenPanel.ResumeLayout(false);
            homeScreenPanel.PerformLayout();
            balanceCardPanel.ResumeLayout(false);
            balanceCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cardPicture).EndInit();
            transferCardPanel.ResumeLayout(false);
            transferCardPanel.PerformLayout();
            receiverIDPanel.ResumeLayout(false);
            receiverIDPanel.PerformLayout();
            yourIDPanel.ResumeLayout(false);
            yourIDPanel.PerformLayout();
            amountTransferPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)amountTransferNumeric).EndInit();
            transactionCardPanel.ResumeLayout(false);
            transactionCardPanel.PerformLayout();
            yourIDTransactionPanel.ResumeLayout(false);
            yourIDTransactionPanel.PerformLayout();
            amountTransactionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)amountTransactionNumeric).EndInit();
            ResumeLayout(false);
        }

        private Panel line1;
        private Panel line2;
        private Panel line3;
        private Panel line4;
        private Panel line5;
        private Panel line6;
        private Panel homeScreenPanel;
        private Panel arrowDownIcon;
        private Utils.Components.RoundedPanel balanceCardPanel;
        private Utils.Components.RoundedPanel transactionCardPanel;
        private Utils.Components.RoundedPanel transferCardPanel;
        private Utils.Components.RoundedPanel amountTransactionPanel;
        private Utils.Components.RoundedPanel amountTransferPanel;
        private Utils.Components.RoundedPanel yourIDPanel;
        private Utils.Components.RoundedPanel receiverIDPanel;
        private Label availableBalanceLabel;
        private Label yourIDLabel;
        private Label receiverIDLabel;
        private Label amountTransactionLabel;
        private Label amountTransferLabel;
        private Label transactionLabel;
        private Label transferLabel;
        private TextBox yourIDTextBox;
        private TextBox receiverIDTextBox;
        private NumericUpDown amountTransactionNumeric;
        private NumericUpDown amountTransferNumeric;
        private Utils.Components.RoundedButton depositButton;
        private Utils.Components.RoundedButton withdrawButton;
        private Utils.Components.RoundedButton confirmButton;
        private PictureBox cardPicture;
        private Label yourIDTransactionLabel;
        private Utils.Components.RoundedPanel yourIDTransactionPanel;
        private TextBox yourIDTransactionTextBox;
        private Panel panel1;
        private static Label greetUserLabel;
        private static Label balanceLabel;
    }
}
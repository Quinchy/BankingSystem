using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.TellerDashBoard
{
    partial class AccountManagementForm
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
            accountManagementLabel = new Label();
            rejectButton = new RoundedButton();
            approveButton = new RoundedButton();
            homeScreenPanel = new Panel();
            closeAccountButton = new RoundedButton();
            openAccountButton = new RoundedButton();
            accountListLAbel = new Label();
            accountListPanel = new RoundedPanel();
            accountListView = new ListView();
            accountIDHeader = new ColumnHeader();
            accountCustomerIDHeader = new ColumnHeader();
            balanceHeader = new ColumnHeader();
            accountStatusHeader = new ColumnHeader();
            accountManagementPanel = new RoundedPanel();
            accountManagementListView = new ListView();
            requestIDHeader = new ColumnHeader();
            customerIDHeader = new ColumnHeader();
            emailHeader = new ColumnHeader();
            dateOfRequestHeader = new ColumnHeader();
            requestStatusHeader = new ColumnHeader();
            homeScreenPanel.SuspendLayout();
            accountListPanel.SuspendLayout();
            accountManagementPanel.SuspendLayout();
            SuspendLayout();
            // 
            // accountManagementLabel
            // 
            accountManagementLabel.AutoSize = true;
            accountManagementLabel.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            accountManagementLabel.ForeColor = Color.White;
            accountManagementLabel.Location = new Point(54, 27);
            accountManagementLabel.Name = "accountManagementLabel";
            accountManagementLabel.Size = new Size(426, 44);
            accountManagementLabel.TabIndex = 30;
            accountManagementLabel.Text = "Account Management";
            // 
            // rejectButton
            // 
            rejectButton.BorderColor = Color.Transparent;
            rejectButton.ButtonColor = Color.FromArgb(92, 184, 92);
            rejectButton.CornerRadius = 5;
            rejectButton.Cursor = Cursors.Hand;
            rejectButton.FlatAppearance.BorderSize = 0;
            rejectButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rejectButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rejectButton.FlatStyle = FlatStyle.Flat;
            rejectButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            rejectButton.ForeColor = Color.White;
            rejectButton.Location = new Point(789, 395);
            rejectButton.Name = "rejectButton";
            rejectButton.OnHoverBorderColor = Color.Transparent;
            rejectButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            rejectButton.OnHoverTextColor = Color.WhiteSmoke;
            rejectButton.Size = new Size(166, 45);
            rejectButton.TabIndex = 44;
            rejectButton.Text = "REJECT";
            rejectButton.TextColor = Color.WhiteSmoke;
            rejectButton.UseVisualStyleBackColor = false;
            rejectButton.Click += rejectButton_Click;
            // 
            // approveButton
            // 
            approveButton.BorderColor = Color.Transparent;
            approveButton.ButtonColor = Color.FromArgb(92, 184, 92);
            approveButton.CornerRadius = 5;
            approveButton.Cursor = Cursors.Hand;
            approveButton.FlatAppearance.BorderSize = 0;
            approveButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            approveButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            approveButton.FlatStyle = FlatStyle.Flat;
            approveButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            approveButton.ForeColor = Color.White;
            approveButton.Location = new Point(600, 395);
            approveButton.Name = "approveButton";
            approveButton.OnHoverBorderColor = Color.Transparent;
            approveButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            approveButton.OnHoverTextColor = Color.WhiteSmoke;
            approveButton.Size = new Size(166, 45);
            approveButton.TabIndex = 43;
            approveButton.Text = "APPROVE";
            approveButton.TextColor = Color.WhiteSmoke;
            approveButton.UseVisualStyleBackColor = false;
            approveButton.Click += approveButton_Click;
            // 
            // homeScreenPanel
            // 
            homeScreenPanel.AutoScroll = true;
            homeScreenPanel.AutoScrollMinSize = new Size(0, 910);
            homeScreenPanel.BackColor = Color.FromArgb(34, 33, 46);
            homeScreenPanel.Controls.Add(closeAccountButton);
            homeScreenPanel.Controls.Add(openAccountButton);
            homeScreenPanel.Controls.Add(accountListLAbel);
            homeScreenPanel.Controls.Add(accountListPanel);
            homeScreenPanel.Controls.Add(rejectButton);
            homeScreenPanel.Controls.Add(approveButton);
            homeScreenPanel.Controls.Add(accountManagementLabel);
            homeScreenPanel.Controls.Add(accountManagementPanel);
            homeScreenPanel.Location = new Point(0, 0);
            homeScreenPanel.Name = "homeScreenPanel";
            homeScreenPanel.Size = new Size(1039, 723);
            homeScreenPanel.TabIndex = 45;
            // 
            // closeAccountButton
            // 
            closeAccountButton.BorderColor = Color.Transparent;
            closeAccountButton.ButtonColor = Color.FromArgb(92, 184, 92);
            closeAccountButton.CornerRadius = 5;
            closeAccountButton.Cursor = Cursors.Hand;
            closeAccountButton.FlatAppearance.BorderSize = 0;
            closeAccountButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeAccountButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeAccountButton.FlatStyle = FlatStyle.Flat;
            closeAccountButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            closeAccountButton.ForeColor = Color.White;
            closeAccountButton.Location = new Point(789, 824);
            closeAccountButton.Name = "closeAccountButton";
            closeAccountButton.OnHoverBorderColor = Color.Transparent;
            closeAccountButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            closeAccountButton.OnHoverTextColor = Color.WhiteSmoke;
            closeAccountButton.Size = new Size(166, 45);
            closeAccountButton.TabIndex = 47;
            closeAccountButton.Text = "CLOSE";
            closeAccountButton.TextColor = Color.WhiteSmoke;
            closeAccountButton.UseVisualStyleBackColor = false;
            closeAccountButton.Click += closeAccountButton_Click;
            // 
            // openAccountButton
            // 
            openAccountButton.BorderColor = Color.Transparent;
            openAccountButton.ButtonColor = Color.FromArgb(92, 184, 92);
            openAccountButton.CornerRadius = 5;
            openAccountButton.Cursor = Cursors.Hand;
            openAccountButton.FlatAppearance.BorderSize = 0;
            openAccountButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            openAccountButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            openAccountButton.FlatStyle = FlatStyle.Flat;
            openAccountButton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            openAccountButton.ForeColor = Color.White;
            openAccountButton.Location = new Point(600, 824);
            openAccountButton.Name = "openAccountButton";
            openAccountButton.OnHoverBorderColor = Color.Transparent;
            openAccountButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            openAccountButton.OnHoverTextColor = Color.WhiteSmoke;
            openAccountButton.Size = new Size(166, 45);
            openAccountButton.TabIndex = 46;
            openAccountButton.Text = "OPEN";
            openAccountButton.TextColor = Color.WhiteSmoke;
            openAccountButton.UseVisualStyleBackColor = false;
            openAccountButton.Click += openAccountButton_Click;
            // 
            // accountListLAbel
            // 
            accountListLAbel.AutoSize = true;
            accountListLAbel.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            accountListLAbel.ForeColor = Color.White;
            accountListLAbel.Location = new Point(54, 455);
            accountListLAbel.Name = "accountListLAbel";
            accountListLAbel.Size = new Size(235, 44);
            accountListLAbel.TabIndex = 45;
            accountListLAbel.Text = "Account List";
            // 
            // accountListPanel
            // 
            accountListPanel.BackColor = Color.Transparent;
            accountListPanel.BorderColor = Color.White;
            accountListPanel.Controls.Add(accountListView);
            accountListPanel.CornerRadius = 10;
            accountListPanel.ForeColor = Color.Transparent;
            accountListPanel.Location = new Point(54, 513);
            accountListPanel.Name = "accountListPanel";
            accountListPanel.Size = new Size(901, 277);
            accountListPanel.TabIndex = 43;
            // 
            // accountListView
            // 
            accountListView.BackColor = Color.White;
            accountListView.BorderStyle = BorderStyle.None;
            accountListView.CheckBoxes = true;
            accountListView.Columns.AddRange(new ColumnHeader[] { accountIDHeader, accountCustomerIDHeader, balanceHeader, accountStatusHeader });
            accountListView.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accountListView.ForeColor = Color.Black;
            accountListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            accountListView.Location = new Point(17, 14);
            accountListView.MultiSelect = false;
            accountListView.Name = "accountListView";
            accountListView.Scrollable = false;
            accountListView.Size = new Size(864, 248);
            accountListView.TabIndex = 41;
            accountListView.UseCompatibleStateImageBehavior = false;
            accountListView.View = View.Details;
            // 
            // accountIDHeader
            // 
            accountIDHeader.Text = "    Account ID";
            accountIDHeader.Width = 200;
            // 
            // accountCustomerIDHeader
            // 
            accountCustomerIDHeader.Text = "Customer ID";
            accountCustomerIDHeader.TextAlign = HorizontalAlignment.Center;
            accountCustomerIDHeader.Width = 200;
            // 
            // balanceHeader
            // 
            balanceHeader.Text = "Balance";
            balanceHeader.TextAlign = HorizontalAlignment.Center;
            balanceHeader.Width = 250;
            // 
            // accountStatusHeader
            // 
            accountStatusHeader.Text = "Account Status";
            accountStatusHeader.TextAlign = HorizontalAlignment.Center;
            accountStatusHeader.Width = 251;
            // 
            // accountManagementPanel
            // 
            accountManagementPanel.BackColor = Color.Transparent;
            accountManagementPanel.BorderColor = Color.White;
            accountManagementPanel.Controls.Add(accountManagementListView);
            accountManagementPanel.CornerRadius = 10;
            accountManagementPanel.ForeColor = Color.Transparent;
            accountManagementPanel.Location = new Point(54, 86);
            accountManagementPanel.Name = "accountManagementPanel";
            accountManagementPanel.Size = new Size(901, 277);
            accountManagementPanel.TabIndex = 42;
            // 
            // accountManagementListView
            // 
            accountManagementListView.BackColor = Color.White;
            accountManagementListView.BorderStyle = BorderStyle.None;
            accountManagementListView.CheckBoxes = true;
            accountManagementListView.Columns.AddRange(new ColumnHeader[] { requestIDHeader, customerIDHeader, emailHeader, dateOfRequestHeader, requestStatusHeader });
            accountManagementListView.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accountManagementListView.ForeColor = Color.Black;
            accountManagementListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            accountManagementListView.Location = new Point(17, 14);
            accountManagementListView.Name = "accountManagementListView";
            accountManagementListView.Scrollable = false;
            accountManagementListView.Size = new Size(864, 248);
            accountManagementListView.TabIndex = 41;
            accountManagementListView.UseCompatibleStateImageBehavior = false;
            accountManagementListView.View = View.Details;
            // 
            // requestIDHeader
            // 
            requestIDHeader.Text = "    Request ID";
            requestIDHeader.TextAlign = HorizontalAlignment.Center;
            requestIDHeader.Width = 135;
            // 
            // customerIDHeader
            // 
            customerIDHeader.Text = "Customer ID";
            customerIDHeader.TextAlign = HorizontalAlignment.Center;
            customerIDHeader.Width = 130;
            // 
            // emailHeader
            // 
            emailHeader.Text = "Email";
            emailHeader.TextAlign = HorizontalAlignment.Center;
            emailHeader.Width = 280;
            // 
            // dateOfRequestHeader
            // 
            dateOfRequestHeader.Text = "Date of Request";
            dateOfRequestHeader.TextAlign = HorizontalAlignment.Center;
            dateOfRequestHeader.Width = 180;
            // 
            // requestStatusHeader
            // 
            requestStatusHeader.Text = "Request Status";
            requestStatusHeader.TextAlign = HorizontalAlignment.Center;
            requestStatusHeader.Width = 140;
            // 
            // AccountManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(homeScreenPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1039, 723);
            Name = "AccountManagementForm";
            Text = "HomeScreenForm";
            homeScreenPanel.ResumeLayout(false);
            homeScreenPanel.PerformLayout();
            accountListPanel.ResumeLayout(false);
            accountManagementPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label accountManagementLabel;
        private RoundedButton rejectButton;
        private RoundedButton approveButton;
        private Panel homeScreenPanel;
        private Label accountListLAbel;
        private RoundedPanel accountListPanel;
        private ListView accountListView;
        private ColumnHeader accountIDHeader;
        private ColumnHeader accountCustomerIDHeader;
        private ColumnHeader balanceHeader;
        private ColumnHeader accountStatusHeader;
        private RoundedButton closeAccountButton;
        private RoundedButton openAccountButton;
        private RoundedPanel accountManagementPanel;
        private ListView accountManagementListView;
        private ColumnHeader requestIDHeader;
        private ColumnHeader customerIDHeader;
        private ColumnHeader emailHeader;
        private ColumnHeader dateOfRequestHeader;
        private ColumnHeader requestStatusHeader;
    }
}
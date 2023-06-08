using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.TellerDashBoard
{
    partial class TransactionProcessingForm
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
            transactionProcessingLabel = new Label();
            transactionProcessingPanel = new RoundedPanel();
            transactionProcessingListView = new ListView();
            processIDHeader = new ColumnHeader();
            accountIDHeader = new ColumnHeader();
            currentBalanceHeader = new ColumnHeader();
            transactionTypeHeader = new ColumnHeader();
            amountHeader = new ColumnHeader();
            processDateHeader = new ColumnHeader();
            rejectButton = new RoundedButton();
            approveButton = new RoundedButton();
            transactionProcessingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // transactionProcessingLabel
            // 
            transactionProcessingLabel.AutoSize = true;
            transactionProcessingLabel.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            transactionProcessingLabel.ForeColor = Color.White;
            transactionProcessingLabel.Location = new Point(54, 27);
            transactionProcessingLabel.Name = "transactionProcessingLabel";
            transactionProcessingLabel.Size = new Size(449, 44);
            transactionProcessingLabel.TabIndex = 31;
            transactionProcessingLabel.Text = "Transaction Proccessing";
            // 
            // transactionProcessingPanel
            // 
            transactionProcessingPanel.BackColor = Color.Transparent;
            transactionProcessingPanel.BorderColor = Color.White;
            transactionProcessingPanel.Controls.Add(transactionProcessingListView);
            transactionProcessingPanel.CornerRadius = 10;
            transactionProcessingPanel.ForeColor = Color.Transparent;
            transactionProcessingPanel.Location = new Point(54, 87);
            transactionProcessingPanel.Name = "transactionProcessingPanel";
            transactionProcessingPanel.Size = new Size(901, 491);
            transactionProcessingPanel.TabIndex = 43;
            // 
            // transactionProcessingListView
            // 
            transactionProcessingListView.BackColor = Color.White;
            transactionProcessingListView.BorderStyle = BorderStyle.None;
            transactionProcessingListView.CheckBoxes = true;
            transactionProcessingListView.Columns.AddRange(new ColumnHeader[] { processIDHeader, accountIDHeader, currentBalanceHeader, transactionTypeHeader, amountHeader, processDateHeader });
            transactionProcessingListView.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionProcessingListView.ForeColor = Color.Black;
            transactionProcessingListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            transactionProcessingListView.Location = new Point(20, 14);
            transactionProcessingListView.MultiSelect = false;
            transactionProcessingListView.Name = "transactionProcessingListView";
            transactionProcessingListView.Scrollable = false;
            transactionProcessingListView.Size = new Size(861, 459);
            transactionProcessingListView.TabIndex = 41;
            transactionProcessingListView.UseCompatibleStateImageBehavior = false;
            transactionProcessingListView.View = View.Details;
            // 
            // processIDHeader
            // 
            processIDHeader.Text = "   Process ID";
            processIDHeader.TextAlign = HorizontalAlignment.Center;
            processIDHeader.Width = 110;
            // 
            // accountIDHeader
            // 
            accountIDHeader.Text = "Account ID";
            accountIDHeader.TextAlign = HorizontalAlignment.Center;
            accountIDHeader.Width = 150;
            // 
            // currentBalanceHeader
            // 
            currentBalanceHeader.Text = "Current Balance";
            currentBalanceHeader.TextAlign = HorizontalAlignment.Center;
            currentBalanceHeader.Width = 170;
            // 
            // transactionTypeHeader
            // 
            transactionTypeHeader.Text = "Transaction Type";
            transactionTypeHeader.TextAlign = HorizontalAlignment.Center;
            transactionTypeHeader.Width = 150;
            // 
            // amountHeader
            // 
            amountHeader.Text = "Amount";
            amountHeader.TextAlign = HorizontalAlignment.Center;
            amountHeader.Width = 152;
            // 
            // processDateHeader
            // 
            processDateHeader.Text = "Process Status";
            processDateHeader.TextAlign = HorizontalAlignment.Center;
            processDateHeader.Width = 130;
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
            rejectButton.Location = new Point(789, 611);
            rejectButton.Name = "rejectButton";
            rejectButton.OnHoverBorderColor = Color.Transparent;
            rejectButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            rejectButton.OnHoverTextColor = Color.WhiteSmoke;
            rejectButton.Size = new Size(166, 45);
            rejectButton.TabIndex = 46;
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
            approveButton.Location = new Point(600, 611);
            approveButton.Name = "approveButton";
            approveButton.OnHoverBorderColor = Color.Transparent;
            approveButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            approveButton.OnHoverTextColor = Color.WhiteSmoke;
            approveButton.Size = new Size(166, 45);
            approveButton.TabIndex = 45;
            approveButton.Text = "APPROVE";
            approveButton.TextColor = Color.WhiteSmoke;
            approveButton.UseVisualStyleBackColor = false;
            approveButton.Click += approveButton_Click;
            // 
            // TransactionProcessingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(rejectButton);
            Controls.Add(transactionProcessingPanel);
            Controls.Add(approveButton);
            Controls.Add(transactionProcessingLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionProcessingForm";
            Text = "UserProfileForm";
            transactionProcessingPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label transactionProcessingLabel;
        private RoundedPanel transactionProcessingPanel;
        private ListView transactionProcessingListView;
        private ColumnHeader processIDHeader;
        private ColumnHeader accountIDHeader;
        private ColumnHeader currentBalanceHeader;
        private ColumnHeader transactionTypeHeader;
        private ColumnHeader amountHeader;
        private RoundedButton rejectButton;
        private RoundedButton approveButton;
        private ColumnHeader processDateHeader;
    }
}
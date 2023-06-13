using BankingSystem.Utils.Components;

namespace BankingSystem.Forms.TellerDashBoard
{
    partial class UpdateRequestForm
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
            updateRequestLabel = new Label();
            updateRequestPanel = new RoundedPanel();
            updateRequestListView = new ListView();
            updateIDHeader = new ColumnHeader();
            accountIDHeader = new ColumnHeader();
            informationTypeHeader = new ColumnHeader();
            changedInformationHeader = new ColumnHeader();
            updateStatusHeader = new ColumnHeader();
            rejectButton = new RoundedButton();
            approveButton = new RoundedButton();
            updateRequestPanel.SuspendLayout();
            SuspendLayout();
            // 
            // updateRequestLabel
            // 
            updateRequestLabel.AutoSize = true;
            updateRequestLabel.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            updateRequestLabel.ForeColor = Color.White;
            updateRequestLabel.Location = new Point(54, 27);
            updateRequestLabel.Name = "updateRequestLabel";
            updateRequestLabel.Size = new Size(698, 44);
            updateRequestLabel.TabIndex = 31;
            updateRequestLabel.Text = "Customer Information Update Request";
            // 
            // updateRequestPanel
            // 
            updateRequestPanel.BackColor = Color.Transparent;
            updateRequestPanel.BorderColor = Color.White;
            updateRequestPanel.Controls.Add(updateRequestListView);
            updateRequestPanel.CornerRadius = 10;
            updateRequestPanel.ForeColor = Color.Transparent;
            updateRequestPanel.Location = new Point(54, 87);
            updateRequestPanel.Name = "updateRequestPanel";
            updateRequestPanel.Size = new Size(901, 491);
            updateRequestPanel.TabIndex = 43;
            // 
            // updateRequestListView
            // 
            updateRequestListView.BackColor = Color.White;
            updateRequestListView.BorderStyle = BorderStyle.None;
            updateRequestListView.CheckBoxes = true;
            updateRequestListView.Columns.AddRange(new ColumnHeader[] { updateIDHeader, accountIDHeader, informationTypeHeader, changedInformationHeader, updateStatusHeader });
            updateRequestListView.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateRequestListView.ForeColor = Color.Black;
            updateRequestListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            updateRequestListView.Location = new Point(20, 14);
            updateRequestListView.MultiSelect = false;
            updateRequestListView.Name = "updateRequestListView";
            updateRequestListView.Scrollable = false;
            updateRequestListView.Size = new Size(861, 459);
            updateRequestListView.TabIndex = 41;
            updateRequestListView.UseCompatibleStateImageBehavior = false;
            updateRequestListView.View = View.Details;
            // 
            // updateIDHeader
            // 
            updateIDHeader.Text = "   Update ID";
            updateIDHeader.TextAlign = HorizontalAlignment.Center;
            updateIDHeader.Width = 110;
            // 
            // accountIDHeader
            // 
            accountIDHeader.Text = "Account ID";
            accountIDHeader.TextAlign = HorizontalAlignment.Center;
            accountIDHeader.Width = 140;
            // 
            // informationTypeHeader
            // 
            informationTypeHeader.Text = "Information Type";
            informationTypeHeader.TextAlign = HorizontalAlignment.Center;
            informationTypeHeader.Width = 180;
            // 
            // changedInformationHeader
            // 
            changedInformationHeader.Text = "Changed Information";
            changedInformationHeader.TextAlign = HorizontalAlignment.Center;
            changedInformationHeader.Width = 280;
            // 
            // updateStatusHeader
            // 
            updateStatusHeader.Text = "Update Status";
            updateStatusHeader.TextAlign = HorizontalAlignment.Center;
            updateStatusHeader.Width = 152;
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
            // UpdateRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 46);
            ClientSize = new Size(1039, 723);
            Controls.Add(rejectButton);
            Controls.Add(updateRequestPanel);
            Controls.Add(approveButton);
            Controls.Add(updateRequestLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateRequestForm";
            Text = "UserProfileForm";
            updateRequestPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label updateRequestLabel;
        private RoundedPanel updateRequestPanel;
        private ListView updateRequestListView;
        private ColumnHeader updateIDHeader;
        private ColumnHeader accountIDHeader;
        private ColumnHeader informationTypeHeader;
        private ColumnHeader changedInformationHeader;
        private RoundedButton rejectButton;
        private RoundedButton approveButton;
        private ColumnHeader updateStatusHeader;
    }
}
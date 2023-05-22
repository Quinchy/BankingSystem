namespace BankingSystem.Forms
{
    partial class UserProfileForm
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
            SuspendLayout();
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1110, 723);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            ResumeLayout(false);
        }
    }
}
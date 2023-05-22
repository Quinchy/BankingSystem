namespace BankingSystem.Forms.DashBoard
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
            SuspendLayout();
            // 
            // HomeScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1110, 723);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeScreenForm";
            Text = "HomeScreenForm";
            ResumeLayout(false);
        }
    }
}
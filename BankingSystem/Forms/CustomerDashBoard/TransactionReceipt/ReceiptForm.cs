using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms.CustomerDashBoard.TransactionReceipt
{
    public partial class ReceiptForm : Form
    {
        public UserControl ReceiptControl { get; set; }
        public ReceiptForm()
        {
            InitializeComponent();
        }
        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            receiptPanel.Controls.Add(ReceiptControl);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                sfd.FileName = "Receipt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(receiptPanel.Width, receiptPanel.Height);
                    receiptPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(sfd.FileName);
                }
            }
        }
    }
}

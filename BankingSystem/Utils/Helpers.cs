using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Utils
{
    internal class Helpers
    {
        // This method changes the currently displayed Form in the panel of BaseForm.
        // It clear and add the new specified Form to that panel.
        public static void ChangeScreen(Control baseFormPanel, Form newForm)
        {
            if (baseFormPanel == null)
                throw new ArgumentNullException(nameof(baseFormPanel));

            if (newForm == null)
                throw new ArgumentNullException(nameof(newForm));

            baseFormPanel.Controls.Clear();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            baseFormPanel.Controls.Add(newForm);
            newForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement
{
     class Toggle
    {
        public static void BtnVisible(Button btn)
        {
            btn.Visible = !btn.Visible;
        }

        public static void BtnEnable(Button btn)
        {
          btn.Enabled = !btn.Enabled;
        }

        public static void TextBoxEn(TextBox textBox)
        {
            textBox.Enabled = !textBox.Enabled;
        }

        public static void TexttBoxVis(TextBox textBox)
        {
            textBox.Visible = !textBox.Visible;
        }

        public static void DataGridVis(DataGridView gridView)
        {
            gridView.Visible = !gridView.Visible;
        }

        public static void PanelVisible(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        public static void PanelEnable(Panel panel)
        {
            panel.Enabled = !panel.Enabled;
        }
    }
}

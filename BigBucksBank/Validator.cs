using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public static class Validator
    {
        private static string title = "ENTRY ERROR!";
        
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static bool IsPresent(TextBox tb)
        {
            if (tb.Text == "")
            {
                MessageBox.Show(tb.Tag + " is a required field.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;

            }
            return true;
        }
        public static bool IsComboBoxFull(ComboBox cb)
        {
            if (cb.SelectedItem == null)
            {
                
                MessageBox.Show(cb.Tag + " is a required field.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb.Focus();
                return false;
            }
            else
            {
                
                return true;
            }
        }
        public static bool IsDecimal(TextBox tb)
        {
            decimal num = 0m;
            if (Decimal.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " must be a decimal values.", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox tb, decimal min, decimal max)
        {
            decimal num = Convert.ToDecimal(tb.Text);
            if (num < min || num > max)
            {
                MessageBox.Show(tb.Tag + " must be between " + min + " and " + max + ". ", Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

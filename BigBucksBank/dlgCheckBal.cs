//Steven Cruickshank
//October 22 2017
//Assignement #2 for OOPL/C#
//
//BIGBUCKSBANK application. create an ATM application called BIGBUCKSBANK. include required 
//functions, and data. Calculations are performed, and when the user is finished, a list of 
//transactions are printed out as a digital "receipt", and the main screen reappears. 
//
//Five usernames have been provided, and loaded upon launch.
//ADMINISTRATOR ACCOUNT:
//USERNAME: admin
//PASSWORD: 1234
///////////
///////////
///////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class dlgCheckBal : Form
    {
        public dlgCheckBal()
        {
            InitializeComponent();
          
        }

        private void dlgCheckBal_FormLoad(object sender, FormClosedEventArgs e)
        {
        }

        //form load to send vals into list box
        private void dlgCheckBal_Load(object sender, EventArgs e)
        {
            cbAccounts.Items.Add(Record.recs[Record.userIndex].userCheckAcct + "   (Checking)");
            cbAccounts.Items.Add(Record.recs[Record.userIndex].userSavAcct + "   (Savings)");
        }

        //listener for when the index changes. a textbox updates with the correct values
        private void cbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string test = cbAccounts.SelectedItem.ToString();
            test = test.Substring(0, 10);
            textBoxBalance.Text = test;
            if (test == Record.recs[Record.userIndex].userCheckAcct)
            {
                textBoxBalance.Text = Record.recs[Record.userIndex].chkValue.ToString();
            }
            if (test == Record.recs[Record.userIndex].userSavAcct)
            {
                textBoxBalance.Text = Record.recs[Record.userIndex].savValue.ToString();
            }
        }

        private void cbAccounts_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //quit dialog
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to finish?", "WARNING",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

               this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
            
        }
        //key down listeners to register Enter  
        private void combo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxBalance.Focus();
                e.Handled = true;
            }
        }
        private void textBoxBal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
                e.Handled = true;
            }
        }
    }
}

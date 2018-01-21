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
    public partial class dlgWithdraw : Form
    {
        public string test; 

        public dlgWithdraw()
        {
            InitializeComponent();
        }
        //validators
        private bool IsValidData()
        {
            return Validator.IsDecimal(textBoxWithdrawal) &&
                Validator.IsWithinRange(textBoxWithdrawal, 1, 15001);
        }

        //series of loops validates data, before assigning it as a new object in the transList arraylist
        private void btOK_Click(object sender, EventArgs e)
        {
            if (IsValidData()) {
                if (cbAccounts.SelectedItem != null)
                {
                    if (test == Record.recs[Record.userIndex].userCheckAcct)
                    {
                        //textBoxDeposit.Text = Record.recs[Record.userIndex].chkValue.ToString();
                        decimal d;
                        if (decimal.TryParse(textBoxWithdrawal.Text, out d))
                        {
                            if ((Record.recs[Record.userIndex].chkValue - d) <= 0)
                            {
                                MessageBox.Show("Insufficient Funds");
                            }
                            else
                            {
                                Record.recs[Record.userIndex].chkValue -= d;
                                Record.transList.Add(new Record(Record.recs[Record.userIndex].userName,
                                                                Record.recs[Record.userIndex].userCheckAcct,
                                                                Record.recs[Record.userIndex].userSavAcct,
                                                                Record.recs[Record.userIndex].chkValue,
                                                                Record.recs[Record.userIndex].savValue,
                                                                d,
                                                                "WITHDRAWAL",
                                                                false,
                                                                false,
                                                                true));
                                MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBoxWithdrawal.Text = "";
                                cbAccounts.SelectedIndex = -1;
                            }
                        }
                    }
                    if (test == Record.recs[Record.userIndex].userSavAcct)
                    {
                        decimal d;
                        if (decimal.TryParse(textBoxWithdrawal.Text, out d))
                        {
                            if ((Record.recs[Record.userIndex].savValue - d) <= 0)
                            {
                                MessageBox.Show("Insufficient Funds", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Record.recs[Record.userIndex].savValue -= d;
                                Record.transList.Add(new Record(Record.recs[Record.userIndex].userName,
                                                                        Record.recs[Record.userIndex].userCheckAcct,
                                                                        Record.recs[Record.userIndex].userSavAcct,
                                                                        Record.recs[Record.userIndex].chkValue,
                                                                        Record.recs[Record.userIndex].savValue,
                                                                        d,
                                                                        "WITHDRAWAL",
                                                                        false,
                                                                        false,
                                                                        false));
                                MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBoxWithdrawal.Text = "";
                                cbAccounts.SelectedIndex = -1;
                            }
                        }
                    } 
            } else { MessageBox.Show("Choose an Account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
           
                
            }
        }

        private void cbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccounts.SelectedItem != null)
            {
                test = cbAccounts.SelectedItem.ToString();
                test = test.Substring(0, 10);
            }
        }
        //formload for combobox vals
        private void dlgWithdraw_FormLoad(object sender, EventArgs e)
        {
            cbAccounts.Items.Add(Record.recs[Record.userIndex].userCheckAcct + "   (Checking)");
            cbAccounts.Items.Add(Record.recs[Record.userIndex].userSavAcct + "   (Savings)");
        }
        //quit dialog
        private void btCancel_Click(object sender, EventArgs e)
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
        //clear button
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxWithdrawal.Text = "";
            cbAccounts.SelectedIndex = -1;
        }

        private void btOK_KeyDown(object sender, KeyEventArgs e)
        {

        }
        //keydown listeners for Enter key
        private void textBoxWithdrawal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btOK.Focus();
                e.Handled = true;
            }
        }

        private void cbAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxWithdrawal.Focus();
                e.Handled = true;
            }
        }
    }
}

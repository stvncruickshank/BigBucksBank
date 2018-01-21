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
    public partial class dlgDeposit : Form
    {
        public string test;

        public dlgDeposit()
        {
            InitializeComponent();
        }

        //validators
        private bool IsValidData()
        {
            return Validator.IsDecimal(textBoxDeposit) &&
                Validator.IsWithinRange(textBoxDeposit, 1, 15001);
        }

        //listener for when the account index changes
        private void cbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccounts.SelectedItem != null)
            {
                test = cbAccounts.SelectedItem.ToString();
                test = test.Substring(0, 10);
            }
        }
        //form loads combobox vals
        private void dlgForm_Load(object sender, EventArgs e)
        {
            cbAccounts.Items.Add(Record.recs[Record.userIndex].userCheckAcct + "   (Checking)");
            cbAccounts.Items.Add(Record.recs[Record.userIndex].userSavAcct + "   (Savings)");
        }

        private void btOK2_Click(object sender, EventArgs e)
        {
            //series of loops that validates the data, then sends it through as a new Record in an Arraylist
            if (IsValidData())
            {
                if (cbAccounts.SelectedItem != null)
                {
                    if (test == Record.recs[Record.userIndex].userCheckAcct)
                    {
                        //textBoxDeposit.Text = Record.recs[Record.userIndex].chkValue.ToString();
                        decimal d;
                        if (decimal.TryParse(textBoxDeposit.Text, out d))
                        {
                            Record.recs[Record.userIndex].chkValue += d;
                            Record.transList.Add(new Record(Record.recs[Record.userIndex].userName,
                                                                    Record.recs[Record.userIndex].userCheckAcct,
                                                                    Record.recs[Record.userIndex].userSavAcct,
                                                                    Record.recs[Record.userIndex].chkValue,
                                                                    Record.recs[Record.userIndex].savValue,
                                                                    d,
                                                                    "DEPOSIT",
                                                                    true,
                                                                    false,
                                                                    true));
                            //Transaction.transList.Add(t);
                            MessageBox.Show("Deposit Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxDeposit.Text = "";
                            cbAccounts.SelectedIndex = -1;

                        }

                    }

                    if (test == Record.recs[Record.userIndex].userSavAcct)
                    {

                        decimal d;
                        if (decimal.TryParse(textBoxDeposit.Text, out d))
                        {
                            Record.recs[Record.userIndex].savValue += d;
                            Record.transList.Add(new Record(Record.recs[Record.userIndex].userName,
                                                                    Record.recs[Record.userIndex].userCheckAcct,
                                                                    Record.recs[Record.userIndex].userSavAcct,
                                                                    Record.recs[Record.userIndex].chkValue,
                                                                    Record.recs[Record.userIndex].savValue,
                                                                    d,
                                                                    "DEPOSIT",
                                                                    true,
                                                                    false,
                                                                    false));
                            MessageBox.Show("Deposit Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxDeposit.Text = "";
                            cbAccounts.SelectedIndex = -1;

                        }

                    }
                } else
                {
                    MessageBox.Show("Select an account!");
                }
            }
        }
        //clear button
        private void btCancel2_Click(object sender, EventArgs e)
        {
            textBoxDeposit.Text = "";
            cbAccounts.SelectedIndex = -1;
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
        //key down listeners for Enter key
        private void textBoxDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btOK2.Focus();
                e.Handled = true;
            }
        }

        private void cbAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxDeposit.Focus();
                e.Handled = true;
            }
        }
    }
}

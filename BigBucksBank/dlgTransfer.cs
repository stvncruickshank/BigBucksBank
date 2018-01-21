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
    public partial class dlgTransfer : Form
    {
        //couple flags to tell which direction the transfer occurs
        string test;
        bool checkToSav = false;
        bool savToCheck = false;

        public dlgTransfer()
        {
            InitializeComponent();
        }
        //form load combobox vals
        private void dlgTransfer_Load(object sender, EventArgs e)
        {
            cbFrom.Items.Add(Record.recs[Record.userIndex].userCheckAcct + "   (Checking)");
            cbFrom.Items.Add(Record.recs[Record.userIndex].userSavAcct + "   (Savings)");
        }
        //series of loops for a index changed listener that will provide the appropriate target account,
        //based on what the user selects as their first account
        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbFrom.SelectedItem != null)
            {
                test = cbFrom.SelectedItem.ToString();
                test = test.Substring(0, 10);
            
                if (cbFrom.SelectedIndex > -1)
                {
                    cbTo.Enabled = true;
                    if (test == Record.recs[Record.userIndex].userCheckAcct)
                    {
                        cbFrom.Enabled = false;
                        cbTo.Items.Add(Record.recs[Record.userIndex].userSavAcct + "   (Savings)");

                    }
                    else if (test == Record.recs[Record.userIndex].userSavAcct)
                    {
                        cbFrom.Enabled = false;
                        cbTo.Items.Add(Record.recs[Record.userIndex].userCheckAcct + "   (Checking)");

                        //cbTo.Enabled = false;

                    }
                }
            }
        }

        //similar to above, provides appropriate output, and makes sure user cant switch their original
        //account selected, unless they hit the clear button
        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTo.SelectedItem != null)
            {
                test = cbTo.SelectedItem.ToString();
                test = test.Substring(0, 10);
                if (test == Record.recs[Record.userIndex].userCheckAcct)
                {
                    savToCheck = true;
                    textBoxTotal.Enabled = true;
                }
                else if (test == Record.recs[Record.userIndex].userSavAcct)
                {
                    checkToSav = true;
                    textBoxTotal.Enabled = true;

                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //validates the info, and sends it along into a new transaction record
                if (cbTo.SelectedItem != null && cbFrom.SelectedItem != null)
                {

                    if (checkToSav)
                    {

                        decimal d;
                        if (decimal.TryParse(textBoxTotal.Text, out d))
                        {
                            Record.recs[Record.userIndex].chkValue -= d;
                            Record.recs[Record.userIndex].savValue += d;
                            Record.transList.Add(new Record(Record.recs[Record.userIndex].userName,
                                                                Record.recs[Record.userIndex].userCheckAcct,
                                                                Record.recs[Record.userIndex].userSavAcct,
                                                                Record.recs[Record.userIndex].chkValue,
                                                                Record.recs[Record.userIndex].savValue,
                                                                d,
                                                                "TRANSFER",
                                                                false,
                                                                true,
                                                                false));
                        MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields
                        cbFrom.Enabled = true;
                        textBoxTotal.Enabled = false;
                        cbFrom.SelectedIndex = -1;
                        cbTo.SelectedIndex = -1;
                        cbTo.Items.Clear();
                        textBoxTotal.Text = "";
                    }
                    else { MessageBox.Show("Please enter a decimal value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                    else if (savToCheck)
                    {
                        decimal d;
                        if (decimal.TryParse(textBoxTotal.Text, out d))
                        {
                            Record.recs[Record.userIndex].chkValue += d;
                            Record.recs[Record.userIndex].savValue -= d;
                            Record.transList.Add(new Record(Record.recs[Record.userIndex].userName,
                                                                Record.recs[Record.userIndex].userCheckAcct,
                                                                Record.recs[Record.userIndex].userSavAcct,
                                                                Record.recs[Record.userIndex].chkValue,
                                                                Record.recs[Record.userIndex].savValue,
                                                                d,
                                                                "TRANSFER",
                                                                false,
                                                                true,
                                                                false));
                        MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields
                        cbFrom.Enabled = true;
                        textBoxTotal.Enabled = false;
                        cbFrom.SelectedIndex = -1;
                        cbTo.SelectedIndex = -1;
                        cbTo.Items.Clear();
                        textBoxTotal.Text = "";
                    }
                    else { MessageBox.Show("Please enter a decimal value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                } else
                {
                    MessageBox.Show("Choose your destinations!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            

        }
        //clear button
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cbFrom.Enabled = true;
            textBoxTotal.Enabled = false;
            cbFrom.SelectedIndex = -1;
            cbTo.SelectedIndex = -1;
            cbTo.Items.Clear();
            textBoxTotal.Text = "";

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
        private void textBoxTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOK.Focus();
                e.Handled = true;
            }
        }

        private void cbFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbTo.Focus();
                e.Handled = true;
            }
        }

        private void cbTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxTotal.Focus();
                e.Handled = true;
            }
        }
    }
}

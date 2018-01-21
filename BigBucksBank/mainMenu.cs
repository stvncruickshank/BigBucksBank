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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            //clear transList for a new user
            Record.transList.Clear();
            this.Focus();
        }
        private void radioButtons_Checked(object sender, EventArgs e)
        {
        }
        //quit dialog
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to exit! Are you sure?", "WARNING",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //typical quit dialog, except this one calls a receipt form to display the list of
                //user transactions
                Receipt dlg1 = new Receipt();
                dlg1.FormClosed += new FormClosedEventHandler(receipt_FormClosed);
                this.Close();
                dlg1.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
           
        }

        //series of listeners for the radio button group members
        private void rbWithdraw_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    
                    dlgWithdraw dlg = new dlgWithdraw();
                    dlg.FormClosed += new FormClosedEventHandler(withdraw_FormClosed);
                    this.Hide();
                    dlg.Show();
                }
            }
        }
        private void rbTransfer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    
                    dlgTransfer dlg = new dlgTransfer();
                    dlg.FormClosed += new FormClosedEventHandler(transfer_FormClosed);
                    this.Hide();
                    dlg.Show();
                }
            }
        }
        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    
                    dlgDeposit dlg = new dlgDeposit();
                    dlg.FormClosed += new FormClosedEventHandler(deposit_FormClosed);
                    this.Hide();
                    dlg.Show();
                }
            }
           
        }

        private void rbCheckBal_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    
                    dlgCheckBal dlg = new dlgCheckBal();
                    dlg.FormClosed += new FormClosedEventHandler(checkBal_FormClosed);
                    this.Hide();
                    dlg.Show();
                }
            }
        }
        
        private void rbCheckBal_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        //series of FormClosed listeners so when the child form closes, this form will Reappear
        void withdraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void transfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void deposit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void checkBal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
           // this.Close();
        }
    }
}

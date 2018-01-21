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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            
            bool isUserName = false; 
            bool isPassWord = false; 
            
           
            //validators
            if (IsValidData())
            {
                for (int x = 0; x < Record.recs.Count(); x++)
                {
                    //if username matches the textbox, save the index val, and set flag to true
                    if (Record.recs[x].userName == textBoxUserName.Text)
                    {
                        isUserName = true;
                        Record.userIndex = x;
                        break;
                    }
                }
                for (int y = 0; y < Record.recs.Count(); y++)
                {
                    //if password matches the username of the same index, set PW flag to true
                    if (Record.recs[Record.userIndex].passWord == textBoxPW.Text)
                    {
                        isPassWord = true;
                        //Record.userIndex = y;
                        break;
                    }
                }

                //if the login count is more than 2, you'll get locked out
                if (Record.warningCount < 2)
                {
                    //makes sure the username and passord have previously been found
                    //if so, lets the user in
                    if (isUserName && isPassWord)
                    {

                        MessageBox.Show("Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMessenger.Text = "";
                        mainMenu menu = new mainMenu();
                        
                        menu.FormClosed += new FormClosedEventHandler(menu_FormClosed);
                        this.Hide();
                        menu.ShowDialog();
                    }
                    //if not, user can try again until they get locked out
                    else
                    {
                        Record.warningCount++;
                        MessageBox.Show("Match not found. Try Again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    //if the user is an Administrator, the account settings will be reset once anyone is locked out
                    if (isUserName && isPassWord && Record.recs[Record.userIndex].isAdmin)
                    {
                        txtMessenger.Text = "Account Settings have been reset. Please log in";
                        textBoxUserName.Text = "";
                        textBoxPW.Text = "";
                        Record.warningCount = 0;

                    }
                    else
                    //else the user will continue to be locked out
                    {
                        textBoxUserName.Text = "";
                        textBoxPW.Text = "";
                        txtMessenger.Text = "TOO MANY ATTEMPTS. YOUR ACCOUNT IS NOW LOCKED OUT. CONTACT AN ADMINISTRATOR.";
                    }
                }

            }
        }

        private void frmLogIn_FormLoad(object sender, FormClosedEventArgs e)
        {
        
        }
        //series of formclosed listeners that will cause the MainMenu to reappear after
        //the child form is closed
        void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            textBoxUserName.Text = "";
            textBoxPW.Text = "";
        }
        void receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            textBoxUserName.Text = "";
            textBoxPW.Text = "";
        }
        //validators
        private bool IsValidData()
        {
            return Validator.IsPresent(textBoxUserName) &&
                Validator.IsPresent(textBoxPW);
        }
        //quit dialog
        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to exit! Are you sure?", "WARNING", 
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
        //key down listeners for user hits Enter
        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPW.Focus();
                e.Handled = true;
            }
        }
        private void textBoxPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogIn.Focus();
                e.Handled = true;
            }
        }

    }
}

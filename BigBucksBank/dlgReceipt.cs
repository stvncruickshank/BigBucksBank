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
    public partial class Receipt : Form
    {
        public static decimal totalTrans = 0m;

        public Receipt()
        {
            InitializeComponent();
        }

        //Receipt will formload the appropriate data based on the TransList array list.
        private void dlgReceipt_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < Record.transList.Count(); x++)
            {
                listBoxReceipt.Items.Add("          " + Record.transList[x].userName);
                listBoxReceipt.Items.Add("      " + Record.transList[x].description);
                listBoxReceipt.Items.Add("   Trans amt: $" + Record.transList[x].transAmount);
                if (Record.transList[x].isDeposit == true && Record.transList[x].isTransfer == false)
                {
                    if (Record.transList[x].isCheckingAcct == true && Record.transList[x].isTransfer == false)
                    {
                        listBoxReceipt.Items.Add("      Check Acct: ");
                        string temp = Record.transList[x].userCheckAcct.ToString();
                        temp = temp.Remove(0, 6).Insert(0, "******");
                        listBoxReceipt.Items.Add("      " + temp);
                        listBoxReceipt.Items.Add("     New Chk Val: ");
                        listBoxReceipt.Items.Add("         $" + Record.transList[x].chkValue);
                        totalTrans += Record.transList[x].transAmount;
                    }
                    else
                    {
                        listBoxReceipt.Items.Add("      Sav Acct: ");
                        string temp = Record.transList[x].userSavAcct.ToString();
                        temp = temp.Remove(0, 6).Insert(0, "******");
                        listBoxReceipt.Items.Add("      " + temp);
                        listBoxReceipt.Items.Add("     New Sav Val: ");
                        listBoxReceipt.Items.Add("         $" + Record.transList[x].savValue);
                        totalTrans += Record.transList[x].transAmount;
                    }
                
                }
                if (Record.transList[x].isDeposit == false && Record.transList[x].isTransfer == false)
                {
                    if (Record.transList[x].isCheckingAcct == true)
                    {
                        listBoxReceipt.Items.Add("     Check Acct: ");
                        string temp = Record.transList[x].userCheckAcct.ToString();
                        temp = temp.Remove(0, 6).Insert(0, "******");
                        listBoxReceipt.Items.Add("      " + temp);
                        listBoxReceipt.Items.Add("     New Chk Val: ");  
                        listBoxReceipt.Items.Add("         $" + Record.transList[x].chkValue);

                        totalTrans -= Record.transList[x].transAmount;
                    }
                    else
                    {
                        listBoxReceipt.Items.Add("     Sav Acct: ");
                        string temp = Record.transList[x].userSavAcct.ToString();
                        temp = temp.Remove(0, 6).Insert(0, "******");
                        listBoxReceipt.Items.Add("      " + temp);
                            
                        listBoxReceipt.Items.Add("     New Sav Val: "); 
                        listBoxReceipt.Items.Add("         $" + Record.transList[x].savValue);
                        totalTrans -= Record.transList[x].transAmount;
                    }
                }
                if (Record.transList[x].isTransfer == true && Record.transList[x].isDeposit == false)
               {
                    listBoxReceipt.Items.Add("    New Chk Val: ");

                    listBoxReceipt.Items.Add("         $" + Record.transList[x].chkValue);
                    listBoxReceipt.Items.Add("    New Sav Val: ");
                    listBoxReceipt.Items.Add("         $" + Record.transList[x].savValue);
                }
                
              listBoxReceipt.Items.Add("\n");

            }
        }
        //exit button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

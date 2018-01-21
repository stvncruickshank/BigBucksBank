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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{


    public class Record
    {
        
        public static int userIndex = 0;
        //array list used to store user transactions
        public static List<Record> transList = new List<Record>();

        //prepared list of users, as requested
        public static Record [] recs = { new Record("msmith12", "5643", "5362848211", "0584736252", 0, 3000, 5000, false),
                                               new Record("admin", "1234", "4876528596", "1582569548", 0, 7500, 10000, true),
                                               new Record("b7thomas", "6239", "4811247891", "9652500124", 0, 800, 3000, false),
                                               new Record("big9bucks", "1932", "0185682144", "4258501484", 0, 2500, 5000, false),
                                               new Record("lisaz324", "2348", "8563215697", "8423540366", 0, 1000, 3500, false)};

        //member variables
        public static bool isUserNameTrue = false;
        public static bool isPassWordTrue = false;
        public static int warningCount = 0;
        public bool isAdmin = false;
        public bool isDeposit = false;
        public bool isTransfer = false;
        public bool isCheckingAcct = false;
        public string userName;
       
        public string passWord;
        public string userCheckAcct;
        public String userSavAcct;
        public decimal startBal = 0m;
        public decimal chkValue = 0m;
        public decimal savValue = 0m;
        public string description;
        public decimal transAmount = 0m;
       
        //public default constructor
        Record() { }

        //constructor for a new user Record
        public Record(string uname, string pw, string ca, string sa, decimal bal, decimal chk, decimal sav, bool admin) 
        {
            userName = uname;
            passWord = pw;
            userCheckAcct = ca;
            userSavAcct = sa;
            startBal = bal;
            chkValue = chk;
            savValue = sav;
            isAdmin = admin;
        }

        //constructor for transaction list constructor
        public Record(string id, string ca, string sa, decimal camt, decimal samt, decimal transamt, string desc, bool isDepo, bool isTran, bool ischk)
        {
            userName = id.ToString();
            userCheckAcct = ca.ToString();
            userSavAcct = sa.ToString();
            chkValue = Convert.ToDecimal(camt);
            savValue = Convert.ToDecimal(samt);
            transAmount = transamt;
            description = desc;
            isDeposit = isDepo;
            isTransfer = isTran;
            isCheckingAcct = ischk;
        }
        //few accessors/mutators
        public void setAdmin(bool b)
        {
            this.isAdmin = true;
        }
        public bool getIsAdmin(Record r)
        {
            return this.isAdmin;
        }
        public void setStartBal(decimal b)
        {
            startBal = b;
        }
        public decimal getStartBal()
        {
            return startBal;
        }
       

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Customer
    {
        public string fname;
        public string lname;
        public string phone;
        public int customernumber;
        public string baddress;
        public string saddress;
        public string email;
        public int balance;

        // Generates customer number
        public int cusnum()
        {
            Random rnd = new Random();
            int cus = rnd.Next(100, 130000);
            //Random random = new Convert.ToInt32(Random());
            //customernumber = random.Next();
            return cus;
        }

        public Customer(string aFname, string aLname, string aphone,  string aBaddress , string aSaddress, string aemail, int abalance)
        {

            customernumber = cusnum();
            fname = aFname;
            lname = aLname;
            phone = aphone;
            baddress = aBaddress;
            saddress = aSaddress;
            email = aemail;
            balance = abalance;


        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    public class Customer
    {
        //private string fname;
        //private string lname;
        //private string phone;
        //private int customernumber;
        //private string baddress;
        //private string saddress;
        //private string email;
        //private int balance;

        public string FName { get; set; }
        public string LName { get; set; }
        public int CustomerNumber { get; set; }
        public string Phone { get; set; }
        public string BAddress { get; set; }
        public string SAddress { get; set; }
        public string Email { get; set; }
        public int Balance { get; set; }
        // Generates customer number
        public int cusnum()
        {
            Random rnd = new Random();
            int cus = rnd.Next(100, 130000);
            //Random random = new Convert.ToInt32(Random());
            //customernumber = random.Next();
            return cus;
        }

        public Customer()
        {

        }

        public Customer(string aFname, string aLname, string aphone, string aBaddress, string aSaddress, string aemail, int abalance)
        {

            CustomerNumber = cusnum();
            FName = aFname;
            LName = aLname;
            Phone = aphone;
            BAddress = aBaddress;
            SAddress = aSaddress;
            Email = aemail;
            Balance = abalance;


        }


    }
}

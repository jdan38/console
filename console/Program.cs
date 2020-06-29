using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = 10;
            int choice = 10;
            while (num != 0)
            {

                try
                {
                    Console.Write("Enter your selection: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number 1 thur 6");
                }
                switch (choice) 
                {
                    case 1:
                        
                        Console.WriteLine("Add budget");
                        break;
                    case 2:
                        Customer person = new Customer("jerrid", "daniels", "3017752259", "123 fake street", "same", "jdaviation@gmail.com", 0);
                        Console.WriteLine(person);
                        Console.WriteLine("Add Customer");
                        break;
                    case 3:
                        Item thing = new Item("apple", "fruit", 1, "lbs", "golden delisious", 1, 1);
                        Console.WriteLine(thing.iname);
                        break;
                    case 4:
                        Console.WriteLine("Delete iteme");
                        break;
                    case 5:
                        Console.WriteLine("Print shopping list");
                        break;
                    case 0:
                        Console.WriteLine("Have a nice day goodbye!");
                        num = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;




                }


                Console.ReadLine(); 
            }
            
        }
    }
}

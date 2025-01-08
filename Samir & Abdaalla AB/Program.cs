using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samir___Abdaalla_AB
{
    internal class Program
    {
        static List<Booking> _list = new List<Booking>();
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Add Booking ");
                Console.WriteLine("2. List all Booking");
                Console.WriteLine("3. ta bort bokningar");
                Console.WriteLine("4- Ändra Booking");
                Console.WriteLine("5 End");
                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                    PersonManager.AddBooking(_list);
                        break;
                    case "2":
                        PersonManager.ListBooking(_list);
                        break; 
                    case "3":

                        break;
                        case "4":
                         break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                       
                }
            }
        }
    }
}

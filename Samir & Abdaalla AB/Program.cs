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
                Console.WriteLine("2. List all Bookings");
                Console.WriteLine("3. Remove Booking");
                Console.WriteLine("4. Update Booking");
                Console.WriteLine("5. Search Available Times");
                Console.WriteLine("6. View Today's Bookings");
                Console.WriteLine("7 SearchBookingsByService");
                Console.WriteLine("8.SearchByCarRegnr");
                Console.WriteLine("9.Price");
                Console.WriteLine("10. End");
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
                       availability.Remove(_list);
                        break;
                    case "4":
                        availability.UpdateBooking(_list);
                        break;
                    case "5":
                        availability.SearchAvailableTimes(_list);
                        break;
                    case "6":
                        availability.ViewTodaysBookings(_list);
                        break;
                    case "7":
                     availability.SearchBookingsByService(_list);

                        break;
                    case "8":
                        availability.SearchByCarRegnr(_list);
                        break;
                    case "9":
                        PersonManager.ServicePrice(_list);
                        break;
                    case "10":
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



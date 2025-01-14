using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samir___Abdaalla_AB
{
    internal class availability
    {
        public static void Remove(List<Booking> Bookings)
        {
            Console.WriteLine("Ange kundens namn:");
            string name = Console.ReadLine();

            Console.WriteLine($"ändringen lyckades! {name}");

            var bookingsToRemove = Bookings.Where(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
            if (bookingsToRemove.Any())
            {
                foreach (var booking in bookingsToRemove)
                {
                    Bookings.Remove(booking);
                }
                Console.WriteLine("Bokning(ar) borttagen.");
            }
            else
            {
                Console.WriteLine("Bokning hittades inte.");
            }
        }

        public static void UpdateBooking(List<Booking> Bookings)
        {
            Console.WriteLine("Ange kundens namn för att ändra bokning:");
            string name = Console.ReadLine();

            var bookingToUpdate = Bookings.FirstOrDefault(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (bookingToUpdate != null)
            {
                Console.WriteLine("Ange ny bokningstid (t.ex. 2025-01-07 14:00):");
                string newBookingTimeString = Console.ReadLine();
                DateTime newBookingTime;

                if (!DateTime.TryParse(newBookingTimeString, out newBookingTime))
                {
                    Console.WriteLine("Ogiltig tid. Försök igen.");
                    return;
                }

                bookingToUpdate.BookingTime = newBookingTime;

                Console.WriteLine("Bokning uppdaterad.");
            }
            else
            {
                Console.WriteLine("Bokning hittades inte.");
            }
        }
        public static void SearchAvailableTimes(List<Booking> bookings)
        {
            Console.WriteLine("Enter date to search for available times (e.g., 2025-01-07):");
            string dateString = Console.ReadLine();
            DateTime date;

            if (!DateTime.TryParse(dateString, out date))
            {
                Console.WriteLine("Invalid date. Try again.");
                return;
            }

            var availableTimes = Enumerable.Range(8, 10).Select(hour => new DateTime(date.Year, date.Month, date.Day, hour, 0, 0))
                                           .Where(time => !bookings.Any(b => b.BookingTime == time))
                                           .ToList();

            if (availableTimes.Any())
            {
                Console.WriteLine("Available times:");
                foreach (var time in availableTimes)
                {
                    Console.WriteLine(time.ToString("HH:mm"));
                }
            }
            else
            {
                Console.WriteLine("No available times for the selected date.");
            }
        }

        public static void ViewTodaysBookings(List<Booking> bookings)
        {
            var today = DateTime.Today;
            var todaysBookings = bookings.Where(b => b.BookingTime.Date == today).ToList();

            if (todaysBookings.Any())
            {
                Console.WriteLine("Today's bookings:");
                foreach (var booking in todaysBookings)
                {
                    Console.WriteLine(booking);
                }
            }
            else
            {
                Console.WriteLine("No bookings for today.");
            }

        }
        public static void SearchByCarRegnr(List<Booking> bookings)
        {
            Console.WriteLine("Ange bilens registreringsnummer:");
            string carRegnrString = Console.ReadLine();
            CarRegnr carRegnr;

            if (!Enum.TryParse(carRegnrString, out carRegnr))
            {
                Console.WriteLine("Ogiltigt registreringsnummer. Försök igen.");
                return;
            }

            var bookingsByCarRegnr = bookings.Where(b => b.CarRegnr == carRegnr).ToList();

            if (bookingsByCarRegnr.Any())
            {
                Console.WriteLine("Bokningar för bilens registreringsnummer:");
                foreach (var booking in bookingsByCarRegnr)
                {
                    Console.WriteLine(booking);
                }
            }
            else
            {
                Console.WriteLine("Inga bokningar hittades för det angivna registreringsnumret.");
            }
        }
        public static void SearchBookingsByService(List<Booking> Bookings)
        {
            Console.WriteLine("Välj tjänst att söka efter\n1. Hjulbyte\n2. Däckhotell\n3. Hjulinställning\n4. Däckbyte ");
            string serviceTypeInput = Console.ReadLine();
            ServiceType serviceType;
            if (!Enum.TryParse(serviceTypeInput, out serviceType))
            {
                Console.WriteLine("Ogiltigt val, vänligen välj ett av de angivna alternativen.");
                return;
            }

            var bookingsByService = Bookings.Where(b => b.ServiceType == serviceType).ToList();

            if (bookingsByService.Any())
            {
                Console.WriteLine($"Bokningar för tjänsten {serviceType}:");
                foreach (var booking in bookingsByService)
                {
                    Console.WriteLine(booking.ToString());
                }
            }
            else
            {
                Console.WriteLine($"Inga bokningar hittades för tjänsten {serviceType}.");
            }

        }
    }
}

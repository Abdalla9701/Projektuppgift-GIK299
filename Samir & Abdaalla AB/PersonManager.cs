using Samir___Abdaalla_AB;
using System;
using System.Collections.Generic;

namespace Samir___Abdaalla_AB
{
    internal class PersonManager
    {
        private static CarRegnr carRegnr;

        public static void AddBooking(List<Booking> Bookings)
        {
            try
            {
                string NameInput;
              

                Console.WriteLine("Skriv ditt Namn:");
                NameInput = Console.ReadLine();
                Console.WriteLine("Skriv bilens registreringsnummer");
                string CarRegnrName = Console.ReadLine();

                ServiceType serviceType;
                string serviceTypeInput;
                do
                {
                    Console.WriteLine("Välj tjänst\n1. Hjulbyte\n2. Däckhotell\n3. Hjulinställning\n4. Däckbyte ");
                    serviceTypeInput = Console.ReadLine();
                    if (!Enum.TryParse(serviceTypeInput, out serviceType))
                    {
                        Console.WriteLine("Ogiltigt val, vänligen välj ett av de angivna alternativen.");
                    }
                } while (!Enum.TryParse(serviceTypeInput, out serviceType));
                Console.WriteLine(serviceType);

                DateTime bookingTime;
                string bookingTimeString;
                do
                {
                   Console.WriteLine("Skriv bokningstid (t.ex. 2025-01-07 14:00):");
                    bookingTimeString = Console.ReadLine();
                    if (!DateTime.TryParse(bookingTimeString, out bookingTime))
                    {
                        Console.WriteLine("Ogiltig tid. Försök igen.");
                        return;
                    }
                } while (!DateTime.TryParse(bookingTimeString, out bookingTime));
                Console.WriteLine(bookingTime);

                Booking booking = new Booking(NameInput, CarRegnrName, serviceType, bookingTime);
                Bookings.Add(booking);
                Console.WriteLine("Bokningen har lagts till.");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel har inträffat: {ex.Message}");
            }
        }
        public static void ServicePrice(List<Booking> _list)
        {
         Console.WriteLine("1:Hjulbyte: 700kr\n2:Däckhotell: 1500kr\n3:Hjulinställning: 600kr\n4:Däckbyte: 500kr");
         
        }



        public static void ListBooking(List<Booking> Bookings)
        {
            if (Bookings.Count == 0)
            {
                Console.WriteLine("Inga personer har lagts till ännu.");
                return;
            }
            foreach (var booking in Bookings)
            {
                Console.WriteLine(booking.ToString());
            }
        }

    }
}
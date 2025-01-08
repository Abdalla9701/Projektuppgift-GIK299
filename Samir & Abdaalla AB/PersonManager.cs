using System;
using System.Collections.Generic;

namespace Samir___Abdaalla_AB
{
    internal class PersonManager
    {
        public static void AddBooking(List<Booking> Bookings)
        {
            try
            {
                string NameInput;

                Console.WriteLine("Skriv ditt Namn:");
                NameInput = Console.ReadLine();
                Console.WriteLine("Skriv bilens registreringsnummer:");
                string CarRegnrName = Console.ReadLine();

                CarRegnr carRegnr;
                if (!Enum.TryParse(CarRegnrName, out carRegnr))
                {
                    Console.WriteLine("Ogiltigt registreringsnummer.");
                    return;
                }

                ServiceType serviceType;
                string serviceTypeInput;
                do
                {
                    Console.WriteLine("Välj tjänst\n1. Hjulbyte\n2. Däckhotell\n3. Hjulinställning\n4. Däckbyte\nAnge nummer (1-4): ");
                    serviceTypeInput = Console.ReadLine();
                    if (!Enum.TryParse(serviceTypeInput, out serviceType))
                    {
                        Console.WriteLine("Ogiltigt val, vänligen välj ett av de angivna alternativen.");
                    }
                } while (!Enum.TryParse(serviceTypeInput, out serviceType));
                Console.WriteLine(serviceType);

                DateTime bookingTime;
                Console.WriteLine("Skriv bokningstid (t.ex. 2025-01-07 14:00):");
                string bookingTimeString = Console.ReadLine();
                if (!DateTime.TryParse(bookingTimeString, out bookingTime))
                {
                    Console.WriteLine("Ogiltig tid. Försök igen.");
                    return;
                }

                var newBooking = new Booking(NameInput, carRegnr, serviceType, new Time_available());
                Bookings.Add(newBooking);
                Console.WriteLine("Bokning tillagd.");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel har inträffat: {ex.Message}");
            }
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
                Console.WriteLine(booking.ToString,());
            }
        }
    }
}
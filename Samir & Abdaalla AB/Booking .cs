using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samir___Abdaalla_AB
{
    internal class Booking
    {
        private string nameInput;
        private DateTime now;
        private Time_available time_available;
        private ServiceType serviceType;

        public string Name { get; set; }
        public CarRegnr CarRegnr { get; set; }
        public DateTime BookingTime { get; set; }
        public string ServiceType { get; set; }
        public Time_available AvailableTime { get; set; }


        public Booking(string name, CarRegnr carRegnr, DateTime bookingTime, string serviceType, Time_available availableTime)
        {
            Name = Name;
            CarRegnr = CarRegnr;
            BookingTime = BookingTime;
            ServiceType = ServiceType;
            AvailableTime = availableTime;
        }

        public Booking(string nameInput, CarRegnr carRegnr, DateTime now, ServiceType serviceType, Time_available time_available)
        {
            this.nameInput = nameInput;
            CarRegnr = carRegnr;
            this.now = now;
            this.time_available = time_available;
        }

        public Booking(string nameInput, CarRegnr carRegnr, ServiceType serviceType, Time_available time_available)
        {
            this.nameInput = nameInput;
            CarRegnr = carRegnr;
            this.serviceType = serviceType;
            this.time_available = time_available;
        }

        public override string ToString()
        {
            return $"{Name}\nBilregnr:{CarRegnr}\nBookingTime: {BookingTime.ToShortTimeString()}";

        }
    }
}

using System;
using System.Diagnostics;

namespace Samir___Abdaalla_AB
{
    internal class Booking
    {
        private string nameInput;
        private string carRegnrName;
        private decimal price;

        public string Name { get; set; }
        public CarRegnr CarRegnr { get; set; }
        public DateTime BookingTime { get; set; }
        public ServiceType ServiceType { get; set; }
        public Time_available AvailableTime { get; set; }
        public decimal Price { get; set; }

        public Booking(string name, CarRegnr carRegnr, DateTime bookingTime, ServiceType serviceType, Time_available availableTime)
        {
            Name = name;
            CarRegnr = carRegnr;
            BookingTime = bookingTime;
            ServiceType = serviceType;
            AvailableTime = availableTime;
            Price = ServicePrice.GetPrice(serviceType);
        }

        public Booking(string nameInput, string carRegnrName, ServiceType serviceType, DateTime bookingTime)
        {
            this.nameInput = nameInput;
            this.carRegnrName = carRegnrName;
            ServiceType = serviceType;
            BookingTime = bookingTime;
            Price = ServicePrice.GetPrice(serviceType);
        }

      

        public override string ToString()
        {
            return $"Name: {nameInput}\nBilregnr: {CarRegnr}\nBookingTime: {BookingTime}\nServiceType: {ServiceType}: Price: {Price}:";
        }
    }
}

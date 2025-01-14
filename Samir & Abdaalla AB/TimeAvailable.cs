using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Samir___Abdaalla_AB
{
    internal class Time_available
    {
        public int TidId { get; set; }
        public DateTime Time { get; set; }
        public DateTime Datum { get; set; }
        public TimeSpan Tid { get; set; }
        public bool IsBooked { get; set; }
        public string ServiceType { get; set; }

        public void SetAvailableTime(int tidId, DateTime datum, TimeSpan tid, bool isBooked, string serviceType)
        {
            TidId = tidId;
            Datum = datum;
            Tid = tid;
            IsBooked = isBooked;
            ServiceType = serviceType;
            var tillgängligTid = new Time_available
            {
                TidId = tidId,
                Datum = datum,
                Tid = tid,
                IsBooked = isBooked,
                ServiceType = serviceType
            };
        }

    }
}


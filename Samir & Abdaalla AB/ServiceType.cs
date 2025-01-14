using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samir___Abdaalla_AB
{
    public enum ServiceType
    {
        Hjulbyte,
        Däckhotell,
        Hjulinställning,
        Däckbyte
    }
    public enum CarRegnr
    {
        bilregnr,
    }
    public static class ServicePrice
    {
       private static readonly Dictionary<ServiceType, decimal> prices = new Dictionary<ServiceType, decimal>
        {
            { ServiceType.Hjulbyte, 700 },
            { ServiceType.Däckhotell, 1500 },
            { ServiceType.Hjulinställning, 600 },
            { ServiceType.Däckbyte, 500 }
        };

        public static decimal GetPrice(ServiceType serviceType)
        {
            return prices[serviceType];
        }
      }
    }



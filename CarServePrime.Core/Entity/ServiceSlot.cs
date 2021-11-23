using System;
using System.Linq;
using System.Collections.Generic;

namespace CarServePrime.Core.Entity
{
    public class ServiceSlot
    {
        public DateTime SlotDateTime { get; set; }
        public bool available()
        {
            ServiceCharter serviceCharter = new ServiceCharter();
            List<Service> currentServiceCharter = serviceCharter.BookedServiceSlots;
            return currentServiceCharter.Any(x => x.ServiceAppointment == SlotDateTime && SlotDateTime != DateTime.MinValue);
        }

        public DateTime availableNext()
        {
            return DateTime.Today.AddDays(12).AddHours(14).AddMinutes(30);
        }
    }
}
using System;
using System.Collections.Generic;

namespace CarServePrime.Core.Entity
{
    public class ServiceCharter
    {
        //Todo: replace Datetime collection with custom ServiceSlot collection.
        public ServiceCharter()
        {
            this.UpcomingServiceSlots=new List<DateTime>
            {
               DateTime.Today.AddHours(10), DateTime.Today.AddHours(10).AddMinutes(30),
               DateTime.Today.AddHours(11), DateTime.Today.AddHours(10).AddMinutes(30),
               DateTime.Today.AddHours(12), DateTime.Today.AddHours(10).AddMinutes(30),
               DateTime.Today.AddHours(13), DateTime.Today.AddHours(10).AddMinutes(30),
               DateTime.Today.AddHours(14),
               DateTime.Today.AddDays(1).AddHours(10), DateTime.Today.AddDays(1).AddHours(10).AddMinutes(30),
               DateTime.Today.AddDays(1).AddHours(11), DateTime.Today.AddDays(1).AddHours(11).AddMinutes(30),
               DateTime.Today.AddDays(1).AddHours(12), DateTime.Today.AddDays(1).AddHours(12).AddMinutes(30),
               DateTime.Today.AddDays(1).AddHours(13), DateTime.Today.AddDays(1).AddHours(13).AddMinutes(30),
               DateTime.Today.AddDays(1).AddHours(14),
               DateTime.Today.AddDays(2).AddHours(10), DateTime.Today.AddDays(2).AddHours(10).AddMinutes(30),
               DateTime.Today.AddDays(2).AddHours(11), DateTime.Today.AddDays(2).AddHours(11).AddMinutes(30),
               DateTime.Today.AddDays(2).AddHours(12), DateTime.Today.AddDays(2).AddHours(12).AddMinutes(30),
               DateTime.Today.AddDays(2).AddHours(13), DateTime.Today.AddDays(2).AddHours(13).AddMinutes(30),
               DateTime.Today.AddDays(2).AddHours(14),
               DateTime.Today.AddDays(3).AddHours(10), DateTime.Today.AddDays(3).AddHours(10).AddMinutes(30),
               DateTime.Today.AddDays(3).AddHours(11), DateTime.Today.AddDays(3).AddHours(11).AddMinutes(30),
               DateTime.Today.AddDays(3).AddHours(12), DateTime.Today.AddDays(3).AddHours(12).AddMinutes(30),
               DateTime.Today.AddDays(3).AddHours(13), DateTime.Today.AddDays(3).AddHours(13).AddMinutes(30),
               DateTime.Today.AddDays(3).AddHours(14),
               DateTime.Today.AddDays(4).AddHours(10), DateTime.Today.AddDays(4).AddHours(10).AddMinutes(30),
               DateTime.Today.AddDays(4).AddHours(11), DateTime.Today.AddDays(4).AddHours(11).AddMinutes(30),
               DateTime.Today.AddDays(4).AddHours(12), DateTime.Today.AddDays(4).AddHours(12).AddMinutes(30),
               DateTime.Today.AddDays(4).AddHours(13), DateTime.Today.AddDays(4).AddHours(13).AddMinutes(30),
               DateTime.Today.AddDays(4).AddHours(14)
            };
            this.BookedServiceSlots=new List<Service>
            {

               new Service{ ServiceAppointment = UpcomingServiceSlots[0], CarRegistration = "KL08CN7897" }, new Service{ ServiceAppointment = UpcomingServiceSlots[1], CarRegistration = "MP04TY2343" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[2], CarRegistration = "MP05HU8768" },new  Service{ ServiceAppointment = UpcomingServiceSlots[3], CarRegistration = "MH05YG9088" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[4], CarRegistration = "DD90FG8900" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[6], CarRegistration = "KA08CN7897" },new  Service{ ServiceAppointment = UpcomingServiceSlots[7], CarRegistration = "JK08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[9], CarRegistration = "OR08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[10], CarRegistration = "WB08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[12], CarRegistration = "UP08CN7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[13], CarRegistration = "JH08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[15], CarRegistration = "HR08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[16], CarRegistration = "HP08CN7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[17], CarRegistration = "GA08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[18], CarRegistration = "GJ08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[21], CarRegistration = "TS08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[22], CarRegistration = "AR08CN7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[23], CarRegistration = "NL08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[24], CarRegistration = "TR08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[26], CarRegistration = "SK08CN7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[27], CarRegistration = "AN08CN7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[28], CarRegistration = "JH09CN7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[29], CarRegistration = "MP45CY7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[30], CarRegistration = "BR05CY7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[31], CarRegistration = "HR05CY7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[32], CarRegistration = "HP05CY7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[34], CarRegistration = "GJ05CY7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[35], CarRegistration = "CG05CY7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[37], CarRegistration = "TS05CY7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[38], CarRegistration = "AR05CY7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[39], CarRegistration = "NL05CY7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[40], CarRegistration = "TR05CY7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[42], CarRegistration = "SK05CY7897" },new Service{ ServiceAppointment = UpcomingServiceSlots[43], CarRegistration = "AN05CY7897" },
               new Service{ ServiceAppointment = UpcomingServiceSlots[44], CarRegistration = "JH05CY7897" }
            };
        }
        public List<DateTime> UpcomingServiceSlots{ get; set; }    
        public List<Service> BookedServiceSlots{ get; set; }    
    }
}
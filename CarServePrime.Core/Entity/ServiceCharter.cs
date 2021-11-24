using System;
using System.Collections.Generic;

namespace CarServePrime.Core.Entity
{
    public class ServiceCharter
    {
        //Todo: replace Datetime collection with custom ServiceSlot collection.
        public ServiceCharter()
        {
            this.UpcomingServiceSlots = new List<ServiceSlot>{
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,10,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,10,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,11,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,11,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,12,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,12,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,13,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,13,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,14,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,14,30,0)},

                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,10,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,10,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,11,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,11,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,12,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,12,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,13,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,13,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,14,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(1).Day,14,30,0)},

                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,10,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,10,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,11,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,11,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,12,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,12,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,13,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,13,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,14,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(2).Day,14,30,0)},

                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,10,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,10,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,11,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,11,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,12,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,12,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,13,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,13,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,14,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(3).Day,14,30,0)},

                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,10,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,10,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,11,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,11,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,12,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,12,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,13,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,13,30,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,14,0,0)},
                new ServiceSlot{SlotDateTime=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.AddDays(4).Day,14,30,0)}
            };
            this.BookedServices = new List<Service>
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
        public List<ServiceSlot> UpcomingServiceSlots { get; set; }
        public List<Service> BookedServices { get; set; }
    }
}
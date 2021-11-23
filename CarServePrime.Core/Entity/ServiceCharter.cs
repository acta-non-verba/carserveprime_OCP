using System;
using System.Collections.Generic;

namespace CarServePrime.Core.Entity
{
    public class ServiceCharter
    {
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
        }
        public List<DateTime> UpcomingServiceSlots{ get; set; }    
        public List<Service> BookedServiceSlots{ get; set; }    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using CarServePrime.Core.Entity;

namespace carserveprime.console
{
    

    class Program
    {
        static void Main(string[] args)
        {

            ServiceSlot requestedTimeSlot = new ServiceSlot();
            CustomerInteractor serviceRepresentative=new CustomerInteractor();
            
            requestedTimeSlot.SlotDateTime = serviceRepresentative.interactsWithCustomer();
            DateTime proposedDatetime = requestedTimeSlot.available() ? requestedTimeSlot.SlotDateTime : requestedTimeSlot.availableNext();
            serviceRepresentative.informsAvailableServiceSlot(proposedDatetime);
        }

    }
}



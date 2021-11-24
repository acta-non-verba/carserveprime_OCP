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
            ServiceSlot requestedSlot = new ServiceSlot();
            ServiceSlot proposedSlot = new ServiceSlot();
            CustomerInteractor serviceRepresentative = new CustomerInteractor();

            requestedSlot.SlotDateTime = serviceRepresentative.asksForPreferredServiceSlot();
            proposedSlot = serviceRepresentative.checksSlotAvailability(requestedSlot);
            serviceRepresentative.proposesSlot(proposedSlot);
            bool confirmation=serviceRepresentative.collectsServiceSlotConfirmation();
            if(confirmation==false) {serviceRepresentative.advisesVisit();return;}
            serviceRepresentative.registersServiceSlot(proposedSlot);
        }

        
    }
}



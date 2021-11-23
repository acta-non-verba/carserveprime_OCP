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
            ServiceSlot slot = new ServiceSlot();
            CustomerInteractor serviceRepresentative = new CustomerInteractor();
            DateTime proposedDatetime;

            slot.SlotDateTime = serviceRepresentative.asksForPreferredServiceSlot();
            proposedDatetime = slot.available() ? slot.SlotDateTime : slot.availableNext();
            serviceRepresentative.informsAvailableServiceSlot(proposedDatetime);
        }

    }
}



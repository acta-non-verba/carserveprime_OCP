using System;
using CarServePrime.Core.Entity;

namespace carserveprime.console
{
    public class CustomerInteractor
    {
        public Car carToBeServiced { get; set; }
        public DateTime asksForPreferredServiceSlot()
        {
            Console.WriteLine("Welcome to Car Serve Prime");
            Console.WriteLine("Can we have car registration number");
            string regnNumber = Console.ReadLine();
            bool isRegistrationvalid = new RegistrationFormatValidator().validateRegistration(ref regnNumber);
            Console.WriteLine("Preferred date and time (dd/mm/yyyy hh:mm)");
            DateTime requestedDatetime = default;
            bool isDateValid = DateTime.TryParse(Console.ReadLine(), out requestedDatetime);
            if (isDateValid == false || isRegistrationvalid == false) requestedDatetime = DateTime.MinValue;
            notesDownCarDetails(regnNumber);
            return requestedDatetime;
        }

        public void registersServiceSlot(ServiceSlot confirmedSlot)
        {
            Service serviceToBook=new Service();
            serviceToBook.CarRegistration="";
            serviceToBook.ServiceAppointment=confirmedSlot;
            ServiceCharter charter=new ServiceCharter();
            charter.BookedServices.Add(serviceToBook);
            Console.WriteLine("\n Service Appointment confirmed on "+confirmedSlot.SlotDateTime);
        }

        public void advisesVisit()
        {
            Console.WriteLine("\n Kindly visit us for getting suitable timeslot.Thanks");
            return;
        }

        public bool collectsServiceSlotConfirmation()
        {   
            Console.WriteLine("Confirm [y/n] or [Enter/Esc]");
            ConsoleKey response=Console.ReadKey(false).Key;
            if(response!=ConsoleKey.Enter && response!=ConsoleKey.Y) return false;
            return true;
        }

        public ServiceSlot checksSlotAvailability(ServiceSlot slot)
        {
            return slot.available() ? slot : slot.availableNext();
        }
        private void notesDownCarDetails(string regnNumber)
        {
            Car customerCar=new Car();
            customerCar.Registration=regnNumber;
            this.carToBeServiced=customerCar;
        }

        public void proposesSlot(ServiceSlot proposedSlot)
        {
            Console.WriteLine("Thank you for providing the information, Available service slot:");
            Console.WriteLine(proposedSlot.SlotDateTime);
            
            //Console.WriteLine("Appointment is confirmed on " + proposedDatetime);
        }

    }
}
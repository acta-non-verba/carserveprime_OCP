using System;

namespace carserveprime.console
{
    public class CustomerInteractor
    {
        public DateTime interactsWithCustomer()
        {
            Console.WriteLine("Welcome to Car Serve Prime");
            Console.WriteLine("Can we have car registration number");
            string regnNumber = Console.ReadLine();
            bool isRegistrationvalid = new RegistrationFormatValidator().validateRegistration(ref regnNumber);
            Console.WriteLine("Preferred date and time (dd/mm/yyyy hh:mm)");
            DateTime requestedDatetime = default;
            bool isDateValid = DateTime.TryParse(Console.ReadLine(), out requestedDatetime);            
            if (isDateValid == false || isRegistrationvalid == false) requestedDatetime= DateTime.MinValue;
            return requestedDatetime;
        }
        
        public void informsAvailableServiceSlot(DateTime proposedDatetime)
        {
            Console.WriteLine("Thank you for providing the information, your appointment information can be fixed as below");
            Console.WriteLine(proposedDatetime);
            Console.WriteLine("Appointment is confirmed on " + proposedDatetime);
        }
    }
}
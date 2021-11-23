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
            ServiceCharter serviceCharter = new ServiceCharter();

            DateTime proposedDatetime = scheduleAppointment(serviceCharter.BookedServiceSlots);

            Console.WriteLine("Thank you for providing the information, your appointment information can be fixed as below");
            Console.WriteLine(proposedDatetime);
            Console.WriteLine("Press (Y)es or (N)o");
            string finalConfirmation = Console.ReadLine();
            if (finalConfirmation.ToLower() != "y")
            {
                Console.WriteLine("Kindly visit service center between 10:00 AM - 05:00 PM");
                return;
            }
            Console.WriteLine("Appointment is confirmed on " + proposedDatetime);
        }

        private static DateTime scheduleAppointment(List<Service> currentServiceCharter)
        {
            DateTime requestedDatetime;
            requestedDatetime = CollectCustomerDetails();
            bool isTimeSlotAvailable = checkCurrentServiceCharter(currentServiceCharter, requestedDatetime);
            bool isDateValid = requestedDatetime.Equals(DateTime.MinValue);
            return isDateValid && isTimeSlotAvailable ? requestedDatetime : suggestNextAvailableSlot();
        }

        private static DateTime CollectCustomerDetails()
        {
            Console.WriteLine("Welcome to Car Serve Prime");

            Console.WriteLine("Can we have car registration number");
            string regnNumber = Console.ReadLine();
            bool isRegistrationvalid = new RegistrationFormatValidator().validateRegistration(ref regnNumber);
            Console.WriteLine("Preferred date and time (dd/mm/yyyy hh:mm)");
            DateTime requestedDatetime = default;
            bool isDateValid = DateTime.TryParse(Console.ReadLine(), out requestedDatetime);

            if (isDateValid == false || isRegistrationvalid == false) return DateTime.MinValue;

            return requestedDatetime;
        }

        private static bool checkCurrentServiceCharter(List<Service> currentServiceCharter, DateTime requestedDatetime)
        {
            return currentServiceCharter.Any(x => x.ServiceAppointment == requestedDatetime);

        }

        private static DateTime suggestNextAvailableSlot()
        {
            return DateTime.Today.AddDays(12).AddHours(14).AddMinutes(30);
        }
    }
}



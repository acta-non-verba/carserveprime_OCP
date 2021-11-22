using System;
using System.Text.RegularExpressions;

namespace carserveprime.console
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime proposedDatetime = scheduleAppointment();
            Console.WriteLine("Thank you for providing the information, your appointment information can be fixed as below");
            Console.WriteLine(proposedDatetime);
            Console.WriteLine("Press (Y)es or (N)o");
            string finalConfirmation = Console.ReadLine();
            if (finalConfirmation.ToLower() == "y")
            {
                Console.WriteLine("Appointment is confirmed on "+proposedDatetime);
                //save the appointment                
            }
        }

        private static DateTime scheduleAppointment()
        {
            DateTime requestedDatetime;
            Console.WriteLine("Welcome to Car Serve Prime");
            Console.WriteLine("Can we have car registration number");
            string regnNumber = Console.ReadLine();
            regnNumber = Regex.Replace(regnNumber, @"\s+", "");
            const string regPattern = "^[A-Z]{2}[ -][0-9]{1,2}(?: [A-Z])?(?: [A-Z]*)? [0-9]{4}$";
            bool isRegistrationvalid = Regex.IsMatch(regnNumber, regPattern);
            if (isRegistrationvalid == false)
            {
                Console.WriteLine("Invalid registration, Please re-enter in format MP09CN0492");
                regnNumber = Console.ReadLine();
            }
            Console.WriteLine("Preferred date and time (dd/mm/yyyy hh:mm)");
            bool isvalidDate = DateTime.TryParse(Console.ReadLine(), out requestedDatetime);
            bool isTimeSlotAvailable = false;
            if (isvalidDate == true)
            {
                isTimeSlotAvailable = checkServicePlan(requestedDatetime);
            }
            DateTime nextAvailableDateTime = default;
            if (isvalidDate == false || isTimeSlotAvailable == false)
            {
                nextAvailableDateTime = suggestNextAvailableSlot();
            }
            return isvalidDate ? requestedDatetime : nextAvailableDateTime;
        }

        private static bool checkServicePlan(DateTime requestedDatetime)
        {
            //Todo: logic for checking the availability
            return true;
        }

        private static DateTime suggestNextAvailableSlot()
        {
            throw new NotImplementedException();
        }

        private static DateTime concatDateTime(string date, string time)
        {
            return new DateTime(DateTime.Today.Year, DateTime.Today.Month, int.Parse(date));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace carserveprime.console
{
    public class Service
    {
        public DateTime ServiceAppointment { get; set; }
        public string CarRegistration { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> acceptableDateRange = new List<DateTime>
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
            List<Service> currentServiceCharter = new List<Service>
            {

               new Service{ ServiceAppointment = acceptableDateRange[0], CarRegistration = "KL08CN7897" }, new Service{ ServiceAppointment = acceptableDateRange[1], CarRegistration = "MP04TY2343" },
               new Service{ ServiceAppointment = acceptableDateRange[2], CarRegistration = "MP05HU8768" },new  Service{ ServiceAppointment = acceptableDateRange[3], CarRegistration = "MH05YG9088" },
               new Service{ ServiceAppointment = acceptableDateRange[4], CarRegistration = "DD90FG8900" },
               new Service{ ServiceAppointment = acceptableDateRange[6], CarRegistration = "KA08CN7897" },new  Service{ ServiceAppointment = acceptableDateRange[7], CarRegistration = "JK08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[9], CarRegistration = "OR08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[10], CarRegistration = "WB08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[12], CarRegistration = "UP08CN7897" },new Service{ ServiceAppointment = acceptableDateRange[13], CarRegistration = "JH08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[15], CarRegistration = "HR08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[16], CarRegistration = "HP08CN7897" },new Service{ ServiceAppointment = acceptableDateRange[17], CarRegistration = "GA08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[18], CarRegistration = "GJ08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[21], CarRegistration = "TS08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[22], CarRegistration = "AR08CN7897" },new Service{ ServiceAppointment = acceptableDateRange[23], CarRegistration = "NL08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[24], CarRegistration = "TR08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[26], CarRegistration = "SK08CN7897" },new Service{ ServiceAppointment = acceptableDateRange[27], CarRegistration = "AN08CN7897" },
               new Service{ ServiceAppointment = acceptableDateRange[28], CarRegistration = "JH09CN7897" },new Service{ ServiceAppointment = acceptableDateRange[29], CarRegistration = "MP45CY7897" },
               new Service{ ServiceAppointment = acceptableDateRange[30], CarRegistration = "BR05CY7897" },new Service{ ServiceAppointment = acceptableDateRange[31], CarRegistration = "HR05CY7897" },
               new Service{ ServiceAppointment = acceptableDateRange[32], CarRegistration = "HP05CY7897" },
               new Service{ ServiceAppointment = acceptableDateRange[34], CarRegistration = "GJ05CY7897" },new Service{ ServiceAppointment = acceptableDateRange[35], CarRegistration = "CG05CY7897" },
               new Service{ ServiceAppointment = acceptableDateRange[37], CarRegistration = "TS05CY7897" },
               new Service{ ServiceAppointment = acceptableDateRange[38], CarRegistration = "AR05CY7897" },new Service{ ServiceAppointment = acceptableDateRange[39], CarRegistration = "NL05CY7897" },
               new Service{ ServiceAppointment = acceptableDateRange[40], CarRegistration = "TR05CY7897" },
               new Service{ ServiceAppointment = acceptableDateRange[42], CarRegistration = "SK05CY7897" },new Service{ ServiceAppointment = acceptableDateRange[43], CarRegistration = "AN05CY7897" },
               new Service{ ServiceAppointment = acceptableDateRange[44], CarRegistration = "JH05CY7897" }
            };

            DateTime proposedDatetime = scheduleAppointment(currentServiceCharter);
            Console.WriteLine("Thank you for providing the information, your appointment information can be fixed as below");
            Console.WriteLine(proposedDatetime);
            Console.WriteLine("Press (Y)es or (N)o");
            string finalConfirmation = Console.ReadLine();
            if (finalConfirmation.ToLower() == "y")
            {
                Console.WriteLine("Appointment is confirmed on " + proposedDatetime);
                communicateServiceAppointment(proposedDatetime.ToShortTimeString(),proposedDatetime);               
            }
        }

        private static DateTime scheduleAppointment(List<Service> currentServiceCharter)
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
                isTimeSlotAvailable = checkCurrentServiceCharter(currentServiceCharter, requestedDatetime);
            }
            DateTime nextAvailableDateTime = default;
            if (isvalidDate == false || isTimeSlotAvailable == false)
            {
                nextAvailableDateTime = suggestNextAvailableSlot();
            }
            return isvalidDate ? requestedDatetime : nextAvailableDateTime;
        }

        private static bool checkCurrentServiceCharter(List<Service> currentServiceCharter, DateTime requestedDatetime)
        {
            return currentServiceCharter.Any(x => x.ServiceAppointment == requestedDatetime);

        }

        private static DateTime suggestNextAvailableSlot()
        {
            return DateTime.Today.AddDays(12).AddHours(14).AddMinutes(30);
        }

        private static DateTime concatDateTime(string date, string time)
        {
            return new DateTime(DateTime.Today.Year, DateTime.Today.Month, int.Parse(date));
        }
        
        private static void communicateServiceAppointment(string timeOfServiceDay, DateTime dateOfService)
        {
            SmtpClient mailClient = new SmtpClient();
            MailAddress fromEmail = new MailAddress("service@carserveprime.com");
            MailAddress toEmail = new MailAddress("customer@customerdomain.com");
            MailMessage message = new MailMessage(fromEmail, toEmail);
            message.Body = @"Thank you for providing the information, your appointment information fixed as below /n" +
                            dateOfService.ToShortDateString() + " " + timeOfServiceDay + " PM";
            message.Subject = "Service apointment at carserverprime";
            mailClient.Send(message);
        }
    }
}

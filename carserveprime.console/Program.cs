using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CarServePrime.Core.Entity;

namespace carserveprime.console
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCharter serviceCharter=new ServiceCharter();
            
            serviceCharter.BookedServiceSlots = new List<Service>
            {

               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[0], CarRegistration = "KL08CN7897" }, new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[1], CarRegistration = "MP04TY2343" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[2], CarRegistration = "MP05HU8768" },new  Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[3], CarRegistration = "MH05YG9088" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[4], CarRegistration = "DD90FG8900" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[6], CarRegistration = "KA08CN7897" },new  Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[7], CarRegistration = "JK08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[9], CarRegistration = "OR08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[10], CarRegistration = "WB08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[12], CarRegistration = "UP08CN7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[13], CarRegistration = "JH08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[15], CarRegistration = "HR08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[16], CarRegistration = "HP08CN7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[17], CarRegistration = "GA08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[18], CarRegistration = "GJ08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[21], CarRegistration = "TS08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[22], CarRegistration = "AR08CN7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[23], CarRegistration = "NL08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[24], CarRegistration = "TR08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[26], CarRegistration = "SK08CN7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[27], CarRegistration = "AN08CN7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[28], CarRegistration = "JH09CN7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[29], CarRegistration = "MP45CY7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[30], CarRegistration = "BR05CY7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[31], CarRegistration = "HR05CY7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[32], CarRegistration = "HP05CY7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[34], CarRegistration = "GJ05CY7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[35], CarRegistration = "CG05CY7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[37], CarRegistration = "TS05CY7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[38], CarRegistration = "AR05CY7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[39], CarRegistration = "NL05CY7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[40], CarRegistration = "TR05CY7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[42], CarRegistration = "SK05CY7897" },new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[43], CarRegistration = "AN05CY7897" },
               new Service{ ServiceAppointment = serviceCharter.UpcomingServiceSlots[44], CarRegistration = "JH05CY7897" }
            };

            DateTime proposedDatetime = scheduleAppointment(serviceCharter.BookedServiceSlots);
            Console.WriteLine("Thank you for providing the information, your appointment information can be fixed as below");
            Console.WriteLine(proposedDatetime);
            Console.WriteLine("Press (Y)es or (N)o");
            string finalConfirmation = Console.ReadLine();
            if (finalConfirmation.ToLower() == "y")
            {
                Console.WriteLine("Appointment is confirmed on " + proposedDatetime);
                //save the appointment                
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
    }
}



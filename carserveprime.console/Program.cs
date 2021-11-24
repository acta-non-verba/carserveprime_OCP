using System;
using System.ComponentModel;
using System.Net.Mail;

namespace carserveprime.console
{
    class Program
    {
        static bool mailSent = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Carserveprime");
            Console.WriteLine("If you are here to schedule a service appointment please enter yes(y) else no(n)");
            string response = Console.ReadLine();
            if (response.ToLower() != "y")
            {
                Console.WriteLine("For any other assistance call toll free number");
                return;
            }
            Console.WriteLine("Can we have your car registration number");
            string regnNumber = Console.ReadLine();
            Console.WriteLine("Can we have your preferred date(dd) of appointment for current month");
            string dateOfAppointment = Console.ReadLine();
            Console.WriteLine("What time would you prefer between (12 PM-5 PM)");
            string timeOfServiceDay = Console.ReadLine();
            DateTime dateOfService = new DateTime(DateTime.Today.Year, DateTime.Today.Month, int.Parse(dateOfAppointment));
            Console.WriteLine("Thank you for providing the information, your appointment information fixed as below");
            Console.WriteLine(dateOfService.ToShortDateString() + " " + timeOfServiceDay + " PM");

            communicateServiceAppointment(timeOfServiceDay, dateOfService);

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

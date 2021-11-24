using System;
using System.Net.Mail;

namespace carserveprime.console
{
    public class EmailSender
    {
        public static void communicateServiceAppointment(string timeOfServiceDay, DateTime dateOfService)
        {
            SmtpClient mailClient = new SmtpClient();
            MailAddress fromEmail = new MailAddress("service@carserveprime.com");
            MailAddress toEmail = new MailAddress("customer@customerdomain.com");
            MailMessage message = new MailMessage(fromEmail, toEmail);
            message.Body = @"Thank you for providing the information, your appointment information fixed as below /n" +
                            dateOfService.ToShortDateString() + " " + timeOfServiceDay + " PM";
            message.Subject = "Service apointment at carserverprime";
            //Todo: Uncomment only while deploying
           // mailClient.Send(message);
        }
    }
}
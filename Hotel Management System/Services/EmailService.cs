using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public class EmailService
    {
        public static string systemEmail = "hms@grandcodeline";
        public static void SendEmail(string to ,string subject,string body)
            {
            Console.WriteLine("From:"+ systemEmail);
            Console.WriteLine("send email to:"+ to );
            Console.WriteLine("subject:"+ subject);
            Console.WriteLine("Body:" + body);
            Console.WriteLine("Email Sent Successfully!");
            }
    }
}

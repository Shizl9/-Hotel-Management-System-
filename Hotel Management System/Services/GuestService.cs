using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public class GuestService
    {
        public static void DisplayAllGuests(List<GuestModel>guests)
        {
            foreach (var g in guests)
            {
                Console.WriteLine($"guest Id:{g.guestId}");
                Console.WriteLine($"Full Name:{g.fullName}");
                Console.WriteLine($"Email:{g.email}");
                Console.WriteLine($"Phone Number:{g.phoneNumber}");

            }
        }
        public static GuestModel FindGuestById(List<GuestModel> guests, string newguestId)
        {
            foreach (var gid in guests)
            {

                if (gid.guestId == newguestId)
                {
                    return gid;
                }
                else
                {
                    Console.WriteLine("not mached guest");
                }

            }

            return null;
        }
    }
}

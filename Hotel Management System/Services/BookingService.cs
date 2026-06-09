using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public class BookingService
    {
        //process members:
        public static void DisplayAllBookings(List<BookingModel>bookings)
        {
            foreach(BookingModel book in bookings)
            {
                Console.WriteLine($"booking id:{book.bookingId}");
                Console.WriteLine($"guest id:{book.guestId}");
                Console.WriteLine($"room number:{book.roomNumber}");
                Console.WriteLine($"check in date:{book.checkInDate}");
                Console.WriteLine($"check out date :{book.checkOutDate}");
                Console.WriteLine($"check out date :{book.checkOutDate}");
                Console.WriteLine($"totat price :{book.totalPrice}");
                Console.WriteLine($"status :{book.status}");
                Console.WriteLine($"booking reviews :{book.bookingReviews}");

            }
        }
    }
}

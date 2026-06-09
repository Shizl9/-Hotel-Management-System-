using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public static BookingModel FindBookingById(List<BookingModel> bookingModels, string bookingId)
        {
            foreach (BookingModel b in bookingModels)
            { 
                if (b.bookingId== bookingId)//(bookid from bookingmodel== bookid from input)
                {
                    return b;// if matched return object b 
                }
                else { Console.WriteLine("not matching booking "); }
            }
            return null;// if not mached retrun null 
        }
        public static bool CancelBooking(BookingModel state )
        {

            bool flage = false;
            if (state.status == "Cancelled")
            {
                flage=true;
                Console.WriteLine("Cancelled succsessfully!");
            }
            else
            {
                Console.WriteLine("try again!");
            }
            return flage;
            
        }
        public static bool CompleteBooking(BookingModel s)
        {
            bool flage = false;
            if (s.status == "Compleated")
            {
                flage = true;
                Console.WriteLine("Compleated booking" );
            }
            else
            {
                Console.WriteLine("try again!");
            }
            return flage;
        }

    }
}

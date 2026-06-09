using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public class ReviewService
    {
        public static void AddReview(BookingModel booking, ReviewModel reviwes)
        {
            booking.bookingReviews.Add(reviwes);
        }
        //print each review's rating and comment. If none exist, print "No reviews yet."
        public static void DisplayReviewsForBooking(BookingModel booking)
        {
            if (booking.bookingReviews == null)
            {
                Console.WriteLine("No Reviews Yet!");
            }
            else
            {
                foreach (ReviewModel reviw in booking.bookingReviews)
                {
                    Console.WriteLine($"rating:{reviw.rating}");
                    Console.WriteLine($"comments:{reviw.comment}");
                }
            }
        }


    }
}

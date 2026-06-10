using Hotel_Management_System.Models;
using Hotel_Management_System.Services;
using System.Drawing;

namespace Hotel_Management_System
{
    public class Program
    {
        public static void RegisterGuest(HotelContext context)
        {
            Console.WriteLine("Enter guest id:");
            string guestId=Console.ReadLine();
            Console.WriteLine("Enter guest Full Name:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter guest Email:");
            string email=Console.ReadLine();
            Console.WriteLine("Enter guest phone number:");
            string phoneNumber = Console.ReadLine();
            context.guests.Add(new GuestModel
            {
                guestId= guestId,
                fullName= fullName,
                email=email,
                phoneNumber= phoneNumber,
                guests = new List<BookingModel>()//inside guestmodel
            });
            EmailService.SendEmail(email, "Welcome to Grand Codeline Hotel",
                "Thank you for registering. We look forward to hosting you!");
        }
        public static void AddRoom(HotelContext context)
        {
            Console.WriteLine("Enter room number:");
            string roomNumber = Console.ReadLine();
            Console.WriteLine("Enter room type:");
            string roomType = Console.ReadLine();
            Console.WriteLine("Enter price of room per night:");
            double pricePerNight =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter guest phone number:");
            int floor = Convert.ToInt32(Console.ReadLine());
            context.rooms.Add(new RoomModel
            {
                roomNumber = roomNumber,
                roomType = roomType,
                pricePerNight = pricePerNight,
                floor = floor,
                isAvailable=true,
                
            });
            Console.WriteLine("Room added successfully.");
        }
        public static void DisplayAvailableRooms(HotelContext context)
        {
         if (context.rooms.Count == 0)
            {
                Console.WriteLine("No rooms in system.");
            }
            else
            {
                RoomService.DisplayAvailableRooms(context.rooms);
            }
            
        }
        public static void AddStaff(HotelContext context)
        {
            Console.WriteLine("Enter staff id:");
            string staffid = Console.ReadLine();
            Console.WriteLine("Enter staff name:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter role of staff:");
            string role = Console.ReadLine();
            Console.WriteLine("Enter staff email:");
            string email=Console.ReadLine();
            context.staff.Add(new StaffModel
            {
                staffid = staffid,
                fullName = fullName,
                role = role,
                email = email,
                isOnDuty = true,

            });
            Console.WriteLine("Staff Added successfuly.");
        }
        public static void DisplayAllStaff(HotelContext context)
        {
            StaffService.DisplayAllStaff(context.staff);
        }
        public static void BookRoom(HotelContext context)
        {
            Console.WriteLine("Enter guest ID:");
            string guestid=Console.ReadLine();
            Console.WriteLine("Enter room number:");
            string roomNumber = Console.ReadLine();
            var guest = GuestService.FindGuestById(context.guests, guestid);
            var room = RoomService.FindRoomByNumber(context.rooms, roomNumber);
            if (guest == null )
            {
                Console.WriteLine("Not found guest id.");
            }
            else if (room == null)
            {
                Console.WriteLine(" Not found room number.");
            }
            else { Console.WriteLine("invalid input!"); }

            if (room.isAvailable == false)
            {
                Console.WriteLine("room not available");
            }
            else { Console.WriteLine("room is available"); }

            Console.WriteLine("Enter check in date:");
            string checkInDate=Console.ReadLine();
            Console.WriteLine("Enter number of nights:");
            int numberOfNights=Convert.ToInt32(Console.ReadLine());
            var totalprice = RoomService.CalculateTotalPrice(room, numberOfNights);

            Console.WriteLine("Enter bookig id:");
            string bookingId = Console.ReadLine();

            context.bookings.Add(new BookingModel
            {
                status = "Confirmed",
                bookingReviews = new List<ReviewModel>()
            });

            if(room.isAvailable == null)
            {
                room.isAvailable = false;
            }
        }
        static void Main(string[] args)
        {
           HotelContext context = new HotelContext();
            context.guests = new List<GuestModel>();
            context.rooms = new List<RoomModel>();
            context.reviews = new List<ReviewModel>();
            context.staff = new List<StaffModel>();
            context.bookings = new List<BookingModel>();
           
        }
    }
}

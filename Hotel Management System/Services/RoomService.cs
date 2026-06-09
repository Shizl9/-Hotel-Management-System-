using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public class RoomService
    {
        public static void DisplayAllRooms(List<RoomModel> rooms)
        {
            foreach (var r in rooms)
            {
                Console.WriteLine($"room number:{r.roomNumber}");
                Console.WriteLine($"room type:{r.roomType}");
                Console.WriteLine($"price per night:{r.pricePerNight}");
                Console.WriteLine($"is there any rooms available:{r.isAvailable}");

            }
        }
        public static void DisplayAvailableRooms(List<RoomModel> rooms)
        {
            foreach (var r in rooms)
            {
                if (r.isAvailable == true)
                {
                    Console.WriteLine($"availability:{r.isAvailable}");
                }
            }
        }

        public static RoomModel FindRoomByNumber(List<RoomModel> rooms, string roomNumber)
        {
            foreach (var r in rooms)
            {
                if (r.roomNumber == roomNumber)
                {
                    return r;
                }
                else
                {
                    Console.WriteLine("room number not matching");
                }
            }
            return null;
        }
        public static double CalculateTotalPrice(RoomModel room , int nights)
        {
           return room.pricePerNight * nights;
        }
    }
}

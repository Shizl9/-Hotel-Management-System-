using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public class StaffService
    {
        public static void DisplayAllStaff(List<StaffModel>staff)
        {
         foreach(StaffModel staff1 in staff)
            {
                Console.WriteLine($"Enter staff id:{staff1.staffid}");
                Console.WriteLine($"Enter staff name:{staff1.fullName}");
                Console.WriteLine($"Enter staff role:{staff1.role}");
                Console.WriteLine($"Enter if staff is on duty or not:{staff1.isOnDuty}");
            }
        }
        public static StaffModel FindStaffById(List<StaffModel>staffclass,string staffId)
        {
            foreach(StaffModel SM in staffclass)
            {
                if (SM.staffid== staffId)
                {
                    return SM;
                }
                else
                {
                    Console.WriteLine("not mached staff");
                }
                
            }
            return null;
        }
        public static void ToggleDutyStatus(StaffModel staffOnDuty) 
        {
            
            if (staffOnDuty.isOnDuty==true)
            {
                staffOnDuty.isOnDuty = false;
            }
            else
            {
                staffOnDuty.isOnDuty =true;
            }
            Console.WriteLine($"new status:{staffOnDuty.isOnDuty}");

        }
    }
}

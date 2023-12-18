using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBasicExercise
{
  
    public class House
    {
        public event EventHandler<OpenDoorEventArguments> DoorOpened;//מנגנון שיאפשר להפעיל את האזעקה כשהדלת נפתחת


        private bool doorOpen;//האם הדלת פתוחה
        public int HouseNumber { get; set; }//מספר בית
        public string Phone { get; set; }//טלפון בית
       

       

        //פעולה בונה המאתחלת בית לפי מספר בית וטלפון 
        //הדלת נעולה
        public House(int houseNumber,string phone)
        {
            this.HouseNumber = houseNumber;
            this.Phone = phone;
            doorOpen = false;
        }

        //פתיחת דלת
        public void OpenDoor(bool usingKey)
        {
            Console.WriteLine("Door Opening....\n\n\n\n\n\n");//רק לתיעוד
            Thread.Sleep(2000);//נחכה 2 שניות בשביל המתח
            doorOpen = true;
            if (!usingKey)//-->משהו פורץ לבית
            {
              //  DoorOpened(this,new EventArgs());   
                DoorOpened(this, new OpenDoorEventArguments() { BreakTime = DateTime.Now });
            }

            Console.WriteLine("Door opened!");

        }

        

        public void CloseDoor()
        {
            Thread.Sleep(2000);//נחכה 2 שניות בשביל המתח
            doorOpen = false;
        }

       
      
    }
}

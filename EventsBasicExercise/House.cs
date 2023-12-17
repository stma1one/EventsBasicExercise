using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBasicExercise
{
  
    public class House
    {
        
        private  bool doorOpen;//האם הדלת פתוחה
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
        public void OpenDoor()
        {
            Thread.Sleep(2000);//נחכה 2 שניות בשביל המתח
            doorOpen = true;    
        }

        public void CloseDoor()
        {
            Thread.Sleep(2000);//נחכה 2 שניות בשביל המתח
            doorOpen = false;
        }

       
      
    }
}

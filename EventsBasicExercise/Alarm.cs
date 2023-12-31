﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBasicExercise
{

    #region שאלות
    /* 1. How can we set the alarm off each time the door opens?=> Add Event to House and subscribe the Set Alarm method to the event
     * 2. How can we tell which house set off the alarm?=>where event raise send this as the object
     * 3. What if we want to know the exact time the door opened? (or any other details?)=>create class that derives from EventArgs and add properties we want to store the eventhadler<T> replace T with the class type created
     * 4. what if we want to copy this logic and make it availble for different types of entities?
     * 5.what if we want the alarm to perform on other types of buildings with doors?
     * 6. finalize the code
     */
    #endregion

    //מערכת אזעקה לבתים
    public class Alarm
    {
        private List<House> Houses;//אוסף הבתים אחריהם המערכת מאזינה

        public Alarm()
        {
            Houses = new List<House>();
        }


        //פעולה המוסיפה אוסף של בתים למערכת
        public void AddHouses(List<House> houses)
        {
            foreach (House house in houses)
            {
                house.DoorOpened += SetAlarm;
                houses.Add(house);
                
            }
        }
        //הוספת בית בודד
        public void AddHouse(House house)
        {

            house.DoorOpened += SetAlarm;
            this.Houses.Add(house);

        }
        //הסרת בית בודד 
        public void RemoveHouse(int houseNum) 
        {
            var item = this.Houses.Where(x => x.HouseNumber == houseNum).FirstOrDefault();//נמצא את הבית לפי המספר
          if(item != null) 
            {
                item.DoorOpened -= SetAlarm;
                this.Houses.Remove(item);   
            }
        }
        public void RemoveHouse(string phone)
        {
            var item = this.Houses.Where(x => x.Phone == phone).FirstOrDefault();//נמצא את הבית לפי המספר
            if (item != null)
            {
                item.DoorOpened -= SetAlarm;
                this.Houses.Remove(item);
            }
        }

        //החזרת עותק של אוסף הבתים שעליהם המערכת מאזינה
        public List<House> GetHouses()
        {
            return Houses.ToList();
        }

        //makes 2 beeps and prints a message
            public void SetAlarm(object sender, OpenDoorEventArguments args)
        {


            Console.Beep(350, 2000);
            Console.Beep(550, 1000);
            Console.WriteLine($"Alarm was Set Off on house number {((House)sender).HouseNumber} breakTime was on {args.BreakTime} ");

            


        }

    }
}

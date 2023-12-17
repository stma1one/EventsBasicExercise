using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBasicExercise
{
    public class Shop
    {
        public string Name;
        private bool isLocked;
        public string Owner;
        public Shop(string name,string onwer)
        {
            Name = name;
            Owner = onwer;
            isLocked = false;
        }

        public void UnlockDoor()
        {
            Thread.Sleep(2000);//נחכה 2 שניות בשביל המתח
           isLocked = true;
        }

        public void LockDoor()
        {
            Thread.Sleep(2000);//נחכה 2 שניות בשביל המתח
           isLocked = false;
        }

    }
}

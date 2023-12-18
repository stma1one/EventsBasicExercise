namespace EventsBasicExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Alarm alarmSystem=new Alarm();
           
           House annaZak=new  House(16, "0525381648");
            House talsi = new House(15, "00000000");

           alarmSystem.AddHouse(annaZak);
        //   alarmSystem.AddHouse(talsi);

           annaZak.OpenDoor(false);
         //  talsi.OpenDoor(true);   
          
            

       

        }
    }
}
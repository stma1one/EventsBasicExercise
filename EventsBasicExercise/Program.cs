namespace EventsBasicExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Alarm alarmSystem=new Alarm();
           House annaZak=new  House(16, "0525381648");
           alarmSystem.AddHouse(annaZak);
           annaZak.OpenDoor();

       

        }
    }
}
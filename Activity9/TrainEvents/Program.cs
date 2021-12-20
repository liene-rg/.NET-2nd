using System;

namespace CSharp.Activity.Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            TrainStation trainStation = new TrainStation(); // declare obj

            trainStation.Arrival += TrainStation_Arrival;

 

    }

        private static void TrainStation_Arrival(object sender, ArrivalEventArgs e)
        {

            ArrivalStatus value = ArrivalStatus.Arriving;
            if (value == ArrivalStatus.Arriving)
            {
                Console.WriteLine("The train is arriving");
            }
            if (value == ArrivalStatus.Delayed)
            {
                Console.WriteLine("The train is delayed");
            }
            if (value == ArrivalStatus.Cancelled)
            {
                Console.WriteLine("The train is cancelled");
            }
        }
    }

    public enum ArrivalStatus
    {
        Arriving,
        Delayed,
        Cancelled
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Events
{
    public class TrainStation // TrainStation class (publisher) raises the Arrival event // Classes can subscribe to the Arrival
    {
       
        public event EventHandler<ArrivalEventArgs> Arrival; // event 

        protected void OnArrival(ArrivalEventArgs e) // this method would raise the event Arrival
        {
            Arrival?.Invoke(this, e);
        }


        public void AnnounceArrival(int train, ArrivalStatus arrivalStatus, DateTime arrivalTime)
        {
            //            This method would be
            //called by the clients. From this method invoke the method
            //OnArrival() by passing a new instance of ArrivalEventArgs.



        }


    }

    
}

using System;

namespace latian
{
    class Taxi
    {
        string DriverName;
        bool OnDuty;
        int NumPassanger;

        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            
            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.WriteLine(taxi.DriverName);

            /*Console.WriteLine(Opel.model);*/
        }
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : " + this.DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : yes");
            }
            else if (OnDuty == false)
            {
                Console.WriteLine("On Duty : no");
            }
            Console.WriteLine("Number Of Passenger : " + this.NumPassanger);
        }

        public void PickUpPassanger()
        {
            Console.WriteLine(this.DriverName + " sedang menjemput penumpang");
        }

        public void DropOffPassanger()
        {
            Console.Write(this.DriverName + " selesai mengantar penumpang");
        }

    }

}


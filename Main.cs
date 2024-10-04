namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            // Create the policeStation and city
            PoliceStation policeStation = new PoliceStation();
            City city = new City(policeStation);

            // Create the taxis
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            Taxi taxi3 = new Taxi("0003 CCC");

            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(taxi3.WriteMessage("Created"));

            // Add them to the city
            city.AddTaxiLicense(taxi1);
            city.AddTaxiLicense(taxi2);
            city.AddTaxiLicense(taxi3);

            // Create the policeCars
            PoliceCar policeCar1 = new PoliceCar("0001 CNP", true, policeStation);
            PoliceCar policeCar2 = new PoliceCar("0002 CNP", false, policeStation);
            PoliceCar policeCar3 = new PoliceCar("0003 CNP", true, policeStation);

            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            Console.WriteLine(policeCar3.WriteMessage("Created"));

            // Add them to the policeStation
            policeStation.RegisterCar(policeCar1);
            policeStation.RegisterCar(policeCar2);
            policeStation.RegisterCar(policeCar3);

            // PoliceCars start patrolling
            foreach (PoliceCar policeCar in policeStation.registeredCars)
            {
                policeCar.StartPatrolling();
            }

            // Try to use radar
            policeCar2.UseRadar(taxi1);

            // Catch taxi
            taxi1.StartRide();
            policeCar1.UseRadar(taxi1);

            // Remove license
            city.RemoveTaxiLicense(taxi1);
        }
    }
}
    


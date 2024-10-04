using System;
namespace Practice1
{
	public class PoliceStation
	{
		public List<PoliceCar> registeredCars { get; private set; }

        public PoliceStation()
		{
            registeredCars = new List<PoliceCar>();
            Console.WriteLine(WriteMessage("Created"));
        }

        // Add policeCar 
		public void RegisterCar(PoliceCar policeCar)
		{
            registeredCars.Add(policeCar);
            if (policeCar.HasRadar())  // Check if has radar
                Console.WriteLine(WriteMessage($"Added PoliceCar with plate {policeCar.GetPlate()} and radar."));
            else
                Console.WriteLine(WriteMessage($"Added PoliceCar with plate {policeCar.GetPlate()}."));

        }

        // Set the chasing vehicle to all of the policeCars
		public void ActivateAlarm(string plate)
		{
			for(int i=0; i < registeredCars.Count; i++)
			{
				PoliceCar car = registeredCars[i];
				if (car.IsPatrolling())
				{
                    car.SetChasingVehicle(plate);
					car.SetIsChasing(true);                  
                }
				
			}
            Console.WriteLine(WriteMessage($"Alarm activated. Vehicle with plate {plate} is being chased."));
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"Police Station";
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}


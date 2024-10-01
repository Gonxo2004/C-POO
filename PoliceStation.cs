using System;
namespace Practice1
{
	public class PoliceStation
	{
		private int number; // Added to difference between Police Stations
		public List<PoliceCar> registeredCars { get; private set; }

        public PoliceStation(int number)
		{
			this.number = number;
            registeredCars = new List<PoliceCar>();
        }

		public void RegisterCar(PoliceCar policeCar)
		{
			registeredCars.Add(policeCar);
		}
		public void ActivateAlarm(Vehicle vehicle)
		{
			for(int i=0; i < registeredCars.Count; i++)
			{
				PoliceCar car = registeredCars[i];
				car.SetChasingVehicle(vehicle);
			}
		}
	}
}


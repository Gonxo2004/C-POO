using System;
namespace Practice1
{
	public abstract class VehicleWithoutPlate:Vehicle, IMessageWritter
	{
		public VehicleWithoutPlate(string typeOfVehicle) : base(typeOfVehicle)
        {
		}
        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()}";
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}


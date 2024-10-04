using System;
namespace Practice1
{
	public class City: IMessageWritter
	{
        public List<Taxi> registeredTaxis { get; private set; }
        private PoliceStation policeStation;

        public City(PoliceStation policeStation)
		{
            this.policeStation = policeStation;
            registeredTaxis = new List<Taxi>();
            Console.WriteLine(WriteMessage("Created"));
        }
        // Add taxis
        public void AddTaxiLicense(Taxi taxi)
        {
            registeredTaxis.Add(taxi);
            Console.WriteLine(WriteMessage($"Added license of Taxi with plate {taxi.GetPlate()}."));
        }
        // Remove taxis
        public void RemoveTaxiLicense(Taxi taxi)
        {               
            registeredTaxis.Remove(taxi);
            Console.WriteLine(WriteMessage($"Removed license of Taxi with plate {taxi.GetPlate()}."));            
        }
        //Override ToString() method with class information
        public override string ToString()
        {
            return $"City";
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}


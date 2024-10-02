using System;
namespace Practice1
{
	public class City: IMessageWritter
	{
        public List<Taxi> registeredTaxis { get; private set; }
        //private PoliceStation policeStation;

        public City()
		{
            registeredTaxis = new List<Taxi>();
            Console.WriteLine(WriteMessage("Created"));
        }

        public void AddTaxiLicense(string plate)
        {
            Taxi taxi = new Taxi(plate);
            registeredTaxis.Add(taxi);
            Console.WriteLine(WriteMessage($"Added license of Taxi with plate {plate}"));
        }

        public void RemoveTaxiLicense(string plate)
        {
            for (int i = 0; i < registeredTaxis.Count; i++)
            {
                Taxi taxi = registeredTaxis[i];
                if (taxi.GetPlate() == plate)
                {
                    registeredTaxis.Remove(taxi);
                    Console.WriteLine(WriteMessage($"Removed license of Taxi with plate {plate}"));
                }
            }

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


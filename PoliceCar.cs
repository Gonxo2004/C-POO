namespace Practice1
{
    public class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        private PoliceStation policeStation;
        private string chasingVehicle;
        private bool isChasing;


        public PoliceCar(string plate, bool hasRadar, PoliceStation policeStation) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            this.policeStation = policeStation;
            if (hasRadar)
            {
                speedRadar = new SpeedRadar();  // Create a Radar instance if the boolean is true
            }
            else
            {
                speedRadar = null; 
            }
        }
        public string GetChasingVehicle()
        {
            return chasingVehicle;
        }
        public bool HasRadar()
        {
            return speedRadar != null;
        }
        public bool IsChasing()
        {
            return isChasing;
        }
        public void SetIsChasing(bool state)
        {
            isChasing = state;
        }
        public void SetChasingVehicle(string plate)
        {
            chasingVehicle = plate;
        }
        public void UseRadar(VehicleWithPlate vehicle)
        {
            if (isPatrolling)
            {
                if (HasRadar())
                {
                    speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                    if (speedRadar.GetCatched())
                    {
                        policeStation.ActivateAlarm(vehicle.GetPlate());
                    }
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no radar."));
                }
            }

            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
            {
                Console.WriteLine(speed);
            }
        }
    }
}
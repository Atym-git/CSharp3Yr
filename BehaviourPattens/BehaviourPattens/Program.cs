namespace BehaviourPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirportTransportation airportTransportation = new AirportTransportation(new ExpressTrain());

            airportTransportation.TransferToAirport();

            Console.WriteLine();

            airportTransportation.IStrategy = new Taxi();

            airportTransportation.TransferToAirport();

            Console.WriteLine();

            airportTransportation.IStrategy = new PersonalCar();

            airportTransportation.TransferToAirport();
        }
    }
}

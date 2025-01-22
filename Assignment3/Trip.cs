using System;
class TripDetails{
    // Method to calculate the total distance
    public static double CalculateTotalDistance(double fromToVia, double viaToFinalCity){
        return fromToVia + viaToFinalCity;}
    // Method to calculate average speed
    public static double CalculateAverageSpeed(double totalDistance, double timeTaken){
        return totalDistance / timeTaken;
        }
	static void Main(string[] args){
        // Taking input for name and cities from user
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter the final destination city: ");
        string toCity = Console.ReadLine();
        // Taking user input for distances in miles
        Console.Write("Enter the distance from the starting city to via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the distance from the via city to the final destination (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
        // Taking user input for time taken for the journey
        Console.Write("Enter the time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());
        // Calculating the total distance
        double totalDistance = CalculateTotalDistance(fromToVia, viaToFinalCity);
        // Calculating the average speed
        double averageSpeed = CalculateAverageSpeed(totalDistance, timeTaken);
        // Printing the results
        Console.WriteLine($"The results of the trip are: ");
        Console.WriteLine($"Traveler: {name}");
        Console.WriteLine($"Starting city: {fromCity}, Via city: {viaCity}, Destination city: {toCity}");
        Console.WriteLine($"Total distance traveled: {totalDistance} miles");
        Console.WriteLine($"Average speed: {averageSpeed} miles per hour");
    }
}

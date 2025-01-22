using System;
class Rounds{
	// method return the number of rounds 
	public static double CalculateRounds(double side1, double side2, double side3 , double distance ){
		double perimeter = side1+side2+side3;
		return perimeter/distance;
		
	}
	static void Main(string[] args){
		 // taking the sides of the triangular park from the user
        Console.Write("Enter the length of side 1 in meters: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 in meters: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 in meters: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        //the total distance to run (5 km in meters)
        double distanceToRun = 5000;
        
        double rounds= CalculateRounds(side1,side2,side3,distanceToRun);
        //printing the rounds
        Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5km");
	}
}
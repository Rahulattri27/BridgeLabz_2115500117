using System;
class Convert{
	static void Main(string[] args){
		double distance_in_km =10.8;
		double distance_in_miles=distance_in_km/1.6;
		Console.WriteLine($"The distance {distance_in_km} km in miles is {distance_in_miles}");
	}
}
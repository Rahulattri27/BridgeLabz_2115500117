using System;
class Earth{
	public static void Volume(){
		double radius = 6378;
		double volume_in_km3 = (double)4/3 * Math.PI *Math.Pow(radius,3);
		double volume_in_miles3=volume_in_km3 / Math.Pow(1.6,3);
		Console.WriteLine($"The volume of earth in cubic kilometers is {volume_in_km3} and cubic miles is {volume_in_miles3}");
		
	}
	static void Main(string[] args){
		Volume();
		
	}	
}
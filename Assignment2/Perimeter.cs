using System;
class Perimeter{
	//Calculating the perimeter of square
	public static void Square(){
		//taking side length from user
		Console.Write("Enter the side of Square: ");
		double side = Convert.ToDouble(Console.ReadLine());
		double perimeter=side*4;
		//printing the perimeter
		Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
	}
	static void Main(string[] args){
		Square();
	}
}
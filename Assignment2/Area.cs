using System;
class Area{
	 public static void TriangleArea(){
	 	//Taking base from user
		Console.Write("Enter the base of Triangle in cm : ");
		double Base = Convert.ToDouble(Console.ReadLine());
		//taking height from user
		Console.Write("Enter the height of Triangle in cm : ");
		double height = Convert.ToDouble(Console.ReadLine());
		double area_in_cm2= (Base*height) /2;
		double area_in_inches2=area_in_cm2/Math.Pow(2.54,2);
		//printing the area of triangle
		Console.WriteLine($"Area of Triangle in cm2 is {area_in_cm2} while area in inches2 is {area_in_inches2} of height {height} cm and base {Base} cm");
		
	}
	static void Main(string[] args){
		TriangleArea();
	}
}
using System;
class Calculator{
	static void Calculate(){
		//Enter the first number
		Console.Write("Enter the number1: ");
		double number1 = Convert.ToDouble(Console.ReadLine());
		//Enter the Second number
		Console.Write("Enter the number2: ");
		//performing operations
		double number2 = Convert.ToDouble(Console.ReadLine());
		double addition = number1 + number2;
		double subtraction = number1 - number2;
		double multiplication = number1 * number2;
		double division = number1 / number2;
		//printing the answers 
		Console.WriteLine($"The addition,subtraction,multiplication and division value of 2 numbers {number1} and {number2} is {addition}, {subtraction}, {multiplication}, {division}");
	}
	static void Main(string[] args){
		Calculate();
	}
}
using System;

class TwoNumber{
	//initialising the variable
	private double number1;
	private double number2;
	//constructor
	public TwoNumber(){

	Console.Write("Enter the first number: ");
	number1 = Convert.ToDouble(Console.ReadLine());
	Console.Write("Enter the second number: ");
	number2 = Convert.ToDouble(Console.ReadLine());}
	//method to calculate the quotient or remainder
	public void Calculate(){
		double quotient = number1 / number2;
		double remainder= number1 % number2;
		Console.WriteLine($"The Quotient is {quotient} and remainder is {remainder} of two numbers {number1} and {number2}.");
	}	
}
class Program {
	static void Main(string[] args){
		TwoNumber tn =new TwoNumber();
		tn.Calculate();
	}	
}
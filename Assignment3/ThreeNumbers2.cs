using System;
class ThreeNumber{
	//initialising the variables
	double a,b,c;
	//constructor
	public ThreeNumber(){
		Console.Write("Enter the value of a: ");
		a= Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the value of b: ");
		b= Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the value of c: ");
		c= Convert.ToDouble(Console.ReadLine());
	}
	public void Operation(){
		double first_op= a + b * c;
		double second_op= a * b + c;
		double third_op = c + a /b;
		double fourth_op = a % b +c;
		Console.WriteLine($"The result of Int Operations are {first_op}, {second_op}, {third_op}, {fourth_op} ");
	}
}
class Program{

static void Main(string[] args){
	ThreeNumber th= new ThreeNumber();
	th.Operation();
	}
}
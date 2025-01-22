using System;
class ThreeNumber{
	//initialising the variables
	int a,b,c;
	//constructor
	public ThreeNumber(){
		Console.Write("Enter the value of a: ");
		a= Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the value of b: ");
		b= Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the value of c: ");
		c= Convert.ToInt32(Console.ReadLine());
	}
	public void Operation(){
		int first_op= a + b * c;
		int second_op= a * b + c;
		int third_op = c + a /b;
		int fourth_op = a % b +c;
		Console.WriteLine($"The result of Int Operations are {first_op}, {second_op}, {third_op}, {fourth_op} ");
	}
}
class Program{

static void Main(string[] args){
	ThreeNumber th= new ThreeNumber();
	th.Operation();
	}
}
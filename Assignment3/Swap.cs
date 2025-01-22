using System;
class Swap{
	//this method interchange the values of variables passed
	public void Change(ref double a,ref double b){
		double temp = b;
		b=a;
		a=temp;
		
	}
	static void Main(String[] args){
		//taking the first number from user
		Console.Write("Enter first number: ");
		double a = Convert.ToDouble(Console.ReadLine());
		//taking the second number from user
		Console.Write("Enter second number: ");
		double b = Convert.ToDouble(Console.ReadLine());
		//creating an instance
		Swap swap = new Swap();
		Console.WriteLine($"Values Before Swap of a is {a} and b is {b}");
		//calling the method
		swap.Change(ref a, ref b);
		Console.WriteLine($"Value After Swap of a is {a} and b is {b}");
	}
}
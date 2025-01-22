using System;
class ConvertCToF{
	//method to convert temperature from celsius to fahrenheit 
	public void Converted(){
		//taking celsius as input from user
		Console.Write("Enter the temperature in Celsius: ");
		double celsius= Convert.ToDouble(Console.ReadLine());
		//converting to fahrenheit
		double fahrenheit = celsius*(double)9/5 +32;
		//Printing the fahrenheit
		Console.WriteLine($"The {celsius} Celsius is {fahrenheit} Fahrenheit");
	}
	static void Main(string[] args){
		ConvertCToF convert = new ConvertCToF();
		convert.Converted();
}
}
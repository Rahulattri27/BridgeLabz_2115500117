using System;
class ConvertFToC{
	//method to convert temperature from fahrenheit to celsius
	public void Converted(){
		//taking fahrenheit as input from user
		Console.Write("Enter the temperature in Celsius: ");
		double fahrenheit= Convert.ToDouble(Console.ReadLine());
		//converting to celsius
		double celsius = (fahrenheit-32)*(double)5/9;
		//Printing the celsius
		Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsius} Celsius ");
	}
	static void Main(string[] args){
		ConvertFToC convert = new ConvertFToC();
		convert.Converted();
}
}
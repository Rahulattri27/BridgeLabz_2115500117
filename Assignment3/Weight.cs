using System;
class Weight{
    // Method to convert pounds to kilograms
    //correct formula is 1kg = 2.2 pound
    public static double ConvertPoundsToKilograms(double pounds){
        return pounds /2.2;}
    static void Main(string[] args){
        // Input weight in pounds from the user
        Console.Write("Enter the weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        // Call the method to convert pounds to kilograms
        double kilograms = ConvertPoundsToKilograms(pounds);
        // print the result
        Console.WriteLine($"The weight of the person in pounds is {pounds} and in kilograms is {kilograms}.");
    }
}

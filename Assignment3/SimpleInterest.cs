using System;
class SimpleInterest{
    // Method to calculate simple interest
    public static double CalculateSimpleInterest(double principal, double rate, double time){
        return (principal * rate * time) / 100;
    }
    static void Main(string[] args){
        // Inputs from the user
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Call the method to calculate interest
        double simpleInterest = CalculateSimpleInterest(principal, rate, time);

        // print the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}, and Time {time} years.");
    }
}

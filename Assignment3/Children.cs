using System;
class ChocolateDivision
{   // Method to calculate chocolates per child
    public static int ChocolatesPerChild(int numberOfChocolates, int numberOfChildren){
        return numberOfChocolates / numberOfChildren; }
	// Method to calculate remaining chocolates
    public static int RemainingChocolates(int numberOfChocolates, int numberOfChildren){
        return numberOfChocolates % numberOfChildren;}
    static void Main(string[] args){
        // take the number of chocolates and children from the user
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the total number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());
        // Ensure the number of children is greater than 0
        if (numberOfChildren <= 0){
            Console.WriteLine("Number of children must be greater than 0.");
            return;}
        // Calling the  methods to calculate results
        int chocolatesPerChild = ChocolatesPerChild(numberOfChocolates, numberOfChildren);
        int remainingChocolates = RemainingChocolates(numberOfChocolates, numberOfChildren);

        // Printing the result
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}.");
    }
}

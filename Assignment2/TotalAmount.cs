using System;
class TotalAmount{
	//this method takes unit price and quantity and give total amount
	static void CalculateAmount(){
		//taking per unit price from user
		Console.Write("Enter the price per Unit: ");
		double unit_price = Convert.ToDouble(Console.ReadLine());
		//taking quantity from user
		Console.Write("Quantity to be bought: ");
		double quantity = Convert.ToDouble(Console.ReadLine());
		double total_amount= unit_price*quantity;
		//printing the total amount with unit price and quantity
		Console.WriteLine($"The total purchase price is INR {total_amount} if the quantity {quantity} and unit price is INR {unit_price}");
	}	
	static void Main(string[] args){
		CalculateAmount();
	}
}
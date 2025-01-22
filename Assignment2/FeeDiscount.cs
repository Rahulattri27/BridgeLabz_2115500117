using System;
class Discount{
	// this method takes fees and discount percent from user and prints the discounted fees
	 public static void CalculateDiscount(){
	 	// taking fees as input
		Console.Write("Enter the Fees: ");
		double fee = Convert.ToDouble(Console.ReadLine());
		//taking discount percent as input
		Console.Write("Enter the Discount Percent: ");
		double discount_percent= Convert.ToDouble(Console.ReadLine());
		double discount = discount_percent/100 *fee;
		double discounted_fee = fee - discount;
		//printing the discounted fees
		Console.WriteLine($"The discount amount is INR {discount} and the final discounted fee is INR {discounted_fee} ");
	}	
	static void Main(string[] args){
		CalculateDiscount();
	}
}

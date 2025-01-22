using System;
class Discount{
	float fee = 125000;
	float discount_percent= 10;
	//this method is calculating the discounted fee by discount_percent and fee
	public void Calculate(){
		float discount = discount_percent/100 *fee;
		float discounted_fee = fee - discount;
		Console.WriteLine($"The discount amount is INR {discount} and the final discounted fee is INR {discounted_fee} ");
	}	
}
class Program{
	static void Main(string[] args){
		Discount discount = new Discount();
		discount.Calculate();
	}
}
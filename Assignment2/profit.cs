using System;
class Profit{
	static void Main(string[] args){
		int cost_price=129;
		int selling_price=191;
		double profit=selling_price -  cost_price;
		double profit_percentage = profit/cost_price *100;
		Console.WriteLine($"The Cost price is INR {cost_price} and Selling Price is INR {selling_price} \nThe profit is INR {profit} and the Profit Percentage is { profit_percentage}");
	}
}
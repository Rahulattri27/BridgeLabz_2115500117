using System;
class TotalIncome{
	//method to add the base salary and bonus
	public void TotalSalary(){
		//taking base salary from user
		Console.Write("Enter the Base Salary: ");
		double salary = Convert.ToDouble(Console.ReadLine());
		// taking bonus from user
		Console.Write("Enter the bonus: ");
		double bonus = Convert.ToDouble(Console.ReadLine());
		//printing the total income using bonus and salary
		Console.WriteLine($"The Salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {salary+bonus} ");
	}
	static void Main(string[] args){
		TotalIncome income =new TotalIncome();
		income.TotalSalary();
	}
}
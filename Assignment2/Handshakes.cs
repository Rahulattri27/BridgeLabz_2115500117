using System;
class Handshakes{
	//this method calculate the possible number of handshakes from certain amount of people
	static void TotalHandshakes(){
		//taking number of people from user
		Console.Write("Enter the number of students: ");
		double students = Convert.ToDouble(Console.ReadLine());
		if (students < 0 ){
			Console.WriteLine("Invalid People");
			
		}
		else{
		double handshakes= (students*(students-1))/2;
		//printing the handshakes possible
		Console.WriteLine($"Total Possible handshakes are: {handshakes}");}
	}
	static void Main(string[] args){
		TotalHandshakes();
	}
}
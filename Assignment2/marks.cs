using System;
class Marks{
	static void Main(string[] args){
		string name="Sam";
		int maths_marks=94;
		int physics_marks=95;
		int chemistry_marks=96;
		double marks=maths_marks + physics_marks +chemistry_marks;
		double average_marks= marks/300;
		Console.WriteLine($"{name}'s average mark in PCM is {average_marks}");
	}
}
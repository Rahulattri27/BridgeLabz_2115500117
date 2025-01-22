using System;
class Pen{
	//method to distribute the pens per student and calculate remaining pens
	public void Distribute_Pens(){
		int pens =14;
		int students= 3;
		int pen_per_student= pens/students;
		int remaining_pens= pens % students;
		Console.WriteLine($"The Pen Per Student is {pen_per_student} and the remaining pen not distributed is {remaining_pens}");
		
	}
	static void Main(string[] args){
		Pen pen = new Pen();
		pen.Distribute_Pens();
	}
}
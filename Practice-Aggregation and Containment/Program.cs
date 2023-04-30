namespace Practice_Aggregation_and_Containment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SchoolProgram CompSci300 = new SchoolProgram("Trinary Computing", "CSI 102010","C303",
				new Instructor("Bob","Jim")
				);
			Console.WriteLine(CompSci300);

			CompSci300.AddStudent("Billy", "Bobrickson", 33, 333);
			CompSci300.AddStudent("Jane", "Doe", 128, 3);
			CompSci300.AddStudent("Robinson", "Crusoe", 1, 14);
			CompSci300.AddStudent("Cornelius", "Smith", 8, 16);
			Console.WriteLine(CompSci300);
		}
	}
}
using System;

using static Point;
using static PointsList;

using static Vector;
using static VectorsList;

using static Calck;

using static Menu;

using static Delete;

class Program
{
	public static void Main()
	{

		// Init boxes for point and vectors
		var Points = PointsList.getInstance();
		var Vectors = VectorsList.getInstance();

		// Set language
		var MainMenu = Menu.getInstance();

		// Circle for running application
		while (true)
		{
			Console.Clear();

			// View already created points and vectors
			Console.Write(Points);
			Console.Write(Vectors);

			// View main menu
			Console.Write(MainMenu);

			// Input user's answer
			Console.Write("\n> ");
			var choise = Console.ReadLine();
			int choised_number;
			try
			{
				choised_number = int.Parse(choise);
			}
			catch
			{
				Console.WriteLine("Incorrect input, type a number");
				Console.ReadLine();
				/*Console.Clear();*/
				continue;
			}

			// Execute user's commands
			switch (choised_number)
			{
				case 0:
					Console.Clear();
					Environment.Exit(0);
					break;

				case 1:// Add new point
					var point = new Point();
					Points.Add(point);
					continue;

				case 2:
					var vector = new Vector();
					Vectors.Add(vector);
					continue;

				case 3:
					Calck.Length();
					break;

				case 4:
					Calck.Angle();
					break;

				case 5:
					Delete.Point(ref Points);
					break;

				case 6:
					Delete.Vector(ref Vectors);
					break;
			}
		}

	}
}
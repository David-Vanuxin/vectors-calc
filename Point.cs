using System;
using System.Text.RegularExpressions;

using static PointsList;

public class Point
{
	public double x;
	public double y;
	public double z;

	public string name;

	public Point()
	{
		while (true)
		{

			AlreadyExist:
				Console.Write("\nType a name for a new point\n> ");
				string pre_name = "";
				pre_name = Console.ReadLine();

				// Checking using names
				var Points = PointsList.getInstance();

				for (int n = 0; n < Points.Count; ++n)
				{
					if (pre_name == Points[n].name)
					{
						Console.WriteLine("Point with name {0} already exists", pre_name);
						goto AlreadyExist;
					}
				}

			var pattern_for_name_of_point = new Regex(@"[A-Z]{1}");

			if (pattern_for_name_of_point.IsMatch(pre_name))
			{
				this.name = pre_name;
				break;
			}
			else
			{
				Console.WriteLine("Name of point have be a one capital letter: A—Z");
				continue;
			}
		}

		Console.WriteLine("\nType coordinates of the point");
		this.x = InputNumber("x = ");
		this.y = InputNumber("y = ");
		this.z = InputNumber("z = ");
	}

    public override string ToString()
    {
    	return $"{this.name}({this.x};{this.y};{this.z})\n";
    }

	public static double InputNumber(string message)
	{	
		double number;

		while (true)
		{
			Console.Write(message);
			string input = Console.ReadLine();

			try
			{
				number = double.Parse(input);
			}
			catch
			{
				Console.WriteLine("Enter a integer or decimal");
				continue;
			}

			return number;	
		}
	}
}

// ZeroPoint has been created when app has been started 
public class ZeroPoint : Point
{
	public ZeroPoint()
	{
		Console.WriteLine("Creating ZeroPoint");
		Console.ReadLine();
		this.name = "O";
		this.x = 0.0;
		this.z = 0.0;
		this.y = 0.0;
	}
}
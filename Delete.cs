using System;

using static PointsList;
using static VectorsList;

public class Delete
{
	public static void Point(ref PointsList Points) 
	{
		while (true)
		{			
			Console.Write("\nType a name of point\n> ");
			string name = Console.ReadLine();

			if (Points.Search(name))
			{
				for (int n = 0; n < Points.Count; ++n)
				{
					if (Points[n].name == name)
					{
						Points.RemoveAt(n);
					}
				}

				break;
			}
			else
			{
				Console.WriteLine("Point with name {0} don't exists", name);
				continue;
			}
		}
	}

	public static void Vector(ref VectorsList Vectors) 
	{
		while (true)
		{			
			Console.Write("\nType a name of vector\n> ");
			string name = Console.ReadLine();

			if (Vectors.Search(name))
			{
				for (int n = 0; n < Vectors.Count; ++n)
				{
					if (Vectors[n].name == name)
					{
						Vectors.RemoveAt(n);
					}
				}

				break;
			}
			else
			{
				Console.WriteLine("Vector with name {0} don't exists", name);
				continue;
			}
		}
	}
}
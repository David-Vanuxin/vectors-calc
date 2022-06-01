using System;

using static VectorsList;

class Calck
{
	public static void Angle()
	{
		var Vectors = VectorsList.getInstance();

		int first = 0;
		int second = 0;

		string first_name = "";

		while (true)
		{			
			Console.Write("\nType a name of first vector\n> ");
			first_name = Console.ReadLine();

			if (Vectors.Search(first_name))
			{
				for (int n = 0; n < Vectors.Count; ++n)
				{
					if (Vectors[n].name == first_name)
					{
						first = n;
					}
				}

				break;
			}
			else
			{
				Console.WriteLine("Vector with name {0} don't exists", first_name);
				continue;
			}
		}

		string second_name = "";
		while (true)
		{			
			Console.Write("\nType a name of second vector\n> ");
			second_name = Console.ReadLine();

			if (Vectors.Search(second_name))
			{
				for (int n = 0; n < Vectors.Count; ++n)
				{
					if (Vectors[n].name == second_name)
					{
						second = n;
					}
				}

				break;
			}
			else
			{
				Console.WriteLine("Vector with name {0} don't exists", second_name);
				continue;
			}
		}

		var start = Vectors[first];
		var finish = Vectors[second];
		
		double cos = (start.x * finish.x + start.y * finish.y +  start.z * finish.z) / (start.CalckLength() * finish.CalckLength()); 
		double angle = Math.Round(Math.Acos(cos) * 57.296);

		Console.WriteLine($"\nAngle between {Vectors[first].name} and {Vectors[second].name} equal {angle}°");
		Console.Read();
	}	

	public static void Length()
	{
		var Vectors = VectorsList.getInstance();
		string name = "";

		while (true)
		{			
			Console.Write("\nType a name of vector\n> ");
			name = Console.ReadLine();

			if (Vectors.Search(name))
			{
				for (int n = 0; n < Vectors.Count; ++n)
				{
					if (Vectors[n].name == name)
					{
						double length = Vectors[n].CalckLength();
						double answer = Math.Round(length, 2); 
						Console.WriteLine($"|{Vectors[n].name}| = {answer}");
						Console.Read();
						break;
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
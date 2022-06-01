using System;
using System.Text.RegularExpressions;

using static Point;
using static PointsList;
using static VectorsList;

public class Vector
{
	public double x;
	public double y;
	public double z;

	public string name;

	public Vector()
	{
		while (true)
		{
			var Points = PointsList.getInstance();

			int start = 0;
			int finish = 0; // indexes

			string start_pre_name = "";
			string finish_pre_name = "";

			NewVector:
			while (true)
			{			
				Console.Write("\nType a name for a start point\n> ");
				start_pre_name = Console.ReadLine();

				if (Points.Search(start_pre_name))
				{
					for (int n = 0; n < Points.Count; ++n)
					{
						if (Points[n].name == start_pre_name)
						{
							start = n;
						}
					}

					break;
				}
				else
				{
					Console.WriteLine("Point with name {0} don't exists", start_pre_name);
					continue;
				}
			}


			while (true)
			{			
				Console.Write("\nType a name for a finish point\n> ");
				finish_pre_name = Console.ReadLine();

				if (Points.Search(finish_pre_name))
				{
					for (int n = 0; n < Points.Count; ++n)
					{
						if (Points[n].name == finish_pre_name)
						{
							finish = n;
						}
					}

					break;
				}
				else
				{
					Console.WriteLine("Point with name {0} don't exists", finish_pre_name);
					continue;
				}
			}

			var Vectors = VectorsList.getInstance();

			this.name = Points[start].name + Points[finish].name;

			while (true)
			{	
				if (Vectors.Search(this.name))
				{
					Console.WriteLine("Vector with name {0} already exists", this.name);
					Console.Read();
					goto NewVector;
				}
				else 
				{	
					this.x = Points[finish].x - Points[start].x;  
					this.y = Points[finish].y - Points[start].y;
					this.z = Points[finish].z - Points[start].z;

					goto end;
				}
			}
			end:
				break;
		}
	}

	public double CalckLength()
	{
		return Math.Sqrt(this.x*this.x + this.y*this.y + this.z*this.z);
	}

    public override string ToString()
    {
    	return $"{this.name}{{{this.x};{this.y};{this.z}}}\n";
    }
}
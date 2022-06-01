using System;

using static PointsList;
using static VectorsList;

namespace Languages
{
	public abstract class Menu
	{
		public string exit          = "0. Exit";
		public string create_point  = "\n1. Create point";  
		public string create_vector = "2. Create vector";
		public string calck_length  = "\n3. Calck length of vector";
		public string calck_angle   = "4. Calck angle between two vectors";
		public string delete_point  = "\n5. Delete point";
		public string delete_vector  = "6. Delete vector";

		public override string ToString()
		{
			Console.WriteLine(this.exit);
			Console.WriteLine(this.create_point);

			var Points = PointsList.getInstance();
			if (Points.Count >= 2) Console.WriteLine(this.create_vector);

			var Vectors = VectorsList.getInstance();
			if (Vectors.Count != 0) Console.WriteLine(this.calck_length);
				
			if (Vectors.Count >= 2) Console.WriteLine(this.calck_angle);

			if (Points.Count != 0) Console.WriteLine(this.delete_point);

			if (Vectors.Count != 0) Console.WriteLine(this.delete_vector);
			return "";
		}
	}

	public class EnglishMenu : Menu
	{}

	public class RussianMenu : Menu
	{
		public RussianMenu()
		{
			exit          = "0. Выход";
			create_point  = "\n1. Создать точку";  
			create_vector = "2. Создать вектор";
			calck_length  = "\n3. Длина вектора";
			calck_angle   = "4. Угол между двумя векторами";
			delete_point  = "\n5. Удалить точку";
			delete_vector  = "6. Удалить вектор";		
		}
	}

}
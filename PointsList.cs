using System;
using System.Collections.Generic;

using static Point;

public class PointsList : List<Point>
{
    private static PointsList instance;
 
    private PointsList()
    {}
 
    public static PointsList getInstance()
    {
        if (instance == null)
            instance = new PointsList();
        return instance;
    }

    public override string ToString()
    {

    	int count = this.Count;

    	if (count == 0) return "";

    	Console.WriteLine("Points:");

    	string list_of_points = "";

    	for (int n = 0; n <= count; ++n)
    	{
    		try
    		{
    			list_of_points += this[n].ToString();
    		}
    		catch
    		{
    			break;
    		}
    	}

    	return list_of_points + "\n";
    }

    public bool Search(string name)
    {
        foreach(Point p in this)
        {
            if (p.name == name)
            {
                return true;
            }
        }

        return false;
    }
}
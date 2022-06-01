using System;
using System.Collections.Generic;

using static Vector;

public class VectorsList : List<Vector>
{
    private static VectorsList instance;
 
    private VectorsList()
    {}
 
    public static VectorsList getInstance()
    {
        if (instance == null)
            instance = new VectorsList();
        return instance;
    }

    public override string ToString()
    {

    	int count = this.Count;

    	if (count == 0) return "";

    	Console.WriteLine("Vectors:");

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
        foreach(Vector p in this)
        {
            if (p.name == name)
            {
                return true;
            }
        }

        return false;
    }
}
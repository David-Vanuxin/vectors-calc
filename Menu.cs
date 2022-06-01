using System;
using System.Globalization;

using Languages;

public class Menu
{
    private static Menu instance;
 
    private Menu()
    {}
 
    public static Menu getInstance()
    {
        if (instance == null)
            instance = new Menu();
        return instance;
    }

	public override string ToString()
	{
		switch (CultureInfo.CurrentUICulture.Name)
		{
			case "ru-RU":
				//var ru_menu = new Languages.RussianMenu();
				var ru_menu = new Languages.RussianMenu();
				Console.Write(ru_menu);
				break;
			default:
				var en_menu = new Languages.EnglishMenu();
				Console.Write(en_menu);
				break;
		}

		return "";
	}
} 

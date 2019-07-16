using System;

public class Temperature
{
	public void Celcious_To_Fahrenheit(double c)
	{
        double f = (c * 9 / 5) + 32;
        Console.WriteLine(f);
    }

    public void Fahrenheit_To_Celcious(double f)
    {
        double c = (f-32)*5/9;
        Console.WriteLine(c);
    }
}

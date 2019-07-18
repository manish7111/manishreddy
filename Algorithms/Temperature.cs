using System;

public class Temperature
{
	public void Celcious_To_Fahrenheit(double c)
	{

        //formula to find fahrenheit temperature
        double f = (c * 9 / 5) + 32;
        Console.WriteLine(f);
    }

    public void Fahrenheit_To_Celcious(double f)
    {
        //formula to find celcius temperature
        double c = (f-32)*5/9;
        Console.WriteLine(c);
    }

    public void Test()
    {
        Console.WriteLine("Enter Celcius temperature");
        double cel = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Fahrenheit temperature");
        double far = Convert.ToDouble(Console.ReadLine());
        this.Celcious_To_Fahrenheit(cel);
        this.Fahrenheit_To_Celcious(far);
    }
}

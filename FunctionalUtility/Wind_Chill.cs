using System;

public class Wind_Chill
{
	public void Print()
	{
        Console.WriteLine("Enter temperature");
        int t = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Speed of the wind");
        int v = Convert.ToInt32(Console.ReadLine());
        double w;
        if(t<50||(v>=3 &&v<120))
        {
            w = 35.74 + (0.6215 * t) + ((0.4275 * t) - 35.75) * (Math.Pow(v, 0.16));
            Console.WriteLine("wind chill:" +w);
        }
        else
        {
            Console.WriteLine("Enter the values within the range");
        }
    }
}

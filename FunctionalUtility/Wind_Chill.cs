using System;

public class Wind_Chill
{
	public void Print()
	{
        Console.WriteLine("Enter temperature");
        //reads input temerature from user
        int t = Convert.ToInt32(Console.ReadLine());
        //reads input velocity from user
        Console.WriteLine("Enter Speed of the wind");
        int v = Convert.ToInt32(Console.ReadLine());       
        double w;
        //condition --->true enters if block and execute 
        if (t<50||(v>=3 &&v<120))                            
        {                                                   
            w = 35.74 + (0.6215 * t) + ((0.4275 * t) - 35.75) * (Math.Pow(v, 0.16));
            Console.WriteLine("wind chill:" +w);
        }
        //condition --->false enters else block and execute
        else
        {
            Console.WriteLine("Enter the values within the range");
        }
    }
}

using System;

public class Harmonic_Number
{
	public void Display()
	{
        Console.WriteLine("Enter number");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.Write(1 + "/" + h + "=");
        double sum = 0;
        for (double i=1;i<=h&&h>0;i++)
        {
            double j = 1 / i;
            sum = sum + j;
            Console.Write(1+"/" +i);
            if(i<h)
            {
                Console.Write("+");
            }
        }
        Console.WriteLine();
        Console.WriteLine(sum);
	}
}

using System;

public class Power
{
	public void Pow()
	{
        Console.WriteLine("Enter the number");
        double n = Convert.ToInt32(Console.ReadLine());
        double p=0;
        if (n > 0 && n < 31)
        {
            for (int i = 0; i < n; i++)
            {
                p = Math.Pow(2, i);
                if (p <= Math.Pow(2, n))
                {
                    Console.WriteLine(2+"^"+i +"=" +p);
                }
                Console.WriteLine();
            }
           
        }
        else
        {
            Console.WriteLine("Emter the n value with in the range");
        }
        

	}
}

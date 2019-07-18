using System;

public class Harmonic_Number
{
	public void Display()
	{
        Console.WriteLine("Enter number");

        //reading of harmonic nth number from the user
        int h = Convert.ToInt32(Console.ReadLine());

        //hormonic number printing in the specific form such as 1/n
        Console.Write(1 + "/" + h + "=");                   
        double sum = 0;
        for (double i=1;i<=h&&h>0;i++)
        {
            double j = 1 / i;

            //for finding the sum of the harmonic number
            sum = sum + j;                                 
            Console.Write(1+"/" +i);

            //this if condition checks and prints the "+" after each each increment of number
            if (i<h)                                        
            {
                Console.Write("+");
            }
        }
        Console.WriteLine();
        Console.WriteLine(sum);
	}
}

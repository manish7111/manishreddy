using System;

public class Power
{
	public void Pow()
	{
        Console.WriteLine("Enter the number");

        //reads the number from the user
        double n = Convert.ToInt32(Console.ReadLine());
        double p=0;

        //condition to check the number present between 0 and 31
        if (n > 0 && n < 31)                                               
        {
            for (int i = 0; i < n; i++)
            {

                //using power function to find the power of 2
                p = Math.Pow(2, i);                                        
                if (p <= Math.Pow(2, n))
                {

                    //printing of 2 power table
                    Console.WriteLine(2+"^"+i +"=" +p);                     
                }
                Console.WriteLine();
            }
           
        }
        else
        {

            //enter the value which is in range btw 0 and 31
            Console.WriteLine("Emter the n value with in the range");      
        }
        

	}
}

using System;

public class Prime_Factor
{
	public void Factor()
	{
        Console.WriteLine("Enter number");

        //read input from user
        int n = Convert.ToInt32(Console.ReadLine());    
        for(int i=2;i<n;i++)
        {

            //condition to find a number which divides input number
            if (n%i==0)                                  
            {
                for(int j=2;j<=i;j++)
                {
                    //condition to check the prime factors of a number
                    if (i%j==0&&i==j)                   
                    {
                        Console.WriteLine(i);
                    }

                }
  
            }
        }

	}
}

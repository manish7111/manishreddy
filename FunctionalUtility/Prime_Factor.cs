using System;

public class Prime_Factor
{
	public void Factor()
	{
        Console.WriteLine("Enter number");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=2;i<n;i++)
        {
            if(n%i==0)
            {
                for(int j=2;j<=i;j++)
                {
                    if(i%j==0&&i==j)
                    {
                        Console.WriteLine(i);
                    }

                }
  
            }
        }

	}
}

using System;

public class Sum_Of_Integers
{
	public void sum()
	{
        Console.WriteLine("Enter the value of n");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        int count = 0;
        for(int i=0;i<n;i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if(a[i]+a[j]+a[k]==0)
                    {
                        count++;
                        Console.WriteLine("triplets are:" + a[i] + " " + a[j] + " " + a[k]);
                    }
                }
            }
        }
        Console.WriteLine("count-->"+count);
    }
}

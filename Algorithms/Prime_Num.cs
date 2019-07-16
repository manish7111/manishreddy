using System;

public class Prime_Num
{
	public void Check(int n)
	{
        int k = 0;//indexing for prime num array
        Console.WriteLine("prime numbers are:");
        int countPrime = 0;
        int[] a = new int[n];//array for storing prime number 
        for (int i = 1; i <=n; i++)
        {
            int count = 0;
            for (int j = i; j >=1; j--)
            {
                if (i%j == 0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.Write(i+" ");
                a[k++] = i;
                countPrime++;
            }
        }
        Console.WriteLine("\nPalindrome: ");
        for (int e = 0; e <countPrime; e++)
        {
            int sum = 0;
            int value = a[e];
            if (value != 0)
            {
                if (value > 9)
                    while (value > 0)
                    {
                        int rem = value % 10;
                        sum = sum * 10 + rem;
                        value = value / 10;
                    }
                if (sum == a[e])
                {
                    Console.Write(a[e] + " ");
                }
            }
        }
    }
}

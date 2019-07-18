using System;

public class Prime_Num
{

    public void Demo()
    {
        Console.WriteLine("Enter n");
        int n = Convert.ToInt32(Console.ReadLine());
        this.Check(n);
    }
	public void Check(int n)
	{
        //indexing for prime num array
        int k = 0;
        Console.WriteLine("prime numbers are:");
        int countPrime = 0;

        //array for storing prime number 
        int[] a = new int[n];
        for (int i = 1; i <=n; i++)
        {
            int count = 0;
            for (int j = i; j >=1; j--)
            {

                //condition of prime number
                if (i%j == 0)
                {
                    count++;
                }
            }

            //if my count becomes 2 such that number has to divide of one and itself
            if(count==2)
            {
                Console.Write(i+" ");

                //storing the prime numbers in this array
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

                    //condition to check whether the primenumber is palendrome or not
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

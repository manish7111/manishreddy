using System;

public class Tic_Tac_Toe
{
    public void Play()
    {
        Console.WriteLine("Enter rows and Columns");
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] a = new int[m, n];
        if(m==n)
        {
            for (int i = 0; i < m ; i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(i%2!=0||j%2!=0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("rows and columns should be equal to 5");
        }
        for (int i = 0; i < m ; i++)
        {
            for (int j = 0; j < n ; j++)
            {
                if (i % 2 != 0 || j % 2 != 0)
                {
                    Console.Write(a[i,j]+" ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}

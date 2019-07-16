using System;
using System.Collections.Generic;

public class Bubble_Sort
{
	public void Sort()
	{
        Console.WriteLine("Enter the length of an array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Enter the elements in array");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("After bubble sort elements in the array are:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i]);
        }
    }
}

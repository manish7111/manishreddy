using System;
using System.Collections.Generic;

public class Bubble_Sort
{
	public void Sort()
	{
        Console.WriteLine("Enter the length of an array");

        //reads input length of array from input
        int n = Convert.ToInt32(Console.ReadLine());

        //initializing of an integer array
        int[] a = new int[n];
        Console.WriteLine("Enter the elements in array");

        //for loop for reading the elements in the array
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        //for loop is used for recursion of the array elements until it ends
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {

                //condition for swaping of elements
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

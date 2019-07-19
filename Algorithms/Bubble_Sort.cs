// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bubble_Sort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
/// <summary>
/// Bubble_sort is a class which i have created to sort the elemnts by using sorting technique.
/// </summary>
public class Bubble_Sort
{
    /// <summary>
    /// Sorts this instance and prints the sorted array as output.
    /// </summary>
    public void Sort()
	{
        Console.WriteLine("Enter the length of an array");

        ////Reads input length of array from input
        int num = Convert.ToInt32(Console.ReadLine());

        ////Initializing of an integer array
        int[] array = new int[num];
        Console.WriteLine("Enter the elements in array");

        ////For loop for reading the elements in the array
        for (int i = 0; i < num; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        ////For loop is used for recursion of the array elements until it ends
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num - i - 1; j++)
            {

                ////Condition for swaping of elements
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("After bubble sort elements in the array are:");
        for (int i = 0; i < num; i++)
        {
            Console.Write(array[i]);
        }
    }
}

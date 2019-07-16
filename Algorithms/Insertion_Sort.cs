using System;
using System.Collections.Generic;

public class Insertion_Sort
{
	public void Sorting()
	{
        Console.WriteLine("Enter the length of an array");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s = new string[n];
        Console.WriteLine("Enter the Strings:");
        for (int i = 0; i < n; i++)
        {
            s[i]=Console.ReadLine();
        }
        for(int i=0;i<s.Length-1;i++)
        {
            for(int j=i+1;j>0;j--)
            {
                if(s[j-1].CompareTo(s[j])>0)
                {
                    String temp = s[j- 1];
                    s[j- 1] = s[j];
                    s[i] = temp;
                }
            }
        }
        Console.WriteLine("After sorting:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(s[i]);
        }

    }
}

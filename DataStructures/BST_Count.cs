// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BST_Count.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// BST_Count is an class,it is used to find the number of trees can be formed by using "n" nodes.
/// </summary>
public class BST_Count
{
    /// <summary>
    /// i had created the constructor an an class.
    /// </summary>
	public BST_Count()
	{
        Console.WriteLine("enter the node");
        int num = Convert.ToInt32(Console.ReadLine());
        int upper = 1;

        ////calculating the factorial of the numerator of an formula.
        for (int n=1;n<=2*num;n++)
        {
            upper *= (n);
        }
        Console.WriteLine(upper);
        int lower1 = 1;

        ////claculating the factorial of denominator of an formula.
        for(int n = 1; n <= num+1; n++)
        {
            lower1 *= (n);
        }
        Console.WriteLine(lower1);
        int lower2 = 1;
        for (int n = 1; n <= num; n++)
        {
            lower2 *= n;
        }
        Console.WriteLine(lower2);
        ////calculating and printing the total number of trees found.
        int total = upper / (lower1 * lower2);
        Console.WriteLine("total number of BST formed are:" + total);
	}
}

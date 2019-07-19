// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vending_Machine.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Vending_Machine is a class where i have to find the number of notes are given as a change fro the amount. 
/// </summary>
public class Vending_Machine
{
    /// <summary>
    /// Notes is the method where iam passing amount as a parameter to check the count and notes which can be given as a change.
    /// </summary>
    static int count = 0;
    public void Notes(int amount)
	{
        int[] note = new int[] {1000,500,100,50,10,5,2,1};
        for (int i=0;i<note.Length;i++)
        {
            if (amount / note[i] >= 1)
            {
                amount = amount - note[i];
                count++;
                Console.WriteLine("notes are:"+" "+note[i]);
                if (amount != 0)
                {
                    this.Notes(amount);
                }
                else
                {
                    return;
                }
                break;
            }
            else
            {
                continue;
            }
        }
       
    }
    public int retCount()
    {
        return count;
    }
}

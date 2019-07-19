// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queestion_Game.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Question_game is a class where we have to find the exact number which a person is storing in his mind.
/// </summary>
public class Question_Game
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Question_Game"/> class.
    /// </summary>
    public Question_Game()
	{
        int[] array = new int[] { 2, 4, 6, 12, 6, 7, 117, 118, 120, 200 };
        char ch;
        int first = 0, last = array.Length - 1;
        Console.WriteLine("keep 1 number in ur mind and dont tell from the below list");
        for(int i=0;i<array.Length;i++)
        {
            Console.WriteLine(array[i] + " ");
        }
        Console.WriteLine("enter 1 if you are done");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num==1)
        {
            Array.Sort(array);
            while(first<=last)
            {
                int mid = (first + last) / 2;
                Console.WriteLine("is your number less than or equal to" + array[mid] + "?(y/n):");
                ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'y' || ch == 'Y')
                {
                    last = mid;
                    Console.WriteLine("is" + array[mid] + "your number?(y/n)");
                    ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'y' || ch == 'Y')
                    {
                        Console.WriteLine("thankyou for playing" + array[mid]);
                        break;
                    }
                }
                else
                {
                    first = mid;
                    Console.WriteLine("is" + array[mid] + "your number?(y/n)");
                    ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'y' || ch == 'Y')
                    {
                        Console.WriteLine("thankyou for playing" + array[mid]);
                        break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Please click only only if ur done to continue");
        }
	}
}

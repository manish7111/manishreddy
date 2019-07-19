// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tic_Tac_Toe.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Tic_Tac_Toe is a class where i created a method Play where user and computer gives the input.
/// </summary>
public class Tic_Tac_Toe
{
    /// <summary>
    /// Plays this instance and declares who wins the game.
    /// </summary>
    public void Play()
    {
        Console.WriteLine("Enter rows and Columns");

        ////Initializing of array with negative integers
        int[,] array = new int[,] { { -1, -2, -3 },{ -4, -5, -6 },{ -7, -8, -9 } };

        ////Initializing of coordinates x,y
        int i = 0,x,y;

        ////Creating a object of an Random class
        Random random = new Random();

        ////As we are having only 9 positions in the board 
        while(i<9)
        {

            ////Giving the positive position turn to the user
            if (i % 2 == 0)
            {
                do
                {
                    Console.WriteLine("user enter the coordinates");

                    ////Reding of coordinates from the user
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                } while (array[x, y] > 0);

                ////Storing of value 1 in that coordinate position in the board
                array[x, y] = 1;

                ////Checks the condition if ture then prints user is win
                ////This. is a keyword which is used to refer current class elements
                ////Iam calling a win method by using this keyword
                if (this.Win(array) == 1)
                {
                    Console.WriteLine("user is winner");
                    break;
                }

                ////Incrementing the position
                i++;
            }
            else
            {

                do
                {
                    Console.WriteLine("computer enter the coordinates");

                    ////Reading of coordinates randomly by using random function
                    x = random.Next(3);
                    y = random.Next(3);
                } while (array[x, y] > 0);

                ////Storing of value 2 in that coordinate position in the board
                array[x, y] = 2;

                ////Checks the condition and prints computer is win
                if (this.Win(array) == 1)
                {
                    Console.WriteLine("computer is winner");
                    break;
                }
                i++;
            }
        }

        //if this condition becomes true then its a Draw match
        if (this.Win(array) != 1)
        {
            Console.WriteLine("draw");
        }
    }

    public int Win(int[,] array)
    {
        for (int i = 0; i < 3; i++)
        {

            //conditions given to get the winning status on the board
            if (array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2])
            {
                return 1;


            }
            else if (array[0, i] == array[1, i] && array[1, i] == array[2, i])
            {
                return 1;
            }
         
        }
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2])
            {
                return 1;
            }
             if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0])
             {
                return 1;
             }
        return 0;

    }

}

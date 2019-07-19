// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Flip_Coin.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Created the class Flip_Coin where i added a method flip to find the number of flips of a coin and to find win%.
/// </summary>
public class Flip_Coin 
{
    /// <summary>
    /// Flip is the instance method created to find the number of flips and percentage of tail and head.
    /// </summary>
    public void Flip()
    { 
        Console.WriteLine("Enter number of Flips");

        ////Reading of number of flips from the user
        double flip = Convert.ToDouble(Console.ReadLine());

        ////Initially heads and tails are 0
        double tail = 0;                                        
        double head = 0;

        ////As asked we have to read the values randomly btw 0 and 1 we call random class
        Random random = new Random();                                
        
        if (flip>0)
        {
            for (int i = 0; i < flip; i++)
            {

                ////Calling of random function to read the values btw 0 and 1
                double result = random.NextDouble();                   
                if (result < 0.5)                                 
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
        }
        else
        {
            Console.WriteLine("enter positive num");
        }

        ////Calculating the percentage of heads and tails
        double tail_per = (tail / flip) * 100;                         
        double head_per = (head / flip) * 100;
        Console.WriteLine("Percentage of tail is:" + tail_per);
        Console.WriteLine("Percentage of head is:" + head_per);
    }
}

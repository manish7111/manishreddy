﻿using System;

public class Gambler
{
	public void Display()
	{
        Console.WriteLine("enter Stake");

        //Reading of stake from the user
        double stake = Convert.ToDouble(Console.ReadLine());       
        Console.WriteLine("Enter Goal");

        //Reading of goal from the user
        double goal = Convert.ToDouble(Console.ReadLine());

        //Accessing the random class as we want the values randomly btw 0 and 1
        Random r = new Random();

        //Initializing of variables
        double count = 0, count_win = 0, count_loss = 0;          
        while (stake > 0 && stake <= goal)
            {
            count++;

            //calling of static function present in random class
            double d = r.NextDouble();                             
            if (d>0.5)
                {
                stake++;

                //count of number of wins
                count_win++;                                     
                }
                else
                {
                stake--;
                count_loss++;
                }
           
            }
        Console.WriteLine("No of bets "+count);
        Console.WriteLine("Wins -->"+count_win);

        //calculating of win and loss percentage
        double win_per = (count_win*100) / count ;                
        double loss_per = (count_loss*100) / count ;

        //printing the win percentage and loss percentage
        Console.WriteLine("% Wins-->"+win_per);                  
        Console.WriteLine("% Loss-->"+loss_per);
    }
}

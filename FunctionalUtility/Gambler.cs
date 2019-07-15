using System;

public class Gambler
{
	public void Display()
	{
        Console.WriteLine("enter Stake");
        double stake = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Goal");
        double goal= Convert.ToDouble(Console.ReadLine());
        Random r = new Random();

        double count = 0, count_win = 0, count_loss = 0;
        while (stake > 0 && stake <= goal)
            {
            count++;

            double d = r.NextDouble();
            if (d>0.5)
                {
                stake++;
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
        double win_per = (count_win*100) / count ;
        double loss_per = (count_loss*100) / count ;
        Console.WriteLine("% Wins-->"+win_per);
        Console.WriteLine("% Loss-->"+loss_per);
    }
}

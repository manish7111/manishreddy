using System;

public class Flip_Coin 
{
	public void Flip()
	{
        Console.WriteLine("Enter number of Flips");
        double f = Convert.ToDouble(Console.ReadLine());
        double tail = 0;
        double head = 0;
        Random r = new Random();
        
        if (f>0)
        {
            for (int i = 0; i < f; i++)
            {
                double result = r.NextDouble();
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
        double tail_per = (tail / f) * 100;
        double head_per = (head / f) * 100;
        Console.WriteLine("Percentage of tail is:" + tail_per);
        Console.WriteLine("Percentage of head is:" + head_per);
    }
}

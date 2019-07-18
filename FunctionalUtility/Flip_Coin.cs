using System;

public class Flip_Coin 
{
	public void Flip()
	{
        Console.WriteLine("Enter number of Flips");

        //reading of number of flips from the user
        double f = Convert.ToDouble(Console.ReadLine());

        //Initially heads and tails are 0
        double tail = 0;                                        
        double head = 0;

        // as asked we have to read the values randomly btw 0 and 1 we call random class
        Random r = new Random();                                
        
        if (f>0)
        {
            for (int i = 0; i < f; i++)
            {

                //calling of random function to read the values btw 0 and 1
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

        //calculating the percentage of heads and tails
        double tail_per = (tail / f) * 100;                         
        double head_per = (head / f) * 100;
        Console.WriteLine("Percentage of tail is:" + tail_per);
        Console.WriteLine("Percentage of head is:" + head_per);
    }
}

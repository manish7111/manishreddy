using System;

public class Stop_Watch
{
	public void Watch()
	{
        String s = Console.ReadLine();
        TimeSpan t = TimeSpan.Zero;

//        TimeSpan t = new TimeSpan();
        int hour = t.Hours;
        int min = t.Minutes;
        int sec = t.Seconds;
        int milsec = t.Milliseconds;

        Console.WriteLine("Total time: {0}", t.Milliseconds);

        if (s.Equals("s"))
        {
            Console.WriteLine("program Started");
            Console.WriteLine(milsec);
            String s1 = Console.ReadLine();
            if(s1.Equals("e"))
            {
                Console.WriteLine("Program stopped");
                int hour1 = t.Hours;
                int min1 = t.Minutes;
                int sec1 = t.Seconds;
                int milsec1 = t.Milliseconds;
                Console.WriteLine(milsec1);
                Console.WriteLine("total time taken:" + "hours:" + (hour1 - hour) + " " + "minutes:" + (min1 - min) + " " + "seconds:" + (sec1 - sec));
                Console.WriteLine(t.ToString());
            }
            else
            {
                Console.WriteLine("Enter correct charecter to stop");
            }
        }
        else
        {
            Console.WriteLine("Enter correct charecter to start");
        }

	}
}

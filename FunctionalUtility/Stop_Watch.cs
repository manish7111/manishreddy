using System;

public class Stop_Watch
{
	public void Watch()
	{
        Console.WriteLine("Enter String");

        //reads input string from the user 
        String s = Console.ReadLine();

        //creating object of an predefined class to access its functionalities
        TimeSpan t = TimeSpan.Zero;

        //call to the functionalities
        int hour = t.Hours;                    
        int min = t.Minutes;
        int sec = t.Seconds;
        int milsec = t.Milliseconds;

        Console.WriteLine("Total time: {0}", t.Milliseconds);

        //condition to check the String enterd from the user is "s" to start the program

        if (s.Equals("s"))                     
        {
            Console.WriteLine("program Started");
            Console.WriteLine(milsec);

            //read another string to end the program
            String s1 = Console.ReadLine();

            //condition to stop
            if (s1.Equals("e"))                  
            {
                Console.WriteLine("Program stopped");

                //accesing the functionalities

                int hour1 = t.Hours;           
                int min1 = t.Minutes;
                int sec1 = t.Seconds;
                int milsec1 = t.Milliseconds;
                Console.WriteLine(milsec1);
                Console.WriteLine("total time taken:" + "hours:" + (hour1 - hour) + " " + "minutes:" + (min1 - min) + " " + "seconds:" + (sec1 - sec));

                //print the time in the format of 00:00:00
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

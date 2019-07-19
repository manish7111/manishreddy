// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stop_Watch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Stop_Watch is a class where Watch methos is declared.
/// </summary>
public class Stop_Watch
{
    /// <summary>
    /// Watche is the method which is used to display the time span of the program between start and stop.
    /// </summary>
    public void Watch()
	{
        Console.WriteLine("Enter String");

        ////Reads input string from the user 
        String str = Console.ReadLine();

        ////Creating object of an predefined class to access its functionalities
        TimeSpan timespan = TimeSpan.Zero;

        ////Call to the functionalities
        int hour = timespan.Hours;                    
        int min = timespan.Minutes;
        int sec = timespan.Seconds;
        int milsec = timespan.Milliseconds;

        Console.WriteLine("Total time: {0}", timespan.Milliseconds);

        ////Condition to check the String enterd from the user is "s" to start the program

        if (str.Equals("s"))                     
        {
            Console.WriteLine("program Started");
            Console.WriteLine(milsec);

            ////Read another string to end the program
            String str1 = Console.ReadLine();

            ////Condition to stop
            if (str1.Equals("e"))                  
            {
                Console.WriteLine("Program stopped");

                ////Accesing the functionalities

                int hour1 = timespan.Hours;           
                int min1 = timespan.Minutes;
                int sec1 = timespan.Seconds;
                int milsec1 = timespan.Milliseconds;
                Console.WriteLine(milsec1);
                Console.WriteLine("total time taken:" + "hours:" + (hour1 - hour) + " " + "minutes:" + (min1 - min) + " " + "seconds:" + (sec1 - sec));

                ////Print the time in the format of 00:00:00
                Console.WriteLine(timespan.ToString());    
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

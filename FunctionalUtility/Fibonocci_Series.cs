using System;

public class Fibonocci_Series
{
	public void Series()
	{
        Console.WriteLine("enter number between which u want to find the series");

        //read of number from the user
        int n = Convert.ToInt32(Console.ReadLine());

        //Initializing the values
        int f0 =0,f1=1,f2;                               
        Console.WriteLine("Fibonocci series are:");

        //for loop until conditions comes false
        for (int i=0;i<n;i++)                            
        {
            //print f0 as it gives us the required result
            Console.Write(f0 + " ");

            //as known always 3rd value will be the sum of 1st and 2nd 
            f2 = f0 + f1;

            //initializing of 1st variable with 2nd
            f0 = f1;

            //initializing of 2nd variable with 3rd
            f1 = f2;                                    
        }
	}
}

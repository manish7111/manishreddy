using System;

public class Payment
{
	public void MonthlyPayment()
	{
        Console.WriteLine("enter Principle loan amount");

        //reading of principle intrest from user
        double P = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter Years to pay the amount");

        //reading of number of years from the user
        double Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter Rate of Intrest");

        //reading of rate of interest from the user
        double R = Convert.ToDouble(Console.ReadLine());
        double n = 12 * Y;
        double r = R / (12 * 100);

        //using the formula by using required functions
        double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
        Console.WriteLine(Math.Round(payment));
    }
}

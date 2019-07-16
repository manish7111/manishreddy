using System;

public class Payment
{
	public void MonthlyPayment()
	{
        Console.WriteLine("enter Principle loan amount");
        double P = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter Years to pay the amount");
        double Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter Rate of Intrest");
        double R = Convert.ToDouble(Console.ReadLine());
        double n = 12 * Y;
        double r = R / (12 * 100);
        double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
        Console.WriteLine(Math.Round(payment));
    }
}

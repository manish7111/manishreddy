using System;

public class Coupon_Number
{
	public void Distinct_Coupon()
	{
        Console.WriteLine("Enter n coupon  numbers");
        int n = Convert.ToInt32(Console.ReadLine());
        bool[] collection = new bool[n];
        int count = 0;
        int distinct = 0;
        Random r = new Random();
        while(distinct<n)
        {
            int i = Convert.ToInt32((r.Next(n)));  //takes random values between 0 to n
            count++;
            if(!collection[i])                     //checks for the value if present in array else add
            {
                distinct++;
                Console.WriteLine("total distinct numbers are" +distinct);
                collection[i] = true;
            }
        }
        Console.WriteLine("total random  numbers needed to make all distinct");
        Console.WriteLine(count);
    }
}

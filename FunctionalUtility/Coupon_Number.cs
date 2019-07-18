using System;

public class Coupon_Number
{
	public void Distinct_Coupon()
	{
        Console.WriteLine("Enter n coupon  numbers");

        //reding of input 
        int n = Convert.ToInt32(Console.ReadLine());

        //boolean array to store only distinct numbers while avoiding dupicates
        bool[] collection = new bool[n];                    
        int count = 0;
        int distinct = 0;
        Random r = new Random();
        while(distinct<n)
        {

            //takes random values between 0 to n
            int i = Convert.ToInt32((r.Next(n)));  
            count++;

            //verify and enter into if block
            if (!collection[i])                    
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

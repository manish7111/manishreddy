using System;
using FunctionalUtility;

namespace Program
{
    class Program                                                                                                                                                               
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to execute");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    String_Replace s = new String_Replace();
                    s.Replace();
                    break;
                case 2:
                    Flip_Coin f = new Flip_Coin();
                    f.Flip();
                    break;
                case 3:
                    Leap_Year l = new Leap_Year();
                    l.Year();
                    break;
                case 4:
                    Power p = new Power();
                    p.Pow();
                    break;
                case 5:
                    Harmonic_Number h = new Harmonic_Number();
                    h.Display();
                    break;
                case 6:
                    Prime_Factor p1 = new Prime_Factor();
                    p1.Factor();
                    break;
                case 7:
                    Gambler g = new Gambler();
                    g.Display();
                    break;
                case 8:
                    Sum_Of_Integers s1 = new Sum_Of_Integers();
                    s1.sum();
                    break;
                case 9:
                    Distance d = new Distance();
                    d.Calculate();
                    break;
                case 10:
                    Quadratic q = new Quadratic();
                    q.Calculate();
                    break;
                case 11:
                    Stop_Watch sw = new Stop_Watch();
                    sw.Watch();
                    break;
                case 12:
                    Wind_Chill w = new Wind_Chill();
                    w.Print();
                    break;
                case 13:
                    Binary_Search b = new Binary_Search();
                    b.Insert1();
                    b.Insert2();
                    b.Search1();
                    b.Search2();
                    b.Sort();
                    b.Sort2();
                    break;
                case 14:
                    Insertion_Sort i = new Insertion_Sort();
                    i.Sorting();
                    break;
                case 15:
                    Two_D_Array t = new Two_D_Array();
                    t.Array();
                    break;
                case 16:
                    Coupon_Number c = new Coupon_Number();
                    c.Distinct_Coupon();
                    break;
                case 17:
                    Tic_Tac_Toe tic = new Tic_Tac_Toe();
                    tic.Play();
                    break;
                case 18:
                    Console.WriteLine("Enter n");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Prime_Num prime = new Prime_Num();
                    prime.Check(n);
                    break;
                case 19:
                    Gregorian_Calender.dayOfWeek();
                    break;
                case 20:
                    Temperature temp = new Temperature();
                    Console.WriteLine("Enter Celcius temperature");
                    double cel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Fahrenheit temperature");
                    double far = Convert.ToDouble(Console.ReadLine());
                    temp.Celcious_To_Fahrenheit(cel);
                    temp.Fahrenheit_To_Celcious(far);
                    break;
                case 21:
                    Payment pay = new Payment();
                    pay.MonthlyPayment();
                    break;
                case 22:
                    Bubble_Sort bubble = new Bubble_Sort();
                    bubble.Sort();
                    break;
                case 23:
                    Vending_Machine v = new Vending_Machine();
                    Console.WriteLine("Enter note");
                    int note = Convert.ToInt32(Console.ReadLine());
                    v.Notes(note);
                    Console.WriteLine("Number of notes : " + v.retCount());
                    break;
                default:
                    Console.WriteLine("Enter correct num");
                    break;
            }   
        }
    }

}

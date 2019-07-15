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
            }   
        }
    }

}

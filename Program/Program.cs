// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using FunctionalUtility;

namespace Program
{
    /// <summary>
    /// Program is a class which contains all the objects and a switch loop to execute what program we want to execute
    /// </summary>
    class Program                                                                                                                                                               
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.Write("\n 1.String replace. \n 2.Flip coin. \n 3.Leap Year. \n 4.Power of 2 table. \n 5.Harmonic number. ");
            Console.Write("\n 6.Prime_Factor. \n 7. Gambler. \n 8.Triplets. \n 9.Distance. \n 10.Quadratic Equation");
            Console.Write("\n 11.Stop_watch. \n 12.Wind Chill. \n 13.Binary_Search. \n 14.Inseartion sort. \n 15.Two_D_Array");
            Console.Write("\n 16.Coupen number. \n 17.Tic_Tac_toe. \n 18.Prime_Number. \n 19.Guorgeon calender \n 20.Temperature");
            Console.Write("\n 21.Payment. \n 22.Bubble_Sort. \n 23.Vending machine. \n 24.Merge sort. \n 25.Fibonocci series");
            Console.WriteLine("Enter the number to execute");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    String_Replace replace = new String_Replace();
                    replace.Replace();
                    break;
                case 2:
                    Flip_Coin flip = new Flip_Coin();
                    flip.Flip();
                    break;
                case 3:
                    Leap_Year leapyear = new Leap_Year();
                    leapyear.Year();
                    break;
                case 4:
                    Power pow = new Power();
                    pow.Pow();
                    break;
                case 5:
                    Harmonic_Number harmonic = new Harmonic_Number();
                    harmonic.Display();
                    break;
                case 6:
                    Prime_Factor prime = new Prime_Factor();
                    prime.Factor();
                    break;
                case 7:
                    Gambler gambler = new Gambler();
                    gambler.Display();
                    break;
                case 8:
                    Sum_Of_Integers sum = new Sum_Of_Integers();
                    sum.Sum();
                    break;
                case 9:
                    Distance dist = new Distance();
                    dist.Calculate();
                    break;
                case 10:
                    Quadratic quadratic = new Quadratic();
                    quadratic.Calculate();
                    break;
                case 11:
                    Stop_Watch sw = new Stop_Watch();
                    sw.Watch();
                    break;
                case 12:
                    Wind_Chill wind = new Wind_Chill();
                    wind.Print();
                    break;
                case 13:
                    Binary_Search binary = new Binary_Search();
                    binary.Insert1();
                    binary.Insert2();
                    binary.Search1();
                    binary.Search2();
                    binary.Sort();
                    binary.Sort2();
                    break;
                case 14:
                    Insertion_Sort insert = new Insertion_Sort();
                    insert.Sorting();
                    break;
                case 15:
                    Two_D_Array two = new Two_D_Array();
                    two.Array();
                    break;
                case 16:
                    Coupon_Number coupon = new Coupon_Number();
                    coupon.Distinct_Coupon();
                    break;
                case 17:
                    Tic_Tac_Toe tic = new Tic_Tac_Toe();
                    tic.Play();
                    break;
                case 18:
                   
                    Prime_Num primenum = new Prime_Num();
                    primenum.Demo();
                    break;
                case 19:
                    Gregorian_Calender.DayOfWeek();
                    break;
                case 20:
                    Temperature temp = new Temperature();
                    temp.Test();
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
                    Vending_Machine vending = new Vending_Machine();
                    Console.WriteLine("Enter note");
                    int note = Convert.ToInt32(Console.ReadLine());
                    vending.Notes(note);
                    Console.WriteLine("Number of notes : " + vending.retCount());
                    break;
                case 24:
                    Merge_Sort merge = new Merge_Sort();
                    merge.Demo();
                    break;
                case 25:
                    Fibonocci_Series fib = new Fibonocci_Series();
                    fib.Series();
                    break;
                case 26:
                    Question_Game question = new Question_Game();
                    break;
                case 27:
                    Read_From_File read = new Read_From_File();
                    break;
                case 29:
                    Sorting sort = new Sorting();
                    break;
                case 30:
                    Week_Of_The_Day day = new Week_Of_The_Day();
                default:
                    Console.WriteLine("Enter correct num");
                    break;
            }   
        }
    }

}

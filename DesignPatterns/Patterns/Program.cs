// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
/// <summary>
/// Patterns is the NameSpace where i declared Program class to execute the programs.
/// </summary>
namespace Patterns
{
    /// <summary>
    /// Program is a class .
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calling of all the classes by using Switch case.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to execute");
            Console.WriteLine("1.Singleton Pattern.\n2.Factory Pattern CreditCard.\n3.Factory Pattern Computer.\n4.ProtoType Pattern.\n5.Adapter Pattern Vehicle");
            Console.WriteLine("6.Socket Adapter Pattern.\n7.Proxy Design Pattern.\n8.Facade Design Pattern.\n9.Observer Design Pattern.\n10.Visitor Design Pattern");
            Console.WriteLine("11.Decorator Pattern.\n12.Example on Annotation.\n13.Dependency Injection.\n14.example on Reflection.//");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Parallel.Invoke(() => SingletonProgram.ManagerRequest(), () => SingletonProgram.EmployeeRequest());
                    break;
                case 2:
                    Execute.Run();
                    break;
                case 3:
                    MainFactory.Run();
                    break;
                case 4:
                    PatternTest.Start();
                    break;
                case 5:
                    Shop.Buy();
                    break;
                case 6:
                    TestAdapter.TestObjectAdapter();
                    TestAdapter.TestClassAdapter();
                    break;
                case 7:
                    TestShape.DisplayShape();
                    break;
                case 8:
                    Test.DisplayOrder();
                    break;
                case 9:
                    ObserverTest.Display();
                    break;
                case 10:
                    VisitorPattern.DisplayDetails();
                    break;
                case 11:
                    TestDecorator.Display();
                    break;
                case 12:
                    TestAnnotation.Display();
                    break;
                case 13:
                    TestDependency.DependencyInjection();
                    break;
                case 14:
                    ReflectionTest.Test();
                    break;
            }
        }
    }
}                                

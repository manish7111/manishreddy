// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Reflection;
/// <summary>
/// ReflectionTest is a class where i declared Test method.
/// </summary>
public class ReflectionTest
{
    /// <summary>
    /// Tests this instance.
    /// </summary>
    public static void Test()
    {
        ////Type is class where iam creating the object and calling the inbuilt function GetType.
        Type type = Type.GetType("Customer");

        ////printing the full name.
        Console.WriteLine("Full Name :{0}", type.FullName);

        ////printing the Class name.
        Console.WriteLine("Class name is:{0}", type.Name);
        Console.WriteLine("Methods in customer class ");

        ////storing the number of methods in an array which is of MethodInfo class.
        MethodInfo[] methods = type.GetMethods();

        ////Traversing the data present in the method object.
        foreach(MethodInfo method in methods)
        {
            Console.WriteLine(method.ReturnType.Name + " " + method.Name);
        }
        Console.WriteLine("Properties in Customer Class");

        ////PropertyInfo is a class where iam storing the properties of customer class in the form of array.
        PropertyInfo[] properties = type.GetProperties();

        ////Traversing the data present in the property object.
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine(property.PropertyType.Name + " " + property.Name);
        }
        Console.WriteLine("Constructors in customer class");

        ////ConstructorInfo is a class where iam storing the constructors of customer class in the form of array.
        ConstructorInfo[] constructors = type.GetConstructors();

        ////Traversing the data present in the constructor object.
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor.ToString());
        }
    }
}

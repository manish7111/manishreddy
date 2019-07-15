using System;

public class Binary_Search
{
    public void Search1()
    {
        Console.WriteLine("Enter the size of the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Enter the value to be searched");
        int s_val = Convert.ToInt32(Console.ReadLine());
        int first = 0, last = a.Length - 1;

        while (first <= last)
        {
            int mid = (first + last) / 2;
            if (a[mid] == s_val)
            {
                Console.WriteLine("number found At index: " + mid);
                break;

            }
            else if (s_val < a[mid])
            {
                last = mid - 1;

            }
            else
            {
                first = mid + 1;

            }
        }
    }

    public void Search2()
    {
        Console.WriteLine("Enter the String");
        String s = Console.ReadLine();
        char[] ch = s.ToCharArray();
        Console.WriteLine("Enter the value to be searched");
        char s_val = Convert.ToChar(Console.ReadLine());
        int first = 0, last = ch.Length - 1;
        while (first <= last)
        {
            int mid = (first + last) / 2;
            if (ch[mid] == s_val)
            {
                Console.WriteLine("Character found At index: " + mid);
                break;

            }
            else if (s_val < ch[mid])
            {
                last = mid - 1;

            }
            else
            {
                first = mid + 1;

            }
        }

    }

    public void Insert1()
    {
        Console.WriteLine("Enter the size of the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[10];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Enter the element to be inserted");
        int in_ele = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the index");
        int index = Convert.ToInt32(Console.ReadLine());
        for (int i = n - 1; i >= index - 1; i--)
        {
            int temp = a[i + 1];
            a[i + 1] = a[i];
            a[i] = temp;
        }
        a[index - 1] = in_ele;
        for (int i = 0; i <= a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

    }

    public void Insert2()
    {
        Console.WriteLine("Length");
        int n = Convert.ToInt32(Console.ReadLine());
        char[] ch = new char[n];
        Console.WriteLine("Enter the String");
        String s = Console.ReadLine();
        ch=s.ToCharArray();
        Console.WriteLine(ch.Length);
        Console.WriteLine("Enter the value to be inserted");
        char in_val = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter the index");
        int index = Convert.ToInt32(Console.ReadLine());
        for (int i = ch.Length - 1; i >= index - 1; i--)
        {
            char temp = ch[i + 1];
            ch[i + 1] =ch[i];
            ch[i] = temp;
        }
        ch[index - 1] = in_val;
        try
        {
            for (int i = 0; i <= ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
        } catch (IndexOutOfRangeException) {
          
            Console.WriteLine("out of bound");
        }
    }
}

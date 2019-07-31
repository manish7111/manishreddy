using Newtonsoft.Json;
using System;
using System.IO;

public class AddressBook
{
    public void Details(string file)
    {
        string message = null; ;
        AddressBookDetails addressBookDetails = new AddressBookDetails();
        try
        {
            ////reading of file by using streamreader
            using (StreamReader read = new StreamReader(file))
            {
                ////reading the file to the end.
                var json = read.ReadToEnd();

                ////for deserializing the json data into string data
                AddressBookDetails[] data = JsonConvert.DeserializeObject<AddressBookDetails[]>(json);
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine("number" + i);
                    Console.WriteLine("name is:" + " " + data[i].Name);
                    Console.WriteLine("contact number is:" + " " + data[i].ContactNumber);
                    Console.WriteLine("Address is:" + " " + data[i].Address);
                    Console.WriteLine("state is:" + " " + data[i].State);
                    Console.WriteLine("Pin number is:" + " " + data[i].Pin);

                }
                Console.WriteLine("Enter the name u want to update");
                string name = Console.ReadLine();
                for (int i = 0; i < data.Length; i++)
                {
                    if (name == data[i].Name)
                    {
                        Console.WriteLine("Enter to change phone number");
                        long number = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("name is:" + " " + data[i].Name);
                        Console.WriteLine("contact number is:" + " " + number);
                        Console.WriteLine("Address is:" + " " + data[i].Address);
                        Console.WriteLine("state is:" + " " + data[i].State);
                        Console.WriteLine("Pin number is:" + " " + data[i].Pin);
                        message = " ";
                    }
                    else
                    {
                        message = "You cannot Update";
                    }
                }
                Console.WriteLine(message);
                Console.WriteLine("do u want to continue(y/n)");
                string repeat = Console.ReadLine();

                ////for repeating the process.
                if (repeat == "y" || repeat == "Y")
                {
                    AddressBook addressBook = new AddressBook();
                    addressBook.Details(file);
                }
         
            }
           
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }

    }

    public void Add(string file)
    {
        AddressBookDetails addressBookDetails = new AddressBookDetails();
        try
        {
            ////reading of file by using streamreader
            using (StreamReader read = new StreamReader(file))
            {
                ////reading the file to the end.
                var json = read.ReadToEnd();

                ////for deserializing the json data into string data
                AddressBookDetails[] data = JsonConvert.DeserializeObject<AddressBookDetails[]>(json);
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine("number" + i);
                    Console.WriteLine("name is:" + " " + data[i].Name);
                    Console.WriteLine("contact number is:" + " " + data[i].ContactNumber);
                    Console.WriteLine("Address is:" + " " + data[i].Address);
                    Console.WriteLine("state is:" + " " + data[i].State);
                    Console.WriteLine("Pin number is:" + " " + data[i].Pin);

                }
                Array.Resize(ref data, data.Length + 1);
                Console.WriteLine("enter the search name to add");
                string sName = Console.ReadLine();
               
                for (int i = 0; i < data.Length; i++)
                {

                    if (data[i]==null)
                    {
                       
                        {
                            Console.WriteLine("Enter details  1.name     2.contact number     3.Address     4.state    5.Pin");
                            string name = Console.ReadLine();
                            long number = Convert.ToInt64(Console.ReadLine());
                            string address = Console.ReadLine();
                            string state = Console.ReadLine();
                            long pin = Convert.ToInt64(Console.ReadLine());

                            Console.WriteLine("number" + i);
                            Console.WriteLine("name is:" + " " + name);
                            Console.WriteLine("contact number is:" + " " + number);
                            Console.WriteLine("Address is:" + " " + address);
                            Console.WriteLine("state is:" + " " + state);
                            Console.WriteLine("Pin number is:" + " " + pin);
                           
                        }                     
                    }
                    try
                    {
                        string save = JsonConvert.SerializeObject(data);
                        System.IO.File.WriteAllText(@"C:\Users\Admin\source\repos\OOPs\AddressBook\AddressBook.json", save);
                        Console.WriteLine("Added");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                //Console.WriteLine("Updated details");
                //for (int i = 0; i <= data.Length; i++)
                //{
                //    Console.WriteLine("number" + i);
                //    Console.WriteLine("name is:" + " " + data[i].Name);
                //    Console.WriteLine("contact number is:" + " " + data[i].ContactNumber);
                //    Console.WriteLine("Address is:" + " " + data[i].Address);
                //    Console.WriteLine("state is:" + " " + data[i].State);
                //    Console.WriteLine("Pin number is:" + " " + data[i].Pin);

                //}
            }
            
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}

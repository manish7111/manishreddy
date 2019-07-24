using System;

namespace DataStructure
{

public class Unordered_List
{
    public void Search()
    {
       
       
        try
        {
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Admin\\Documents\\development.txt", True);
            file.WriteLine("Here is the first string.");
        } catch (Exception e)
        {
            e.printStackTrace();
        }
        finally
        {
            fw.close();
        }


    }
}
}

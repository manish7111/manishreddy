using System;

public class Tic_Tac_Toe
{
    public void Play()
    {
        Console.WriteLine("Enter rows and Columns");

        //initializing of array with negative integers
        int[,] a = new int[,] { { -1, -2, -3 },{ -4, -5, -6 },{ -7, -8, -9 } };

        //initializing of coordinates x,y
        int i = 0,x,y;

        //creating a object of an Random class
        Random r = new Random();

        //as we are having only 9 positions in the board 
        while(i<9)
        {

            //giving the positive position turn to the user
            if (i % 2 == 0)
            {
                do
                {
                    Console.WriteLine("user enter the coordinates");

                    //reding of coordinates from the user
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                } while (a[x, y] > 0);

                //storing of value 1 in that coordinate position in the board
                a[x, y] = 1;

                //checks the condition if ture then prints user is win
                //this. is a keyword which is used to refer current class elements
                //iam calling a win method by using this keyword
                if (this.Win(a) == 1)
                {
                    Console.WriteLine("user is winner");
                    break;
                }

                //incrementing the position
                i++;
            }
            else
            {

                do
                {
                    Console.WriteLine("computer enter the coordinates");

                    //reading of coordinates randomly by using random function
                    x = r.Next(3);
                    y = r.Next(3);
                } while (a[x, y] > 0);

                //storing of value 2 in that coordinate position in the board
                a[x, y] = 2;

                //checks the condition and prints computer is win
                if (this.Win(a) == 1)
                {
                    Console.WriteLine("computer is winner");
                    break;
                }
                i++;
            }
        }

        //if this condition becomes true then its a Draw match
        if (this.Win(a) != 1)
        {
            Console.WriteLine("draw");
        }
    }

    public int Win(int[,] a)
    {
        for (int i = 0; i < 3; i++)
        {

            //conditions given to get the winning status on the board
            if (a[i, 0] == a[i, 1] && a[i, 1] == a[i, 2])
            {
                return 1;


            }
            else if (a[0, i] == a[1, i] && a[1, i] == a[2, i])
            {
                return 1;
            }
         
        }
            if (a[0, 0] == a[1, 1] && a[1, 1] == a[2, 2])
            {
                return 1;
            }
             if (a[0, 2] == a[1, 1] && a[1, 1] == a[2, 0])
             {
                return 1;
             }
        return 0;

    }

}

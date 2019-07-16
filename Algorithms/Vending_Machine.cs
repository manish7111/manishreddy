using System;

public class Vending_Machine
{
    static int count = 0;
    public void Notes(int amount)
	{
        int[] note = new int[] {1000,500,100,50,10,5,2,1};
        for (int i=0;i<note.Length;i++)
        {
            if (amount / note[i] >= 1)
            {
                amount = amount - note[i];
                count++;
                Console.WriteLine("notes are:"+" "+note[i]);
                if (amount != 0)
                {
                    this.Notes(amount);
                }
                else
                {
                    return;
                }
                break;
            }
            else
            {
                continue;
            }
        }
       
    }
    public int retCount()
    {
        return count;
    }
}

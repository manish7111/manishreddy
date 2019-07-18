using System;

public class Merge_Sort
{
    public void Demo()
    {

        Console.WriteLine("enter the length of an array");          //reading of length of an array from user
        int n = Convert.ToInt32(Console.ReadLine());                             //taking an array of integer type
        Console.WriteLine("enter the elements in the array");
        int[] arr = new int[n];
        for(int i=0;i<n;i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int low = 0, high = n - 1;
        Merge_Sorting(arr, low, high);
    }
    public void Merge_Sorting(int[] arr,int low,int high)
    {
        int mid;
        if(low<high)
        {
            mid = (low + high) / 2;
            Merge_Sorting(arr, low, mid);
            Merge_Sorting(arr, mid + 1, high);
            Sort(arr, low, mid, high);
        }
    }
    public void Sort(int[] arr, int low, int mid, int high)
    {
        int i, j, k;
        int[] a = new int[30];
        i = low;
        j = mid + 1;
        k = low;
        while((i<=mid)&&(j<=high))
        {
            if(arr[i]<arr[j])
            {
                a[k] = arr[i];
                k++;
                i++;
            }
            else
            {
                a[k] = arr[j];
                k++;
                j++;
            }
        }

        while(i<=mid)
        {
            a[k] = arr[i];
            k++;
            i++;
        }
        while (j<=high)
        {
            a[k] = arr[j];
            k++;
            j++;
        }
        for(int c=0;c<k;c++ )
        {
            arr[i] = a[i];
        }

        for (int b = low; b < high; b++)
        {
            arr[i] = a[i];
        }
    }
}

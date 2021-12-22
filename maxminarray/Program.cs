using System;

class program
{
    static void Main(string[] args)
    {
        int[] arr = {  9,7, 78,1,100,200 } ;
        int  i,min, max;
        int n=arr.Length;
        max = arr[0];
        min = arr[0];
        for (i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
               
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Maximum element is =   " + max);
        Console.Write("Minimum element is =   " +min);
        Console.ReadKey();
    }
}













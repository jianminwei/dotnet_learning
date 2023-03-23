
using System;

class Test
{

    public static void Main(string[] args)
    {
        int x = 10;
        int y = 20;

        int tmp = 0;

        tmp = x;
        x = y;
        y = tmp;

        System.Console.WriteLine(x);
        System.Console.WriteLine(y);


    }
}
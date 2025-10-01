// See https://aka.ms/new-console-template for more information
using System;

class Program
{

    public static void Main(string[] args)
    {
        Console.Write("mexicanwave(hello world) =  ");
        mexicanwave("hello");
    }


    static void mexicanwave(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (input.Substring(i, 1).Equals(" "))
            {
                continue;
            }
            else
            {
                String x = input.Substring(i, 1).ToUpper();
                for (int a = 0; a < input.Length; a++)
                {
                    if (a == i)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(input.Substring(a, 1));
                    }
                }
            }
            Console.Write(" ");
        }
        
    }



}
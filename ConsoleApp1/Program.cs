// See https://aka.ms/new-console-template for more information
using System;

class Program
{

    public static void Main(string[] args)
    {


    }


    static String mexicanwave(string input)
    {
        String result = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input.Substring(i, 1).Equals(" "))
            {
                continue;
            }
            else
            {
                String x = input.Substring(i, 1).ToUpper;
            }
        }
        
    }



}
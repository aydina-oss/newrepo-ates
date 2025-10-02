// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{

    public static void Main(string[] args)
    {
        Console.Write("mexicanwave(hello world) =  ");
        mexicanwave("hello");
        Console.WriteLine();
        PrintCharacterCodes("hello", "hello");
        PrintCharacterCodes("你好", "nihao");
        PrintBytes("hello");
        PrintBytes("你好");
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
    static void PrintCharacterCodes(string input, string label)
    {
        Console.WriteLine($"Character codes for {label}:");
        foreach (char c in input)
        {
            Console.WriteLine($"{c} -> {(int)c}");
        }
        Console.WriteLine();
    }
    static void PrintBytes(string text)
    {
        byte[] bytes = Encoding.Default.GetBytes(text);
        Console.WriteLine($"String: {text}");
        Console.WriteLine("Byte array: [" + string.Join(", ", bytes) + "]");
    }
    

    
    



}
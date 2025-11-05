using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
class Program
{


    public static void Main(string[] args)
    {
        Debug.Assert(rightmost(91) == 1);
        Debug.Assert(threerightmost(31) == 7);
        Debug.Assert(leftmost(26) == 1);
        Debug.Assert(threeleftmost(34) == 4);

    }
    static int rightmost(int x)
    {
        int result = x & 1;
        return result;

    }
    static int threerightmost(int x)
    {
        int result = x & 7;
        return result;
    }
    static int leftmost(int x)
    {
        return x >> Convert.ToInt32(Math.Floor(Math.Log2(x)));
    }
    static int threeleftmost(int x)
    {
        return x >> (Convert.ToInt32(Math.Floor(Math.Log2(x))) - 2);

    }
    
       
    







}
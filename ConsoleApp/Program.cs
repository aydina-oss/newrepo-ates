// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
class Program
{

    public static void Main(string[] args)
    {

        //          QUESTION 1
        List<string> wave = mexicanwave("hello");
        Debug.Assert(wave.Count == 5);
        Debug.Assert(wave[0] == "Hello");
        Debug.Assert(wave[4] == "hellO");

        //          QUESTION 2
        List<string> helloCodes = GetCharacterCodes("hello");
        Debug.Assert(helloCodes[0] == "h -> 104");
        Debug.Assert(helloCodes[4] == "o -> 111");
        List<string> chineseCodes = GetCharacterCodes("你好");
        Debug.Assert(chineseCodes.Count == 2);

        //          QUESTION 3
        byte[] helloBytes = GetBytes("hello");
        Debug.Assert(helloBytes.Length == 5);
        Debug.Assert(helloBytes[0] == (byte)'h');
        byte[] chineseBytes = GetBytes("你好");
        Debug.Assert(chineseBytes.Length > 2);

        //          QUESTION 4
        int[] wordCodes = { 956, 942, 955, 959 }; 
        string codeWord = FromCharacterCodes(wordCodes);
        Debug.Assert(codeWord.Length == 4);

        //          QUESTION 5
        byte[] wordBytes = { 206, 188, 206, 174, 206, 187, 206, 191 };
        string codeWord2 = FromBytes(wordBytes);
        Debug.Assert(codeWord2 == codeWord);

        //          QUESTION 6
        int anagramCount = Anagram("star", new string[] { "rats", "arts", "arc" });
        Debug.Assert(anagramCount == 2);

        //          QUESTION 7
        string camel = VariableNameHelper("Cost of cakes", "camel");
        string pascal = VariableNameHelper("Cost of cakes", "pascal");
        string snake = VariableNameHelper("Cost of cakes", "snake");
        Debug.Assert(camel == "costOfCakes");
        Debug.Assert(pascal == "CostOfCakes");
        Debug.Assert(snake == "cost_of_cakes");

        //          QUESTION 8
        string pig = PigLatin("The cat sat on the mat.");
        Debug.Assert(pig == "heTay atcay atsay noay hetay atmay.");




    }


    static List<string> mexicanwave(string input)
    {
        List<string> results = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ') continue;
            char[] chars = input.ToCharArray();
            chars[i] = char.ToUpper(chars[i]);
            results.Add(new string(chars));
        }
        return results;
    }
    static List<string> GetCharacterCodes(string input)
    {
        List<string> codes = new List<string>();
        foreach (char c in input)
        {
            codes.Add(c + " -> " + (int)c);
        }
        return codes;
    }
    static byte[] GetBytes(string text)
    {
        return Encoding.GetEncoding("UTF-8").GetBytes(text);
    }
    static string FromCharacterCodes(int[] codes)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < codes.Length; i++)
        {
            sb.Append((char)codes[i]);
        }
        return sb.ToString();
    }
    static string FromBytes(byte[] bytes)
    {
         return Encoding.GetEncoding("UTF-8").GetString(bytes);
    }
    static int Anagram(string word, string[] list)
    {
        char[] sortedWord = word.ToCharArray();
        Array.Sort(sortedWord);
        int count = 0;
        for (int i = 0; i < list.Length; i++)
        {
            char[] sorted = list[i].ToCharArray();
            Array.Sort(sorted);
            if (new string(sorted) == new string(sortedWord))
            {
                count++;
            }
        }
        return count;
    }
    static string VariableNameHelper(string text, string style)
    {
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToLower();
        }
        if (style == "camel")
        {
            for (int i = 1; i < words.Length; i++)
            {
                words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            return string.Join("", words);
        }
        else if (style == "pascal")
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            return string.Join("", words);
        }
        else
        {
            return string.Join("_", words);
        }
    }
    static string PigLatin(string text)
    {
        string[] words = text.Split(' ');
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            string w = words[i];
            if (w.Length == 0) continue;
            char last = w[w.Length - 1];
            bool punct = Char.IsPunctuation(last);
            string core = punct ? w.Substring(0, w.Length - 1) : w;
            if (core.Length > 0)
            {
                string transformed = core.Substring(1) + core[0] + "ay";
                if (punct) sb.Append(transformed + last);
                else sb.Append(transformed);
                if (i < words.Length - 1) sb.Append(" ");
            }
        }
        return sb.ToString();
    }


    

    
    



}
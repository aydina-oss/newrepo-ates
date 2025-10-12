using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
class Program
{


    public static void Main(string[] args)
    {
        storesentences("ates.txt");
        StreamReader fileStr = File.OpenText("stations.txt");
        List<string> lines = File.ReadAllLines("stations.txt").ToList();
        List<string> stationnames = new List<string>();
        foreach (string line in lines)
        {
            string[] splitedString = line.Split(",");
            foreach (string s in splitedString)
            {
                stationnames.Add(s);
            }
        }
        fileStr.Close();

        Debug.Assert("Battersea Power Station" == stationname(stationnames));
        Debug.Assert(ShareNoLetters("Mackerel", stationnames).Contains("St. John's Wood"));
        Debug.Assert(ShareNoLetters("Piranha", stationnames).Contains("Stockwell"));
        Debug.Assert(ShareNoLetters("Sturgeon", stationnames).Contains("Balham"));
        Debug.Assert(ShareNoLetters("Bacteria", stationnames).Contains(""));
        Debug.Assert(sameletter(stationnames).Contains("Charing Cross"));
        Debug.Assert(sameletter(stationnames).Contains("Clapham Common"));
        Debug.Assert(sameletter(stationnames).Contains("Golders Green"));
        Debug.Assert(sameletter(stationnames).Contains("Seven Sisters"));
        Debug.Assert(sameletter(stationnames).Contains("Sloane Square"));
        Debug.Assert(moststations(lines) == "District");

    }



                    // QUESTION 1
    static void storesentences(string filename)
    {
        StreamWriter fileStr;
        if (File.Exists(filename))
        {
            fileStr = File.AppendText(filename);
            Console.Write("Your File Exists");

        }
        else
        {
            fileStr = File.CreateText(filename);
        }
        Console.Write("Enter your sentence");
        string userInput = Console.ReadLine();


        while (!userInput.Equals(""))
        {
            fileStr.WriteLine(userInput);
            Console.Write("Enter your sentence");
            userInput = Console.ReadLine();

        }
        fileStr.Close();


    }
        
                    // QUESTION 2
        static string stationname(List<string> names)
        {
            string target = "";

            foreach (string x in names)
            {
                if (x.Contains("Station"))
                {
                    target = x;
                }
            }
            return target;

        }


    // QUESTION 3
    static List<string> ShareNoLetters(string input, List<string> names)
    {
        List<string> sharenostation = new List<string>();
        string lowerInput = input.ToLower();

        foreach (string station in names)
        {
            Boolean noshare = true;
            string lowerStation = station.ToLower();
            foreach (char c in lowerInput)
            {
                if (lowerStation.Contains(c))
                {
                    noshare = false;
                    break;
                }
            }
            if (noshare)
            {
                sharenostation.Add(station);
            }


        }
        return sharenostation;


    }
    // QUESTION 4
    static List<string> sameletter(List<string> names)
    {
        List<string> sameinitials = new List<string>();
        foreach (string station in names)
        {
            string clean = station.Trim();
            if (string.IsNullOrWhiteSpace(clean)) continue;
            string[] words = clean.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 2)
            {
                char first1 = char.ToLower(words[0][0]);
                char first2 = char.ToLower(words[1][0]);

                if (first1 == first2)
                {
                    sameinitials.Add(clean);
                }
            }
        }
        return sameinitials;
    }
                            // QUESTION 5
    static string moststations(List<string> lines)
    {
        List<string> tubes = new List<string>();
        List<int> tubecounts = new List<int>();
        for(int c = 0; c < lines.Count; c++)
        {
            tubecounts.Add(0);
        }
        {
            
        }
        foreach (string x in lines)
        {
            string t = x.Split(',').Last().Trim();
            if (tubes.IndexOf(t) == -1)
            {
                tubes.Add(t);
                tubecounts[tubes.IndexOf(t)] += 1;
            }
            else
            {
                tubecounts[tubes.IndexOf(t)] += 1;
            }
        }
        int max = tubecounts[0];
        foreach (int maxcount in tubecounts)
        {
            if (maxcount > max)
            {
                max = maxcount;
            }
        }
        int maxindex = tubecounts.IndexOf(max);
        return tubes[maxindex];
        

    }

                    



        
    }
                    









    

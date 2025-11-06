using System.Diagnostics;

/* Fix me */
List<string> listOfStrings = new List<string> { "13", "Candy", "Mike Myers", "True", "#FF5F1F", "1978" };


Debug.Assert(NextOnAThursday() == 2031);

int NextOnAThursday()
{
    int result;
    for (int year = 2025; year < 2034; year++)
    {
        int today = (int)(new DateTime(year, 10, 6).DayOfWeek);
        if (today == 4)
        {
            result = year;
            break;
        }
        

    }
    
    return result;
}
int CuttingChocolate(int cuts)
{
    int maxpieces = cuts + 1;
    for (int i = 1; i < cuts; i++)
    {
        int pieces = i * (cuts - i);
        if (pieces > maxpieces)
        {
            maxpieces = pieces;
        }

    }
    return maxpieces;
}
int EatingSweets(List<int> pile,int sleephours)
{
    int minsph = 17;
    for (int sph = 1; sph < 17; sph++)
    {
        int hours = 0;
        for (int i = 0; i < pile.Count; i++)
        {
            if (pile[i] < sph)
            {
                hours = hours + 1;
            }
            else if (pile[i] % sph == 0)
            {
                hours = hours + (pile[i] / sph);
            }
            else
            {
                hours = hours + (pile[i] / sph) + 1;
            }

        }
        if (hours <= sleephours)
        {
            minsph = sph;
            break;
        }
        break;


    }
    return minsph;


}


List<int> pileSizes = new List<int> { 4, 9, 11, 17 };
int numHours = 8;


Debug.Assert(EatingSweets(pileSizes, numHours) == 6);


Debug.Assert(CuttingChocolate(5) == 6);
Debug.Assert(CuttingChocolate(6) == 9);
Debug.Assert(CuttingChocolate(7) == 12);
Debug.Assert(CuttingChocolate(8) == 16);

// Note the exclamation marks showing not, so False 
Debug.Assert(!ValidatePassword("ABCdef")); // too short
Debug.Assert(!ValidatePassword("ABCABC12!")); // duplicates, doesn't divide by 11
Debug.Assert(!ValidatePassword("ABCabcde!")); // no digit 
Debug.Assert(!ValidatePassword("ABCdef12!")); // doesn't divide by 11 
Debug.Assert(ValidatePassword("ABCdef12&")); // should succeed 


bool ValidatePassword(string candidate)
{
    if (candidate.Length > 32 || candidate.Length < 8)
    {
        return false;
    }
    if (candidate.ToLower().Equals(candidate) || candidate.ToUpper().Equals(candidate))
    {
        return false;
    }
    if (candidate.IndexOf("0") == -1 && candidate.IndexOf("1") == -1 && candidate.IndexOf("2") == -1 && candidate.IndexOf("3") == -1 && candidate.IndexOf("4") == -1 && candidate.IndexOf("5") == -1 && candidate.IndexOf("6") == -1 && candidate.IndexOf("7") == -1 && candidate.IndexOf("8") == -1 && candidate.IndexOf("9") == -1)
    {
        return false;
    }



    return true;
}
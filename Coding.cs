public class Coding
{
    public void SumofArray()
    {
        int sum = 0;
        int[] numberArr =  {1,2,3,4,5};

        foreach(var item in numberArr)
        {
          sum+= item;
        }
        Console.WriteLine("Sum of given Arr : " + sum);
    }

    public void GetArrayLength()
    {
        int[] numberArr = {2,3,4,5,6,7};

        Console.WriteLine("Length of the Given Array :" + numberArr.Length);
    }

    public void CalculateAverageofArray(int[] numberarr)
    {
        int sum = 0;
        
        foreach(var item in numberarr)
        {
            sum+=item;
        }
        Console.WriteLine("Average of given Array:" + (double)sum/numberarr.Length);
    }


    public void GetSmallestNumberInArr(int[] numberArr)
    {
       int smallestNumber = numberArr[0];

       for(int i  = 1;i<numberArr.Length; i++)
       {
         if(smallestNumber > numberArr[i])
         {
            smallestNumber = numberArr[i];
         }
       }

       Console.WriteLine("Smallestnumber of Aray :" + smallestNumber);
    }
   

    public void GetLargestNumberOfArray(int[] numberArr)
    {
      int largestNumber = numberArr[0];

      for(int i = 0;i<numberArr.Length; i++)
      {
        if(largestNumber < numberArr[i])
        {
            largestNumber= numberArr[i];
        }
      }

      Console.WriteLine("Largest number of the Array :" + largestNumber);
    }


    public  void OrderTheArray(int[] numberArr)
    {
      int[] ordernumber =   numberArr.OrderDescending().ToArray();

        Console.WriteLine(ordernumber[0]);
    }

    public void GetDuplicateCharCountInString()
    {
        string word = "Naveen";
        Dictionary<char, int> duplicate = new Dictionary<char, int>();

        foreach (char item in word)
        {
            if (duplicate.ContainsKey(item))
            {
                duplicate[item]++;  
            }
            else
            {
                duplicate[item] = 1;  
            }
        }

        // Print only duplicate characters
        foreach (var entry in duplicate)
        {
            if (entry.Value > 1)
            {
                Console.WriteLine($"Character '{entry.Key}' appears {entry.Value} times.");
            }
        }
    }

public void GetFirstLetterString()
{
    string word = "Hello";

    char firstLetter = word[0];
    Console.WriteLine($"answer is '{word+firstLetter}'");
}

public void ReverseSentence(string sentence)
{
    string resultSentence = "";
    string[] sentenceArr = sentence.Split(' ');
    for(int i = sentenceArr.Length - 1; i>=0; i--)
    {
        //resultSentence+=sentenceArr[i]+" ";
        resultSentence+=new string (sentenceArr[i].Reverse().ToArray())+" ";
    }

    Console.WriteLine(resultSentence);
}

public void Reversethestring(string str)
{
    string resultStr = "";
    char[] arr = str.ToArray();
    for(int i = arr.Length-1; i >=0; i--)
    {
        resultStr+=arr[i];
    }
    System.Console.WriteLine($"Orginal string is '{str}' and Reversed string is '{resultStr}'");
}

public void SortBasedOnStringLength()
{
    string[] strArray = {"The","Cow","Moon","is","very","beautiful"};
    string[] resultstrArray = new string[strArray.Length];

    Dictionary<string,int> strDictArr = new Dictionary<string, int>();

    foreach(var item in strArray)
    {
        strDictArr[item] = item.Length;
    }
    System.Console.WriteLine("Sorting based on the given string Array");
    resultstrArray = strDictArr.OrderBy(exp => exp.Value).ThenBy(p => p.Key).Select(exp => exp.Key).ToArray();

    foreach(var item in resultstrArray)
    {
        System.Console.WriteLine(item);
    }
}

public void MultipleOfTwoArray()
{
    int[] firstArr = {1,2,3,4,8};
    int[] secondarr = {5,6,7,8};

    if(firstArr.Length == secondarr.Length) {System.Console.WriteLine("Array Mismatch Length");}
    else
    {
    int[] resultArr = new int[firstArr.Length];

        for(int i =0; i<firstArr.Length; i++)
        {
           resultArr[i] = firstArr[i] + secondarr[i];
           Console.WriteLine(resultArr[i]);
        }

    }
}
}



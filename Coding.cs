using System.Buffers;
using System.IO.IsolatedStorage;

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
    int[] firstArr = {1,2,3,8};
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

    public void GetSecondLargestNumber()
    {
        int[] arr = {5,2,8,23,65,32};
        int largestNumber = arr[0];
        int secondLargestNumber = 0;

        for(int i =0;i<arr.Length;i++)
        {
            if(arr[i] > largestNumber)
            {
                secondLargestNumber = largestNumber;
                largestNumber = arr[i];
            }
            else if(arr[i] > secondLargestNumber && secondLargestNumber != largestNumber)
            {
                secondLargestNumber = arr[i];
            }
        }

        System.Console.WriteLine($"Second Largest Number is :{secondLargestNumber}");
    }

    public void ImportantFunctionOfArray()
    {
        int[] Arr = {2,3,5,1,4};

        string joinedArr = string.Join(", ",Arr);
        System.Console.WriteLine(joinedArr);

        Array.Sort(Arr);
        string sortedArr = string.Join(", ", Arr);
        System.Console.WriteLine(sortedArr);

         Array.Reverse(Arr);
         string reversdeArr = string.Join(", ",Arr);
        System.Console.WriteLine(reversdeArr);

        Array.Fill(Arr,1);
        string filledArr = string.Join(", ",Arr);
        System.Console.WriteLine(filledArr);

        Arr = new int[] {1,2,3,4,5};
        int[] newArr =  new int[7];
        Array.Copy(Arr, newArr, Arr.Length);

        string coprArr = string.Join(", ",newArr);
        System.Console.WriteLine(coprArr);
    }

    public void FindTwoArraySame()
    {
        int [] arr1 = {3,2,5,1,6,7,8};
        int [] arr2 = {3,2,5,2,6,7};
        bool isBothArrEqual = true;

      ///  System.Console.WriteLine(arr1.SequenceEqual(arr2));
         if(arr1.Length == arr2.Length)
         {
            for(int i =0 ;i<arr1.Length; i++)
            {
               if(arr1[i] != arr2[i]){ isBothArrEqual = false; break;}
            }
         }
         else{
            isBothArrEqual = false;
         }
        string result = isBothArrEqual ? "Equal" : "Not Equals";
         System.Console.WriteLine($"Both Array are {result}");
    }
    
    public void CheckArrayIsSortedASC()
    {
        bool isSorted = true;
        int[] arr1 = {1,2,7,4,5};
        int firstElement = arr1[0];
        for(int i = 1; i < arr1.Length ; i++)
        {
            if(firstElement > arr1[i])
            {
             isSorted = false; break;
            }
            firstElement = arr1[i];
        }
       string result  = isSorted ? "Sorted" : "Not Sorted";
        System.Console.WriteLine($"Given Array is {result}");
    }

    public void MergeTwoArray()
    {
        int[] arr1= {1,2,3,5};
        int[] arr2 = {8,7,4,9};

        int[] arr3  = new int[arr1.Length + arr2.Length];

        //Array.Copy(arr1,0,arr3,0,arr1.Length);
        //Array.Copy(arr2,0,arr3,arr1.Length,arr2.Length);

        for(int i = 0; i<arr1.Length;i++)
        {
            arr3[i] = arr1[i];
            arr3[arr1.Length + i] = arr2[i];
        }
        string resultArr = string.Join(", ",arr3);
        System.Console.WriteLine(resultArr);
    }

    public void RemoveSpecificElementInArray()
    {
        int[] arr1 =  {2, 4, 5,3,6,7,3};
        int element = 3;
        int count=0;
        foreach(var item in arr1)
        {
            if(item == element) { count++; }
        }

        int[] arr2 = new int[(arr1.Length - count)];
int index = 0;
        for(int i = 0; i<arr1.Length; i++)
        {
            if(arr1[i]!= element)
            {
                arr2[index] = arr1[i];
                index++;
            }
        }

        string result  = string.Join(", ",arr2);
        System.Console.WriteLine("Removed the occurence"+result);
    }
}



string[] RequestStringArray() //User input of string array
{
    Console.Write("Input count of string array elements: ");
    int n = Convert.ToInt32(Console.ReadLine());
    String[] inputArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Input element[{i}]: ");
        inputArray[i] = Convert.ToString(Console.ReadLine());
    }
    return inputArray;
}

﻿void ShowArrayInString(string[] array) //Output array in string
{
    int count = array.Length;
    if (count == 0) Console.Write("[]");
    for (int i = 0; i < count; i++)
    {
        if (i == 0 && i == count-1) Console.Write($"[{array[i]}]");
        else if (i == 0) Console.Write($"[{array[i]}");
            else  if (i == count-1) Console.Write($", {array[i]}]");
                else Console.Write($", {array[i]}");
    }
}

// Output array before and after changes
void ShowResultOfChangeArray(string[] inputArray, string[] resultArray) 
{
    ShowArrayInString(inputArray);
    Console.Write("->");
    ShowArrayInString(resultArray);
    Console.WriteLine();
}


﻿string[] OnlyShortStringArrayElement(string[] inputArray) // Created new array from input array elements, that lenght less than 3
{
    int countElementsOfInputArray = inputArray.Length;
    int countElementsOfResult = 0;

    for (int i =0; i < countElementsOfInputArray; i++)
    {
        if (inputArray[i].Length <= 3) {
            countElementsOfResult++;
        }
    }

    string[] resultArray = new string[countElementsOfResult];
    int j = 0;
    for (int i =0; i < countElementsOfInputArray; i++)
    {
        if (inputArray[i].Length <= 3) {
            resultArray[j] = inputArray[i];
            j++;
        }
    }
    return resultArray;
}

string[] inputArray = RequestStringArray();
string[] resultArray = 	OnlyShortStringArrayElement(inputArray);
ShowResultOfChangeArray(inputArray, resultArray);


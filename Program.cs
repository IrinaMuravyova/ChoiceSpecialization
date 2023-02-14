string[] OnlyShortStringArrayElement(string[] inputArray) // Created new array from input array elements, that lenght less than 3
{
    int countElementsOfInputArray = inputArray.Length;
    int countElementsOfResult = 0;

    for (int i =0; i < countElementsOfInputArray; i++)
    {
        if (inputArray[i].Length <= 3) {
            countElementsOfResult++;
        }
    }
    Console.WriteLine(countElementsOfResult);
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

string[] inputArray = {"hello", "2", "world", ":-)"};
string[] resultArray = 	OnlyShortStringArrayElement(inputArray);
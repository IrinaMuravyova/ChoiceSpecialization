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
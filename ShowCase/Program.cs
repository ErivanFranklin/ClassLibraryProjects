using MissingNumbersLibrary;
class Program
{
    static void Main(string[] args)
    {
        List<int> input = new List<int>(){4, 3, 6, 2, 1, 7, 9};
        int nth = 1;

        MissingNumbers missingNumbers = new MissingNumbers();
        Console.WriteLine(missingNumbers.getMissingNumber(input, nth));
    }
}
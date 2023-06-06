namespace MissingNumbersLibrary;
public static class MissingNumbers
{
    public static int getMissingNumber(List<int> input, int nth = 1)
    {
        int i = 1; // Step 01: index variable
        int temp = 0; // Step 02: host the current element
        int search = 0; // Step 03: Current item to search
        input.Sort(); // Step 04: Normalize data
        
        // Step 05: Loop till the current is less than missing numbers item is found
        while (search < nth)
        {
            //Step 06: Search item into array
            if(input.Contains(i) == false) {
                temp = i; // Step 07: Save the missing item
                search++; // Step 08: Increment the search
            }
            i++; // Step 09: Increment the index
        }
        return temp; // Step 10: Return the missing number
    }
}

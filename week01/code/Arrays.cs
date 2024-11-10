using System.Runtime.ExceptionServices;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create an empty static array that can be used to store the new multiple variables, the length should be the the 'length' parameter
        // 2. create a loop that will multiply the orignal number the same amount of times as 'length' by an increasing number, starting at 1. e.g. if length is 3 then it would multiple by 1,2, and then 3.
        // 3. each time it loops, it will store the new multiplied number at the end of the multiples array.

        // create an array of size length 
        double[] arrayMultiples = new double[length];
        // calculate multiples for number and store in the array 
        for (int i = 0; i < length; i++)
        {
            // adding result of multiplication to array 
            arrayMultiples[i] = number * (i + 1);
        }

        return arrayMultiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Since we will be using the reference to the original list, we need to first create a copy of the original list so it can be modified.
        // 2. Loop the number of times requested by  'amount', i will be the index, so it will start at 0
        // 3. each iteration I will add 'amount' to the index (i) and pull the number at index i from the temp list and assign it to the original list at the modified index.
	    // e.g. if i is 1, amount is 5, the new index would be 6, and so on for each.
        // 4. I need to implement module probably to make sure that when i is greater than the actual index of the list, it will start back at 0 index of the list.

        // n is the length of the array 
        int n = data.Count;

        // create copy of orginal array 
        List<int> tempList = new List<int> (data);

        for (int i = 0; i < n; i++)
        {
            // copy the value from the copied array at the original position (index i), add 'amount' to the index, then use module to provide an index within the length of the array and add the value to the new position
            data[(i + amount) % n] = tempList[i];
        }
    }


}

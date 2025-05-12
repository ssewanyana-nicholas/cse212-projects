using System;
using System.Collections.Generic;

//plan
// Step 1: Create a new array of doubles with the given 'length'.
// Step 2: Use a for loop that runs from 0 to length - 1.
// Step 3: For each index i in the loop, calculate the multiple as number * (i + 1).
//         (We use i + 1 to start from 1 * number, not 0 * number.)
// Step 4: Assign the calculated multiple to the i-th position in the array.
// Step 5: After the loop ends, return the filled array.


public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of size 'length'
        double[] result = new double[length];

        // Step 2: Use a loop to fill the array with multiples of 'number'
        // Each element at index i will be: number * (i + 1)
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // Step 3: Return the populated array
        return result;
    }

    //plan
    // Step 1: Get the last 'amount' elements of the list using GetRange.
    //         These are the elements we want to move to the front.
    // Step 2: Get the first 'data.Count - amount' elements of the list using GetRange.
    //         These will go after the rotated elements.
    // Step 3: Clear the original list so we can refill it in the new order.
    // Step 4: Add the 'last part' (the rotated elements) to the empty list.
    // Step 5: Add the 'first part' (the remaining elements) to the list.
    // Now the list is rotated to the right.


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3 
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// 
    /// This function modifies the original list instead of returning a new one.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Get the last 'amount' elements using GetRange
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        // Step 2: Get the first part (from 0 to data.Count - amount)
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Step 3: Clear the original list to rebuild it
        data.Clear();

        // Step 4: Add the last part (moved to front)
        data.AddRange(lastPart);

        // Step 5: Add the first part (comes after rotated part)
        data.AddRange(firstPart);
    }
}

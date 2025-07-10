using System.Diagnostics;


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

        /// Create an array of capacity "length"
        /// Make a for from 1 to "length" (i = 0; i < length, i++)
        /// Add the multiplication of i * number
        /// Return de Array

        var multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = (i + 1) * number;
        }
        return multiples; // replace this return statement with your own
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

        /// Check that amount and the list data.count are different, otherwise don't do anything
        /// If amount and data.count are different
        /// Create 2 list
        /// In the first list save the first part of the array, from 0 to the data.count - amount
        /// In the second list save the rest of the list, from data.count -amount to data.count
        /// Clear the data list
        /// Insert the first list into data
        /// Insert the second list into data
        if (amount != data.Count)
        {
            List<int> d1 = data.GetRange(0, data.Count - amount);
            List<int> d2 = data.GetRange(data.Count - amount, amount);
            data.Clear();
            data.InsertRange(0, d1);
            data.InsertRange(0, d2);
        }

        // data.RemoveRange(amount, data.Count - amount);
        // data.InsertRange(0, d1);
    }
}

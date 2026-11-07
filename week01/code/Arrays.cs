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
        /// Plan:
        // 1. Create an array of doubles called 'result' with size 'length'.
        //    Each position in the array will hold one multiple of 'number'.
        // 2. Use a for loop with an index 'i' that goes from 0 to length - 1.
        // 3. In each iteration, calculate the multiple as number * (i + 1).
        //    We add 1 to the index because the first multiple (index 0) must be
        //    number * 1, the second (index 1) must be number * 2, and so on.
        // 4. Store that value in result[i].
        // 5. When the loop finishes, the array is full; return 'result'.


        // Step 1: create the array with the requested size
        double[] result = new double[length];

        // Steps 2 to 4: fill each position with its multiple
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // Step 5: return the array of multiples
        return result;
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
        // Plan:
        // Rotating the list to the right by 'amount' means that the last 'amount'
        // elements move to the front of the list, keeping their order.
        // Example: {1, 2, 3, 4, 5, 6, 7, 8, 9} with amount = 3
        //          last 3 elements = {7, 8, 9}, rest = {1, 2, 3, 4, 5, 6}
        //          result = {7, 8, 9, 1, 2, 3, 4, 5, 6}
        //
        // 1. Find the index where the elements to move begin:
        //    startIndex = data.Count - amount.
        // 2. Use GetRange(startIndex, amount) to copy the last 'amount'
        //    elements into a new list called 'slice'.
        // 3. Use RemoveRange(startIndex, amount) to remove those same
        //    elements from the end of 'data'.
        // 4. Use InsertRange(0, slice) to put the copied elements at the
        //    beginning of 'data'.
        // Because a List is dynamic, these steps modify 'data' directly,
        // so nothing needs to be returned.

        // Step 1: find where the last 'amount' elements start
        int startIndex = data.Count - amount;

        // Step 2: copy the last 'amount' elements
        List<int> slice = data.GetRange(startIndex, amount);

        // Step 3: remove those elements from the end of the list
        data.RemoveRange(startIndex, amount);

        // Step 4: insert the copied elements at the front of the list
        data.InsertRange(0, slice);
    }
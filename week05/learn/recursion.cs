
public class RecursionFunctions
{
    public int Factorial(int n)
    {
        if (n <= 1)
        {
            // 1! = 1 (no recursion)
            return 1;
        }
        else
        {
            // n! = n * (n - 1)!
            return (n * Factorial(n - 1));
        }
    }
    public int Sumatory(int n)
    {
        if (n <= 1)
        {
            // 1! = 1 (no recursion)
            return 1;
        }
        else
        {
            // n! = n * (n - 1)!
            return (n + Sumatory(n - 1));
        }
    }

    public long Fibonacci(int n, Dictionary<int, long> remember = null)
    {
        // If this is the first time calling the function, then
        // we need to create the dictionary.
        if (remember == null)
            remember = new Dictionary<int, long>();

        // Base Case
        if (n <= 2)
            return 1;

        // Check if we have solved this one before
        if (remember.ContainsKey(n))
            return remember[n];

        // Otherwise solve with recursion
        var result = Fibonacci(n - 1, remember) + Fibonacci(n - 2, remember);

        // Remember result for potential later use
        remember[n] = result;
        return result;
    }

    public void Permutations(string letters, string word = "")
    {
        // Try adding each of the available letters
        // to the 'word' and add up all the
        // resulting permutations.
        if (letters.Length == 0)
        {
            Console.WriteLine(word);
        }
        else
        {
            for (var i = 0; i < letters.Length; i++)
            {
                // Make a copy of the letters to pass to the
                // the next call to permutations.  We need
                // to remove the letter we just added before
                // we call permutations again.
                var lettersLeft = letters.Remove(i, 1);

                // Add the new letter to the word we have so far
                Permutations(lettersLeft, word + letters[i]);
            }
        }
    }
    public bool BinarySearch(int[] sortedArray, int target)
    {
        if (sortedArray.Length == 1)
        {
            // Base case
            return target == sortedArray[0];
        }
        else
        {
            // Find the middle and compare
            var middle = sortedArray.Length / 2;

            if (target == sortedArray[middle])
            {
                // We got lucky and the middle was the match
                return true;
            }
            else if (target < sortedArray[middle])
            {
                // Search the first half (index 0 to middle-1) and return the result
                return BinarySearch(sortedArray[..middle], target);
            }
            else
            {
                // Search the second half (index middle to end) and return the result
                return BinarySearch(sortedArray[middle..], target);
            }
        }
    }

}
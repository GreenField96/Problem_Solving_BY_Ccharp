internal class Program
{
    private static void Main(string[] args)
    {
        //string str = "abcabc";
        string str = "bbbbbbbcdv";
        Console.WriteLine(str + " : " + LengthOfLongestSubstring(str));
    }
    public static int LengthOfLongestSubstring(string s) {
        if (s == null)
            return 0;
        var letters = new Dictionary<char, int>(); // key:letter, val: latest index
        int maxCount = 0, left = 0, right;

        for (right = 0; right < s?.Length; right++)
        {
            char letter = s[right];

            if (letters.ContainsKey(letter))
            { // End the window
                left = Math.Max(left, letters[letter] + 1); // Update left of window
            }

            letters[letter] = right; //Update index of letter on map

            maxCount = Math.Max(maxCount, right - left + 1); // Get the longest window length 
        }

        return maxCount;

    }
}
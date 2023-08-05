public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {

        string temp;
        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i + 1; j < heights.Length; j++)
            {
                if (heights[i] < heights[j])
                {
                    heights[i] ^= heights[j];
                    heights[j] ^= heights[i];
                    heights[i] ^= heights[j];

                    temp = names[i];
                    names[i] = names[j];
                    names[j] = temp;
                }
            }
        }
        //return heights.Select(i => i.ToString()).ToArray();
        return names;
    }

}
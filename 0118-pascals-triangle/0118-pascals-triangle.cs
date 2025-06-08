public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        int currentRow = 1;
        IList<IList<int>> result = new List<IList<int>>();
        List<int> prevList = new List<int> { 1 };
        result.Add(prevList);

        while (currentRow < numRows)
        {
            List<int> currList = new List<int>();
            for (int i = 0; i < prevList.Count; i++)
            {
                if (i == 0)
                {
                    currList.Add(1);
                }
                else
                {
                    currList.Add(prevList[i - 1] + prevList[i]);
                }

                if (i == prevList.Count - 1)
                {
                    currList.Add(1);
                }
            }

            result.Add(currList);
            prevList = currList;
            currentRow++;
        }

        return result;
    }
}
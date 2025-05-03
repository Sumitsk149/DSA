public class Solution {
    public int HeightChecker(int[] heights) {
        
        int[] ogArr = new int[heights.Length];
        Array.Copy(heights, ogArr, heights.Length);
        
        bool isSwap = true;
        while(isSwap)
        {
            isSwap = false;
            for(int i = 0; i < heights.Length -1; i++)
            {
                if(heights[i] > heights[i+1])
                {
                    int temp = heights[i];
                    heights[i] = heights[i+1];
                    heights[i+1] = temp;
                    isSwap = true;
                }
            }
        }
        
        int counter = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            if(ogArr[i] != heights[i])
            {
                counter++;
            }
        }
        return counter;
        
    }
}
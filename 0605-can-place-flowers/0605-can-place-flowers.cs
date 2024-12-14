public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        if(n == 0)
        {
            return true;
        }

        int count = 0;
        for(int i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i] == 0)
            {
                bool isLeftPlotEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                bool isRightPlotEmpty = (i + 1 == flowerbed.Length) || (flowerbed[i + 1] == 0);
                               
                if(isLeftPlotEmpty && isRightPlotEmpty)
                {
                    flowerbed[i] = 1;
                    count++;
                    if(count >= n)
                        return true;
                }                
            }
        }

        if(count >= n)
            return true;
        return false;
    }
}

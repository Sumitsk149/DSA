public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        if(n == 0)
        {
            return true;
        }

        int placedCount = 0;
        for(int i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i] == 0)
            {
                bool isLeftEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                bool isRightEmpty = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                if(isLeftEmpty && isRightEmpty)
                {
                    flowerbed[i] = 1;
                    placedCount++;
                }
            }
            
            if(placedCount == n)
            {
                return true;
            }
        }

        return false;
        
    }
}
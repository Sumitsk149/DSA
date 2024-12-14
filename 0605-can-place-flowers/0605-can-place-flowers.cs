public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        bool isLastEmpty = true;
        for(int i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i] == 1)
            {
                isLastEmpty = false;
                continue;
            }

            if(flowerbed[i] == 0)
            {
                if(isLastEmpty && (i + 1 == flowerbed.Length))
                {
                    count++;
                    isLastEmpty = false;
                }                
                else if(isLastEmpty && flowerbed[i + 1] == 0)
                {
                    count++;
                    isLastEmpty = false;
                }
                else
                {
                    isLastEmpty = true;
                }
            }
        }

        if(count >= n)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
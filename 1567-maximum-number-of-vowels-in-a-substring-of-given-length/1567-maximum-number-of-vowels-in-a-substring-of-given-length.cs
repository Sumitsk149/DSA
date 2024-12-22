public class Solution {

    HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

    public int MaxVowels(string s, int k) 
    {
        int windowSum = 0;
        for(int i = 0; i < k; i++)
        {
            if(isVowel(s[i]))
            {
                windowSum++;
            }
        }

        int maxSum = windowSum;
        for(int j = k; j < s.Length; j++)
        {
            if(isVowel(s[j]))
            {
                if(!isVowel(s[j - k]))
                {
                    windowSum++;
                }
            }
            else
            {
                if(isVowel(s[j - k]))
                {
                    windowSum--;
                }
            }

            maxSum = Math.Max(windowSum, maxSum);
            
            if(maxSum == k)
            {
                break;
            }
        }

        return maxSum;
        
              
    }

    public bool isVowel(char ch)
    {
        return vowels.Contains(char.ToLower(ch));
    }
}
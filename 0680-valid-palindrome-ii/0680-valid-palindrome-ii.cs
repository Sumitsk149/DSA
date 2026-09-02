public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        int deleteCount = 0;
        while(left < right)
        {
            if(s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                if(isValidPalindrome(left + 1, right, s) || isValidPalindrome(left, right - 1, s))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }

    public bool isValidPalindrome(int i, int j, string s) 
    {
        while(i < j)
        {
            if(s[i] != s[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
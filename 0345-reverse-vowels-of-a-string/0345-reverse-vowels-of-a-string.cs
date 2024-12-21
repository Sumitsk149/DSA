public class Solution {
    public string ReverseVowels(string s) {

        int i = 0;
        int j = s.Length - 1;
        char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        char[] resultArray = s.ToCharArray();
        while(i < j)
        {
            if(!vowels.Contains(char.ToLower(s[i])))
            {
                i++;
                continue;
            }

            if(!vowels.Contains(char.ToLower(s[j])))
            {
                j--;
                continue;
            }

            resultArray[i] = s[j];
            resultArray[j] = s[i];
            i++;
            j--;
        }

        return new string(resultArray);;
        
    }
}
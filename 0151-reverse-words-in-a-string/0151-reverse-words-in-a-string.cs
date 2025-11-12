public class Solution {
    public string ReverseWords(string s) 
    {
        //Trim for deleting spaces
        s= s.Trim();

        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);
        
        return string.Join(" ", words);
    } 
}
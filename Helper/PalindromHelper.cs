namespace Helper
{
    public static class PalindromeHelper
    {
        public static bool IsPalindrome(string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            return word.ToLower() == reversed.ToLower();
        }
    }
}

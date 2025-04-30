using Helper;

namespace GitPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Git Branching Practice");
            Console.WriteLine("\n-- Palindrome Check --");
            Console.WriteLine("Is 'madam' a palindrome? " + PalindromeHelper.IsPalindrome("madam"));

            Console.WriteLine("\n-- Array Helper --");
            int[] numbers = { 4, 2, 9, 1 };
            Console.WriteLine("Max number: " + ArrayHelper.GetMax(numbers));
        }
    }
}

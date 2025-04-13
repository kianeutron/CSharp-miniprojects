namespace Assignment23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input a string
            Console.Write("Enter a string: ");
            string inputText = Console.ReadLine();

            // Check if the input text is a palindrome
            if (IsPalindrome(inputText))
            {
                Console.WriteLine("It’s a palindrome.");
            }
            else
            {
                Console.WriteLine("It’s not a palindrome.");
            }
        }

        // Method 1: Check if the string is a palindrome
        static bool IsPalindrome(string text)
        {
            // Remove spaces and convert to lowercase for consistent checking
            string cleanedText = text.Replace(" ", "").ToLower();

            // Reverse the cleaned text and compare with the original
            char[] reversedText = cleanedText.ToCharArray();
            Array.Reverse(reversedText);
            return cleanedText == new string(reversedText);  // Check if original and reversed are equal
        }
    }
}

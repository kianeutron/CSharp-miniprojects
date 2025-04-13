namespace Assignment21
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Prompt user to input a character
            Console.WriteLine("Enter a single letter (a-z or A-Z):");
            char input;

            // Read user input and check if it's a valid character
            if (char.TryParse(Console.ReadLine(), out input))
            {
                // Check if the input is a letter
                if (char.IsLetter(input))
                {
                    // Call IsLetterVowel method and display result
                    if (IsLetterVowel(input))
                    {
                        Console.WriteLine($"The letter '{input}' is a vowel.");
                    }
                    else
                    {
                        Console.WriteLine($"The letter '{input}' is a consonant.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: The input is not a letter.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a single letter.");
            }
        }

        bool IsLetterVowel(char letter)
        {
            // Convert letter to lowercase to handle both cases
            char lowerLetter = char.ToLower(letter);

            // Use a switch statement to determine if it's a vowel
            switch (lowerLetter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}

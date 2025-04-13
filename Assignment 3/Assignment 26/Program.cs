namespace Assignment26
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Initialize the source array
            int[] sourceArray = { 10, 20, 30, 40, 50 };
            int[] destinationArray = new int[sourceArray.Length];

            // Step 2: Copy elements from sourceArray to destinationArray
            CopyArray(sourceArray, destinationArray);

            // Step 3: Display the copied array
            Console.WriteLine("Copied Array:");
            DisplayCopiedArray(destinationArray);
        }

        // Method 1: Copies elements from sourceArray to destinationArray
        void CopyArray(int[] sourceArray, int[] destinationArray)
        {
            for (int i = 0; i < sourceArray.Length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }
        }

        // Method 2: Displays the contents of the array
        void DisplayCopiedArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

namespace Assignment27
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Initialize the original array
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int positions = 2;  // Number of positions to rotate

            // Step 2: Rotate the array to the left by specified positions
            int[] rotatedLeftArray = RotateLeft(originalArray, positions);
            Console.WriteLine("Array rotated to the left:");
            DisplayRotatedArray(rotatedLeftArray);

            // Step 3: Rotate the array to the right by specified positions
            int[] rotatedRightArray = RotateRight(originalArray, positions);
            Console.WriteLine("Array rotated to the right:");
            DisplayRotatedArray(rotatedRightArray);
        }

        // Method 1: Rotates the array to the left by the specified number of positions
        int[] RotateLeft(int[] array, int positions)
        {
            int length = array.Length;
            positions = positions % length; // Handles cases where positions > length of array
            int[] rotatedArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                int newIndex = (i - positions + length) % length;
                rotatedArray[newIndex] = array[i];
            }

            return rotatedArray;
        }

        // Method 2: Rotates the array to the right by the specified number of positions
        int[] RotateRight(int[] array, int positions)
        {
            int length = array.Length;
            positions = positions % length; // Handles cases where positions > length of array
            int[] rotatedArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                int newIndex = (i + positions) % length;
                rotatedArray[newIndex] = array[i];
            }

            return rotatedArray;
        }

        // Method 3: Displays the contents of the rotated array
        void DisplayRotatedArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

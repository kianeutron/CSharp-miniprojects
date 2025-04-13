namespace Assignment24
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        void Start()
        {
            // Step 1: Create an array for storing movie names
            string[] movies = new string[5];  // Allow up to 5 movies for now

            // Step 2: Add movies to the collection
            Console.WriteLine("Adding movies to the collection:");
            AddMovie(movies, 0, "Inception");
            AddMovie(movies, 1, "The Dark Knight");
            AddMovie(movies, 2, "Interstellar");
            AddMovie(movies, 3, "Avatar");
            AddMovie(movies, 4, "The Matrix");

            // Step 3: Display the movies after adding
            Console.WriteLine("\nCurrent Movie Collection:");
            DisplayMovies(movies);

            // Step 4: Remove a movie from the collection
            Console.WriteLine("\nRemoving 'Avatar' from the collection...");
            RemoveMovie(movies, 3);

            // Step 5: Display the movie collection after removing a movie
            Console.WriteLine("\nUpdated Movie Collection:");
            DisplayMovies(movies);
        }

        // Method 1: Add a movie to the collection at a specified index
        void AddMovie(string[] movies, int index, string movieName)
        {
            if (index >= 0 && index < movies.Length)
            {
                movies[index] = movieName;
                Console.WriteLine($"Added '{movieName}' at position {index + 1}.");
            }
            else
            {
                Console.WriteLine("Invalid index. Cannot add movie.");
            }
        }

        // Method 2: Remove a movie from the collection at a specified index
        void RemoveMovie(string[] movies, int index)
        {
            if (index >= 0 && index < movies.Length && movies[index] != null)
            {
                Console.WriteLine($"Removed '{movies[index]}' from position {index + 1}.");
                movies[index] = null;  // Set the index to null to "remove" the movie
            }
            else
            {
                Console.WriteLine("Invalid index or no movie to remove.");
            }
        }

        // Method 3: Display the movies currently in the collection
        void DisplayMovies(string[] movies)
        {
            Console.WriteLine("Movies in your collection:");
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {movies[i]}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. (empty slot)");
                }
            }
        }
    }
}

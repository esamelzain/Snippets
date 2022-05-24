internal static class Binary
    {
        internal static void Search()
        {
            Console.WriteLine("Size:");
            //Creating the array with entered size
            int[] arr = new int[Convert.ToInt16(Console.ReadLine())];
            //Filling the array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            Console.WriteLine("Search Key:");
            int key = Convert.ToInt16(Console.ReadLine());
            int step = 0;
            int low = 0, high = arr.Length - 1;
            int guess;
            //Start looping and deviding the array
            do
            {
                guess = (low + high) / 2;
                step++;
                Console.WriteLine($"Step :{step} Guess is {arr[guess]}");
                if (arr[guess] > key)
                {
                    high = guess - 1;
                    Console.WriteLine($"Too high");
                }
                else if (arr[guess] < key)
                {
                    low = guess + 1;
                    Console.WriteLine($"Too low");
                }
                else
                {
                    Console.WriteLine($"Found in index :{guess}");
                    break;
                }
            } while (low <= high);
        }
    }

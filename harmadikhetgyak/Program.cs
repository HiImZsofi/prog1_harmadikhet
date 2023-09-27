namespace harmadikhetgyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Adjon meg egy szamot");
            int usernum = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] array = new int[1000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }

            bool isExisting = false;
            foreach (int i in array)
            {
                if(i == usernum)
                {
                    isExisting = true;
                }
            }
            
            if(isExisting)
            {
                Console.WriteLine("Van ilyen szam a tombben");
            }
            else
            {
                Console.WriteLine("Nincs ilyen szam a tombben");
            }*/

            Random rnd = new Random();
            int[,] fishes = new int[10, 10];

            for (int i = 0; i < fishes.GetLength(0); i++)
            {
                for (int j = 0; j < fishes.GetLength(1); j++)
                {
                    fishes[i, j] = rnd.Next(0, 10);
                }
            }

            print(fishes);
            numberOfCatches(fishes);

            Console.ReadKey();
        }

        static void print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", array[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        static void numberOfCatches(int[,] array)
        {
            Dictionary<int, int> fishermenAndCatches = new Dictionary<int, int>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                {
                    fishermenAndCatches.Add();
                }
            }

            Console.WriteLine(fishermenAndCatches[0]);
        }
    }
}
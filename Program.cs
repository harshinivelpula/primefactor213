

namespace primefactor213
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int num = 898;
            int i, j;
            int count = 0;
            int flag = 0;

            Console.WriteLine("Prime factor of {0}:", num);
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count = 0;
                    
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.Write(i + " ");
                    }
                }
            }

            if (flag == 0)
                Console.WriteLine("There is no Prime factor for {0} ", num);
        }

    }
}


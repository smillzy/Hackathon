namespace contentReplacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數");
            int max;

            while (!int.TryParse(Console.ReadLine(), out max) || max <= 90)
            {
                Console.WriteLine("請輸入正確的整數，且必須大於90");
            }

            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) // 最嚴格的條件放最上面
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

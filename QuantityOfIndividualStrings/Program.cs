namespace QuantityOfIndividualStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個英文敘述：");

            string? input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("輸入不可為空，請重新輸入：");
                input = Console.ReadLine();
            }

            string[] words = input
                             .ToLower()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            foreach (var item in wordCount)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}

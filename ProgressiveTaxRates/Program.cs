namespace ProgressiveTaxRates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal income;
            while (true)
            {
                Console.Write("請輸入年收入：");

                string input = Console.ReadLine();

                if (!decimal.TryParse(input, out income))
                {
                    Console.WriteLine("輸入錯誤，請輸入正確的數字。");
                    continue;
                }

                if (income < 0)
                {
                    Console.WriteLine("年收入不可小於0。");
                    continue;
                }

                break;
            }

            decimal tax = GetTax(income);
            Console.WriteLine($"{income:N0}：{tax:N2}");
        }

        static decimal GetTax(decimal income)
        {
            var taxRates = new List<(decimal Limit, decimal Rate)>
    {
        (540000m, 0.05m),
        (1210000m, 0.12m),
        (2420000m, 0.20m),
        (4530000m, 0.30m),
        (10310000m, 0.40m),
        (decimal.MaxValue, 0.50m)
    };
            decimal tax = 0m;
            decimal previousLimit = 0m;

            foreach (var item in taxRates)
            {
                if (income > item.Limit)
                {
                    tax += (item.Limit - previousLimit) * item.Rate;
                    previousLimit = item.Limit;
                }
                else
                {
                    tax += (income - previousLimit) * item.Rate;
                    break;
                }
            }

            return tax;
        }
    }

}

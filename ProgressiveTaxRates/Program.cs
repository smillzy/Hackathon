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
            decimal tax = 0m;

            if (income <= 540000m)
            {
                tax = income * 0.05m;
            }
            else if (income <= 1210000m)
            {
                tax = 540000m * 0.05m
                    + (income - 540000m) * 0.12m;
            }
            else if (income <= 2420000m)
            {
                tax = 540000m * 0.05m
                    + (1210000m - 540000m) * 0.12m
                    + (income - 1210000m) * 0.20m;
            }
            else if (income <= 4530000m)
            {
                tax = 540000m * 0.05m
                    + (1210000m - 540000m) * 0.12m
                    + (2420000m - 1210000m) * 0.20m
                    + (income - 2420000m) * 0.30m;
            }
            else if (income <= 10310000m)
            {
                tax = 540000m * 0.05m
                    + (1210000m - 540000m) * 0.12m
                    + (2420000m - 1210000m) * 0.20m
                    + (4530000m - 2420000m) * 0.30m
                    + (income - 4530000m) * 0.40m;
            }
            else
            {
                tax = 540000m * 0.05m
                    + (1210000m - 540000m) * 0.12m
                    + (2420000m - 1210000m) * 0.20m
                    + (4530000m - 2420000m) * 0.30m
                    + (10310000m - 4530000m) * 0.40m
                    + (income - 10310000m) * 0.50m;
            }

            return tax;
        }
    }

}

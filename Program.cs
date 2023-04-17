namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call methods here
            int a = 5;
            int b = 8;

            decimal c = .3m;
            decimal d = .5m;

            int e = 2;
            int f = 4;

            var answer1 = Add(a, b);
            var answer2 = Add(c, d);
            var answer3 = Add(e, f, true);

            Console.WriteLine($"Int add: 5 + 8 = {answer1}\nDecimal add: .3 + .5 = {answer2}");
            Console.WriteLine($"bool check: 2 + 4 = {answer3}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal c, decimal d)
        {
            return c + d;
        }

        public static string Add(int e, int f, bool check)
        {
            var sum = e + f;
            if(check == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(check == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(check == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

    }
}
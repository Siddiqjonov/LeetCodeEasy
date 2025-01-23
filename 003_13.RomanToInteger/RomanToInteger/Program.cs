namespace RomanToInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            var res = solution.RomanToInt("MCMXLIV");
            Console.WriteLine(res);
        }
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int number = 0;

            if (s.Contains("IV"))
                number += 4; s = s.Replace("IV", "4");
            if (s.Contains("IX"))
                number += 9; s = s.Replace("IX", "9");
            if (s.Contains("XL"))
                number += 40; s = s.Replace("XL", "40");
            if (s.Contains("XC"))
                number += 90; s = s.Replace("XC", "90");
            if (s.Contains("CD"))
                number += 400; s = s.Replace("CD", "400");
            if (s.Contains("CM"))
                number += 900; s = s.Replace("CM", "900");

            foreach (var d in s)
                if (char.IsLetter(d))
                    number = number + ConvertOneDigit(d);

            return number;
        }
        public static int ConvertOneDigit(char rom)
        {
            switch (rom)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: throw new NullReferenceException();
            }
        }
    }
}

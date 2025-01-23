namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string xIntoStr = Convert.ToString(x);

            string reversed = "";

            for (int i = xIntoStr.Length - 1; i >= 0; i--)
            {
                reversed = reversed + xIntoStr[i];
            }

            if (xIntoStr == reversed)
                return true;
            else
                return false;
        }
    }
}

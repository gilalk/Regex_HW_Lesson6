using System;
using System.Text.RegularExpressions;

namespace Regex_HW_Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            Regex reg = new Regex(@"^D");
            bool matching = reg.IsMatch("Gil");
            bool matching1 = reg.IsMatch("Dil");
            Console.WriteLine(matching);
            Console.WriteLine(matching1);

            #endregion

            #region Q2

            Regex reg1 = new Regex(@"^[D,F,J]");
            bool match = reg1.IsMatch("Gil");
            bool match1 = reg1.IsMatch("Diuiy");
            bool match2 = reg1.IsMatch("Falafel");
            Console.WriteLine(match);
            Console.WriteLine(match1);
            Console.WriteLine(match2);

            #endregion

            #region Q3

            Regex reg2 = new Regex(@"^[D,F,J]\d{6}_\D{2}$");
            bool expression = reg2.IsMatch("D246765_DF");
            bool expression1 = reg2.IsMatch("D246765_DFH");
            bool expression2 = reg2.IsMatch("D26765_DF");
            bool expression3 = reg2.IsMatch("d265765_DF");
            Console.WriteLine(expression);
            Console.WriteLine(expression1);
            Console.WriteLine(expression2);
            Console.WriteLine(expression3);

            #endregion

            #region Q4

            string st = ReplaceMyString("lkwehfdlckw");
            Console.WriteLine(st);

            #endregion

            #region Q5

            Regex pattern = new Regex(@"^[A-Z]");
            string word = "Gil";
            Console.WriteLine(pattern.Match(word).Success);

            #endregion

            #region Q6

            string str = Console.ReadLine();
            Console.WriteLine(ContainABCinLowerOrUpperCases(str));

            #endregion

            #region Q7

            Console.WriteLine(ValidateFullName("Gil Alkobianskovicheskist"));

            #endregion

            #region Q8

            string num = Console.ReadLine();
            Console.WriteLine(IsDecimal(num));

            #endregion

            #region Q9

            Console.WriteLine(IsDecimalWithOnlyThreeDigitsAfterPeriod(Console.ReadLine()));

            #endregion

            #region Q10

            Console.WriteLine(IsValidEmail(Console.ReadLine()));

            #endregion

            #region Q11

            Console.WriteLine(IsURLValidForCOILdomain(Console.ReadLine()));

            #endregion
        }

        /// <summary>
        /// Question 4
        /// This function replace the input string (pattern accordingly) with empty string
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Empty string if the input string match the pattern, else </returns>
        public static string ReplaceMyString(string str)
        {
            string myPattern = @"(y{3}|ז{4})";
            string clean = Regex.Replace(str, myPattern, "");
            return clean;
        }

        /// <summary>
        /// Question 6
        /// The function checkes if the input string contains the string "ABC" or "abc"
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true if it contains, else false</returns>
        public static bool ContainABCinLowerOrUpperCases(string str)
        {
            string pattern = @"(abc|ABC)";
            return Regex.Match(str, pattern).Success;
        }

        /// <summary>
        /// Question 7
        /// This function ensures that first and last name each is between 2 to 18 letters with 
        /// one whitespace between them
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns>true if input string is valid, else false</returns>
        public static bool ValidateFullName(string fullName)
        {
            string pattern = @"\D{2,18} \D{2,18}$";
            return Regex.IsMatch(fullName, pattern);
        }

        /// <summary>
        /// Question 8
        /// This function checkes if the input number is decimal
        /// </summary>
        /// <param name="num"></param>
        /// <returns>true if is decimal, else false</returns>
        public static bool IsDecimal(string num)
        {
            string pattern = @"^[0-9]*\.[0-9]+$";
            return Regex.Match(num, pattern).Success;
        }

        /// <summary>
        /// Question 9
        /// This function checkes if input number is decimal but has only three digits after period
        /// </summary>
        /// <param name="num"></param>
        /// <returns>true if number is by the pattern, else false</returns>
        public static bool IsDecimalWithOnlyThreeDigitsAfterPeriod(string num)
        {
            string pattern = @"^[0-9]*\.\d{1,3}$";
            return Regex.Match(num, pattern).Success;
        }

        /// <summary>
        /// Question 10
        /// This function checkes if the input email is valid
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true if valid, else false</returns>
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[A-z0-9.]+\@(gmail|yahoo|GMAIL|YAHOO)\.(com|COM)$";
            return Regex.Match(email, pattern).Success;
        }

        /// <summary>
        /// Question 11
        /// This function checkes if the input URL is valid according to the pattern defined
        /// </summary>
        /// <param name="url"></param>
        /// <returns>true if valid, else false</returns>
        public static bool IsURLValidForCOILdomain(string url)
        {
            string pattern = @"^[A-z0-9\-]{4,20}\.co\.il$";
            return Regex.Match(url, pattern).Success;
        }
    }
}

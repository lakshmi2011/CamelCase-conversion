using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string test = "Jack-and_jill_went_up_the-Hill_to_fetch-water";
            char[] demiliters = new char[] { '_', '-' };
            string result = test.GetCamelCase(demiliters);

            Console.WriteLine($"{test} -- converted to -- {result}");

        }

    }

    public static class Extensions
    {
        public static string GetCamelCase(this string inputText, char[] demiliters)
        {
            List<String> converted = new List<String>();

            var splitArray = inputText.Split(demiliters);
            if (splitArray != null && splitArray.Length > 1)
            {
                converted.Add(splitArray[0]);
                converted.AddRange(splitArray.Skip(1).Select(x => String.Concat(Char.ToUpper(x[0]), x.Substring(1))));
            }

            return String.Join(string.Empty, converted);
        }
    }
}

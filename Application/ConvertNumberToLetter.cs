using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class NumberToLetter
    {
        public static String[] ones = { "","one","two","three","four","five","six","seven","eight","nine","ten",
                 "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};

        public static String[] tens = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        public static String[] hundreds = {"","onehundred","twohundred","threehundred","fourhundred","fivehundred","sixhundred",
                                            "sevenhundred","eighthundred","ninehundred"};

        //public Int64 GetNumberOfLetters(int letter)
        //{
        //    Int64 iCount = 0;
        //    for (int i = 1; i <= letter; i++)
        //    {
        //        string s = word(i);
        //        s = s.Replace(" ", string.Empty);
        //        s = s.Replace("-", string.Empty);
        //        iCount += s.Length;
        //    }
        //    return iCount;
        //}

        public string word(int letter)
        {
            string WordLetter = "";
            if (letter == 0)
            {
                WordLetter = "zero";
                return WordLetter;
            }
            if (letter < 0)
            {
                WordLetter = "minus" + word(Math.Abs(letter));
            }
            if ((letter / 1000000) > 0)
            {
                WordLetter += word(letter / 1000000) + " million ";
                letter %= 1000000;
            }

            if ((letter / 1000) > 0)
            {
                WordLetter += word(letter / 1000) + " thousand ";
                letter %= 1000;
            }

            if ((letter / 100) > 0)
            {
                WordLetter += word(letter / 100) + " hundred ";
                letter %= 100;
            }

            if (letter > 0)
            {
                if (WordLetter != "")
                    WordLetter += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (letter < 20)
                    WordLetter += unitsMap[letter];
                else
                {
                    WordLetter += tensMap[letter / 10];
                    if ((letter % 10) > 0)
                        WordLetter += "-" + unitsMap[letter % 10];
                }
            }

            Console.WriteLine("Number to Word :" + WordLetter);

            return WordLetter;

        }
    }
    class ConvertNumberToLetter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int letter = Convert.ToInt16(Console.ReadLine());
            NumberToLetter mtl = new NumberToLetter();
            mtl.word(letter);
            Console.ReadKey();
        }
    }
}

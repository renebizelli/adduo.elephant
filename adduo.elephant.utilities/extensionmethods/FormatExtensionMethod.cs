﻿using adduo.elephant.utilities.entries;
using System.Text.RegularExpressions;

namespace adduo.elephant.utilities.extensionmethods
{
    public static class FormatExtensionMethod
    {
        public static string PhoneFormat(this PhoneEntry number)
        {
            return number.Value.PhoneFormat();
        }

        public static string CPFFormat(this CPFEntry number)
        {
            return number.Value.CPFFormat();
        }

        public static string PhoneFormat(this string number)
        {
            var clear = number.OnlyNumbers();

            var formatted = number;

            if (clear.Length >= 10)
            {
                var last = clear.Length == 10 ? 9 : 10;

                formatted = clear
                    .Insert(0, "(")
                    .Insert(3, ") ")
                    .Insert(last, "-");
            }

            return formatted;
        }

        public static string CPFFormat(this string number)
        {
            var clear = number.OnlyNumbers();

            var formatted = number;

            if (clear.Length == 11)
            {
                formatted = clear
                    .Insert(3, ".")
                    .Insert(7, ".")
                    .Insert(11, "-");
            }

            return formatted;
        }

        public static string CreateUrlFriendly(this string phrase)
        {
            string str = phrase.RemoveAccent().ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }

        public static string RemoveAccent(this string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }



    }
}

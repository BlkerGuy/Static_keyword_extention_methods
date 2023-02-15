using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Static_keyword_extention_methods
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int value)
        {
            if (value % 2 != 0)
                return true;
            return false;
        }

        public static bool IsEven(this int value)
        {
            if (value % 2 == 0)
                return true;
            return false;
        }

        public static bool IsContainsDigit(this string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ToCapitalize(this string text)
        {
            var strArr = text.Split(' ');
            string newStr = "";
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] != "")
                {
                    newStr += strArr[i].Substring(0, 1).ToUpper() + strArr[i].Substring(1).ToLower() + " ";
                }
            }
            return newStr.TrimEnd();
        }


        public static int[] GetValueIndexes(this string text,char cr)
        {
            int[] indexArr = new int[0];

            var txt = text.ToLower();
            if (txt.Contains(cr))
            {
                for (int i = 0; i < text.Length; i++)
                {

                    if ( txt[i] == cr)
                    {
                            var indexAr = i;
                            Array.Resize(ref indexArr, indexArr.Length + 1);
                            indexArr[indexArr.Length - 1] = indexAr;
                        
                    }
                }
                return indexArr;
            }

            return indexArr;
        }

     


    }
}

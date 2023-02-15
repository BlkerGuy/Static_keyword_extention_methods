using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Static_keyword_extention_methods
{
    internal class Student
    {
         string _fullname;
         string _groupNo;
         byte _age;

        public string Fullname
        {
            get => _fullname;
            set
            {
                if (CheckFullname(value))
                {
                    _fullname = value;
                }
            }
        }
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }

        public byte Age
        {
            get => _age;
            set
            {
                if (CheckAge(value))
                {
                    _age = value;
                }
            }
        }




        public static bool CheckFullname(string fullName)
        {
            byte count = 0;
            var fullname = fullName.Trim();
            if (char.IsUpper(fullname[0]) && fullname.Contains(" ") && fullName.Length >= 8)
            {
                int emptty = fullName.IndexOf(" ");
                for (int i = 1; i < fullname.Length; i++)
                {
                    if (fullname[i] != ' ')
                    {
                        if (char.IsLower(fullname[i]))
                        {
                            count++;
                        }
                        else
                            break;
                    }
                    else if (fullname[i] == ' ')
                    {
                        count += 2;
                        i++;
                        if (char.IsUpper(fullname[i])) { i++; count++; }
                        else
                            break;
                    }
                }
                if (count == fullname.Length - 1)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (char.IsLetter(groupNo[0]) && char.IsUpper(groupNo[0]) && groupNo.Substring(1, 3).All(char.IsDigit) && groupNo.Length == 4)
            {
                return true;
            }
            return false;
        }

        public static bool CheckAge(byte age)
        {
            if (age>0 || age<=250)
            {
                return true;
            }
            return false;
        }

    }
}

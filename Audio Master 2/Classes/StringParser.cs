using Kaztep.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Audio_Master
{
    public class StringParser
    { 
        public static Dictionary<string, string> GetTrackTimes(string txt)
        {
            var dictionary = new Dictionary<string, string>();
            var split = txt.Split('\n').ToList();
            var names = new List<string>();
            var times = new List<string>();

            foreach (string s in split)
            {
                if (String.IsNullOrEmpty(s) || s.Length < 3)
                    continue;

                string name = s.RemoveAll("\r").Trim();
                string time = GetTime(name);

                if (String.IsNullOrEmpty(time))
                    continue;

                name = name.RemoveAll(time, "[]", "()").Trim();

                if (time.Length < 5 && time.IndexOf(":") == 1)
                    time = "0" + time;

                names.Add(name);
                times.Add(time);
            }

            names = RemoveTrackNumbers(names);
            names = RemoveDuplicateCharacters(names);

            if (names.Count != times.Count)
                return dictionary;
            foreach (string s in names)
                dictionary.Add(s, times[names.IndexOf(s)]);
            return dictionary;
        }

        public static string GetTime(string s)
        {
            string time = String.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == ":" && i > 0 && IsInteger(s[i - 1]) && i < s.Length - 1 && IsInteger(s[i + 1]))
                {
                    time = (s[i - 2].ToString() + s[i - 1].ToString() + s[i].ToString()
                            + s[i + 1].ToString() + s[i + 2].ToString()).Trim();
                    break;
                }
            }
            return time.TrimStart('[').TrimEnd(']').TrimStart('(').TrimEnd(')');
        }

        public static List<string> RemoveTrackNumbers(List<string> list)
        {
            if (list.Count < 3 || !list[0].Contains("1") && !list[1].Contains("2") && !list[2].Contains("3"))
                return list;

            for (int i = 0; i < list.Count; i++)
                list[i] = list[i].TrimStart('0');

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].StartsWith((i + 1).ToString()))
                    list[i] = list[i].Remove(0, (i + 1).ToString().Length);
            }
            return list;
        }

        public static bool IsInteger(char s)
        {
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            return numbers.Contains(s.ToString());
        }

        public static List<string> RemoveDuplicateCharacters(List<string> list)
        {
            try
            {
                int i = 0;
                bool stop = false;
                while (true)
                {
                    string currentChar = list[0][i].ToString();
                    foreach (string s in list)
                    {
                        if (s.Length > i && s[i].ToString() != currentChar)
                            stop = true;
                    }
                    if (stop)
                        break;
                    i++;
                }

                for (int j = 0; j < list.Count; j++)
                    list[j] = list[j].Remove(0, i);

                i = 0;
                stop = false;
                while (true)
                {
                    string currentChar = list[0][list[0].Length - 1 - i].ToString();
                    foreach (string s in list)
                    {
                        if (i < s.Length && s[s.Length - 1 - i].ToString() != currentChar)
                            stop = true;
                    }
                    if (stop)
                        break;
                    i++;
                }

                for (int j = 0; j < list.Count; j++)
                    list[j] = list[j].Remove(list[j].Length - i);
            }
            catch
            {
                
            }
            return list;
        }

        private string ToUpperCaseWords(string name)
        {
            string s = "";
            char[] chars = name.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                s = s + chars[i];
                if (chars[i].Equals(' '))
                {
                    s = s + Convert.ToString(chars[i + 1]).ToUpper();
                    i++;
                }
            }
            return s;
        }

        public bool Match(string val1, string val2)
        {
            if (val1.ToLower() == val2.ToLower() || val1.ToLower().Contains(val2.ToLower()) || val2.ToLower().Contains(val1.ToLower()))
                return true;           

            //if (val1.ToLower().StartsWith(val2[0].ToString().ToLower()) && val1.ToLower().EndsWith(val2[val2.Length - 1].ToString().ToLower()) && val1.Split(' ').Length == val2.Split(' ').Length)
            //    return true;

            return false;
        }
    }
}

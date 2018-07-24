namespace ns20
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal static class Class189
    {
        internal static readonly bool[] bool_0 = new bool[0x80];
        internal static readonly bool[] bool_1 = new bool[0x80];
        internal static readonly bool[] bool_2 = new bool[0x80];
        private const string string_0 = "!";

        static Class189()
        {
            IList<char> first = new List<char> { 10, 13, 9, 0x5c, 12, 8 };
            for (int i = 0; i < 0x20; i++)
            {
                first.Add((char) ((ushort) i));
            }
            foreach (char ch in first.Union<char>(new char[] { '\'' }))
            {
                bool_0[ch] = true;
            }
            foreach (char ch2 in first.Union<char>(new char[] { '"' }))
            {
                bool_1[ch2] = true;
            }
            foreach (char ch3 in first.Union<char>(new char[] { '"', '\'', '<', '>', '&' }))
            {
                bool_2[ch3] = true;
            }
        }

        public static void smethod_0(TextWriter textWriter_0, string string_1, char char_0, bool bool_3, bool[] bool_4, StringEscapeHandling stringEscapeHandling_0, ref char[] char_1)
        {
            if (bool_3)
            {
                textWriter_0.Write(char_0);
            }
            if (string_1 != null)
            {
                int sourceIndex = 0;
                for (int i = 0; i < string_1.Length; i++)
                {
                    string str;
                    char index = string_1[i];
                    if ((index < bool_4.Length) && !bool_4[index])
                    {
                        continue;
                    }
                    char ch2 = index;
                    if (ch2 <= '\\')
                    {
                        switch (ch2)
                        {
                            case '\b':
                                str = @"\b";
                                goto Label_012E;

                            case '\t':
                                str = @"\t";
                                goto Label_012E;

                            case '\n':
                                str = @"\n";
                                goto Label_012E;

                            case '\v':
                                goto Label_00C3;

                            case '\f':
                                str = @"\f";
                                goto Label_012E;

                            case '\r':
                                str = @"\r";
                                goto Label_012E;
                        }
                        if (ch2 != '\\')
                        {
                            goto Label_00C3;
                        }
                        str = @"\\";
                        goto Label_012E;
                    }
                    switch (ch2)
                    {
                        case '\u2028':
                            str = @"\u2028";
                            goto Label_012E;

                        case '\u2029':
                            str = @"\u2029";
                            goto Label_012E;

                        case '\x0085':
                            str = @"\u0085";
                            goto Label_012E;
                    }
                Label_00C3:
                    if ((index >= bool_4.Length) && (stringEscapeHandling_0 != StringEscapeHandling.EscapeNonAscii))
                    {
                        str = null;
                    }
                    else if ((index == '\'') && (stringEscapeHandling_0 != StringEscapeHandling.EscapeHtml))
                    {
                        str = @"\'";
                    }
                    else if ((index == '"') && (stringEscapeHandling_0 != StringEscapeHandling.EscapeHtml))
                    {
                        str = "\\\"";
                    }
                    else
                    {
                        if (char_1 == null)
                        {
                            char_1 = new char[6];
                        }
                        Class198.smethod_8(index, char_1);
                        str = "!";
                    }
                Label_012E:
                    if (str != null)
                    {
                        bool flag = string.Equals(str, "!");
                        if (i > sourceIndex)
                        {
                            int num3 = (i - sourceIndex) + (flag ? 6 : 0);
                            int destinationIndex = flag ? 6 : 0;
                            if ((char_1 == null) || (char_1.Length < num3))
                            {
                                char[] destinationArray = new char[num3];
                                if (flag)
                                {
                                    Array.Copy(char_1, destinationArray, 6);
                                }
                                char_1 = destinationArray;
                            }
                            string_1.CopyTo(sourceIndex, char_1, destinationIndex, num3 - destinationIndex);
                            textWriter_0.Write(char_1, destinationIndex, num3 - destinationIndex);
                        }
                        sourceIndex = i + 1;
                        if (!flag)
                        {
                            textWriter_0.Write(str);
                        }
                        else
                        {
                            textWriter_0.Write(char_1, 0, 6);
                        }
                    }
                }
                if (sourceIndex == 0)
                {
                    textWriter_0.Write(string_1);
                }
                else
                {
                    int count = string_1.Length - sourceIndex;
                    if ((char_1 == null) || (char_1.Length < count))
                    {
                        char_1 = new char[count];
                    }
                    string_1.CopyTo(sourceIndex, char_1, 0, count);
                    textWriter_0.Write(char_1, 0, count);
                }
            }
            if (bool_3)
            {
                textWriter_0.Write(char_0);
            }
        }

        public static string smethod_1(string string_1, char char_0, bool bool_3)
        {
            int? nullable = Class198.smethod_7(string_1);
            using (StringWriter writer = Class198.smethod_6(nullable.HasValue ? nullable.GetValueOrDefault() : 0x10))
            {
                char[] chArray = null;
                smethod_0(writer, string_1, char_0, bool_3, (char_0 == '"') ? bool_1 : bool_0, StringEscapeHandling.Default, ref chArray);
                return writer.ToString();
            }
        }
    }
}


namespace Triton.Common
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Arguments
    {
        private readonly Dictionary<string, Collection<string>> dictionary_0 = new Dictionary<string, Collection<string>>();
        private string string_0;

        public Arguments(IEnumerable<string> arguments)
        {
            Regex regex = new Regex("^-{1,2}|^/|=|:", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (string str in arguments)
            {
                string[] strArray = regex.Split(str, 3);
                switch (strArray.Length)
                {
                    case 1:
                        this.method_2(strArray[0]);
                        break;

                    case 2:
                        this.method_1();
                        this.string_0 = strArray[1];
                        break;

                    case 3:
                    {
                        this.method_1();
                        string str2 = smethod_1(strArray[2]);
                        char[] separator = new char[] { ',' };
                        this.method_0(strArray[1], str2.Split(separator));
                        break;
                    }
                }
            }
            this.method_1();
        }

        public bool Exists(string argument)
        {
            return ((this[argument] != null) && (this[argument].Count > 0));
        }

        public bool IsTrue(string argument)
        {
            this.method_6(argument);
            Collection<string> collection = this[argument];
            return ((collection != null) && collection[0].Equals("true", StringComparison.OrdinalIgnoreCase));
        }

        private void method_0(string string_1, IEnumerable<string> ienumerable_0)
        {
            foreach (string str in ienumerable_0)
            {
                this.method_3(string_1, str);
            }
        }

        private void method_1()
        {
            if (this.string_0 != null)
            {
                this.method_4(this.string_0, "true");
                this.string_0 = null;
            }
        }

        private void method_2(string string_1)
        {
            if (this.string_0 != null)
            {
                string_1 = smethod_1(string_1);
                this.method_3(this.string_0, string_1);
                this.string_0 = null;
            }
        }

        private void method_3(string string_1, string string_2)
        {
            if (!this.dictionary_0.ContainsKey(string_1))
            {
                this.dictionary_0.Add(string_1, new Collection<string>());
            }
            this.dictionary_0[string_1].Add(string_2);
        }

        private void method_4(string string_1, string string_2)
        {
            if (this.dictionary_0.ContainsKey(string_1))
            {
                throw new ArgumentException(string.Format("Argument {0} has already been defined", string_1));
            }
            this.dictionary_0.Add(string_1, new Collection<string>());
            this.dictionary_0[string_1].Add(string_2);
        }

        private void method_5(string string_1)
        {
            if (this.dictionary_0.ContainsKey(string_1))
            {
                this.dictionary_0.Remove(string_1);
            }
        }

        private void method_6(string string_1)
        {
            if ((this[string_1] != null) && (this[string_1].Count > 1))
            {
                throw new ArgumentException(string.Format("{0} has been specified more than once, expecting single value", string_1));
            }
        }

        public string Single(string argument)
        {
            this.method_6(argument);
            if ((this[argument] != null) && !this.IsTrue(argument))
            {
                return this[argument][0];
            }
            return null;
        }

        private static string[] smethod_0(string string_1)
        {
            StringBuilder builder = new StringBuilder(string_1);
            bool flag = false;
            for (int i = 0; i < builder.Length; i++)
            {
                if (builder[i] == '"')
                {
                    flag = !flag;
                }
                if ((builder[i] == ' ') && !flag)
                {
                    builder[i] = '\n';
                }
            }
            char[] separator = new char[] { '\n' };
            string[] strArray = builder.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < strArray.Length; j++)
            {
                strArray[j] = smethod_1(strArray[j]);
            }
            return strArray;
        }

        private static string smethod_1(string string_1)
        {
            int index = string_1.IndexOf('"');
            for (int i = string_1.LastIndexOf('"'); index != i; i = string_1.LastIndexOf('"'))
            {
                string_1 = string_1.Remove(index, 1);
                string_1 = string_1.Remove(i - 1, 1);
                index = string_1.IndexOf('"');
            }
            return string_1;
        }

        public int Count
        {
            get
            {
                return this.dictionary_0.Count;
            }
        }

        public Collection<string> this[string parameter]
        {
            get
            {
                if (!this.dictionary_0.ContainsKey(parameter))
                {
                    return null;
                }
                return this.dictionary_0[parameter];
            }
        }
    }
}


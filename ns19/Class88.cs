namespace ns19
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    internal class Class88
    {
        private int int_0;
        [CompilerGenerated]
        private List<object> list_0;
        private readonly string string_0;

        public Class88(string expression)
        {
            Class203.smethod_2(expression, "expression");
            this.string_0 = expression;
            this.List_0 = new List<object>();
            this.method_0();
        }

        private void method_0()
        {
            int startIndex = this.int_0;
            bool flag = false;
            while (this.int_0 < this.string_0.Length)
            {
                char ch = this.string_0[this.int_0];
                switch (ch)
                {
                    case '(':
                    case '[':
                        if (this.int_0 > startIndex)
                        {
                            string item = this.string_0.Substring(startIndex, this.int_0 - startIndex);
                            this.List_0.Add(item);
                        }
                        this.method_1(ch);
                        startIndex = this.int_0 + 1;
                        flag = true;
                        break;

                    case ')':
                    case ']':
                        throw new JsonException("Unexpected character while parsing path: " + ch);

                    case '.':
                        if (this.int_0 > startIndex)
                        {
                            string str2 = this.string_0.Substring(startIndex, this.int_0 - startIndex);
                            this.List_0.Add(str2);
                        }
                        startIndex = this.int_0 + 1;
                        flag = false;
                        break;

                    default:
                        if (flag)
                        {
                            throw new JsonException("Unexpected character following indexer: " + ch);
                        }
                        break;
                }
                this.int_0++;
            }
            if (this.int_0 > startIndex)
            {
                string str3 = this.string_0.Substring(startIndex, this.int_0 - startIndex);
                this.List_0.Add(str3);
            }
        }

        private void method_1(char char_0)
        {
            this.int_0++;
            char ch = (char_0 == '[') ? ']' : ')';
            int startIndex = this.int_0;
            int length = 0;
            bool flag = false;
            while (this.int_0 < this.string_0.Length)
            {
                char c = this.string_0[this.int_0];
                if (!char.IsDigit(c))
                {
                    if (c != ch)
                    {
                        throw new JsonException("Unexpected character while parsing path indexer: " + c);
                    }
                    flag = true;
                    break;
                }
                length++;
                this.int_0++;
            }
            if (!flag)
            {
                throw new JsonException("Path ended with open indexer. Expected " + ch);
            }
            if (length == 0)
            {
                throw new JsonException("Empty path indexer.");
            }
            string str = this.string_0.Substring(startIndex, length);
            this.List_0.Add(Convert.ToInt32(str, CultureInfo.InvariantCulture));
        }

        internal JToken method_2(JToken jtoken_0, bool bool_0)
        {
            JToken token = jtoken_0;
            using (List<object>.Enumerator enumerator = this.List_0.GetEnumerator())
            {
                string str;
                int num;
                while (enumerator.MoveNext())
                {
                    object current = enumerator.Current;
                    str = current as string;
                    if (str != null)
                    {
                        JObject obj3 = token as JObject;
                        if (obj3 != null)
                        {
                            token = obj3[str];
                            if ((token == null) && bool_0)
                            {
                                throw new JsonException("Property '{0}' does not exist on JObject.".smethod_0(CultureInfo.InvariantCulture, str));
                            }
                            continue;
                        }
                        goto Label_00C5;
                    }
                    num = (int) current;
                    JArray array = token as JArray;
                    JConstructor constructor = token as JConstructor;
                    if (array != null)
                    {
                        if (array.Count <= num)
                        {
                            goto Label_00F1;
                        }
                        token = array[num];
                    }
                    else
                    {
                        if (constructor == null)
                        {
                            goto Label_0139;
                        }
                        if (constructor.Count <= num)
                        {
                            goto Label_0115;
                        }
                        token = constructor[num];
                    }
                }
                return token;
            Label_00C5:
                if (bool_0)
                {
                    throw new JsonException("Property '{0}' not valid on {1}.".smethod_1(CultureInfo.InvariantCulture, str, token.GetType().Name));
                }
                return null;
            Label_00F1:
                if (bool_0)
                {
                    throw new JsonException("Index {0} outside the bounds of JArray.".smethod_0(CultureInfo.InvariantCulture, num));
                }
                return null;
            Label_0115:
                if (bool_0)
                {
                    throw new JsonException("Index {0} outside the bounds of JConstructor.".smethod_0(CultureInfo.InvariantCulture, num));
                }
                return null;
            Label_0139:
                if (bool_0)
                {
                    throw new JsonException("Index {0} not valid on {1}.".smethod_1(CultureInfo.InvariantCulture, num, token.GetType().Name));
                }
                return null;
            }
        }

        public List<object> List_0
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            private set
            {
                this.list_0 = value;
            }
        }
    }
}


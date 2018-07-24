namespace Newtonsoft.Json
{
    using ns18;
    using ns20;
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Numerics;

    public class JsonTextReader : JsonReader, IJsonLineInfo
    {
        private bool bool_2;
        private const char char_1 = '�';
        private char[] char_2;
        private Class190 class190_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private Struct29 struct29_0;
        private readonly TextReader textReader_0;

        public JsonTextReader(TextReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            this.textReader_0 = reader;
            this.int_3 = 1;
            this.char_2 = new char[0x401];
        }

        public override void Close()
        {
            base.Close();
            if (base.CloseInput && (this.textReader_0 != null))
            {
                this.textReader_0.Close();
            }
            if (this.class190_0 != null)
            {
                this.class190_0.method_2();
            }
        }

        public bool HasLineInfo()
        {
            return true;
        }

        private Class190 method_14()
        {
            if (this.class190_0 == null)
            {
                this.class190_0 = new Class190(0x401);
            }
            else
            {
                this.class190_0.Int32_0 = 0;
            }
            return this.class190_0;
        }

        private void method_15(int int_4)
        {
            this.int_3++;
            this.int_2 = int_4 - 1;
        }

        private void method_16(char char_3)
        {
            this.int_1++;
            this.method_17();
            this.method_22(char_3);
            if (base.enum14_0 == Enum14.ReadAsBytes)
            {
                byte[] buffer;
                if (this.struct29_0.Int32_1 == 0)
                {
                    buffer = new byte[0];
                }
                else
                {
                    buffer = Convert.FromBase64CharArray(this.struct29_0.Char_0, this.struct29_0.Int32_0, this.struct29_0.Int32_1);
                }
                base.SetToken(JsonToken.Bytes, buffer);
            }
            else if (base.enum14_0 == Enum14.ReadAsString)
            {
                string str = this.struct29_0.ToString();
                base.SetToken(JsonToken.String, str);
                base.char_0 = char_3;
            }
            else
            {
                string str2 = this.struct29_0.ToString();
                if (base.dateParseHandling_0 != DateParseHandling.None)
                {
                    DateParseHandling dateTime;
                    object obj2;
                    if (base.enum14_0 == Enum14.ReadAsDateTime)
                    {
                        dateTime = DateParseHandling.DateTime;
                    }
                    else if (base.enum14_0 == Enum14.ReadAsDateTimeOffset)
                    {
                        dateTime = DateParseHandling.DateTimeOffset;
                    }
                    else
                    {
                        dateTime = base.dateParseHandling_0;
                    }
                    if (Class184.smethod_13(str2, dateTime, base.DateTimeZoneHandling, out obj2))
                    {
                        base.SetToken(JsonToken.Date, obj2);
                        return;
                    }
                }
                base.SetToken(JsonToken.String, str2);
                base.char_0 = char_3;
            }
        }

        private void method_17()
        {
            int length = this.char_2.Length;
            if ((length - this.int_1) <= (length * 0.1))
            {
                int num2 = this.int_0 - this.int_1;
                if (num2 > 0)
                {
                    smethod_2(this.char_2, this.int_1, this.char_2, 0, num2);
                }
                this.int_2 -= this.int_1;
                this.int_1 = 0;
                this.int_0 = num2;
                this.char_2[this.int_0] = '\0';
            }
        }

        private int method_18(bool bool_3)
        {
            return this.method_19(bool_3, 0);
        }

        private int method_19(bool bool_3, int int_4)
        {
            if (this.bool_2)
            {
                return 0;
            }
            if ((this.int_0 + int_4) >= (this.char_2.Length - 1))
            {
                if (bool_3)
                {
                    char[] chArray = new char[Math.Max((int) (this.char_2.Length * 2), (int) ((this.int_0 + int_4) + 1))];
                    smethod_2(this.char_2, 0, chArray, 0, this.char_2.Length);
                    this.char_2 = chArray;
                }
                else
                {
                    int num2 = this.int_0 - this.int_1;
                    if (((num2 + int_4) + 1) >= this.char_2.Length)
                    {
                        char[] chArray2 = new char[(num2 + int_4) + 1];
                        if (num2 > 0)
                        {
                            smethod_2(this.char_2, this.int_1, chArray2, 0, num2);
                        }
                        this.char_2 = chArray2;
                    }
                    else if (num2 > 0)
                    {
                        smethod_2(this.char_2, this.int_1, this.char_2, 0, num2);
                    }
                    this.int_2 -= this.int_1;
                    this.int_1 = 0;
                    this.int_0 = num2;
                }
            }
            int count = (this.char_2.Length - this.int_0) - 1;
            int num4 = this.textReader_0.Read(this.char_2, this.int_0, count);
            this.int_0 += num4;
            if (num4 == 0)
            {
                this.bool_2 = true;
            }
            this.char_2[this.int_0] = '\0';
            return num4;
        }

        private bool method_20(int int_4, bool bool_3)
        {
            if ((this.int_1 + int_4) >= this.int_0)
            {
                return this.method_21(int_4, bool_3);
            }
            return true;
        }

        private bool method_21(int int_4, bool bool_3)
        {
            int num3;
            if (this.bool_2)
            {
                return false;
            }
            int num = ((this.int_1 + int_4) - this.int_0) + 1;
            int num2 = 0;
        Label_0028:
            num3 = this.method_19(bool_3, num - num2);
            if (num3 != 0)
            {
                num2 += num3;
                if (num2 < num)
                {
                    goto Label_0028;
                }
            }
            if (num2 < num)
            {
                return false;
            }
            return true;
        }

        private void method_22(char char_3)
        {
            int num4;
            char ch;
            char ch2;
            char ch4;
            int index = this.int_1;
            int startIndex = this.int_1;
            int num3 = this.int_1;
            Class190 class2 = null;
            goto Label_0299;
        Label_009B:
            ch2 = ch;
            index++;
        Label_0211:
            if (class2 == null)
            {
                class2 = this.method_14();
            }
            this.method_23(class2, ch2, num3, num4);
            num3 = index;
        Label_0299:
            ch4 = this.char_2[index++];
            if (ch4 > '\r')
            {
                switch (ch4)
                {
                    case '"':
                    case '\'':
                        if (this.char_2[index - 1] != char_3)
                        {
                            goto Label_0299;
                        }
                        index--;
                        if (startIndex == num3)
                        {
                            this.struct29_0 = new Struct29(this.char_2, startIndex, index - startIndex);
                        }
                        else
                        {
                            if (class2 == null)
                            {
                                class2 = this.method_14();
                            }
                            if (index > num3)
                            {
                                class2.method_1(this.char_2, num3, index - num3);
                            }
                            this.struct29_0 = new Struct29(class2.method_5(), 0, class2.Int32_0);
                        }
                        index++;
                        this.int_1 = index;
                        return;
                }
                if (ch4 != '\\')
                {
                    goto Label_0299;
                }
                this.int_1 = index;
                if (!this.method_20(0, true))
                {
                    this.int_1 = index;
                    throw JsonReaderException.smethod_1(this, "Unterminated string. Expected delimiter: {0}.".smethod_0(CultureInfo.InvariantCulture, char_3));
                }
                num4 = index - 1;
                ch = this.char_2[index];
                char ch5 = ch;
                if (ch5 > '\\')
                {
                    if (ch5 <= 'f')
                    {
                        if (ch5 != 'b')
                        {
                            if (ch5 != 'f')
                            {
                                goto Label_02F8;
                            }
                            index++;
                            ch2 = '\f';
                        }
                        else
                        {
                            index++;
                            ch2 = '\b';
                        }
                        goto Label_0211;
                    }
                    switch (ch5)
                    {
                        case 'r':
                            index++;
                            ch2 = '\r';
                            goto Label_0211;

                        case 't':
                            index++;
                            ch2 = '\t';
                            goto Label_0211;

                        case 'u':
                            index++;
                            this.int_1 = index;
                            ch2 = this.method_24();
                            if (!Class198.smethod_12(ch2))
                            {
                                if (Class198.smethod_11(ch2))
                                {
                                    bool flag;
                                    do
                                    {
                                        flag = false;
                                        if (!this.method_20(2, true) || ((this.char_2[this.int_1] != '\\') || (this.char_2[this.int_1 + 1] != 'u')))
                                        {
                                            ch2 = 0xfffd;
                                        }
                                        else
                                        {
                                            char ch3 = ch2;
                                            this.int_1 += 2;
                                            ch2 = this.method_24();
                                            if (!Class198.smethod_12(ch2))
                                            {
                                                if (Class198.smethod_11(ch2))
                                                {
                                                    ch3 = 0xfffd;
                                                    flag = true;
                                                }
                                                else
                                                {
                                                    ch3 = 0xfffd;
                                                }
                                            }
                                            if (class2 == null)
                                            {
                                                class2 = this.method_14();
                                            }
                                            this.method_23(class2, ch3, num3, num4);
                                            num3 = this.int_1;
                                        }
                                    }
                                    while (flag);
                                }
                            }
                            else
                            {
                                ch2 = 0xfffd;
                            }
                            index = this.int_1;
                            goto Label_0211;

                        case 'n':
                            index++;
                            ch2 = '\n';
                            goto Label_0211;
                    }
                    goto Label_02F8;
                }
                if (ch5 <= '\'')
                {
                    switch (ch5)
                    {
                        case '"':
                        case '\'':
                            goto Label_009B;
                    }
                    goto Label_02F8;
                }
                if (ch5 != '/')
                {
                    if (ch5 != '\\')
                    {
                        goto Label_02F8;
                    }
                    index++;
                    ch2 = '\\';
                    goto Label_0211;
                }
                goto Label_009B;
            }
            switch (ch4)
            {
                case '\0':
                    if (this.int_0 == (index - 1))
                    {
                        index--;
                        if (this.method_18(true) == 0)
                        {
                            this.int_1 = index;
                            throw JsonReaderException.smethod_1(this, "Unterminated string. Expected delimiter: {0}.".smethod_0(CultureInfo.InvariantCulture, char_3));
                        }
                    }
                    break;

                case '\n':
                    this.int_1 = index - 1;
                    this.method_33();
                    index = this.int_1;
                    break;

                case '\r':
                    this.int_1 = index - 1;
                    this.method_34(true);
                    index = this.int_1;
                    break;
            }
            goto Label_0299;
        Label_02F8:
            index++;
            this.int_1 = index;
            throw JsonReaderException.smethod_1(this, "Bad JSON escape sequence: {0}.".smethod_0(CultureInfo.InvariantCulture, @"\" + ch));
        }

        private void method_23(Class190 class190_1, char char_3, int int_4, int int_5)
        {
            if (int_5 > int_4)
            {
                class190_1.method_1(this.char_2, int_4, int_5 - int_4);
            }
            class190_1.method_0(char_3);
        }

        private char method_24()
        {
            if (!this.method_20(4, true))
            {
                throw JsonReaderException.smethod_1(this, "Unexpected end while parsing unicode character.");
            }
            string s = new string(this.char_2, this.int_1, 4);
            char ch = Convert.ToChar(int.Parse(s, NumberStyles.HexNumber, NumberFormatInfo.InvariantInfo));
            this.int_1 += 4;
            return ch;
        }

        private void method_25()
        {
            char ch;
            int num = this.int_1;
        Label_00E0:
            ch = this.char_2[num++];
            if (ch > 'F')
            {
                switch (ch)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'x':
                    case 'X':
                        goto Label_00E0;
                }
            }
            else
            {
                switch (ch)
                {
                    case '+':
                    case '-':
                    case '.':
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                        goto Label_00E0;

                    case '\0':
                        if (this.int_0 != (num - 1))
                        {
                            this.int_1 = num - 1;
                            return;
                        }
                        num--;
                        this.int_1 = num;
                        if (this.method_18(true) == 0)
                        {
                            return;
                        }
                        goto Label_00E0;
                }
            }
            this.int_1 = num - 1;
        }

        private void method_26()
        {
            if (this.class190_0 != null)
            {
                this.class190_0.Int32_0 = 0;
            }
            this.struct29_0 = new Struct29();
        }

        private bool method_27()
        {
            char ch;
        Label_0000:
            ch = this.char_2[this.int_1];
            switch (ch)
            {
                case '\t':
                case ' ':
                    this.int_1++;
                    goto Label_0000;

                case '\n':
                    this.method_33();
                    goto Label_0000;

                case '\r':
                    this.method_34(false);
                    goto Label_0000;

                case '\0':
                    if (this.int_0 == this.int_1)
                    {
                        if (this.method_18(false) == 0)
                        {
                            base.state_0 = JsonReader.State.Finished;
                            return false;
                        }
                    }
                    else
                    {
                        this.int_1++;
                    }
                    goto Label_0000;

                case ')':
                    this.int_1++;
                    base.SetToken(JsonToken.EndConstructor);
                    return true;

                case ',':
                    this.int_1++;
                    base.SetStateBasedOnCurrent();
                    return false;

                case '/':
                    this.method_38();
                    return true;

                case ']':
                    this.int_1++;
                    base.SetToken(JsonToken.EndArray);
                    return true;

                case '}':
                    this.int_1++;
                    base.SetToken(JsonToken.EndObject);
                    return true;
            }
            if (!char.IsWhiteSpace(ch))
            {
                throw JsonReaderException.smethod_1(this, "After parsing a value an unexpected character was encountered: {0}.".smethod_0(CultureInfo.InvariantCulture, ch));
            }
            this.int_1++;
            goto Label_0000;
        }

        private bool method_28()
        {
            char ch;
        Label_0000:
            ch = this.char_2[this.int_1];
            switch (ch)
            {
                case '\t':
                case ' ':
                    this.int_1++;
                    goto Label_0000;

                case '\n':
                    this.method_33();
                    goto Label_0000;

                case '\r':
                    this.method_34(false);
                    goto Label_0000;

                case '\0':
                    if (this.int_0 == this.int_1)
                    {
                        if (this.method_18(false) == 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        this.int_1++;
                    }
                    goto Label_0000;

                case '/':
                    this.method_38();
                    return true;

                case '}':
                    base.SetToken(JsonToken.EndObject);
                    this.int_1++;
                    return true;
            }
            if (!char.IsWhiteSpace(ch))
            {
                return this.method_29();
            }
            this.int_1++;
            goto Label_0000;
        }

        private bool method_29()
        {
            char ch2;
            char ch = this.char_2[this.int_1];
            switch (ch)
            {
                case '"':
                case '\'':
                    this.int_1++;
                    ch2 = ch;
                    this.method_17();
                    this.method_22(ch2);
                    break;

                default:
                    if (this.method_30(ch))
                    {
                        ch2 = '\0';
                        this.method_17();
                        this.method_31();
                        break;
                    }
                    throw JsonReaderException.smethod_1(this, "Invalid property identifier character: {0}.".smethod_0(CultureInfo.InvariantCulture, this.char_2[this.int_1]));
            }
            string str = this.struct29_0.ToString();
            this.method_35(false);
            if (this.char_2[this.int_1] != ':')
            {
                throw JsonReaderException.smethod_1(this, "Invalid character after parsing property name. Expected ':' but got: {0}.".smethod_0(CultureInfo.InvariantCulture, this.char_2[this.int_1]));
            }
            this.int_1++;
            base.SetToken(JsonToken.PropertyName, str);
            base.char_0 = ch2;
            this.method_26();
            return true;
        }

        private bool method_30(char char_3)
        {
            if (!char.IsLetterOrDigit(char_3) && (char_3 != '_'))
            {
                return (char_3 == '$');
            }
            return true;
        }

        private void method_31()
        {
            int startIndex = this.int_1;
            while (true)
            {
                char ch2 = this.char_2[this.int_1];
                if (ch2 != '\0')
                {
                    char ch = this.char_2[this.int_1];
                    if (!this.method_30(ch))
                    {
                        if (!char.IsWhiteSpace(ch) && (ch != ':'))
                        {
                            throw JsonReaderException.smethod_1(this, "Invalid JavaScript property identifier character: {0}.".smethod_0(CultureInfo.InvariantCulture, ch));
                        }
                        this.struct29_0 = new Struct29(this.char_2, startIndex, this.int_1 - startIndex);
                        return;
                    }
                    this.int_1++;
                }
                else
                {
                    if (this.int_0 != this.int_1)
                    {
                        this.struct29_0 = new Struct29(this.char_2, startIndex, this.int_1 - startIndex);
                        return;
                    }
                    if (this.method_18(true) == 0)
                    {
                        throw JsonReaderException.smethod_1(this, "Unexpected end while parsing unquoted property name.");
                    }
                }
            }
        }

        private bool method_32()
        {
            char ch;
        Label_0000:
            ch = this.char_2[this.int_1];
            switch (ch)
            {
                case '\t':
                case ' ':
                    this.int_1++;
                    goto Label_0000;

                case '\n':
                    this.method_33();
                    goto Label_0000;

                case '\r':
                    this.method_34(false);
                    goto Label_0000;

                case '\0':
                    if (this.int_0 == this.int_1)
                    {
                        if (this.method_18(false) == 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        this.int_1++;
                    }
                    goto Label_0000;

                case '"':
                case '\'':
                    this.method_16(ch);
                    return true;

                case ')':
                    this.int_1++;
                    base.SetToken(JsonToken.EndConstructor);
                    return true;

                case ',':
                    base.SetToken(JsonToken.Undefined);
                    return true;

                case '-':
                    if (!this.method_20(1, true) || (this.char_2[this.int_1 + 1] != 'I'))
                    {
                        this.method_37();
                    }
                    else
                    {
                        this.method_46();
                    }
                    return true;

                case '/':
                    this.method_38();
                    return true;

                case 'I':
                    this.method_47();
                    return true;

                case '[':
                    this.int_1++;
                    base.SetToken(JsonToken.StartArray);
                    return true;

                case ']':
                    this.int_1++;
                    base.SetToken(JsonToken.EndArray);
                    return true;

                case 'f':
                    this.method_45();
                    return true;

                case 'N':
                    this.method_48();
                    return true;

                case 't':
                    this.method_42();
                    return true;

                case 'u':
                    this.method_44();
                    return true;

                case '{':
                    this.int_1++;
                    base.SetToken(JsonToken.StartObject);
                    return true;

                case 'n':
                    if (!this.method_20(1, true))
                    {
                        throw JsonReaderException.smethod_1(this, "Unexpected end.");
                    }
                    switch (this.char_2[this.int_1 + 1])
                    {
                        case 'u':
                            this.method_43();
                            goto Label_02BA;

                        case 'e':
                            this.method_36();
                            goto Label_02BA;
                    }
                    throw JsonReaderException.smethod_1(this, "Unexpected character encountered while parsing value: {0}.".smethod_0(CultureInfo.InvariantCulture, this.char_2[this.int_1]));

                default:
                    if (!char.IsWhiteSpace(ch))
                    {
                        if ((!char.IsNumber(ch) && (ch != '-')) && (ch != '.'))
                        {
                            throw JsonReaderException.smethod_1(this, "Unexpected character encountered while parsing value: {0}.".smethod_0(CultureInfo.InvariantCulture, ch));
                        }
                        this.method_37();
                        return true;
                    }
                    this.int_1++;
                    goto Label_0000;
            }
        Label_02BA:
            return true;
        }

        private void method_33()
        {
            this.int_1++;
            this.method_15(this.int_1);
        }

        private void method_34(bool bool_3)
        {
            this.int_1++;
            if (this.method_20(1, bool_3) && (this.char_2[this.int_1] == '\n'))
            {
                this.int_1++;
            }
            this.method_15(this.int_1);
        }

        private bool method_35(bool bool_3)
        {
            bool flag = false;
            bool flag2 = false;
            while (!flag)
            {
                char c = this.char_2[this.int_1];
                switch (c)
                {
                    case '\0':
                    {
                        if (this.int_0 == this.int_1)
                        {
                            if (this.method_18(false) == 0)
                            {
                                flag = true;
                            }
                        }
                        else
                        {
                            this.int_1++;
                        }
                        continue;
                    }
                    case '\n':
                    {
                        this.method_33();
                        continue;
                    }
                    case '\r':
                    {
                        this.method_34(false);
                        continue;
                    }
                }
                if ((c != ' ') && !char.IsWhiteSpace(c))
                {
                    flag = true;
                }
                else
                {
                    flag2 = true;
                    this.int_1++;
                    continue;
                }
            }
            if (bool_3)
            {
                return flag2;
            }
            return true;
        }

        private void method_36()
        {
            int num2;
            char ch;
            if (!this.method_40("new"))
            {
                throw JsonReaderException.smethod_1(this, "Unexpected content while parsing JSON.");
            }
            this.method_35(false);
            int startIndex = this.int_1;
        Label_0050:
            ch = this.char_2[this.int_1];
            if (ch != '\0')
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    switch (ch)
                    {
                        case '\r':
                            num2 = this.int_1;
                            this.method_34(true);
                            goto Label_00DA;

                        case '\n':
                            num2 = this.int_1;
                            this.method_33();
                            goto Label_00DA;
                    }
                    if (char.IsWhiteSpace(ch))
                    {
                        num2 = this.int_1;
                        this.int_1++;
                    }
                    else
                    {
                        if (ch != '(')
                        {
                            throw JsonReaderException.smethod_1(this, "Unexpected character while parsing constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, ch));
                        }
                        num2 = this.int_1;
                    }
                    goto Label_00DA;
                }
                this.int_1++;
                goto Label_0050;
            }
            if (this.int_0 != this.int_1)
            {
                num2 = this.int_1;
                this.int_1++;
            }
            else
            {
                if (this.method_18(true) == 0)
                {
                    throw JsonReaderException.smethod_1(this, "Unexpected end while parsing constructor.");
                }
                goto Label_0050;
            }
        Label_00DA:
            this.struct29_0 = new Struct29(this.char_2, startIndex, num2 - startIndex);
            string str = this.struct29_0.ToString();
            this.method_35(false);
            if (this.char_2[this.int_1] != '(')
            {
                throw JsonReaderException.smethod_1(this, "Unexpected character while parsing constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, this.char_2[this.int_1]));
            }
            this.int_1++;
            this.method_26();
            base.SetToken(JsonToken.StartConstructor, str);
        }

        private void method_37()
        {
            object obj2;
            JsonToken integer;
            this.method_17();
            char c = this.char_2[this.int_1];
            int startIndex = this.int_1;
            this.method_25();
            this.struct29_0 = new Struct29(this.char_2, startIndex, this.int_1 - startIndex);
            bool flag = char.IsDigit(c) && (this.struct29_0.Int32_1 == 1);
            bool flag2 = (((c == '0') && (this.struct29_0.Int32_1 > 1)) && ((this.struct29_0.Char_0[this.struct29_0.Int32_0 + 1] != '.') && (this.struct29_0.Char_0[this.struct29_0.Int32_0 + 1] != 'e'))) && (this.struct29_0.Char_0[this.struct29_0.Int32_0 + 1] != 'E');
            if (base.enum14_0 == Enum14.ReadAsInt32)
            {
                if (flag)
                {
                    obj2 = c - '0';
                }
                else if (flag2)
                {
                    string str = this.struct29_0.ToString();
                    int num2 = str.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt32(str, 0x10) : Convert.ToInt32(str, 8);
                    obj2 = num2;
                }
                else
                {
                    obj2 = Class181.smethod_15(this.struct29_0.Char_0, this.struct29_0.Int32_0, this.struct29_0.Int32_1);
                }
                integer = JsonToken.Integer;
            }
            else if (base.enum14_0 == Enum14.ReadAsDecimal)
            {
                if (flag)
                {
                    obj2 = c - 48M;
                }
                else if (flag2)
                {
                    string str2 = this.struct29_0.ToString();
                    long num3 = str2.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(str2, 0x10) : Convert.ToInt64(str2, 8);
                    obj2 = Convert.ToDecimal(num3);
                }
                else
                {
                    obj2 = decimal.Parse(this.struct29_0.ToString(), NumberStyles.Float | NumberStyles.AllowThousands | NumberStyles.AllowTrailingSign, CultureInfo.InvariantCulture);
                }
                integer = JsonToken.Float;
            }
            else if (flag)
            {
                obj2 = ((long) c) - 0x30L;
                integer = JsonToken.Integer;
            }
            else if (flag2)
            {
                string str4 = this.struct29_0.ToString();
                obj2 = str4.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(str4, 0x10) : Convert.ToInt64(str4, 8);
                integer = JsonToken.Integer;
            }
            else
            {
                long num4;
                Enum18 enum2 = Class181.smethod_16(this.struct29_0.Char_0, this.struct29_0.Int32_0, this.struct29_0.Int32_1, out num4);
                switch (enum2)
                {
                    case Enum18.Success:
                        obj2 = num4;
                        integer = JsonToken.Integer;
                        goto Label_032C;

                    case Enum18.Invalid:
                    {
                        string s = this.struct29_0.ToString();
                        if (base.floatParseHandling_0 == FloatParseHandling.Decimal)
                        {
                            obj2 = decimal.Parse(s, NumberStyles.Float | NumberStyles.AllowThousands | NumberStyles.AllowTrailingSign, CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            obj2 = Convert.ToDouble(s, CultureInfo.InvariantCulture);
                        }
                        integer = JsonToken.Float;
                        goto Label_032C;
                    }
                    case Enum18.Overflow:
                        obj2 = BigInteger.Parse(this.struct29_0.ToString(), CultureInfo.InvariantCulture);
                        integer = JsonToken.Integer;
                        goto Label_032C;
                }
                if (enum2 != Enum18.Overflow)
                {
                    throw JsonReaderException.smethod_1(this, "Unknown error parsing integer.");
                }
                obj2 = BigInteger.Parse(this.struct29_0.ToString(), CultureInfo.InvariantCulture);
                integer = JsonToken.Integer;
            }
        Label_032C:
            this.method_26();
            base.SetToken(integer, obj2);
        }

        private void method_38()
        {
            this.int_1++;
            if (!this.method_20(1, false) || (this.char_2[this.int_1] != '*'))
            {
                throw JsonReaderException.smethod_1(this, "Error parsing comment. Expected: *, got {0}.".smethod_0(CultureInfo.InvariantCulture, this.char_2[this.int_1]));
            }
            this.int_1++;
            int startIndex = this.int_1;
            bool flag = false;
            while (!flag)
            {
                char ch = this.char_2[this.int_1];
                if (ch <= '\n')
                {
                    if (ch != '\0')
                    {
                        if (ch != '\n')
                        {
                            goto Label_00AF;
                        }
                        this.method_33();
                    }
                    else if (this.int_0 == this.int_1)
                    {
                        if (this.method_18(true) == 0)
                        {
                            throw JsonReaderException.smethod_1(this, "Unexpected end while parsing comment.");
                        }
                    }
                    else
                    {
                        this.int_1++;
                    }
                    continue;
                }
                switch (ch)
                {
                    case '\r':
                        goto Label_0116;

                    case '*':
                    {
                        this.int_1++;
                        if (this.method_20(0, true) && (this.char_2[this.int_1] == '/'))
                        {
                            this.struct29_0 = new Struct29(this.char_2, startIndex, (this.int_1 - startIndex) - 1);
                            this.int_1++;
                            flag = true;
                        }
                        continue;
                    }
                }
            Label_00AF:
                this.int_1++;
                continue;
            Label_0116:
                this.method_34(true);
            }
            base.SetToken(JsonToken.Comment, this.struct29_0.ToString());
            this.method_26();
        }

        private bool method_39(string string_0)
        {
            if (!this.method_20(string_0.Length - 1, true))
            {
                return false;
            }
            for (int i = 0; i < string_0.Length; i++)
            {
                if (this.char_2[this.int_1 + i] != string_0[i])
                {
                    return false;
                }
            }
            this.int_1 += string_0.Length;
            return true;
        }

        private bool method_40(string string_0)
        {
            if (!this.method_39(string_0))
            {
                return false;
            }
            if (this.method_20(0, false) && !this.method_41(this.char_2[this.int_1]))
            {
                return (this.char_2[this.int_1] == '\0');
            }
            return true;
        }

        private bool method_41(char char_3)
        {
            switch (char_3)
            {
                case '\t':
                case '\n':
                case '\r':
                case ' ':
                    return true;

                case ')':
                    if ((base.CurrentState == JsonReader.State.Constructor) || (base.CurrentState == JsonReader.State.ConstructorStart))
                    {
                        return true;
                    }
                    break;

                case ',':
                case ']':
                case '}':
                    return true;

                case '/':
                    if (!this.method_20(1, false))
                    {
                        return false;
                    }
                    return (this.char_2[this.int_1 + 1] == '*');

                default:
                    if (char.IsWhiteSpace(char_3))
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }

        private void method_42()
        {
            if (!this.method_40(JsonConvert.True))
            {
                throw JsonReaderException.smethod_1(this, "Error parsing boolean value.");
            }
            base.SetToken(JsonToken.Boolean, true);
        }

        private void method_43()
        {
            if (!this.method_40(JsonConvert.Null))
            {
                throw JsonReaderException.smethod_1(this, "Error parsing null value.");
            }
            base.SetToken(JsonToken.Null);
        }

        private void method_44()
        {
            if (!this.method_40(JsonConvert.Undefined))
            {
                throw JsonReaderException.smethod_1(this, "Error parsing undefined value.");
            }
            base.SetToken(JsonToken.Undefined);
        }

        private void method_45()
        {
            if (!this.method_40(JsonConvert.False))
            {
                throw JsonReaderException.smethod_1(this, "Error parsing boolean value.");
            }
            base.SetToken(JsonToken.Boolean, false);
        }

        private void method_46()
        {
            if (!this.method_40(JsonConvert.NegativeInfinity))
            {
                throw JsonReaderException.smethod_1(this, "Error parsing negative infinity value.");
            }
            if (base.floatParseHandling_0 == FloatParseHandling.Decimal)
            {
                throw new JsonReaderException("Cannot read -Infinity as a decimal.");
            }
            base.SetToken(JsonToken.Float, (double) -1.0 / (double) 0.0);
        }

        private void method_47()
        {
            if (!this.method_40(JsonConvert.PositiveInfinity))
            {
                throw JsonReaderException.smethod_1(this, "Error parsing positive infinity value.");
            }
            if (base.floatParseHandling_0 == FloatParseHandling.Decimal)
            {
                throw new JsonReaderException("Cannot read Infinity as a decimal.");
            }
            base.SetToken(JsonToken.Float, (double) 1.0 / (double) 0.0);
        }

        private void method_48()
        {
            if (!this.method_40(JsonConvert.NaN))
            {
                throw JsonReaderException.smethod_1(this, "Error parsing NaN value.");
            }
            if (base.floatParseHandling_0 == FloatParseHandling.Decimal)
            {
                throw new JsonReaderException("Cannot read NaN as a decimal.");
            }
            base.SetToken(JsonToken.Float, (double) 1.0 / (double) 0.0);
        }

        bool JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮()
        {
        Label_0000:
            switch (base.state_0)
            {
                case JsonReader.State.Start:
                case JsonReader.State.Property:
                case JsonReader.State.ArrayStart:
                case JsonReader.State.Array:
                case JsonReader.State.ConstructorStart:
                case JsonReader.State.Constructor:
                    return this.method_32();

                case JsonReader.State.Complete:
                case JsonReader.State.Closed:
                case JsonReader.State.Error:
                    goto Label_0000;

                case JsonReader.State.ObjectStart:
                case JsonReader.State.Object:
                    return this.method_28();

                case JsonReader.State.PostValue:
                    if (!this.method_27())
                    {
                        goto Label_0000;
                    }
                    return true;

                case JsonReader.State.Finished:
                    if (this.method_20(0, false))
                    {
                        this.method_35(false);
                        if (!this.bool_2)
                        {
                            if (this.char_2[this.int_1] != '/')
                            {
                                throw JsonReaderException.smethod_1(this, "Additional text encountered after finished reading JSON content: {0}.".smethod_0(CultureInfo.InvariantCulture, this.char_2[this.int_1]));
                            }
                            this.method_38();
                            return true;
                        }
                    }
                    return false;
            }
            throw JsonReaderException.smethod_1(this, "Unexpected state: {0}.".smethod_0(CultureInfo.InvariantCulture, base.CurrentState));
        }

        [DebuggerStepThrough]
        public override bool Read()
        {
            base.enum14_0 = Enum14.Read;
            if (!this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮())
            {
                base.SetToken(JsonToken.None);
                return false;
            }
            return true;
        }

        public override byte[] ReadAsBytes()
        {
            return base.method_5();
        }

        public override DateTime? ReadAsDateTime()
        {
            return base.method_9();
        }

        public override DateTimeOffset? ReadAsDateTimeOffset()
        {
            return base.method_4();
        }

        public override decimal? ReadAsDecimal()
        {
            return base.method_6();
        }

        public override int? ReadAsInt32()
        {
            return base.method_7();
        }

        public override string ReadAsString()
        {
            return base.method_8();
        }

        private static void smethod_2(char[] char_3, int int_4, char[] char_4, int int_5, int int_6)
        {
            Buffer.BlockCopy(char_3, int_4 * 2, char_4, int_5 * 2, int_6 * 2);
        }

        public int LineNumber
        {
            get
            {
                if ((base.CurrentState == JsonReader.State.Start) && (this.LinePosition == 0))
                {
                    return 0;
                }
                return this.int_3;
            }
        }

        public int LinePosition
        {
            get
            {
                return (this.int_1 - this.int_2);
            }
        }
    }
}


namespace ns18
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Text;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct25
    {
        internal Enum12 enum12_0;
        internal int int_0;
        internal string string_0;
        internal bool bool_0;
        public Struct25(Enum12 type)
        {
            this.enum12_0 = type;
            this.bool_0 = smethod_0(type);
            this.int_0 = -1;
            this.string_0 = null;
        }

        internal void method_0(StringBuilder stringBuilder_0)
        {
            switch (this.enum12_0)
            {
                case Enum12.Object:
                    if (stringBuilder_0.Length > 0)
                    {
                        stringBuilder_0.Append(".");
                    }
                    stringBuilder_0.Append(this.string_0);
                    return;

                case Enum12.Array:
                case Enum12.Constructor:
                    stringBuilder_0.Append("[");
                    stringBuilder_0.Append(this.int_0);
                    stringBuilder_0.Append("]");
                    return;
            }
        }

        internal static bool smethod_0(Enum12 enum12_1)
        {
            if (enum12_1 != Enum12.Array)
            {
                return (enum12_1 == Enum12.Constructor);
            }
            return true;
        }

        internal static string smethod_1(IEnumerable<Struct25> ienumerable_0)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Struct25 struct2 in ienumerable_0)
            {
                struct2.method_0(builder);
            }
            return builder.ToString();
        }

        internal static string smethod_2(IJsonLineInfo ijsonLineInfo_0, string string_1, string string_2)
        {
            if (!string_2.EndsWith(Environment.NewLine))
            {
                string_2 = string_2.Trim();
                if (!string_2.EndsWith("."))
                {
                    string_2 = string_2 + ".";
                }
                string_2 = string_2 + " ";
            }
            string_2 = string_2 + "Path '{0}'".smethod_0(CultureInfo.InvariantCulture, string_1);
            if ((ijsonLineInfo_0 != null) && ijsonLineInfo_0.HasLineInfo())
            {
                string_2 = string_2 + ", line {0}, position {1}".smethod_1(CultureInfo.InvariantCulture, ijsonLineInfo_0.LineNumber, ijsonLineInfo_0.LinePosition);
            }
            string_2 = string_2 + ".";
            return string_2;
        }
    }
}


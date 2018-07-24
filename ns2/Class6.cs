namespace ns2
{
    using System;
    using System.Runtime.CompilerServices;

    internal class Class6
    {
        [CompilerGenerated]
        private readonly Enum1 enum1_0;
        [CompilerGenerated]
        private readonly string string_0;
        [CompilerGenerated]
        private readonly string string_1;
        [CompilerGenerated]
        private readonly string string_2;

        private Class6(Enum1 type, string exePath, string relaunchFile, string errorMessage)
        {
            this.enum1_0 = type;
            this.string_0 = exePath;
            this.string_1 = relaunchFile;
            this.string_2 = errorMessage;
        }

        public static Class6 smethod_0(string string_3)
        {
            return new Class6(Enum1.Success, string_3, null, null);
        }

        public static Class6 smethod_1(string string_3)
        {
            return new Class6(Enum1.Relaunch, null, string_3, null);
        }

        public static Class6 smethod_2(string string_3)
        {
            return new Class6(Enum1.Error, null, null, string_3);
        }

        public Enum1 Enum1_0
        {
            [CompilerGenerated]
            get
            {
                return this.enum1_0;
            }
        }

        public string String_0
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
        }

        public string String_1
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
        }

        public string String_2
        {
            [CompilerGenerated]
            get
            {
                return this.string_2;
            }
        }
    }
}


namespace ns8
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;

    internal class Class43
    {
        public static uint smethod_0()
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            byte[] source = new byte[] { 0x11, 0x33, 0x22, 0x18, 0x37, 0x3b, 0x33 };
            byte[] buffer2 = new byte[] { 
                0x76, 0x54, 0x45, 0x61, 0x44, 0x53, 0x5d, 0x58, 0x52, 0x7a, 0x54, 0x48, 0x65, 0x5e, 90, 0x54, 
                0x5f
             };
            object obj2 = entryAssembly.GetType().GetMethod(Encoding.ASCII.GetString(source.Select<byte, byte>((Class44.<>9__0_0 ?? (Class44.<>9__0_0 = new Func<byte, byte>(Class44.<>9.method_0)))).ToArray<byte>()), new Type[0]).Invoke(entryAssembly, null);
            ulong num = 14695981039346656037L;
            foreach (byte num3 in (byte[]) obj2.GetType().GetMethod(Encoding.ASCII.GetString(buffer2.Select<byte, byte>((Class44.<>9__0_1 ?? (Class44.<>9__0_1 = new Func<byte, byte>(Class44.<>9.method_1)))).ToArray<byte>())).Invoke(obj2, null))
            {
                num ^= num3;
                num *= (ulong) 0x100000001b3L;
            }
            return (uint) (num & ((ulong) 0xffffffffL));
        }

        private static byte[] smethod_1()
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            byte[] source = new byte[] { 0x11, 0x33, 0x22, 0x18, 0x37, 0x3b, 0x33 };
            byte[] buffer2 = new byte[] { 
                0x76, 0x54, 0x45, 0x61, 0x44, 0x53, 0x5d, 0x58, 0x52, 0x7a, 0x54, 0x48, 0x65, 0x5e, 90, 0x54, 
                0x5f
             };
            object obj2 = entryAssembly.GetType().GetMethod(Encoding.ASCII.GetString(source.Select<byte, byte>((Class44.<>9__1_0 ?? (Class44.<>9__1_0 = new Func<byte, byte>(Class44.<>9.method_2)))).ToArray<byte>()), new Type[0]).Invoke(entryAssembly, null);
            return (byte[]) obj2.GetType().GetMethod(Encoding.ASCII.GetString(buffer2.Select<byte, byte>((Class44.<>9__1_1 ?? (Class44.<>9__1_1 = new Func<byte, byte>(Class44.<>9.method_3)))).ToArray<byte>())).Invoke(obj2, null);
        }

        [Serializable, CompilerGenerated]
        private sealed class Class44
        {
            public static readonly Class43.Class44 <>9 = new Class43.Class44();
            public static Func<byte, byte> <>9__0_0;
            public static Func<byte, byte> <>9__0_1;
            public static Func<byte, byte> <>9__1_0;
            public static Func<byte, byte> <>9__1_1;

            internal byte method_0(byte byte_0)
            {
                return (byte) (byte_0 ^ 0x56);
            }

            internal byte method_1(byte byte_0)
            {
                return (byte) (byte_0 ^ 0x31);
            }

            internal byte method_2(byte byte_0)
            {
                return (byte) (byte_0 ^ 0x56);
            }

            internal byte method_3(byte byte_0)
            {
                return (byte) (byte_0 ^ 0x31);
            }
        }
    }
}


namespace ns10
{
    using ns9;
    using System;
    using System.IO;

    internal static class Class59
    {
        private static readonly Enum5[] enum5_0 = new Enum5[] { Enum5.const_1 };
        private const int int_0 = 0x800000;
        private static readonly object[] object_0 = new object[] { 0x800000, 2, 3, 0, 2, 0x80, "bt4", false };

        public static byte[] smethod_0(byte[] byte_0)
        {
            using (MemoryStream stream = new MemoryStream(byte_0))
            {
                return smethod_1(stream);
            }
        }

        public static byte[] smethod_1(Stream stream_0)
        {
            Stream stream = stream_0;
            MemoryStream stream2 = new MemoryStream();
            Class54 class2 = new Class54();
            class2.imethod_1(enum5_0, object_0);
            class2.imethod_2(stream2);
            long length = stream.Length;
            for (int i = 0; i < 8; i++)
            {
                stream2.WriteByte((byte) (length >> (8 * i)));
            }
            class2.imethod_0(stream, stream2, -1L, -1L, null);
            return stream2.ToArray();
        }

        public static byte[] smethod_2(byte[] byte_0)
        {
            using (MemoryStream stream = new MemoryStream(byte_0))
            {
                return smethod_3(stream);
            }
        }

        public static byte[] smethod_3(Stream stream_0)
        {
            Stream stream = stream_0;
            Class51 class2 = new Class51();
            stream.Seek(0L, SeekOrigin.Begin);
            MemoryStream stream2 = new MemoryStream();
            byte[] buffer = new byte[5];
            if (stream.Read(buffer, 0, 5) != 5)
            {
                throw new Exception("input .lzma is too short");
            }
            long num = 0L;
            for (int i = 0; i < 8; i++)
            {
                int num4 = stream.ReadByte();
                if (num4 < 0)
                {
                    throw new Exception("Can't Read 1");
                }
                num |= ((byte) num4) << (8 * i);
            }
            class2.imethod_1(buffer);
            long num2 = stream.Length - stream.Position;
            class2.imethod_0(stream, stream2, num2, num, null);
            return stream2.ToArray();
        }
    }
}


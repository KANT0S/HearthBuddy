namespace ns8
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Text;

    internal class Class41
    {
        private const string string_0 = "<RSAKeyValue><Modulus>ntODwyoUyuohguy+MRKVhGUy864S5IpTUoy1WNzbl74rIn3h9jo+d++UKGsBBeNw8y+hmtfaiYCr8Nd6M2g7f1RHWuZO7au/Ct6ol6stJG3sS8d59/j7pLABL5ZoIjwQhWdu1kJ5w2uPZHDN8F6qncAq8YFur7Lh7/ZxeNu8B/E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        public static byte[] smethod_0(string string_1)
        {
            using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider(0x400))
            {
                provider.FromXmlString("<RSAKeyValue><Modulus>ntODwyoUyuohguy+MRKVhGUy864S5IpTUoy1WNzbl74rIn3h9jo+d++UKGsBBeNw8y+hmtfaiYCr8Nd6M2g7f1RHWuZO7au/Ct6ol6stJG3sS8d59/j7pLABL5ZoIjwQhWdu1kJ5w2uPZHDN8F6qncAq8YFur7Lh7/ZxeNu8B/E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
                provider.PersistKeyInCsp = false;
                return provider.Encrypt(Encoding.UTF8.GetBytes(string_1), true);
            }
        }

        public static string smethod_1(string string_1)
        {
            using (SHA256Managed managed = new SHA256Managed())
            {
                byte[] source = managed.ComputeHash(Encoding.UTF8.GetBytes(string_1));
                return string.Join("", source.Select<byte, string>(Class42.<>9__2_0 ?? (Class42.<>9__2_0 = new Func<byte, string>(Class42.<>9.method_0))));
            }
        }

        public static string smethod_2(string string_1)
        {
            using (MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider())
            {
                return provider.ComputeHash(Encoding.ASCII.GetBytes(string_1)).Aggregate<byte, string>("", (Class42.<>9__3_0 ?? (Class42.<>9__3_0 = new Func<string, byte, string>(Class42.<>9.method_1))));
            }
        }

        public static byte[] smethod_3(byte[] byte_0, byte[] byte_1)
        {
            byte[] buffer3;
            byte[] dst = new byte[0x20];
            byte[] buffer2 = new byte[0x10];
            using (SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider())
            {
                byte[] src = provider.ComputeHash(byte_1);
                Buffer.BlockCopy(src, 0, dst, 0, 0x20);
                Buffer.BlockCopy(src, 0, buffer2, 0x20, 0x10);
            }
            using (MemoryStream stream = new MemoryStream())
            {
                using (RijndaelManaged managed = new RijndaelManaged())
                {
                    managed.Mode = CipherMode.ECB;
                    managed.Padding = PaddingMode.ISO10126;
                    using (CryptoStream stream2 = new CryptoStream(stream, managed.CreateEncryptor(dst, buffer2), CryptoStreamMode.Write))
                    {
                        stream2.Write(byte_0, 0, byte_0.Length);
                        stream2.FlushFinalBlock();
                        buffer3 = stream.ToArray();
                    }
                }
            }
            return buffer3;
        }

        public static byte[] smethod_4(byte[] byte_0, byte[] byte_1)
        {
            return smethod_5(byte_0, byte_1, byte_1);
        }

        public static byte[] smethod_5(byte[] byte_0, byte[] byte_1, byte[] byte_2)
        {
            byte[] buffer5;
            if (byte_1.Length != 0x20)
            {
                byte[] buffer = new byte[0x20];
                for (int i = 0; i < 0x20; i++)
                {
                    if (i < byte_1.Length)
                    {
                        buffer[i] = byte_1[i];
                    }
                    else
                    {
                        buffer[i] = (byte) i;
                    }
                }
                byte_1 = buffer;
            }
            if (byte_2.Length != 0x10)
            {
                byte[] buffer2 = new byte[0x10];
                for (int j = 0; j < 0x10; j++)
                {
                    if (j < byte_2.Length)
                    {
                        buffer2[j] = byte_2[j];
                    }
                    else
                    {
                        buffer2[j] = (byte) j;
                    }
                }
                byte_2 = buffer2;
            }
            using (RijndaelManaged managed = new RijndaelManaged())
            {
                managed.Key = byte_1;
                managed.IV = byte_2;
                managed.Mode = CipherMode.ECB;
                managed.Padding = PaddingMode.ISO10126;
                using (CryptoStream stream = new CryptoStream(new MemoryStream(byte_0), managed.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] buffer3 = new byte[byte_0.Length];
                    int count = stream.Read(buffer3, 0, buffer3.Length);
                    byte[] dst = new byte[count];
                    Buffer.BlockCopy(buffer3, 0, dst, 0, count);
                    buffer5 = dst;
                }
            }
            return buffer5;
        }

        [Serializable, CompilerGenerated]
        private sealed class Class42
        {
            public static readonly Class41.Class42 <>9 = new Class41.Class42();
            public static Func<byte, string> <>9__2_0;
            public static Func<string, byte, string> <>9__3_0;

            internal string method_0(byte byte_0)
            {
                return byte_0.ToString("x2");
            }

            internal string method_1(string string_0, byte byte_0)
            {
                return (string_0 + byte_0.ToString("x2"));
            }
        }
    }
}


namespace ns24
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.InteropServices;

    internal class Class243
    {
        private IntPtr[] intptr_0;
        public const string string_0 = "HSB-12051.186971";
        internal Struct101 struct101_0;
        internal Struct102 struct102_0;
        public const uint uint_0 = 0xcf3a992b;
        public const uint uint_1 = 0x2f13;
        public const uint uint_2 = 0x2da5b;

        internal unsafe void method_0(IntPtr intptr_1)
        {
            ArraySegment<IntPtr> segment;
            ArraySegment<IntPtr> segment2;
            IntPtr[] ptrArray2;
            ref IntPtr pinned ptrRef2;
            IntPtr[] array = new IntPtr[this.intptr_0.Length];
            this.intptr_0.CopyTo(array, 0);
            this.method_4(array, out segment, out segment2);
            for (int i = segment.Offset; i < segment.Count; i++)
            {
                if (segment.Array[i].ToInt32() > 0x400000)
                {
                    array[i] = (array[i] - 0x400000) + intptr_1.ToInt32();
                }
            }
            if (((ptrArray2 = this.method_2<IntPtr>(segment)) != null) && (ptrArray2.Length != 0))
            {
                ptrRef = ptrArray2;
                goto Label_0095;
            }
            fixed (IntPtr* ptrRef = null)
            {
                byte* numPtr;
            Label_0095:
                numPtr = (byte*) ptrRef;
                if (numPtr != null)
                {
                    this.struct101_0 = *((Struct101*) numPtr);
                }
            }
            if (((ptrArray2 = this.method_2<IntPtr>(segment2)) != null) && (ptrArray2.Length != 0))
            {
                ptrRef2 = ptrArray2;
            }
            else
            {
                ptrRef2 = null;
            }
            byte* numPtr2 = (byte*) ptrRef2;
            if (numPtr2 != null)
            {
                this.struct102_0 = *((Struct102*) numPtr2);
            }
            ptrRef2 = null;
        }

        internal unsafe void method_1(byte[] byte_0, IntPtr intptr_1)
        {
            byte[] buffer;
            this.intptr_0 = new IntPtr[byte_0.Length / 4];
            byte num = 1;
            if (((buffer = byte_0) != null) && (buffer.Length != 0))
            {
                numRef = buffer;
                goto Label_0029;
            }
            fixed (byte* numRef = null)
            {
                uint* numPtr;
            Label_0029:
                numPtr = (uint*) numRef;
                for (int i = 0; i < this.intptr_0.Length; i++)
                {
                    uint num3 = numPtr[i];
                    this.intptr_0[i] = new IntPtr((long) smethod_0(num3, num));
                    num = (byte) (num + 1);
                    if (num == 0)
                    {
                        num = 0;
                    }
                }
            }
            this.method_0(intptr_1);
        }

        private T[] method_2<T>(ArraySegment<T> arraySegment_0) where T: struct
        {
            List<T> list = new List<T>();
            for (int i = arraySegment_0.Offset; i < (arraySegment_0.Offset + arraySegment_0.Count); i++)
            {
                list.Add(arraySegment_0.Array[i]);
            }
            return list.ToArray();
        }

        public void method_3()
        {
            this.intptr_0 = null;
            this.struct101_0 = new Struct101();
            this.struct102_0 = new Struct102();
        }

        public void method_4(IntPtr[] intptr_1, out ArraySegment<IntPtr> arraySegment_0, out ArraySegment<IntPtr> arraySegment_1)
        {
            arraySegment_0 = new ArraySegment<IntPtr>(intptr_1, 0, 0);
            arraySegment_1 = new ArraySegment<IntPtr>(intptr_1, 0, 0x24);
        }

        private static uint smethod_0(uint uint_3, byte byte_0)
        {
            uint num = (uint) ((((byte_0 << 0x18) | (byte_0 << 0x10)) | (byte_0 << 8)) | byte_0);
            return (uint_3 ^ num);
        }

        public static uint smethod_1(string string_1)
        {
            return Class244.smethod_0(File.ReadAllBytes(string_1), 0xc58f1a7b);
        }

        internal class Class244
        {
            private const int int_0 = 0x18;
            private const uint uint_0 = 0x5bd1e995;

            public static unsafe uint smethod_0(byte[] byte_0, uint uint_1 = 0xc58f1a7b)
            {
                int length = byte_0.Length;
                if (length == 0)
                {
                    return 0;
                }
                uint num2 = uint_1 ^ ((uint) length);
                int num3 = length & 3;
                int num4 = length >> 2;
                fixed (byte* numRef = byte_0)
                {
                    uint* numPtr = (uint*) numRef;
                    while (num4 != 0)
                    {
                        uint num5 = numPtr[0];
                        num5 *= 0x5bd1e995;
                        num5 ^= num5 >> 0x18;
                        num5 *= 0x5bd1e995;
                        num2 *= 0x5bd1e995;
                        num2 ^= num5;
                        num4--;
                        numPtr++;
                    }
                    switch (num3)
                    {
                        case 1:
                            num2 ^= *((byte*) numPtr);
                            num2 *= 0x5bd1e995;
                            break;

                        case 2:
                            num2 ^= (ushort) numPtr[0];
                            num2 *= 0x5bd1e995;
                            break;

                        case 3:
                            num2 ^= (ushort) numPtr[0];
                            num2 ^= (uint) (*(((byte*) (numPtr + 2))) << 0x10);
                            num2 *= 0x5bd1e995;
                            break;
                    }
                }
                num2 ^= num2 >> 13;
                num2 *= 0x5bd1e995;
                return (num2 ^ (num2 >> 15));
            }
        }
    }
}


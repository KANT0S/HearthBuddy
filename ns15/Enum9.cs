namespace ns15
{
    using System;

    internal enum Enum9 : byte
    {
        Binary = 0,
        [Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
        BinaryOld = 2,
        Function = 1,
        Md5 = 5,
        UserDefined = 0x80,
        Uuid = 4,
        [Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
        UuidOld = 3
    }
}


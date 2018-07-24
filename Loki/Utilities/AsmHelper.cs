namespace Loki.Utilities
{
    using System;

    public static class AsmHelper
    {
        public static unsafe int GetFloatInt(float val)
        {
            return *(((int*) &val));
        }

        public static unsafe uint GetFloatUInt(float val)
        {
            return *(((uint*) &val));
        }
    }
}


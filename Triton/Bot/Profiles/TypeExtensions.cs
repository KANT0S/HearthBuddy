namespace Triton.Bot.Profiles
{
    using System;
    using System.Runtime.CompilerServices;

    public static class TypeExtensions
    {
        public static object GetDefaultValue(this Type t)
        {
            if (t.IsValueType)
            {
                return Activator.CreateInstance(t);
            }
            return null;
        }
    }
}


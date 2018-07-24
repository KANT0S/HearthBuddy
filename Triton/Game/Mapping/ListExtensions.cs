namespace Triton.Game.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public static class ListExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            Random random = new Random();
            int count = list.Count;
            while (count > 1)
            {
                count--;
                int num2 = random.Next(count + 1);
                T local = list[num2];
                list[num2] = list[count];
                list[count] = local;
            }
        }
    }
}


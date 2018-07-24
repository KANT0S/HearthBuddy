namespace ns20
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal static class Class191
    {
        public static bool smethod_0<T>(ICollection<T> icollection_0)
        {
            if (icollection_0 != null)
            {
                return (icollection_0.Count == 0);
            }
            return true;
        }

        public static void smethod_1<T>(this IList<T> ilist_0, IEnumerable<T> ienumerable_0)
        {
            if (ilist_0 == null)
            {
                throw new ArgumentNullException("initial");
            }
            if (ienumerable_0 != null)
            {
                foreach (T local in ienumerable_0)
                {
                    ilist_0.Add(local);
                }
            }
        }

        private static IList<int> smethod_10(IList ilist_0)
        {
            IList<int> list = new List<int>();
            IList list2 = ilist_0;
        Label_0021:
            list.Add(list2.Count);
            if (list2.Count != 0)
            {
                object obj2 = list2[0];
                if (!(obj2 is IList))
                {
                    return list;
                }
                list2 = (IList) obj2;
                goto Label_0021;
            }
            return list;
        }

        private static void smethod_11(IList ilist_0, Array array_0, int[] int_0)
        {
            int length = int_0.Length;
            if (length == array_0.Rank)
            {
                array_0.SetValue(smethod_12(ilist_0, int_0), int_0);
            }
            else
            {
                int num2 = array_0.GetLength(length);
                IList list = (IList) smethod_12(ilist_0, int_0);
                if (list.Count != num2)
                {
                    throw new Exception("Cannot deserialize non-cubical array as multidimensional array.");
                }
                int[] numArray = new int[length + 1];
                for (int i = 0; i < length; i++)
                {
                    numArray[i] = int_0[i];
                }
                for (int j = 0; j < array_0.GetLength(length); j++)
                {
                    numArray[length] = j;
                    smethod_11(ilist_0, array_0, numArray);
                }
            }
        }

        private static object smethod_12(IList ilist_0, int[] int_0)
        {
            IList list = ilist_0;
            for (int i = 0; i < int_0.Length; i++)
            {
                int num2 = int_0[i];
                if (i == (int_0.Length - 1))
                {
                    return list[num2];
                }
                list = (IList) list[num2];
            }
            return list;
        }

        public static Array smethod_13(IList ilist_0, Type type_0, int int_0)
        {
            IList<int> source = smethod_10(ilist_0);
            while (source.Count < int_0)
            {
                source.Add(0);
            }
            Array array = Array.CreateInstance(type_0, source.ToArray<int>());
            smethod_11(ilist_0, array, new int[0]);
            return array;
        }

        public static bool smethod_2(Type type_0)
        {
            Class203.smethod_2(type_0, "type");
            return (typeof(IDictionary).IsAssignableFrom(type_0) || Class194.smethod_13(type_0, typeof(IDictionary<,>)));
        }

        public static ConstructorInfo smethod_3(Type type_0, Type type_1)
        {
            Type type = typeof(IEnumerable<>).MakeGenericType(new Type[] { type_1 });
            foreach (ConstructorInfo info in type_0.GetConstructors(BindingFlags.Public | BindingFlags.Instance))
            {
                IList<ParameterInfo> parameters = info.GetParameters();
                if ((parameters.Count == 1) && type.IsAssignableFrom(parameters[0].ParameterType))
                {
                    return info;
                }
            }
            return null;
        }

        public static bool smethod_4<T>(this IList<T> ilist_0, T gparam_0)
        {
            return ilist_0.smethod_5<T>(gparam_0, EqualityComparer<T>.Default);
        }

        public static bool smethod_5<T>(this IList<T> ilist_0, T gparam_0, IEqualityComparer<T> iequalityComparer_0)
        {
            if (ilist_0.smethod_6<T>(gparam_0, iequalityComparer_0))
            {
                return false;
            }
            ilist_0.Add(gparam_0);
            return true;
        }

        public static bool smethod_6<T>(this IEnumerable<T> ienumerable_0, T gparam_0, IEqualityComparer<T> iequalityComparer_0)
        {
            if (iequalityComparer_0 == null)
            {
                iequalityComparer_0 = EqualityComparer<T>.Default;
            }
            if (ienumerable_0 == null)
            {
                throw new ArgumentNullException("source");
            }
            foreach (T local in ienumerable_0)
            {
                if (iequalityComparer_0.Equals(local, gparam_0))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool smethod_7<T>(this IList<T> ilist_0, IEnumerable<T> ienumerable_0, IEqualityComparer<T> iequalityComparer_0)
        {
            bool flag = true;
            foreach (T local in ienumerable_0)
            {
                if (!ilist_0.smethod_5<T>(local, iequalityComparer_0))
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static int smethod_8<T>(this IEnumerable<T> ienumerable_0, Func<T, bool> func_0)
        {
            int num = 0;
            foreach (T local in ienumerable_0)
            {
                if (func_0(local))
                {
                    return num;
                }
                num++;
            }
            return -1;
        }

        public static int smethod_9<T>(this IEnumerable<T> ienumerable_0, T gparam_0, IEqualityComparer<T> iequalityComparer_0)
        {
            int num = 0;
            foreach (T local in ienumerable_0)
            {
                if (iequalityComparer_0.Equals(local, gparam_0))
                {
                    return num;
                }
                num++;
            }
            return -1;
        }
    }
}


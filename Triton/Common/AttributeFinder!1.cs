namespace Triton.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class AttributeFinder<T> where T: Attribute
    {
        [CompilerGenerated]
        private List<Tuple<MemberInfo, List<T>>> list_0;
        [CompilerGenerated]
        private List<Tuple<Type, List<T>>> list_1;

        public AttributeFinder(bool publicOnly = true, bool includeGacAssemblies = false)
        {
            this.AttributedMembers = new List<Tuple<MemberInfo, List<T>>>();
            this.AttributedObjects = new List<Tuple<Type, List<T>>>();
            AttributeUsageAttribute customAttribute = typeof(T).GetCustomAttribute<AttributeUsageAttribute>();
            bool flag = customAttribute.ValidOn.HasFlag(AttributeTargets.Class);
            bool flag2 = customAttribute.ValidOn.HasFlag(AttributeTargets.Struct);
            bool flag3 = customAttribute.ValidOn.HasFlag(AttributeTargets.Enum);
            bool flag4 = (customAttribute.ValidOn & (AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Constructor)) > 0;
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (includeGacAssemblies || !assembly.GlobalAssemblyCache)
                {
                    foreach (Type type in assembly.GetTypes())
                    {
                        if (((!flag || type.IsClass) && (!flag3 || type.IsEnum)) && ((!flag2 || type.IsValueType) && (publicOnly || type.IsPublic)))
                        {
                            List<T> list = type.GetCustomAttributes<T>().ToList<T>();
                            if (list.Count != 0)
                            {
                                this.AttributedObjects.Add(new Tuple<Type, List<T>>(type, list));
                            }
                            if (flag4)
                            {
                                foreach (MemberInfo info in type.GetMembers())
                                {
                                    List<T> list2 = info.GetCustomAttributes<T>().ToList<T>();
                                    if (list2.Count != 0)
                                    {
                                        this.AttributedMembers.Add(new Tuple<MemberInfo, List<T>>(info, list2));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public List<Tuple<MemberInfo, List<T>>> AttributedMembers
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            set
            {
                this.list_0 = value;
            }
        }

        public List<Tuple<Type, List<T>>> AttributedObjects
        {
            [CompilerGenerated]
            get
            {
                return this.list_1;
            }
            [CompilerGenerated]
            set
            {
                this.list_1 = value;
            }
        }
    }
}


namespace ns20
{
    using System;
    using System.Globalization;
    using System.Reflection;

    internal abstract class Class166
    {
        protected Class166()
        {
        }

        public Func<T, object> method_0<T>(MemberInfo memberInfo_0)
        {
            PropertyInfo info = memberInfo_0 as PropertyInfo;
            if (info != null)
            {
                return this.ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(info);
            }
            FieldInfo info2 = memberInfo_0 as FieldInfo;
            if (info2 == null)
            {
                throw new Exception("Could not create getter for {0}.".smethod_0(CultureInfo.InvariantCulture, memberInfo_0));
            }
            return this.ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(info2);
        }

        public Action<T, object> method_1<T>(MemberInfo memberInfo_0)
        {
            PropertyInfo info = memberInfo_0 as PropertyInfo;
            if (info != null)
            {
                return this.ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(info);
            }
            FieldInfo info2 = memberInfo_0 as FieldInfo;
            if (info2 == null)
            {
                throw new Exception("Could not create setter for {0}.".smethod_0(CultureInfo.InvariantCulture, memberInfo_0));
            }
            return this.ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(info2);
        }

        public abstract Action<T, object> ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(FieldInfo fieldInfo_0);
        public abstract Delegate3<T, object> ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<T>(MethodBase methodBase_0);
        public abstract Action<T, object> ns20.Class166.‬‭⁭‎‎‌⁭⁮⁬‏‮‪​‬‭‏‫‭‫‏⁫⁪‫⁬‎‮‫‫‎⁫‎⁭‎‭‍‫⁯‪⁭‏‮<T>(PropertyInfo propertyInfo_0);
        public abstract Func<T> ns20.Class166.‍‍‍‏‍‍‍⁪‮‪⁫⁯‌⁪‍‏‭⁭‎⁬‭​‬⁫⁭‪‬‪⁫‮⁪‬​‫‫‎‮⁪⁬‏‮<T>(Type type_0);
        public abstract Func<T, object> ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(FieldInfo fieldInfo_0);
        public abstract Func<T, object> ns20.Class166.⁬⁮⁯‍‌‫‍⁯‫​​‫⁯⁬‌​⁬⁫⁭⁭‪​‭⁪⁪‬‎‭⁪‍‌​‎⁬⁮‪⁪⁮⁭⁫‮<T>(PropertyInfo propertyInfo_0);
    }
}


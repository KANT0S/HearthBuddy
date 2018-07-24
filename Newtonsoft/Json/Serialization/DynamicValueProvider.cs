namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Globalization;
    using System.Reflection;

    public class DynamicValueProvider : IValueProvider
    {
        private Action<object, object> action_0;
        private Func<object, object> func_0;
        private readonly MemberInfo memberInfo_0;

        public DynamicValueProvider(MemberInfo memberInfo)
        {
            Class203.smethod_2(memberInfo, "memberInfo");
            this.memberInfo_0 = memberInfo;
        }

        public object GetValue(object target)
        {
            object obj2;
            try
            {
                if (this.func_0 == null)
                {
                    this.func_0 = Class167.class167_0.method_0<object>(this.memberInfo_0);
                }
                obj2 = this.func_0(target);
            }
            catch (Exception exception)
            {
                throw new JsonSerializationException("Error getting value from '{0}' on '{1}'.".smethod_1(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), exception);
            }
            return obj2;
        }

        public void SetValue(object target, object value)
        {
            try
            {
                if (this.action_0 == null)
                {
                    this.action_0 = Class167.class167_0.method_1<object>(this.memberInfo_0);
                }
                this.action_0(target, value);
            }
            catch (Exception exception)
            {
                throw new JsonSerializationException("Error setting value to '{0}' on '{1}'.".smethod_1(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), exception);
            }
        }
    }
}


namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Globalization;
    using System.Reflection;

    public class ReflectionValueProvider : IValueProvider
    {
        private readonly MemberInfo memberInfo_0;

        public ReflectionValueProvider(MemberInfo memberInfo)
        {
            Class203.smethod_2(memberInfo, "memberInfo");
            this.memberInfo_0 = memberInfo;
        }

        public object GetValue(object target)
        {
            object obj2;
            try
            {
                obj2 = Class194.smethod_23(this.memberInfo_0, target);
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
                Class194.smethod_24(this.memberInfo_0, target, value);
            }
            catch (Exception exception)
            {
                throw new JsonSerializationException("Error setting value to '{0}' on '{1}'.".smethod_1(CultureInfo.InvariantCulture, this.memberInfo_0.Name, target.GetType()), exception);
            }
        }
    }
}


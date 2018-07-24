namespace Newtonsoft.Json.Serialization
{
    using ns16;
    using ns20;
    using System;
    using System.Dynamic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class JsonDynamicContract : JsonContainerContract
    {
        private readonly Class178<string, CallSite<Func<CallSite, object, object>>> class178_0;
        private readonly Class178<string, CallSite<Func<CallSite, object, object, object>>> class178_1;
        [CompilerGenerated]
        private Func<string, string> func_1;
        [CompilerGenerated]
        private JsonPropertyCollection jsonPropertyCollection_0;

        public JsonDynamicContract(Type underlyingType) : base(underlyingType)
        {
            this.class178_0 = new Class178<string, CallSite<Func<CallSite, object, object>>>(new Func<string, CallSite<Func<CallSite, object, object>>>(JsonDynamicContract.smethod_2));
            this.class178_1 = new Class178<string, CallSite<Func<CallSite, object, object, object>>>(new Func<string, CallSite<Func<CallSite, object, object, object>>>(JsonDynamicContract.smethod_3));
            base.enum15_0 = Enum15.Dynamic;
            this.Properties = new JsonPropertyCollection(base.UnderlyingType);
        }

        internal bool method_5(IDynamicMetaObjectProvider idynamicMetaObjectProvider_0, string string_0, out object object_0)
        {
            Class203.smethod_2(idynamicMetaObjectProvider_0, "dynamicProvider");
            CallSite<Func<CallSite, object, object>> site = this.class178_0.method_0(string_0);
            object objA = site.Target(site, idynamicMetaObjectProvider_0);
            if (!object.ReferenceEquals(objA, Class161.object_0))
            {
                object_0 = objA;
                return true;
            }
            object_0 = null;
            return false;
        }

        internal bool method_6(IDynamicMetaObjectProvider idynamicMetaObjectProvider_0, string string_0, object object_0)
        {
            Class203.smethod_2(idynamicMetaObjectProvider_0, "dynamicProvider");
            CallSite<Func<CallSite, object, object, object>> site = this.class178_1.method_0(string_0);
            return !object.ReferenceEquals(site.Target(site, idynamicMetaObjectProvider_0, object_0), Class161.object_0);
        }

        private static CallSite<Func<CallSite, object, object>> smethod_2(string string_0)
        {
            GetMemberBinder innerBinder = (GetMemberBinder) Class157.Class158.smethod_3(string_0, typeof(Class157));
            return CallSite<Func<CallSite, object, object>>.Create(new Class159(innerBinder));
        }

        private static CallSite<Func<CallSite, object, object, object>> smethod_3(string string_0)
        {
            SetMemberBinder innerBinder = (SetMemberBinder) Class157.Class158.smethod_4(string_0, typeof(Class157));
            return CallSite<Func<CallSite, object, object, object>>.Create(new Class160(innerBinder));
        }

        public JsonPropertyCollection Properties
        {
            [CompilerGenerated]
            get
            {
                return this.jsonPropertyCollection_0;
            }
            [CompilerGenerated]
            private set
            {
                this.jsonPropertyCollection_0 = value;
            }
        }

        public Func<string, string> PropertyNameResolver
        {
            [CompilerGenerated]
            get
            {
                return this.func_1;
            }
            [CompilerGenerated]
            set
            {
                this.func_1 = value;
            }
        }
    }
}


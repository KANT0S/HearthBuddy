namespace ns20
{
    using System;
    using System.Dynamic;

    internal class Class159 : GetMemberBinder
    {
        private readonly GetMemberBinder getMemberBinder_0;

        public Class159(GetMemberBinder innerBinder) : base(innerBinder.Name, innerBinder.IgnoreCase)
        {
            this.getMemberBinder_0 = innerBinder;
        }

        DynamicMetaObject GetMemberBinder.FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
        {
            DynamicMetaObject obj2 = this.getMemberBinder_0.Bind(target, new DynamicMetaObject[0]);
            Class161 class2 = new Class161();
            return new DynamicMetaObject(class2.Visit(obj2.Expression), obj2.Restrictions);
        }
    }
}


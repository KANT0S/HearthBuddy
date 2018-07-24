namespace ns20
{
    using System;
    using System.Dynamic;

    internal class Class160 : SetMemberBinder
    {
        private readonly SetMemberBinder setMemberBinder_0;

        public Class160(SetMemberBinder innerBinder) : base(innerBinder.Name, innerBinder.IgnoreCase)
        {
            this.setMemberBinder_0 = innerBinder;
        }

        DynamicMetaObject SetMemberBinder.FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
        {
            DynamicMetaObject obj2 = this.setMemberBinder_0.Bind(target, new DynamicMetaObject[] { value });
            Class161 class2 = new Class161();
            return new DynamicMetaObject(class2.Visit(obj2.Expression), obj2.Restrictions);
        }
    }
}


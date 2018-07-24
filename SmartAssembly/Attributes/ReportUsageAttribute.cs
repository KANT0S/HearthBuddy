namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public class ReportUsageAttribute : Attribute
    {
        public ReportUsageAttribute()
        {
        }

        public ReportUsageAttribute(string featureName)
        {
        }
    }
}


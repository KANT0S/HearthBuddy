namespace Buddy.Auth
{
    using System;
    using System.ComponentModel;

    public enum Region
    {
        [Description("- Best Latency -")]
        BestLatency = 0,
        China = 3,
        Europe = 1,
        [Description("North America")]
        NorthAmerica = 2,
        [Description("Southeast Asia")]
        SoutheastAsia = 4
    }
}


namespace Buddy.Auth.SR
{
    using Buddy.Auth.Objects;
    using System;
    using System.CodeDom.Compiler;
    using System.ServiceModel;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(ConfigurationName="SR.IA")]
    public interface IA
    {
        [ServiceKnownType(typeof(string[])), ServiceKnownType(typeof(WoWNpc[])), OperationContract(Action="http://tempuri.org/IA/Do", ReplyAction="http://tempuri.org/IA/DoResponse"), ServiceKnownType(typeof(d0)), ServiceKnownType(typeof(WoWFragment)), ServiceKnownType(typeof(r0)), ServiceKnownType(typeof(object[])), ServiceKnownType(typeof(UsageInfo)), ServiceKnownType(typeof(WoWMailbox[])), ServiceKnownType(typeof(WoWMailboxEx[]))]
        d0 Do(byte b, object[] args);
    }
}


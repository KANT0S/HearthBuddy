namespace Buddy.Auth.SR
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    [DebuggerStepThrough, GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class AClient : ClientBase<IA>, IA
    {
        public AClient()
        {
        }

        public AClient(string endpointConfigurationName) : base(endpointConfigurationName)
        {
        }

        public AClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public AClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public AClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public d0 Do(byte b, object[] args)
        {
            return base.Channel.Do(b, args);
        }
    }
}


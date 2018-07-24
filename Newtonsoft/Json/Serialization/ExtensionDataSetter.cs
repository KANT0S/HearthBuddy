namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Runtime.CompilerServices;

    public delegate void ExtensionDataSetter(object o, string key, JToken value);
}


namespace Triton.Bot.Settings
{
    using Buddy.Auth;
    using log4net;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Security.Cryptography;
    using Triton.Common;

    public class GlobalSettings : JsonSettings
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private static GlobalSettings globalSettings_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private List<Region> list_0;
        private List<string> list_1;
        private Region region_0;
        private string string_1;
        private string string_2;

        public GlobalSettings() : base(JsonSettings.GetSettingsFilePath(textArray1))
        {
            string[] textArray1 = new string[] { "Global", "GlobalSettings.json" };
            if (this.Configurations == null)
            {
                List<string> list1 = new List<string> { "Default" };
                this.Configurations = list1;
                this.string_2 = "Default";
            }
            if (this.Configurations.Count == 0)
            {
                this.Configurations.Add("Default");
                this.string_2 = "Default";
            }
        }

        [OnSerializing]
        internal void method_0(StreamingContext streamingContext_0)
        {
            if (!string.IsNullOrEmpty(this.LoginKey))
            {
                this.LoginKey = Class213.smethod_0(this.LoginKey, "hbseckey");
            }
        }

        [OnSerialized]
        internal void method_1(StreamingContext streamingContext_0)
        {
            if (!string.IsNullOrEmpty(this.LoginKey))
            {
                this.LoginKey = Class213.smethod_1(this.LoginKey, "hbseckey");
            }
        }

        [OnDeserialized]
        internal void method_2(StreamingContext streamingContext_0)
        {
            this.method_1(streamingContext_0);
        }

        [DefaultValue(true)]
        public bool AuthLogin
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                if (!value.Equals(this.bool_0))
                {
                    this.bool_0 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(GlobalSettings)), (MethodInfo) methodof(GlobalSettings.get_AuthLogin)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(0)]
        public Region AuthRegion
        {
            get
            {
                return this.region_0;
            }
            set
            {
                if (!value.Equals(this.region_0))
                {
                    this.region_0 = value;
                    base.NotifyPropertyChanged<Region>(Expression.Lambda<Func<Region>>(Expression.Property(Expression.Constant(this, typeof(GlobalSettings)), (MethodInfo) methodof(GlobalSettings.get_AuthRegion)), new ParameterExpression[0]));
                    ilog_0.InfoFormat("[AuthRegion] {0}.", this.region_0);
                }
            }
        }

        [JsonIgnore]
        public List<Region> AuthRegions
        {
            get
            {
                List<Region> list1;
                return (new List<Region> { 0, 1, 2, 3, 4 } ?? (this.list_0 = list1));
            }
        }

        public List<string> Configurations
        {
            get
            {
                return this.list_1;
            }
            set
            {
                if (!value.Equals(this.list_1))
                {
                    this.list_1 = value;
                    base.NotifyPropertyChanged<List<string>>(Expression.Lambda<Func<List<string>>>(Expression.Property(Expression.Constant(this, typeof(GlobalSettings)), (MethodInfo) methodof(GlobalSettings.get_Configurations)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(false)]
        public bool DebugLastTask
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                if (!value.Equals(this.bool_2))
                {
                    this.bool_2 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(GlobalSettings)), (MethodInfo) methodof(GlobalSettings.get_DebugLastTask)), new ParameterExpression[0]));
                }
            }
        }

        [DefaultValue(false)]
        public bool DisableUpdateCheck
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                if (!value.Equals(this.bool_1))
                {
                    this.bool_1 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(GlobalSettings)), (MethodInfo) methodof(GlobalSettings.get_DisableUpdateCheck)), new ParameterExpression[0]));
                }
            }
        }

        public static GlobalSettings Instance
        {
            get
            {
                return (globalSettings_0 ?? (globalSettings_0 = new GlobalSettings()));
            }
        }

        public string LastUsedConfiguration
        {
            get
            {
                return this.string_2;
            }
            set
            {
                if (!value.Equals(this.string_2))
                {
                    this.string_2 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(GlobalSettings)), (MethodInfo) methodof(GlobalSettings.get_LastUsedConfiguration)), new ParameterExpression[0]));
                }
            }
        }

        public string LoginKey
        {
            get
            {
                return this.string_1;
            }
            set
            {
                if (!value.Equals(this.string_1))
                {
                    this.string_1 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(GlobalSettings)), (MethodInfo) methodof(GlobalSettings.get_LoginKey)), new ParameterExpression[0]));
                }
            }
        }

        private static class Class213
        {
            private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("o6806642kbM7c5");

            public static string smethod_0(string string_0, string string_1)
            {
                string str;
                if (string.IsNullOrEmpty(string_0))
                {
                    throw new ArgumentNullException("plainText");
                }
                if (string.IsNullOrEmpty(string_1))
                {
                    throw new ArgumentNullException("sharedSecret");
                }
                RijndaelManaged managed = null;
                try
                {
                    Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(string_1, byte_0);
                    managed = new RijndaelManaged {
                        Key = bytes.GetBytes(managed.KeySize / 8)
                    };
                    ICryptoTransform transform = managed.CreateEncryptor(managed.Key, managed.IV);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        stream.Write(BitConverter.GetBytes(managed.IV.Length), 0, 4);
                        stream.Write(managed.IV, 0, managed.IV.Length);
                        using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write))
                        {
                            using (StreamWriter writer = new StreamWriter(stream2))
                            {
                                writer.Write(string_0);
                            }
                        }
                        str = Convert.ToBase64String(stream.ToArray());
                    }
                }
                finally
                {
                    if (managed != null)
                    {
                        managed.Clear();
                    }
                }
                return str;
            }

            public static string smethod_1(string string_0, string string_1)
            {
                string str;
                if (string.IsNullOrEmpty(string_0))
                {
                    throw new ArgumentNullException("cipherText");
                }
                if (string.IsNullOrEmpty(string_1))
                {
                    throw new ArgumentNullException("sharedSecret");
                }
                RijndaelManaged managed = null;
                try
                {
                    Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(string_1, byte_0);
                    using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(string_0)))
                    {
                        managed = new RijndaelManaged {
                            Key = bytes.GetBytes(managed.KeySize / 8),
                            IV = smethod_2(stream)
                        };
                        ICryptoTransform transform = managed.CreateDecryptor(managed.Key, managed.IV);
                        using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(stream2))
                            {
                                str = reader.ReadToEnd();
                            }
                        }
                    }
                }
                finally
                {
                    if (managed != null)
                    {
                        managed.Clear();
                    }
                }
                return str;
            }

            private static byte[] smethod_2(Stream stream_0)
            {
                byte[] buffer = new byte[4];
                if (stream_0.Read(buffer, 0, buffer.Length) != buffer.Length)
                {
                    throw new SystemException("Stream did not contain properly formatted byte array");
                }
                byte[] buffer2 = new byte[BitConverter.ToInt32(buffer, 0)];
                if (stream_0.Read(buffer2, 0, buffer2.Length) != buffer2.Length)
                {
                    throw new SystemException("Did not read byte array properly");
                }
                return buffer2;
            }
        }
    }
}


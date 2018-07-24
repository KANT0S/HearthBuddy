namespace ns8
{
    using Buddy.Auth;
    using Buddy.Auth.Objects;
    using Buddy.Auth.SR;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    using System.Security.Cryptography;
    using System.ServiceModel;
    using System.Text;
    using System.Threading;

    internal class Class40
    {
        internal readonly AClient aclient_0;
        private static byte[] byte_0;
        private static EndpointAddress endpointAddress_0;
        [CompilerGenerated]
        private static Region region_0;
        private static Stopwatch stopwatch_0;
        public static string string_0;
        [CompilerGenerated]
        private static string string_1;
        [CompilerGenerated]
        private static string string_2;
        private const string string_3 = "<RSAKeyValue><Modulus>t0aG8IaxqGaPj0mJN8HwD0BDm57mUdEnuiq+ANRH5A+rLoLrHbCfgDaslUckBzzlUqXHncDGARD8tYbVRjFWjbH4oWPLvKfjx/ZmIIvzVxOj5Uo9r95qJdS+DNh7oVP8pFavEtSOurXYrw0uRbj08r1zrrIsrssfXVBw2PI/pCy+gX3WeydXQknczl97bKIOBAFobMpLUBsQcM8Bs8gJC+f81cGw1ndhAwqZYRpR/KlDdEw0vWACpOMBIdeLAK0akx2deWvquAGRmLJBaJInOGpYRa6kVqcXRIG1vB2Zh3x9GhYeoeAQMVcogTvIxgNfiGNNc6CgsyRWoikLYS+1UQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        [field: CompilerGenerated]
        public static  event EventHandler Event_0;

        [field: CompilerGenerated]
        public static  event EventHandler Event_1;

        [field: CompilerGenerated]
        public static  event EventHandler Event_2;

        static Class40()
        {
            smethod_0(Region.BestLatency);
        }

        public Class40()
        {
            NetTcpBinding binding1 = new NetTcpBinding(SecurityMode.None) {
                PortSharingEnabled = true,
                MaxReceivedMessageSize = 0x7fffffffL
            };
            binding1.ReaderQuotas.MaxArrayLength = 0x7fffffff;
            binding1.SendTimeout = new TimeSpan(0, 10, 0);
            NetTcpBinding binding = binding1;
            this.aclient_0 = new AClient(binding, endpointAddress_0);
        }

        [Obsolete("Does nothing")]
        public void method_0()
        {
        }

        public void method_1()
        {
            this.aclient_0.Abort();
        }

        public unsafe r0 method_10(params object[] object_0)
        {
            byte[] buffer3;
            if (!this.method_4() || ((stopwatch_0 != null) && (stopwatch_0.Elapsed.TotalMinutes > 5.0)))
            {
                goto Label_027D;
            }
            long timestamp = Stopwatch.GetTimestamp();
            ulong num2 = this.method_9();
            long num3 = 0L;
            if (byte_0 != null)
            {
                ulong num4;
                byte[] buffer2;
                if (byte_0.Length != 0x110)
                {
                    this.method_8();
                }
                if (((buffer3 = byte_0) != null) && (buffer3.Length != 0))
                {
                    numRef = buffer3;
                    goto Label_0088;
                }
                fixed (byte* numRef = null)
                {
                Label_0088:
                    num3 = numRef[0];
                    num4 = numRef[8];
                }
                if (((timestamp - num3) / Stopwatch.Frequency) > 720L)
                {
                    this.method_8();
                }
                if (num2 != num4)
                {
                    this.method_8();
                }
                using (SHA256Managed managed = new SHA256Managed())
                {
                    buffer2 = managed.ComputeHash(byte_0, 0, 0x10);
                }
                using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
                {
                    provider.PersistKeyInCsp = false;
                    provider.FromXmlString("<RSAKeyValue><Modulus>t0aG8IaxqGaPj0mJN8HwD0BDm57mUdEnuiq+ANRH5A+rLoLrHbCfgDaslUckBzzlUqXHncDGARD8tYbVRjFWjbH4oWPLvKfjx/ZmIIvzVxOj5Uo9r95qJdS+DNh7oVP8pFavEtSOurXYrw0uRbj08r1zrrIsrssfXVBw2PI/pCy+gX3WeydXQknczl97bKIOBAFobMpLUBsQcM8Bs8gJC+f81cGw1ndhAwqZYRpR/KlDdEw0vWACpOMBIdeLAK0akx2deWvquAGRmLJBaJInOGpYRa6kVqcXRIG1vB2Zh3x9GhYeoeAQMVcogTvIxgNfiGNNc6CgsyRWoikLYS+1UQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
                    RSAPKCS1SignatureDeformatter deformatter = new RSAPKCS1SignatureDeformatter(provider);
                    deformatter.SetHashAlgorithm("SHA256");
                    byte[] rgbSignature = new byte[byte_0.Length - 0x10];
                    for (int i = 0; i < (byte_0.Length - 0x10); i++)
                    {
                        rgbSignature[i] = byte_0[0x10 + i];
                    }
                    if (!deformatter.VerifySignature(buffer2, rgbSignature))
                    {
                        this.method_8();
                    }
                }
            }
            byte[] item = null;
            if ((num3 != 0) && (((timestamp - num3) / Stopwatch.Frequency) <= 540L))
            {
                goto Label_01C0;
            }
            item = new byte[0x10];
            if (((buffer3 = item) != null) && (buffer3.Length != 0))
            {
                numRef2 = buffer3;
            }
            else
            {
                numRef2 = null;
            }
            numRef2[0] = (byte) timestamp;
            numRef2[8] = (byte) num2;
            fixed (byte* numRef2 = null)
            {
                List<object> list;
                EventHandler expressionStack_273_0;
                EventHandler expressionStack_261_0;
            Label_01C0:
                list = object_0.ToList<object>();
                list.Insert(0, this.String_2);
                if (item != null)
                {
                    list.Insert(1, item);
                }
                d0 d = this.method_3(Enum4.Heartbeat, list.ToArray());
                if (((item != null) && (d.Data != null)) && (d.Data.Length == 0x110))
                {
                    byte_0 = d.Data;
                }
                if (d.Success || (stopwatch_0 == null))
                {
                    stopwatch_0 = Stopwatch.StartNew();
                }
                if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
                {
                    if (eventHandler_1 != null)
                    {
                        expressionStack_261_0 = eventHandler_1;
                        goto Label_0261;
                    }
                    else
                    {
                        EventHandler expressionStack_25E_0 = eventHandler_1;
                    }
                }
                goto Label_0268;
            Label_0261:
                expressionStack_261_0(null, null);
            Label_0268:
                if (eventHandler_0 != null)
                {
                    expressionStack_273_0 = eventHandler_0;
                    goto Label_0273;
                }
                else
                {
                    EventHandler expressionStack_270_0 = eventHandler_0;
                }
                return d;
            Label_0273:
                expressionStack_273_0(null, null);
                return d;
            Label_027D:
                stopwatch_0 = null;
                return new r0 { Success = false, Body = "Invalid Session" };
            }
        }

        public d0 method_11(string string_4, byte byte_1 = 2)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, string_4, byte_1 };
            d0 d = this.method_3(Enum4.Mesh, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_6E_0 = eventHandler_1;
                    expressionStack_6E_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_6B_0 = eventHandler_1;
                }
            }
            return d;
        }

        public d0 method_12(string string_4, string string_5, byte byte_1 = 2)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, string_4, string_5, byte_1 };
            d0 d = this.method_3(Enum4.HB_MESH_FROM_MAP, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_73_0 = eventHandler_1;
                    expressionStack_73_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_70_0 = eventHandler_1;
                }
            }
            return d;
        }

        public d0 method_13(WoWNpc[] woWNpc_0)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, woWNpc_0, Assembly.GetEntryAssembly().GetName().Version.Build };
            d0 d = this.method_3(Enum4.HBInsertNpc, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_82_0 = eventHandler_1;
                    expressionStack_82_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_7F_0 = eventHandler_1;
                }
            }
            return d;
        }

        public d0 method_14(WoWMailboxEx[] woWMailboxEx_0)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, woWMailboxEx_0, Assembly.GetEntryAssembly().GetName().Version.Build };
            d0 d = this.method_3(Enum4.HBInsertMailbox, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_82_0 = eventHandler_1;
                    expressionStack_82_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_7F_0 = eventHandler_1;
                }
            }
            return d;
        }

        public d0 method_15(WoWFragment woWFragment_0)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, woWFragment_0, Assembly.GetEntryAssembly().GetName().Version.Build };
            d0 d = this.method_3(Enum4.HBInsertFragment, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_82_0 = eventHandler_1;
                    expressionStack_82_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_7F_0 = eventHandler_1;
                }
            }
            return d;
        }

        public d0 method_16(string string_4, byte byte_1 = 2)
        {
            string expressionStack_25_0;
            string expressionStack_31_0;
            string expressionStack_31_1;
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            if (byte_1 == 2)
            {
                expressionStack_31_1 = string_4;
                expressionStack_31_0 = "_v2";
                goto Label_0031;
            }
            else
            {
                expressionStack_25_0 = string_4;
            }
            expressionStack_31_1 = expressionStack_25_0;
            expressionStack_31_0 = "";
        Label_0031:
            string_4 = expressionStack_31_1 + expressionStack_31_0;
            object[] objArray2 = new object[] { this.String_2, string_4, byte_1 };
            d0 d = this.method_3(Enum4.Tilemap, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_87_0 = eventHandler_1;
                    expressionStack_87_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_84_0 = eventHandler_1;
                }
            }
            return d;
        }

        public d0 method_17(string string_4, byte byte_1 = 2)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, string_4, byte_1 };
            d0 d = this.method_3(Enum4.HB_MAPMETADATA, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_6F_0 = eventHandler_1;
                    expressionStack_6F_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_6C_0 = eventHandler_1;
                }
            }
            return d;
        }

        public d0 method_18(string string_4, byte[] byte_1, byte byte_2 = 2)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, string_4, byte_1, byte_2 };
            d0 d = this.method_3(Enum4.HB_GAMEOBJ_MESH_QUERY, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_73_0 = eventHandler_1;
                    expressionStack_73_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_70_0 = eventHandler_1;
                }
            }
            return d;
        }

        public r0 method_19(UsageInfo usageInfo_0)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, usageInfo_0 };
            r0 r = this.method_3(Enum4.UsageInfo, objArray2);
            if (!string.IsNullOrEmpty(r.Body) && (r.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_66_0 = eventHandler_1;
                    expressionStack_66_0(null, null);
                    return r;
                }
                else
                {
                    EventHandler expressionStack_63_0 = eventHandler_1;
                }
            }
            return r;
        }

        public void method_2()
        {
            this.aclient_0.Close();
        }

        public Dictionary<string, string> method_20(byte byte_1)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            if (!this.method_4())
            {
                return dictionary;
            }
            object[] objArray2 = new object[] { this.String_2, byte_1 };
            d0 d = this.method_3(Enum4.StoreGetProductList, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_5B_0 = eventHandler_1;
                    expressionStack_5B_0(null, null);
                }
                else
                {
                    EventHandler expressionStack_58_0 = eventHandler_1;
                }
            }
            if ((!d.Success || (d.Data == null)) || (d.Data.Length == 0))
            {
                return dictionary;
            }
            DataContractSerializer serializer = new DataContractSerializer(typeof(Dictionary<string, string>));
            using (MemoryStream stream = new MemoryStream(d.Data))
            {
                return (Dictionary<string, string>) serializer.ReadObject(stream);
            }
        }

        public List<StoreProduct> method_21(byte byte_1, string[] string_4)
        {
            List<StoreProduct> list = new List<StoreProduct>();
            if (!this.method_4())
            {
                return list;
            }
            object[] objArray2 = new object[] { this.String_2, byte_1, string_4 };
            d0 d = this.method_3(Enum4.StoreGetProducts, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_5F_0 = eventHandler_1;
                    expressionStack_5F_0(null, null);
                }
                else
                {
                    EventHandler expressionStack_5C_0 = eventHandler_1;
                }
            }
            if ((!d.Success || (d.Data == null)) || (d.Data.Length == 0))
            {
                return list;
            }
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<StoreProduct>));
            using (MemoryStream stream = new MemoryStream(d.Data))
            {
                return (List<StoreProduct>) serializer.ReadObject(stream);
            }
        }

        public r0 method_22(string string_4, string string_5, string string_6, int int_0)
        {
            if (!this.method_4())
            {
                return new r0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, string_4, string_5, string_6, int_0 };
            d0 d = this.method_3(Enum4.BGJoined, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_78_0 = eventHandler_1;
                    expressionStack_78_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_75_0 = eventHandler_1;
                }
            }
            return d;
        }

        public r0 method_23(string string_4, string string_5)
        {
            if (!this.method_4())
            {
                return new r0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, string_4, string_5 };
            d0 d = this.method_3(Enum4.BGLeaderChanged, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_6A_0 = eventHandler_1;
                    expressionStack_6A_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_67_0 = eventHandler_1;
                }
            }
            return d;
        }

        public r0 method_24(string string_4)
        {
            if (!this.method_4())
            {
                return new r0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, string_4 };
            d0 d = this.method_3(Enum4.BGFinished, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_66_0 = eventHandler_1;
                    expressionStack_66_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_63_0 = eventHandler_1;
                }
            }
            return d;
        }

        private d0 method_3(Enum4 enum4_0, params object[] object_0)
        {
            return this.aclient_0.Do((byte) enum4_0, object_0);
        }

        private bool method_4()
        {
            return !string.IsNullOrEmpty(this.String_2);
        }

        public d0 method_5(string string_4, byte byte_1, long long_0)
        {
            string str = Class41.smethod_2("AUTH_KEY");
            object[] objArray2 = new object[] { string_4, str, byte_1, long_0 };
            d0 d = this.method_3(Enum4.Login, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_5D_0 = eventHandler_1;
                    expressionStack_5D_0(null, null);
                }
                else
                {
                    EventHandler expressionStack_5A_0 = eventHandler_1;
                }
            }
            if (d.Success)
            {
                this.String_2 = Encoding.ASCII.GetString(d.Data);
                smethod_0(smethod_2(d.Info));
            }
            return d;
        }

        public r0 method_6()
        {
            if (!this.method_4())
            {
                return new r0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2 };
            d0 d = this.method_3(Enum4.Logout, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_61_0 = eventHandler_1;
                    expressionStack_61_0(null, null);
                    return d;
                }
                else
                {
                    EventHandler expressionStack_5E_0 = eventHandler_1;
                }
            }
            return d;
        }

        public d0 method_7(string string_4, string string_5, bool bool_0 = false)
        {
            if (!this.method_4())
            {
                return new d0 { Success = false, Body = "Invalid Session" };
            }
            object[] objArray2 = new object[] { this.String_2, string_4, string_5, bool_0 };
            d0 d = this.method_3(Enum4.Offsets, objArray2);
            if (!string.IsNullOrEmpty(d.Body) && (d.Body == "TRIPWIRE"))
            {
                if (eventHandler_1 != null)
                {
                    EventHandler expressionStack_72_0 = eventHandler_1;
                    expressionStack_72_0(null, null);
                }
                else
                {
                    EventHandler expressionStack_6F_0 = eventHandler_1;
                }
            }
            if ((d.Data != null) && (d.Data.Length != 0))
            {
                byte[] bytes = Encoding.ASCII.GetBytes(this.String_2);
                byte[] array = Encoding.ASCII.GetBytes(this.String_2);
                Array.Reverse(array);
                d.Data = Class41.smethod_5(d.Data, bytes, array);
            }
            String_0 = d.Info;
            return d;
        }

        private void method_8()
        {
            Process.GetCurrentProcess().Kill();
        }

        private ulong method_9()
        {
            ulong num = 14695981039346656037L;
            uint id = (uint) Process.GetCurrentProcess().Id;
            byte[] buffer1 = new byte[] { (byte) id, (byte) (id >> 8), (byte) (id >> 0x10), (byte) (id >> 0x18) };
            foreach (byte num4 in buffer1)
            {
                num *= (ulong) 0x100000001b3L;
                num ^= num4;
            }
            foreach (char ch in Assembly.GetEntryAssembly().Location)
            {
                num ^= (byte) ch;
                num *= (ulong) 0x100000001b3L;
            }
            return num;
        }

        public static void smethod_0(Region region_1)
        {
            string str;
            Region_0 = region_1;
            if (region_1 == Region.BestLatency)
            {
                String_1 = null;
                str = "auth.buddyauth.com";
            }
            else
            {
                String_1 = smethod_1(region_1);
                str = string.Format("auth.{0}.buddyauth.com", String_1);
            }
            endpointAddress_0 = new EndpointAddress(string.Format("net.tcp://{0}:5031/AuthService.svc", str));
        }

        private static string smethod_1(Region region_1)
        {
            switch (region_1)
            {
                case Region.Europe:
                    return "eu";

                case Region.NorthAmerica:
                    return "na";

                case Region.China:
                    return "cn";

                case Region.SoutheastAsia:
                    return "sea";
            }
            throw new ArgumentOutOfRangeException("region");
        }

        private static Region smethod_2(string string_4)
        {
            string str = string_4.ToLowerInvariant();
            switch (str)
            {
                case "eu":
                    return Region.Europe;

                case "na":
                    return Region.NorthAmerica;

                case "cn":
                    return Region.China;
            }
            if (!(str == "sea"))
            {
                throw new ArgumentOutOfRangeException("regionAbbrev");
            }
            return Region.SoutheastAsia;
        }

        public static void smethod_3()
        {
            if (eventHandler_2 != null)
            {
                EventHandler expressionStack_A_0 = eventHandler_2;
                expressionStack_A_0(null, null);
            }
            else
            {
                EventHandler expressionStack_8_0 = eventHandler_2;
            }
        }

        public CommunicationState CommunicationState_0
        {
            get
            {
                return this.aclient_0.State;
            }
        }

        public static Region Region_0
        {
            [CompilerGenerated]
            get
            {
                return region_0;
            }
            [CompilerGenerated]
            private set
            {
                region_0 = value;
            }
        }

        public static string String_0
        {
            [CompilerGenerated]
            get
            {
                return string_1;
            }
            [CompilerGenerated]
            private set
            {
                string_1 = value;
            }
        }

        public static string String_1
        {
            [CompilerGenerated]
            get
            {
                return string_2;
            }
            [CompilerGenerated]
            private set
            {
                string_2 = value;
            }
        }

        public string String_2
        {
            get
            {
                return string_0;
            }
            set
            {
                string_0 = value;
            }
        }

        [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Module | AttributeTargets.Assembly)]
        private sealed class Attribute0 : Attribute
        {
        }
    }
}


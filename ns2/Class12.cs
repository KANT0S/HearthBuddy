namespace ns2
{
    using Buddy.Auth;
    using Buddy.Auth.SR;
    using Hearthbuddy.Windows;
    using log4net;
    using ns10;
    using ns8;
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows;
    using Triton.Common;
    using Triton.Common.LogUtilities;
    using Triton.Game;

    internal class Class12
    {
        private static bool bool_0 = false;
        private static bool bool_1 = false;
        private const byte byte_0 = 15;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private static readonly object object_0 = new object();
        public static string string_0;
        private static Thread thread_0;

        internal static void smethod_0()
        {
            try
            {
                Class45.smethod_2<r0>(Class13.<>9__3_0 ?? (Class13.<>9__3_0 = new Func<Class40, r0>(Class13.<>9.method_0)));
            }
            catch
            {
            }
        }

        internal static bool smethod_1(Region region_0, string string_1)
        {
            Class14 class2 = new Class14 {
                string_0 = string_1
            };
            string_0 = "";
            Class40.smethod_0(region_0);
            if (!bool_0)
            {
                Class40.Event_1 += (Class13.<>9__6_0 ?? (Class13.<>9__6_0 = new EventHandler(Class13.<>9.method_1)));
                bool_0 = true;
            }
            if (!bool_1)
            {
                Class40.Event_2 += (Class13.<>9__6_1 ?? (Class13.<>9__6_1 = new EventHandler(Class13.<>9.method_2)));
                bool_1 = true;
            }
            bool? nullable = new bool?(Class45.smethod_2<bool>(new Func<Class40, bool>(class2.method_0)));
            if (!nullable.HasValue)
            {
                return false;
            }
            return nullable.Value;
        }

        private static string smethod_2(Class40 class40_0)
        {
            Uri uri = class40_0.aclient_0.Endpoint.Address.Uri;
            try
            {
                if (uri.HostNameType == UriHostNameType.Dns)
                {
                    return string.Format("Connecting to {0} ({1})", Class40.Region_0, Dns.GetHostAddresses(uri.Host).FirstOrDefault<IPAddress>(Class13.<>9__7_0 ?? (Class13.<>9__7_0 = new Func<IPAddress, bool>(Class13.<>9.method_3))));
                }
                return string.Format("Connecting to {0} [{1}]", Class40.Region_0, uri.Host);
            }
            catch (Exception exception)
            {
                return string.Format("Could not retrieve host name for {0}. Please check the DNS configuration. Error: {1}", uri.Host, exception);
            }
        }

        public static bool smethod_3()
        {
            object obj2 = object_0;
            lock (obj2)
            {
                if (thread_0 != null)
                {
                    return false;
                }
                Thread thread1 = new Thread(Class13.<>9__10_0 ?? (Class13.<>9__10_0 = new ThreadStart(Class13.<>9.method_4))) {
                    IsBackground = true
                };
                thread_0 = thread1;
            }
            thread_0.Start();
            return true;
        }

        public static byte[] smethod_4(string string_1, out string string_2)
        {
            Class15 class2 = new Class15 {
                string_0 = string_1,
                string_1 = null
            };
            string_2 = class2.string_1;
            byte[] buffer = Class45.smethod_2<byte[]>(new Func<Class40, byte[]>(class2.method_0));
            if ((buffer != null) && (buffer.Length != 0))
            {
                return buffer;
            }
            return null;
        }

        internal static void smethod_5()
        {
            string text1 = new WebClient().DownloadString("http://updates.buddyauth.com/GetVersion?filter=Hearthbuddy");
            if (text1 == "Unknown Version")
            {
                throw new Exception("There is no version information available from the server.");
            }
            Version version = new Version(text1);
            bool? nullable = null;
            Version version2 = Assembly.GetEntryAssembly().GetName().Version;
            if (version == version2)
            {
                ilog_0.InfoFormat("{0} [{1}] is up to date!", "Hearthbuddy", version2);
            }
            else if ((version2.Minor >= version.Minor) && (version2.Major >= version.Major))
            {
                if (version < version2)
                {
                    nullable = true;
                }
                else if (version > version2)
                {
                    nullable = false;
                }
                if (nullable.HasValue)
                {
                    bool? nullable2;
                    if (CommandLine.Arguments.Exists("autoupdate"))
                    {
                        nullable2 = true;
                    }
                    else if (!nullable.Value)
                    {
                        nullable2 = new UpdateWindow("Hearthbuddy").ShowDialog();
                    }
                    else
                    {
                        nullable2 = false;
                    }
                    if (nullable2.HasValue && nullable2.Value)
                    {
                        string exePath = Path.Combine(Path.GetTempPath(), string.Format("buddyupdater{0}.exe", Environment.TickCount));
                        new DownloadingWindow("Hearthbuddy", exePath).ShowDialog();
                        MessageBox.Show("Hearthbuddy will now close. Please restart it.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                string format = string.Format("{0} [{1}] is now out-of-date. A new installation is required. Please check the forums for more information: https://www.thebuddyforum.com/hearthbuddy-forum/", "Hearthbuddy", version2);
                ilog_0.ErrorFormat(format, Array.Empty<object>());
                MessageBox.Show(format, "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                Environment.Exit(0);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class13
        {
            public static readonly Class12.Class13 <>9 = new Class12.Class13();
            public static ThreadStart <>9__10_0;
            public static Func<Class40, bool> <>9__10_1;
            public static Func<Class40, r0> <>9__3_0;
            public static EventHandler <>9__6_0;
            public static EventHandler <>9__6_1;
            public static Func<IPAddress, bool> <>9__7_0;

            internal r0 method_0(Class40 class40_0)
            {
                return class40_0.method_6();
            }

            internal void method_1(object sender, EventArgs e)
            {
                Class12.ilog_0.InfoFormat("TRIPWIRE", Array.Empty<object>());
                Class12.ilog_0.InfoFormat("Please wait for an \"[OFFICIAL] Tripwire event\" announcement on the forums.", Array.Empty<object>());
                Class12.ilog_0.InfoFormat("https://www.thebuddyforum.com/hearthbuddy-forum/", Array.Empty<object>());
                Logger.OpenLogFile();
                Class12.smethod_0();
                ProcessHookManager.smethod_4();
                Environment.Exit(1);
            }

            internal void method_2(object sender, EventArgs e)
            {
                Class12.smethod_0();
                ProcessHookManager.smethod_4();
                Environment.Exit(1);
            }

            internal bool method_3(IPAddress ipaddress_0)
            {
                return (ipaddress_0.AddressFamily == AddressFamily.InterNetwork);
            }

            internal void method_4()
            {
                Random random = new Random();
                try
                {
                    while (string.IsNullOrEmpty(Class40.string_0))
                    {
                        Class12.ilog_0.InfoFormat("Waiting for SID...", Array.Empty<object>());
                        Thread.Sleep(0x3e8);
                        continue;
                    Label_0029:
                        try
                        {
                            Thread.Sleep((int) (random.Next(20, 30) * 0x3e8));
                            if (!Class45.smethod_2<bool>(<>9__10_1 ?? (<>9__10_1 = new Func<Class40, bool>(<>9.method_5))))
                            {
                                Class40.smethod_3();
                                continue;
                            }
                        }
                        catch (Exception exception)
                        {
                            Class12.ilog_0.ErrorFormat("Authentication thread exception: {0}", exception.ToString());
                        }
                        break;
                    }
                    goto Label_0029;
                }
                catch (ThreadAbortException exception2)
                {
                    Class12.ilog_0.ErrorFormat("Authentication thread abort exception: {0}", exception2.ToString());
                }
                object obj2 = Class12.object_0;
                lock (obj2)
                {
                    Class12.thread_0 = null;
                }
            }

            internal bool method_5(Class40 class40_0)
            {
                string str = Class12.smethod_2(class40_0);
                r0 r = class40_0.method_10(Array.Empty<object>());
                if (((r.Body != "Server Exception") && !r.Body.ToLower().Contains("underlying provider")) && !r.Body.ToLower().Contains("fehler beim zugrunde"))
                {
                    if (!r.Success)
                    {
                        Class12.ilog_0.ErrorFormat("Authentication Server Response: {0}", r.Body);
                        Class12.ilog_0.ErrorFormat("Connection: {0}", str);
                        Class12.ilog_0.ErrorFormat("SID: {0}", class40_0.String_2);
                        class40_0.String_2 = null;
                        return false;
                    }
                    if (!string.IsNullOrEmpty(r.Body) && (r.Body[0] == 'T'))
                    {
                        Class12.ilog_0.ErrorFormat("Thank you for your HSB trial. You may purchase the full version at: https://www.hearthbuddy.com/", Array.Empty<object>());
                        class40_0.String_2 = null;
                        return false;
                    }
                }
                return true;
            }
        }

        [CompilerGenerated]
        private sealed class Class14
        {
            public string string_0;

            internal bool method_0(Class40 class40_0)
            {
                try
                {
                    class40_0.method_6();
                    long num = DateTime.UtcNow.ToBinary();
                    d0 d = class40_0.method_5(this.string_0, 15, num);
                    Class12.string_0 = d.Body;
                    if (d.Success)
                    {
                        Class12.ilog_0.InfoFormat("Region: {0}", d.Info);
                        Class12.ilog_0.InfoFormat("T: {0} {1}", num, Class12.string_0);
                        return true;
                    }
                    Class12.ilog_0.Debug(Class12.string_0);
                    return false;
                }
                catch (Exception exception)
                {
                    Class12.ilog_0.Debug(exception.ToString());
                    Class12.string_0 = exception.ToString();
                    class40_0.method_6();
                    return false;
                }
            }
        }

        [CompilerGenerated]
        private sealed class Class15
        {
            public string string_0;
            public string string_1;

            internal byte[] method_0(Class40 class40_0)
            {
                d0 d = class40_0.method_7(this.string_0, Assembly.GetEntryAssembly().GetName().Version.ToString(), false);
                if (d.Success)
                {
                    return Class59.smethod_2(d.Data);
                }
                this.string_1 = d.Body;
                return null;
            }
        }
    }
}


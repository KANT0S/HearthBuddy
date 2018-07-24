namespace Triton.Common
{
    using System;
    using System.Runtime.InteropServices;

    public static class OSInfo
    {
        private const int int_0 = 0;
        private const int int_1 = 1;
        private const int int_10 = 10;
        private const int int_11 = 11;
        private const int int_12 = 12;
        private const int int_13 = 13;
        private const int int_14 = 14;
        private const int int_15 = 15;
        private const int int_16 = 0x10;
        private const int int_17 = 0x11;
        private const int int_18 = 0x12;
        private const int int_19 = 0x13;
        private const int int_2 = 2;
        private const int int_20 = 20;
        private const int int_21 = 0x15;
        private const int int_22 = 0x16;
        private const int int_23 = 0x17;
        private const int int_24 = 0x18;
        private const int int_25 = 0x19;
        private const int int_26 = 0x1a;
        private const int int_27 = 0x1b;
        private const int int_28 = 0x1c;
        private const int int_29 = 0x1d;
        private const int int_3 = 3;
        private const int int_30 = 30;
        private const int int_31 = 0x1f;
        private const int int_32 = 0x20;
        private const int int_33 = 0x23;
        private const int int_34 = 0x24;
        private const int int_35 = 0x26;
        private const int int_36 = 40;
        private const int int_37 = 0x29;
        private const int int_38 = 0x2a;
        private const int int_39 = 0x65;
        private const int int_4 = 4;
        private const int int_40 = 0x62;
        private const int int_41 = 0x63;
        private const int int_42 = 100;
        private const int int_43 = 0x30;
        private const int int_44 = 1;
        private const int int_45 = 2;
        private const int int_46 = 3;
        private const int int_47 = 1;
        private const int int_48 = 2;
        private const int int_49 = 0x10;
        private const int int_5 = 5;
        private const int int_50 = 0x80;
        private const int int_51 = 0x100;
        private const int int_52 = 0x200;
        private const int int_53 = 0x400;
        private const int int_6 = 6;
        private const int int_7 = 7;
        private const int int_8 = 8;
        private const int int_9 = 9;
        private static string string_0;
        private static string string_1;

        [DllImport("Kernel32.dll")]
        internal static extern bool GetProductInfo(int int_54, int int_55, int int_56, int int_57, out int int_58);
        [DllImport("kernel32.dll")]
        private static extern bool GetVersionEx(ref Struct88 struct88_0);

        public static int Bits
        {
            get
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    return 0x40;
                }
                return 0x20;
            }
        }

        public static int BuildVersion
        {
            get
            {
                return Environment.OSVersion.Version.Build;
            }
        }

        public static string Edition
        {
            get
            {
                if (string_0 != null)
                {
                    return string_0;
                }
                string str = string.Empty;
                OperatingSystem oSVersion = Environment.OSVersion;
                Struct88 struct2 = new Struct88 {
                    int_0 = Marshal.SizeOf(typeof(Struct88))
                };
                if (GetVersionEx(ref struct2))
                {
                    int num5;
                    int major = oSVersion.Version.Major;
                    int minor = oSVersion.Version.Minor;
                    byte num3 = struct2.byte_0;
                    short num4 = struct2.short_2;
                    switch (major)
                    {
                        case 4:
                            switch (num3)
                            {
                                case 1:
                                    str = "Workstation";
                                    break;

                                case 3:
                                    if ((num4 & 2) != 0)
                                    {
                                        str = "Enterprise Server";
                                    }
                                    else
                                    {
                                        str = "Standard Server";
                                    }
                                    break;
                            }
                            goto Label_03B2;

                        case 5:
                            switch (num3)
                            {
                                case 1:
                                    if ((num4 & 0x200) != 0)
                                    {
                                        str = "Home";
                                    }
                                    else
                                    {
                                        str = "Professional";
                                    }
                                    break;

                                case 3:
                                    if (minor == 0)
                                    {
                                        if ((num4 & 0x80) != 0)
                                        {
                                            str = "Datacenter Server";
                                        }
                                        else if ((num4 & 2) != 0)
                                        {
                                            str = "Advanced Server";
                                        }
                                        else
                                        {
                                            str = "Server";
                                        }
                                    }
                                    else if ((num4 & 0x80) != 0)
                                    {
                                        str = "Datacenter";
                                    }
                                    else if ((num4 & 2) != 0)
                                    {
                                        str = "Enterprise";
                                    }
                                    else if ((num4 & 0x400) != 0)
                                    {
                                        str = "Web Edition";
                                    }
                                    else
                                    {
                                        str = "Standard";
                                    }
                                    break;
                            }
                            goto Label_03B2;
                    }
                    if ((major == 6) && GetProductInfo(major, minor, struct2.short_0, struct2.short_1, out num5))
                    {
                        switch (num5)
                        {
                            case 0:
                                str = "Unknown product";
                                break;

                            case 1:
                                str = "Ultimate";
                                break;

                            case 2:
                                str = "Home Basic";
                                break;

                            case 3:
                                str = "Home Premium";
                                break;

                            case 4:
                                str = "Enterprise";
                                break;

                            case 5:
                                str = "Home Basic N";
                                break;

                            case 6:
                                str = "Business";
                                break;

                            case 7:
                                str = "Standard Server";
                                break;

                            case 8:
                                str = "Datacenter Server";
                                break;

                            case 9:
                                str = "Windows Small Business Server";
                                break;

                            case 10:
                                str = "Enterprise Server";
                                break;

                            case 11:
                                str = "Starter";
                                break;

                            case 12:
                                str = "Datacenter Server (core installation)";
                                break;

                            case 13:
                                str = "Standard Server (core installation)";
                                break;

                            case 14:
                                str = "Enterprise Server (core installation)";
                                break;

                            case 15:
                                str = "Enterprise Server for Itanium-based Systems";
                                break;

                            case 0x10:
                                str = "Business N";
                                break;

                            case 0x11:
                                str = "Web Server";
                                break;

                            case 0x12:
                                str = "HPC Edition";
                                break;

                            case 20:
                                str = "Express Storage Server";
                                break;

                            case 0x15:
                                str = "Standard Storage Server";
                                break;

                            case 0x16:
                                str = "Workgroup Storage Server";
                                break;

                            case 0x17:
                                str = "Enterprise Storage Server";
                                break;

                            case 0x18:
                                str = "Windows Essential Server Solutions";
                                break;

                            case 0x1a:
                                str = "Home Premium N";
                                break;

                            case 0x1b:
                                str = "Enterprise N";
                                break;

                            case 0x1c:
                                str = "Ultimate N";
                                break;

                            case 0x1d:
                                str = "Web Server (core installation)";
                                break;

                            case 30:
                                str = "Windows Essential Business Management Server";
                                break;

                            case 0x1f:
                                str = "Windows Essential Business Security Server";
                                break;

                            case 0x20:
                                str = "Windows Essential Business Messaging Server";
                                break;

                            case 0x23:
                                str = "Windows Essential Server Solutions without Hyper-V";
                                break;

                            case 0x24:
                                str = "Standard Server without Hyper-V";
                                break;

                            case 0x26:
                                str = "Enterprise Server without Hyper-V";
                                break;

                            case 40:
                                str = "Standard Server without Hyper-V (core installation)";
                                break;

                            case 0x29:
                                str = "Enterprise Server without Hyper-V (core installation)";
                                break;

                            case 0x2a:
                                str = "Microsoft Hyper-V Server";
                                break;

                            case 0x30:
                                str = "Professional";
                                break;
                        }
                    }
                }
            Label_03B2:
                string_0 = str;
                return str;
            }
        }

        public static int MajorVersion
        {
            get
            {
                return Environment.OSVersion.Version.Major;
            }
        }

        public static int MinorVersion
        {
            get
            {
                return Environment.OSVersion.Version.Minor;
            }
        }

        public static string Name
        {
            get
            {
                if (string_1 != null)
                {
                    return string_1;
                }
                string str = "unknown";
                OperatingSystem oSVersion = Environment.OSVersion;
                Struct88 struct2 = new Struct88 {
                    int_0 = Marshal.SizeOf(typeof(Struct88))
                };
                if (GetVersionEx(ref struct2))
                {
                    int major = oSVersion.Version.Major;
                    int minor = oSVersion.Version.Minor;
                    switch (oSVersion.Platform)
                    {
                        case PlatformID.Win32Windows:
                            if (major == 4)
                            {
                                string str2 = struct2.string_0;
                                switch (minor)
                                {
                                    case 0:
                                        if (!(str2 == "B") && !(str2 == "C"))
                                        {
                                            str = "Windows 95";
                                        }
                                        else
                                        {
                                            str = "Windows 95 OSR2";
                                        }
                                        break;

                                    case 10:
                                        if (str2 == "A")
                                        {
                                            str = "Windows 98 Second Edition";
                                        }
                                        else
                                        {
                                            str = "Windows 98";
                                        }
                                        break;

                                    case 90:
                                        str = "Windows Me";
                                        break;
                                }
                            }
                            break;

                        case PlatformID.Win32NT:
                        {
                            byte num3 = struct2.byte_0;
                            switch (major)
                            {
                                case 3:
                                    str = "Windows NT 3.51";
                                    goto Label_0200;

                                case 4:
                                    switch (num3)
                                    {
                                        case 1:
                                            str = "Windows NT 4.0";
                                            break;

                                        case 3:
                                            str = "Windows NT 4.0 Server";
                                            break;
                                    }
                                    goto Label_0200;

                                case 5:
                                    switch (minor)
                                    {
                                        case 0:
                                            str = "Windows 2000";
                                            break;

                                        case 1:
                                            str = "Windows XP";
                                            break;

                                        case 2:
                                            if (num3 == 1)
                                            {
                                                str = "Windows XP";
                                            }
                                            else
                                            {
                                                str = "Windows Server 2003";
                                            }
                                            break;
                                    }
                                    goto Label_0200;

                                case 6:
                                    switch (minor)
                                    {
                                        case 0:
                                            if (num3 == 1)
                                            {
                                                str = "Windows Vista";
                                            }
                                            else if (num3 == 3)
                                            {
                                                str = "Windows Server 2008";
                                            }
                                            break;

                                        case 1:
                                            if (num3 == 1)
                                            {
                                                str = "Windows 7";
                                            }
                                            else if (num3 == 3)
                                            {
                                                str = "Windows Server 2008 R2";
                                            }
                                            break;

                                        case 2:
                                            if (num3 == 1)
                                            {
                                                str = "Windows 8";
                                            }
                                            else if (num3 == 2)
                                            {
                                                str = "Windows Server 2012 R2";
                                            }
                                            break;
                                    }
                                    goto Label_0200;
                            }
                            break;
                        }
                    }
                }
            Label_0200:
                string_1 = str;
                return str;
            }
        }

        public static int RevisionVersion
        {
            get
            {
                return Environment.OSVersion.Version.Revision;
            }
        }

        public static string ServicePack
        {
            get
            {
                string str = string.Empty;
                Struct88 struct2 = new Struct88 {
                    int_0 = Marshal.SizeOf(typeof(Struct88))
                };
                if (GetVersionEx(ref struct2))
                {
                    str = struct2.string_0;
                }
                return str;
            }
        }

        public static System.Version Version
        {
            get
            {
                return Environment.OSVersion.Version;
            }
        }

        public static string VersionString
        {
            get
            {
                return Environment.OSVersion.Version.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct88
        {
            public int int_0;
            public readonly int int_1;
            public readonly int int_2;
            public readonly int int_3;
            public readonly int int_4;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x80)]
            public readonly string string_0;
            public readonly short short_0;
            public readonly short short_1;
            public readonly short short_2;
            public readonly byte byte_0;
            public readonly byte byte_1;
        }
    }
}


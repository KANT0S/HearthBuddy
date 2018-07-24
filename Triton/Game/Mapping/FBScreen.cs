namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FBScreen")]
    public class FBScreen : MonoClass
    {
        public FBScreen(IntPtr address) : this(address, "FBScreen")
        {
        }

        public FBScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public static Layout.OptionCenterHorizontal CenterHorizontal()
        {
            return MonoClass.smethod_15<Layout.OptionCenterHorizontal>(TritonHs.MainAssemblyPath, "", "FBScreen", "CenterHorizontal", Array.Empty<object>());
        }

        public static Layout.OptionCenterVertical CenterVertical()
        {
            return MonoClass.smethod_15<Layout.OptionCenterVertical>(TritonHs.MainAssemblyPath, "", "FBScreen", "CenterVertical", Array.Empty<object>());
        }

        public static Layout.OptionLeft Left(float amount)
        {
            object[] objArray1 = new object[] { amount };
            return MonoClass.smethod_15<Layout.OptionLeft>(TritonHs.MainAssemblyPath, "", "FBScreen", "Left", objArray1);
        }

        public static void SetUnityPlayerEmbedCSS(string key, string value)
        {
            object[] objArray1 = new object[] { key, value };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "FBScreen", "SetUnityPlayerEmbedCSS", objArray1);
        }

        public static Layout.OptionTop Top(float amount)
        {
            object[] objArray1 = new object[] { amount };
            return MonoClass.smethod_15<Layout.OptionTop>(TritonHs.MainAssemblyPath, "", "FBScreen", "Top", objArray1);
        }

        public static bool FullScreen
        {
            get
            {
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "FBScreen", "get_FullScreen", Array.Empty<object>());
            }
        }

        public static int Height
        {
            get
            {
                return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "FBScreen", "get_Height", Array.Empty<object>());
            }
        }

        public static bool resizable
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "FBScreen", "resizable");
            }
        }

        public static bool Resizable
        {
            get
            {
                return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "FBScreen", "get_Resizable", Array.Empty<object>());
            }
        }

        public static int Width
        {
            get
            {
                return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "FBScreen", "get_Width", Array.Empty<object>());
            }
        }

        [Attribute38("FBScreen.Layout")]
        public class Layout : MonoClass
        {
            public Layout(IntPtr address) : this(address, "Layout")
            {
            }

            public Layout(IntPtr address, string className) : base(address, className)
            {
            }

            [Attribute38("FBScreen.Layout.OptionCenterHorizontal")]
            public class OptionCenterHorizontal : FBScreen.Layout
            {
                public OptionCenterHorizontal(IntPtr address) : this(address, "OptionCenterHorizontal")
                {
                }

                public OptionCenterHorizontal(IntPtr address, string className) : base(address, className)
                {
                }
            }

            [Attribute38("FBScreen.Layout.OptionCenterVertical")]
            public class OptionCenterVertical : FBScreen.Layout
            {
                public OptionCenterVertical(IntPtr address) : this(address, "OptionCenterVertical")
                {
                }

                public OptionCenterVertical(IntPtr address, string className) : base(address, className)
                {
                }
            }

            [Attribute38("FBScreen.Layout.OptionLeft")]
            public class OptionLeft : FBScreen.Layout
            {
                public OptionLeft(IntPtr address) : this(address, "OptionLeft")
                {
                }

                public OptionLeft(IntPtr address, string className) : base(address, className)
                {
                }

                public float Amount
                {
                    get
                    {
                        return base.method_2<float>("Amount");
                    }
                }
            }

            [Attribute38("FBScreen.Layout.OptionTop")]
            public class OptionTop : FBScreen.Layout
            {
                public OptionTop(IntPtr address) : this(address, "OptionTop")
                {
                }

                public OptionTop(IntPtr address, string className) : base(address, className)
                {
                }

                public float Amount
                {
                    get
                    {
                        return base.method_2<float>("Amount");
                    }
                }
            }
        }
    }
}


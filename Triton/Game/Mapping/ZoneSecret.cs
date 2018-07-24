namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ZoneSecret")]
    public class ZoneSecret : Zone
    {
        public ZoneSecret(IntPtr address) : this(address, "ZoneSecret")
        {
        }

        public ZoneSecret(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanAnimateCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("CanAnimateCard", objArray1);
        }

        public void OnGameOver(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnGameOver", objArray1);
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateLayout_Default()
        {
            base.method_8("UpdateLayout_Default", Array.Empty<object>());
        }

        public void UpdateLayout_Phone()
        {
            base.method_8("UpdateLayout_Phone", Array.Empty<object>());
        }

        public static float LAYOUT_ANIM_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneSecret", "LAYOUT_ANIM_SEC");
            }
        }

        public static float MAX_LAYOUT_PYRAMID_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ZoneSecret", "MAX_LAYOUT_PYRAMID_LEVEL");
            }
        }
    }
}


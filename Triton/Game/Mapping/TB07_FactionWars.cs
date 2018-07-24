namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TB07_FactionWars")]
    public class TB07_FactionWars : MissionEntity
    {
        public TB07_FactionWars(IntPtr address) : this(address, "TB07_FactionWars")
        {
        }

        public TB07_FactionWars(IntPtr address, string className) : base(address, className)
        {
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Notification GameOverPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("GameOverPopup");
            }
        }

        public Vector3 popUpPos
        {
            get
            {
                return base.method_2<Vector3>("popUpPos");
            }
        }

        public string textID
        {
            get
            {
                return base.method_4("textID");
            }
        }
    }
}


namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TB_ChooseYourFateBuildaround")]
    public class TB_ChooseYourFateBuildaround : MissionEntity
    {
        public TB_ChooseYourFateBuildaround(IntPtr address) : this(address, "TB_ChooseYourFateBuildaround")
        {
        }

        public TB_ChooseYourFateBuildaround(IntPtr address, string className) : base(address, className)
        {
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Notification ChooseYourFatePopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("ChooseYourFatePopup");
            }
        }

        public string friendlyFate
        {
            get
            {
                return base.method_4("friendlyFate");
            }
        }

        public string opposingFate
        {
            get
            {
                return base.method_4("opposingFate");
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


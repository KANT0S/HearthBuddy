namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TB_ChooseYourFateRandom")]
    public class TB_ChooseYourFateRandom : MissionEntity
    {
        public TB_ChooseYourFateRandom(IntPtr address) : this(address, "TB_ChooseYourFateRandom")
        {
        }

        public TB_ChooseYourFateRandom(IntPtr address, string className) : base(address, className)
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

        public string firstFate
        {
            get
            {
                return base.method_4("firstFate");
            }
        }

        public string firstOpponenentFate
        {
            get
            {
                return base.method_4("firstOpponenentFate");
            }
        }

        public string newFate
        {
            get
            {
                return base.method_4("newFate");
            }
        }

        public string opponentFate
        {
            get
            {
                return base.method_4("opponentFate");
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


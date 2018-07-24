namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TB04_DeckBuilding")]
    public class TB04_DeckBuilding : MissionEntity
    {
        public TB04_DeckBuilding(IntPtr address) : this(address, "TB04_DeckBuilding")
        {
        }

        public TB04_DeckBuilding(IntPtr address, string className) : base(address, className)
        {
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public bool ShouldDoAlternateMulliganIntro()
        {
            return base.method_11<bool>("ShouldDoAlternateMulliganIntro", Array.Empty<object>());
        }

        public bool ShouldHandleCoin()
        {
            return base.method_11<bool>("ShouldHandleCoin", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Notification CardPlayedPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("CardPlayedPopup");
            }
        }

        public Triton.Game.Mapping.Notification EndOfTurnPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("EndOfTurnPopup");
            }
        }

        public Triton.Game.Mapping.Notification PickThreePopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("PickThreePopup");
            }
        }

        public Vector3 popUpPos
        {
            get
            {
                return base.method_2<Vector3>("popUpPos");
            }
        }

        public Triton.Game.Mapping.Notification StartOfTurnPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("StartOfTurnPopup");
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


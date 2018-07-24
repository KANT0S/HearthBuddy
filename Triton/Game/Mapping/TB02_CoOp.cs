namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TB02_CoOp")]
    public class TB02_CoOp : MissionEntity
    {
        public TB02_CoOp(IntPtr address) : this(address, "TB02_CoOp")
        {
        }

        public TB02_CoOp(IntPtr address, string className) : base(address, className)
        {
        }

        public void NotifyOfGameOver(TAG_PLAYSTATE gameResult)
        {
            object[] objArray1 = new object[] { gameResult };
            base.method_8("NotifyOfGameOver", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public void SetUpBossCard()
        {
            base.method_8("SetUpBossCard", Array.Empty<object>());
        }

        public Card m_bossCard
        {
            get
            {
                return base.method_3<Card>("m_bossCard");
            }
        }
    }
}


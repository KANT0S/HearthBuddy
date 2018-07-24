namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM06_Majordomo")]
    public class BRM06_Majordomo : BRM_MissionEntity
    {
        public BRM06_Majordomo(IntPtr address) : this(address, "BRM06_Majordomo")
        {
        }

        public BRM06_Majordomo(IntPtr address, string className) : base(address, className)
        {
        }

        public void PlayEmoteResponse(EmoteType emoteType, CardSoundSpell emoteSpell)
        {
            object[] objArray1 = new object[] { emoteType, emoteSpell };
            base.method_8("PlayEmoteResponse", objArray1);
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }
    }
}


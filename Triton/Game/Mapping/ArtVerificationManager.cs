namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ArtVerificationManager")]
    public class ArtVerificationManager : MonoBehaviour
    {
        public ArtVerificationManager(IntPtr address) : this(address, "ArtVerificationManager")
        {
        }

        public ArtVerificationManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void CleanUpCard(CardDef def)
        {
            object[] objArray1 = new object[] { def };
            base.method_8("CleanUpCard", objArray1);
        }

        public void FinishVerification()
        {
            base.method_8("FinishVerification", Array.Empty<object>());
        }

        public void LoadCards()
        {
            base.method_8("LoadCards", Array.Empty<object>());
        }

        public void OnCardDefLoaded(string cardID, CardDef def, object userData)
        {
            object[] objArray1 = new object[] { cardID, def, userData };
            base.method_8("OnCardDefLoaded", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public int m_cardsToLoad
        {
            get
            {
                return base.method_2<int>("m_cardsToLoad");
            }
        }

        public static float START_DELAY_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ArtVerificationManager", "START_DELAY_SEC");
            }
        }
    }
}


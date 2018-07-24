namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("EnemyEmoteHandler")]
    public class EnemyEmoteHandler : MonoBehaviour
    {
        public EnemyEmoteHandler(IntPtr address) : this(address, "EnemyEmoteHandler")
        {
        }

        public EnemyEmoteHandler(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AreEmotesActive()
        {
            return base.method_11<bool>("AreEmotesActive", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DoSquelchClick()
        {
            base.method_8("DoSquelchClick", Array.Empty<object>());
        }

        public static EnemyEmoteHandler Get()
        {
            return MonoClass.smethod_15<EnemyEmoteHandler>(TritonHs.MainAssemblyPath, "", "EnemyEmoteHandler", "Get", Array.Empty<object>());
        }

        public void HandleInput()
        {
            base.method_8("HandleInput", Array.Empty<object>());
        }

        public void HideEmotes()
        {
            base.method_8("HideEmotes", Array.Empty<object>());
        }

        public bool IsMousedOverEmote(RaycastHit cardHitInfo)
        {
            object[] objArray1 = new object[] { cardHitInfo };
            return base.method_11<bool>("IsMousedOverEmote", objArray1);
        }

        public bool IsMousedOverHero(RaycastHit cardHitInfo)
        {
            object[] objArray1 = new object[] { cardHitInfo };
            return base.method_11<bool>("IsMousedOverHero", objArray1);
        }

        public bool IsMousedOverSelf(RaycastHit cardHitInfo)
        {
            object[] objArray1 = new object[] { cardHitInfo };
            return base.method_11<bool>("IsMousedOverSelf", objArray1);
        }

        public bool IsMouseOverEmoteOption()
        {
            return base.method_11<bool>("IsMouseOverEmoteOption", Array.Empty<object>());
        }

        public bool IsSquelched()
        {
            return base.method_11<bool>("IsSquelched", Array.Empty<object>());
        }

        public void MouseOutSquelch()
        {
            base.method_8("MouseOutSquelch", Array.Empty<object>());
        }

        public void MouseOverSquelch()
        {
            base.method_8("MouseOverSquelch", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void ShowEmotes()
        {
            base.method_8("ShowEmotes", Array.Empty<object>());
        }

        public bool emotesDisplayed
        {
            get
            {
                return base.method_2<bool>("emotesDisplayed");
            }
        }

        public bool m_squelched
        {
            get
            {
                return base.method_2<bool>("m_squelched");
            }
        }

        public GameObject m_squelchEmote
        {
            get
            {
                return base.method_3<GameObject>("m_squelchEmote");
            }
        }

        public MeshRenderer m_squelchEmoteBackplate
        {
            get
            {
                return base.method_3<MeshRenderer>("m_squelchEmoteBackplate");
            }
        }

        public UberText m_squelchEmoteDisplayText
        {
            get
            {
                return base.method_3<UberText>("m_squelchEmoteDisplayText");
            }
        }

        public Vector3 m_squelchEmoteStartingScale
        {
            get
            {
                return base.method_2<Vector3>("m_squelchEmoteStartingScale");
            }
        }

        public int shownAt
        {
            get
            {
                return base.method_2<int>("shownAt");
            }
        }

        public bool squelchMousedOver
        {
            get
            {
                return base.method_2<bool>("squelchMousedOver");
            }
        }
    }
}


namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("EmoteHandler")]
    public class EmoteHandler : MonoBehaviour
    {
        public EmoteHandler(IntPtr address) : this(address, "EmoteHandler")
        {
        }

        public EmoteHandler(IntPtr address, string className) : base(address, className)
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

        public bool EmoteSpamBlocked()
        {
            return base.method_11<bool>("EmoteSpamBlocked", Array.Empty<object>());
        }

        public static EmoteHandler Get()
        {
            return MonoClass.smethod_15<EmoteHandler>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "Get", Array.Empty<object>());
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

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void ResetTimeSinceLastEmote()
        {
            base.method_8("ResetTimeSinceLastEmote", Array.Empty<object>());
        }

        public void ShowEmotes()
        {
            base.method_8("ShowEmotes", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Material blackTextMatieral
        {
            get
            {
                return base.method_3<Material>("blackTextMatieral");
            }
        }

        public int chainedEmotes
        {
            get
            {
                return base.method_2<int>("chainedEmotes");
            }
        }

        public bool emotesDisplayed
        {
            get
            {
                return base.method_2<bool>("emotesDisplayed");
            }
        }

        public Material greyTextMaterial
        {
            get
            {
                return base.method_3<Material>("greyTextMaterial");
            }
        }

        public List<EmoteOption> m_emotes
        {
            get
            {
                Class267<EmoteOption> class2 = base.method_3<Class267<EmoteOption>>("m_emotes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static float MIN_TIME_BETWEEN_EMOTES
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "MIN_TIME_BETWEEN_EMOTES");
            }
        }

        public EmoteOption mousedOverEmote
        {
            get
            {
                return base.method_3<EmoteOption>("mousedOverEmote");
            }
        }

        public static int NUM_CHAIN_EMOTES_BEFORE_CONSIDERED_SPAM
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "NUM_CHAIN_EMOTES_BEFORE_CONSIDERED_SPAM");
            }
        }

        public static int NUM_EMOTES_BEFORE_CONSIDERED_A_SPAMMER
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "NUM_EMOTES_BEFORE_CONSIDERED_A_SPAMMER");
            }
        }

        public static int NUM_EMOTES_BEFORE_CONSIDERED_UBER_SPAMMER
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "NUM_EMOTES_BEFORE_CONSIDERED_UBER_SPAMMER");
            }
        }

        public int shownAt
        {
            get
            {
                return base.method_2<int>("shownAt");
            }
        }

        public static float SPAMMER_MIN_TIME_BETWEEN_EMOTES
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "SPAMMER_MIN_TIME_BETWEEN_EMOTES");
            }
        }

        public static float TIME_BEFORE_EMOTES_APPEAR
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "TIME_BEFORE_EMOTES_APPEAR");
            }
        }

        public static float TIME_WINDOW_TO_BE_CONSIDERED_A_CHAIN
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "TIME_WINDOW_TO_BE_CONSIDERED_A_CHAIN");
            }
        }

        public float timeSinceLastEmote
        {
            get
            {
                return base.method_2<float>("timeSinceLastEmote");
            }
        }

        public int totalEmotes
        {
            get
            {
                return base.method_2<int>("totalEmotes");
            }
        }

        public static float UBER_SPAMMER_MIN_TIME_BETWEEN_EMOTES
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "EmoteHandler", "UBER_SPAMMER_MIN_TIME_BETWEEN_EMOTES");
            }
        }
    }
}


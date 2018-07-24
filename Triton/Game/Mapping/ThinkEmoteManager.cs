namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ThinkEmoteManager")]
    public class ThinkEmoteManager : MonoBehaviour
    {
        public ThinkEmoteManager(IntPtr address) : this(address, "ThinkEmoteManager")
        {
        }

        public ThinkEmoteManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static ThinkEmoteManager Get()
        {
            return MonoClass.smethod_15<ThinkEmoteManager>(TritonHs.MainAssemblyPath, "", "ThinkEmoteManager", "Get", Array.Empty<object>());
        }

        public void NotifyOfActivity()
        {
            base.method_8("NotifyOfActivity", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void PlayThinkEmote()
        {
            base.method_8("PlayThinkEmote", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float m_secondsSinceAction
        {
            get
            {
                return base.method_2<float>("m_secondsSinceAction");
            }
        }

        public static float SECONDS_BEFORE_EMOTE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ThinkEmoteManager", "SECONDS_BEFORE_EMOTE");
            }
        }
    }
}


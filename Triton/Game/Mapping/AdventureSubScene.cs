namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureSubScene")]
    public class AdventureSubScene : MonoBehaviour
    {
        public AdventureSubScene(IntPtr address) : this(address, "AdventureSubScene")
        {
        }

        public AdventureSubScene(IntPtr address, string className) : base(address, className)
        {
        }

        public void FireSubSceneTransitionFinishedEvent()
        {
            base.method_8("FireSubSceneTransitionFinishedEvent", Array.Empty<object>());
        }

        public bool IsLoaded()
        {
            return base.method_11<bool>("IsLoaded", Array.Empty<object>());
        }

        public void NotifyTransitionComplete()
        {
            base.method_8("NotifyTransitionComplete", Array.Empty<object>());
        }

        public void SetIsLoaded(bool loaded)
        {
            object[] objArray1 = new object[] { loaded };
            base.method_8("SetIsLoaded", objArray1);
        }

        public bool m_IsLoaded
        {
            get
            {
                return base.method_2<bool>("m_IsLoaded");
            }
        }

        public float m_TransitionAnimationTime
        {
            get
            {
                return base.method_2<float>("m_TransitionAnimationTime");
            }
        }
    }
}


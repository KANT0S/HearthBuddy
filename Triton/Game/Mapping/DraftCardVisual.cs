namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DraftCardVisual")]
    public class DraftCardVisual : PegUIElement
    {
        public DraftCardVisual(IntPtr address) : this(address, "DraftCardVisual")
        {
        }

        public DraftCardVisual(IntPtr address, string className) : base(address, className)
        {
        }

        public void ChooseThisCard()
        {
            base.method_8("ChooseThisCard", Array.Empty<object>());
        }

        public Actor GetActor()
        {
            return base.method_14<Actor>("GetActor", Array.Empty<object>());
        }

        public int GetChoiceNum()
        {
            return base.method_11<int>("GetChoiceNum", Array.Empty<object>());
        }

        public bool IsChosen()
        {
            return base.method_11<bool>("IsChosen", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void SetActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("SetActor", objArray1);
        }

        public void SetChoiceNum(int num)
        {
            object[] objArray1 = new object[] { num };
            base.method_8("SetChoiceNum", objArray1);
        }

        public void SetChosenFlag(bool bOn)
        {
            object[] objArray1 = new object[] { bOn };
            base.method_8("SetChosenFlag", objArray1);
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public int m_cardChoice
        {
            get
            {
                return base.method_2<int>("m_cardChoice");
            }
        }

        public bool m_chosen
        {
            get
            {
                return base.method_2<bool>("m_chosen");
            }
        }

        public float m_mouseOverTimer
        {
            get
            {
                return base.method_2<float>("m_mouseOverTimer");
            }
        }

        public static float MOUSE_OVER_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DraftCardVisual", "MOUSE_OVER_DELAY");
            }
        }
    }
}


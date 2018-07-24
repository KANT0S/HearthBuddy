namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Notification")]
    public class Notification : MonoBehaviour
    {
        public Notification(IntPtr address) : this(address, "Notification")
        {
        }

        public Notification(IntPtr address, string className) : base(address, className)
        {
        }

        public void BounceDown()
        {
            base.method_8("BounceDown", Array.Empty<object>());
        }

        public void BounceUp()
        {
            base.method_8("BounceUp", Array.Empty<object>());
        }

        public void ChangeDialogText(string headlineString, string bodyString, string yesOrOKstring, string noString)
        {
            object[] objArray1 = new object[] { headlineString, bodyString, yesOrOKstring, noString };
            base.method_8("ChangeDialogText", objArray1);
        }

        public void ChangeText(string newText)
        {
            object[] objArray1 = new object[] { newText };
            base.method_8("ChangeText", objArray1);
        }

        public void FaceDirection(SpeechBubbleDirection direction)
        {
            object[] objArray1 = new object[] { direction };
            base.method_8("FaceDirection", objArray1);
        }

        public void FadeComplete()
        {
            base.method_8("FadeComplete", Array.Empty<object>());
        }

        public void FadeOut()
        {
            base.method_8("FadeOut", Array.Empty<object>());
        }

        public void FinishDeath()
        {
            base.method_8("FinishDeath", Array.Empty<object>());
        }

        public SpeechBubbleDirection GetSpeechBubbleDirection()
        {
            return base.method_11<SpeechBubbleDirection>("GetSpeechBubbleDirection", Array.Empty<object>());
        }

        public bool IsDying()
        {
            return base.method_11<bool>("IsDying", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void PlayBirth()
        {
            base.method_8("PlayBirth", Array.Empty<object>());
        }

        public void PlayBirthWithForcedScale(Vector3 targetScale)
        {
            object[] objArray1 = new object[] { targetScale };
            base.method_8("PlayBirthWithForcedScale", objArray1);
        }

        public void PlayDeath()
        {
            base.method_8("PlayDeath", Array.Empty<object>());
        }

        public void PlaySmallBirthForFakeBubble()
        {
            base.method_8("PlaySmallBirthForFakeBubble", Array.Empty<object>());
        }

        public void PulseReminderEveryXSeconds(float seconds)
        {
            object[] objArray1 = new object[] { seconds };
            base.method_8("PulseReminderEveryXSeconds", objArray1);
        }

        public void SetPosition(Actor actor, SpeechBubbleDirection direction)
        {
            object[] objArray1 = new object[] { actor, direction };
            base.method_8("SetPosition", objArray1);
        }

        public void SetPositionForSmallBubble(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("SetPositionForSmallBubble", objArray1);
        }

        public void ShowPopUpArrow(PopUpArrowDirection direction)
        {
            object[] objArray1 = new object[] { direction };
            base.method_8("ShowPopUpArrow", objArray1);
        }

        public void Shrink(float duration)
        {
            object[] objArray1 = new object[] { duration };
            base.method_8("Shrink", objArray1);
        }

        public void Unshrink(float duration)
        {
            object[] objArray1 = new object[] { duration };
            base.method_8("Unshrink", objArray1);
        }

        public MeshRenderer artOverlay
        {
            get
            {
                return base.method_3<MeshRenderer>("artOverlay");
            }
        }

        public GameObject bottomLeftBubble
        {
            get
            {
                return base.method_3<GameObject>("bottomLeftBubble");
            }
        }

        public GameObject bottomLeftPopupArrow
        {
            get
            {
                return base.method_3<GameObject>("bottomLeftPopupArrow");
            }
        }

        public GameObject bottomPopupArrow
        {
            get
            {
                return base.method_3<GameObject>("bottomPopupArrow");
            }
        }

        public GameObject bottomRightBubble
        {
            get
            {
                return base.method_3<GameObject>("bottomRightBubble");
            }
        }

        public GameObject bottomRightPopupArrow
        {
            get
            {
                return base.method_3<GameObject>("bottomRightPopupArrow");
            }
        }

        public static float BOUNCE_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Notification", "BOUNCE_SPEED");
            }
        }

        public GameObject bounceObject
        {
            get
            {
                return base.method_3<GameObject>("bounceObject");
            }
        }

        public SpeechBubbleDirection bubbleDirection
        {
            get
            {
                return base.method_2<SpeechBubbleDirection>("bubbleDirection");
            }
        }

        public PegUIElement clickOff
        {
            get
            {
                return base.method_3<PegUIElement>("clickOff");
            }
        }

        public static float DEATH_ANIMATION_DURATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Notification", "DEATH_ANIMATION_DURATION");
            }
        }

        public Spell destroyEvent
        {
            get
            {
                return base.method_3<Spell>("destroyEvent");
            }
        }

        public static float FADE_PAUSE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Notification", "FADE_PAUSE");
            }
        }

        public static float FADE_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Notification", "FADE_SPEED");
            }
        }

        public GameObject fadeArrowObject
        {
            get
            {
                return base.method_3<GameObject>("fadeArrowObject");
            }
        }

        public UberText headlineUberText
        {
            get
            {
                return base.method_3<UberText>("headlineUberText");
            }
        }

        public bool isDying
        {
            get
            {
                return base.method_2<bool>("isDying");
            }
        }

        public GameObject leftPopupArrow
        {
            get
            {
                return base.method_3<GameObject>("leftPopupArrow");
            }
        }

        public Vector3 m_initialScale
        {
            get
            {
                return base.method_2<Vector3>("m_initialScale");
            }
        }

        public static int MAX_CHARACTERS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Notification", "MAX_CHARACTERS");
            }
        }

        public static int MAX_CHARACTERS_IN_DIALOG
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Notification", "MAX_CHARACTERS_IN_DIALOG");
            }
        }

        public GameObject rightPopupArrow
        {
            get
            {
                return base.method_3<GameObject>("rightPopupArrow");
            }
        }

        public Spell showEvent
        {
            get
            {
                return base.method_3<Spell>("showEvent");
            }
        }

        public UberText speechUberText
        {
            get
            {
                return base.method_3<UberText>("speechUberText");
            }
        }

        public Material swapMaterial
        {
            get
            {
                return base.method_3<Material>("swapMaterial");
            }
        }

        public GameObject topPopupArrow
        {
            get
            {
                return base.method_3<GameObject>("topPopupArrow");
            }
        }

        public GameObject upperLeftBubble
        {
            get
            {
                return base.method_3<GameObject>("upperLeftBubble");
            }
        }

        public GameObject upperRightBubble
        {
            get
            {
                return base.method_3<GameObject>("upperRightBubble");
            }
        }

        public enum PopUpArrowDirection
        {
            Left,
            Right,
            Down,
            Up,
            LeftDown,
            RightDown
        }

        public enum SpeechBubbleDirection
        {
            None,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }
    }
}


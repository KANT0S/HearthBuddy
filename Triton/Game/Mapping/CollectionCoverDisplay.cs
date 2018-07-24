namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionCoverDisplay")]
    public class CollectionCoverDisplay : PegUIElement
    {
        public CollectionCoverDisplay(IntPtr address) : this(address, "CollectionCoverDisplay")
        {
        }

        public CollectionCoverDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateCoverClosing()
        {
            base.method_8("AnimateCoverClosing", Array.Empty<object>());
        }

        public void AnimateLatchClosing()
        {
            base.method_8("AnimateLatchClosing", Array.Empty<object>());
        }

        public void AnimateLatchOpening()
        {
            base.method_8("AnimateLatchOpening", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Close()
        {
            base.method_8("Close", Array.Empty<object>());
        }

        public void CrackClose()
        {
            base.method_8("CrackClose", Array.Empty<object>());
        }

        public void CrackOpen()
        {
            base.method_8("CrackOpen", Array.Empty<object>());
        }

        public void EnableCollider(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("EnableCollider", objArray1);
        }

        public bool IsAnimating()
        {
            return base.method_11<bool>("IsAnimating", Array.Empty<object>());
        }

        public void OnLatchClosed()
        {
            base.method_8("OnLatchClosed", Array.Empty<object>());
        }

        public void OnLatchOpened()
        {
            base.method_8("OnLatchOpened", Array.Empty<object>());
        }

        public void SetIsAnimating(bool animating)
        {
            object[] objArray1 = new object[] { animating };
            base.method_8("SetIsAnimating", objArray1);
        }

        public void SetOpenState()
        {
            base.method_8("SetOpenState", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float BOOK_COVER_FULL_ANIM_TIME
        {
            get
            {
                return base.method_2<float>("BOOK_COVER_FULL_ANIM_TIME");
            }
        }

        public float BOOK_COVER_FULLY_CLOSED_Z_ROTATION
        {
            get
            {
                return base.method_2<float>("BOOK_COVER_FULLY_CLOSED_Z_ROTATION");
            }
        }

        public float BOOK_COVER_FULLY_OPEN_Z_ROTATION
        {
            get
            {
                return base.method_2<float>("BOOK_COVER_FULLY_OPEN_Z_ROTATION");
            }
        }

        public string CRACK_LATCH_OPEN_ANIM_COROUTINE
        {
            get
            {
                return base.method_4("CRACK_LATCH_OPEN_ANIM_COROUTINE");
            }
        }

        public float LATCH_FADE_DELAY
        {
            get
            {
                return base.method_2<float>("LATCH_FADE_DELAY");
            }
        }

        public float LATCH_FADE_TIME
        {
            get
            {
                return base.method_2<float>("LATCH_FADE_TIME");
            }
        }

        public string LATCH_OPEN_ANIM_NAME
        {
            get
            {
                return base.method_4("LATCH_OPEN_ANIM_NAME");
            }
        }

        public float LATCH_OPEN_ANIM_SPEED
        {
            get
            {
                return base.method_2<float>("LATCH_OPEN_ANIM_SPEED");
            }
        }

        public GameObject m_bookCover
        {
            get
            {
                return base.method_3<GameObject>("m_bookCover");
            }
        }

        public GameObject m_bookCoverLatch
        {
            get
            {
                return base.method_3<GameObject>("m_bookCoverLatch");
            }
        }

        public GameObject m_bookCoverLatchJoint
        {
            get
            {
                return base.method_3<GameObject>("m_bookCoverLatchJoint");
            }
        }

        public BoxCollider m_boxCollider
        {
            get
            {
                return base.method_3<BoxCollider>("m_boxCollider");
            }
        }

        public bool m_isAnimating
        {
            get
            {
                return base.method_2<bool>("m_isAnimating");
            }
        }

        public Material m_latchFadeMaterial
        {
            get
            {
                return base.method_3<Material>("m_latchFadeMaterial");
            }
        }

        public Material m_latchOpaqueMaterial
        {
            get
            {
                return base.method_3<Material>("m_latchOpaqueMaterial");
            }
        }
    }
}


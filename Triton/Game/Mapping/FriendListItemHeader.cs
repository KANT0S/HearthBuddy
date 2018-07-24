namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListItemHeader")]
    public class FriendListItemHeader : PegUIElement
    {
        public FriendListItemHeader(IntPtr address) : this(address, "FriendListItemHeader")
        {
        }

        public FriendListItemHeader(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClearToggleListeners()
        {
            base.method_8("ClearToggleListeners", Array.Empty<object>());
        }

        public Transform GetCurrentBoneTransform()
        {
            return base.method_14<Transform>("GetCurrentBoneTransform", Array.Empty<object>());
        }

        public void OnHeaderButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnHeaderButtonReleased", objArray1);
        }

        public void SetInitialShowContents(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("SetInitialShowContents", objArray1);
        }

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public void UpdateFoldoutArrow()
        {
            base.method_8("UpdateFoldoutArrow", Array.Empty<object>());
        }

        public GameObject Background
        {
            get
            {
                return base.method_14<GameObject>("get_Background", Array.Empty<object>());
            }
        }

        public bool IsHeader
        {
            get
            {
                return base.method_11<bool>("get_IsHeader", Array.Empty<object>());
            }
        }

        public bool IsShowingContents
        {
            get
            {
                return base.method_11<bool>("get_IsShowingContents", Array.Empty<object>());
            }
        }

        public Bounds LocalBounds
        {
            get
            {
                return base.method_11<Bounds>("get_LocalBounds", Array.Empty<object>());
            }
        }

        public float m_AnimRotateTime
        {
            get
            {
                return base.method_2<float>("m_AnimRotateTime");
            }
        }

        public GameObject m_Arrow
        {
            get
            {
                return base.method_3<GameObject>("m_Arrow");
            }
        }

        public Transform m_FoldinBone
        {
            get
            {
                return base.method_3<Transform>("m_FoldinBone");
            }
        }

        public Transform m_FoldoutBone
        {
            get
            {
                return base.method_3<Transform>("m_FoldoutBone");
            }
        }

        public MultiSliceElement m_multiSlice
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_multiSlice");
            }
        }

        public bool m_ShowContents
        {
            get
            {
                return base.method_2<bool>("m_ShowContents");
            }
        }

        public UberText m_Text
        {
            get
            {
                return base.method_3<UberText>("m_Text");
            }
        }

        public Triton.Game.Mapping.Option Option
        {
            get
            {
                return base.method_11<Triton.Game.Mapping.Option>("get_Option", Array.Empty<object>());
            }
        }

        public MobileFriendListItem.TypeFlags SubType
        {
            get
            {
                return base.method_11<MobileFriendListItem.TypeFlags>("get_SubType", Array.Empty<object>());
            }
        }

        public bool Visible
        {
            get
            {
                return base.method_11<bool>("get_Visible", Array.Empty<object>());
            }
        }
    }
}


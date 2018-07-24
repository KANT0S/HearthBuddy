namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionClassTab")]
    public class CollectionClassTab : PegUIElement
    {
        public CollectionClassTab(IntPtr address) : this(address, "CollectionClassTab")
        {
        }

        public CollectionClassTab(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateToTargetPosition(float animationTime, iTween.EaseType easeType)
        {
            object[] objArray1 = new object[] { animationTime, easeType };
            base.method_8("AnimateToTargetPosition", objArray1);
        }

        public TAG_CLASS GetClass()
        {
            return base.method_11<TAG_CLASS>("GetClass", Array.Empty<object>());
        }

        public static Vector2 GetTextureOffset(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return MonoClass.smethod_14<Vector2>(TritonHs.MainAssemblyPath, "", "CollectionClassTab", "GetTextureOffset", objArray1);
        }

        public bool IsVisible()
        {
            return base.method_11<bool>("IsVisible", Array.Empty<object>());
        }

        public void OnMovedToTargetPos()
        {
            base.method_8("OnMovedToTargetPos", Array.Empty<object>());
        }

        public void SetClassIconsTextureOffset(Renderer renderer)
        {
            object[] objArray1 = new object[] { renderer };
            base.method_8("SetClassIconsTextureOffset", objArray1);
        }

        public void SetGlowActive(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("SetGlowActive", objArray1);
        }

        public void SetIsVisible(bool isVisible)
        {
            object[] objArray1 = new object[] { isVisible };
            base.method_8("SetIsVisible", objArray1);
        }

        public void SetLargeTab(bool large)
        {
            object[] objArray1 = new object[] { large };
            base.method_8("SetLargeTab", objArray1);
        }

        public void SetSelected(bool selected)
        {
            object[] objArray1 = new object[] { selected };
            base.method_8("SetSelected", objArray1);
        }

        public void SetTargetLocalPosition(Vector3 targetLocalPos)
        {
            object[] objArray1 = new object[] { targetLocalPos };
            base.method_8("SetTargetLocalPosition", objArray1);
        }

        public void SetTargetVisibility(bool visible)
        {
            object[] objArray1 = new object[] { visible };
            base.method_8("SetTargetVisibility", objArray1);
        }

        public bool ShouldBeVisible()
        {
            return base.method_11<bool>("ShouldBeVisible", Array.Empty<object>());
        }

        public void UpdateNewItemCount(int numNewItems)
        {
            object[] objArray1 = new object[] { numNewItems };
            base.method_8("UpdateNewItemCount", objArray1);
        }

        public void UpdateNewItemCountVisuals()
        {
            base.method_8("UpdateNewItemCountVisuals", Array.Empty<object>());
        }

        public bool WillSlide()
        {
            return base.method_11<bool>("WillSlide", Array.Empty<object>());
        }

        public static string CLASS_ICONS_TEXTURE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionClassTab", "CLASS_ICONS_TEXTURE_NAME");
            }
        }

        public TAG_CLASS m_classTag
        {
            get
            {
                return base.method_2<TAG_CLASS>("m_classTag");
            }
        }

        public Vector3 m_DeselectedLocalScale
        {
            get
            {
                return base.method_2<Vector3>("m_DeselectedLocalScale");
            }
        }

        public float m_DeselectedLocalYPos
        {
            get
            {
                return base.method_2<float>("m_DeselectedLocalYPos");
            }
        }

        public GameObject m_glowMesh
        {
            get
            {
                return base.method_3<GameObject>("m_glowMesh");
            }
        }

        public bool m_isVisible
        {
            get
            {
                return base.method_2<bool>("m_isVisible");
            }
        }

        public GameObject m_newItemCount
        {
            get
            {
                return base.method_3<GameObject>("m_newItemCount");
            }
        }

        public UberText m_newItemCountText
        {
            get
            {
                return base.method_3<UberText>("m_newItemCountText");
            }
        }

        public int m_numNewItems
        {
            get
            {
                return base.method_2<int>("m_numNewItems");
            }
        }

        public bool m_selected
        {
            get
            {
                return base.method_2<bool>("m_selected");
            }
        }

        public Vector3 m_SelectedLocalScale
        {
            get
            {
                return base.method_2<Vector3>("m_SelectedLocalScale");
            }
        }

        public float m_SelectedLocalYPos
        {
            get
            {
                return base.method_2<float>("m_SelectedLocalYPos");
            }
        }

        public bool m_shouldBeVisible
        {
            get
            {
                return base.method_2<bool>("m_shouldBeVisible");
            }
        }

        public bool m_showLargeTab
        {
            get
            {
                return base.method_2<bool>("m_showLargeTab");
            }
        }

        public CollectionManagerDisplay.ViewMode m_tabViewMode
        {
            get
            {
                return base.method_2<CollectionManagerDisplay.ViewMode>("m_tabViewMode");
            }
        }

        public Vector3 m_targetLocalPos
        {
            get
            {
                return base.method_2<Vector3>("m_targetLocalPos");
            }
        }

        public static float SELECT_TAB_ANIM_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionClassTab", "SELECT_TAB_ANIM_TIME");
            }
        }
    }
}


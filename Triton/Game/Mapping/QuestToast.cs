namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("QuestToast")]
    public class QuestToast : MonoBehaviour
    {
        public QuestToast(IntPtr address) : this(address, "QuestToast")
        {
        }

        public QuestToast(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CloseQuestToast()
        {
            base.method_9("CloseQuestToast", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void CloseQuestToast(UIEvent e)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { e };
            base.method_9("CloseQuestToast", enumArray1, objArray1);
        }

        public void DestroyQuestToast()
        {
            base.method_8("DestroyQuestToast", Array.Empty<object>());
        }

        public void FadeEffectsIn()
        {
            base.method_8("FadeEffectsIn", Array.Empty<object>());
        }

        public void FadeEffectsOut()
        {
            base.method_8("FadeEffectsOut", Array.Empty<object>());
        }

        public static QuestToast GetCurrentToast()
        {
            return MonoClass.smethod_15<QuestToast>(TritonHs.MainAssemblyPath, "", "QuestToast", "GetCurrentToast", Array.Empty<object>());
        }

        public static bool IsQuestActive()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "QuestToast", "IsQuestActive", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public static void PositionActor(string actorName, GameObject actorObject, object c)
        {
            object[] objArray1 = new object[] { actorName, actorObject, c };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "QuestToast", "PositionActor", objArray1);
        }

        public void RewardObjectLoaded(Reward reward, object callbackData)
        {
            object[] objArray1 = new object[] { reward, callbackData };
            base.method_8("RewardObjectLoaded", objArray1);
        }

        public void SetUpToast(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("SetUpToast", objArray1);
        }

        public static QuestToast m_activeQuest
        {
            get
            {
                return MonoClass.smethod_7<QuestToast>(TritonHs.MainAssemblyPath, "", "QuestToast", "m_activeQuest");
            }
        }

        public PegUIElement m_clickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_clickCatcher");
            }
        }

        public GameObject m_nameLine
        {
            get
            {
                return base.method_3<GameObject>("m_nameLine");
            }
        }

        public object m_onCloseCallbackData
        {
            get
            {
                return base.method_3<object>("m_onCloseCallbackData");
            }
        }

        public static bool m_questActive
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "QuestToast", "m_questActive");
            }
        }

        public UberText m_questName
        {
            get
            {
                return base.method_3<UberText>("m_questName");
            }
        }

        public UberText m_requirement
        {
            get
            {
                return base.method_3<UberText>("m_requirement");
            }
        }

        public Transform m_rewardBone
        {
            get
            {
                return base.method_3<Transform>("m_rewardBone");
            }
        }

        public static bool m_showFullscreenEffects
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "QuestToast", "m_showFullscreenEffects");
            }
        }

        public string m_toastDescription
        {
            get
            {
                return base.method_4("m_toastDescription");
            }
        }

        public string m_toastName
        {
            get
            {
                return base.method_4("m_toastName");
            }
        }

        public List<RewardData> m_toastRewards
        {
            get
            {
                Class267<RewardData> class2 = base.method_3<Class267<RewardData>>("m_toastRewards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static Vector3 REWARD_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "QuestToast", "REWARD_SCALE");
            }
        }

        [Attribute38("QuestToast.ToastCallbackData")]
        public class ToastCallbackData : MonoClass
        {
            public ToastCallbackData(IntPtr address) : this(address, "ToastCallbackData")
            {
            }

            public ToastCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_onCloseCallbackData
            {
                get
                {
                    return base.method_3<object>("m_onCloseCallbackData");
                }
            }

            public string m_toastDescription
            {
                get
                {
                    return base.method_4("m_toastDescription");
                }
            }

            public string m_toastName
            {
                get
                {
                    return base.method_4("m_toastName");
                }
            }

            public List<RewardData> m_toastRewards
            {
                get
                {
                    Class267<RewardData> class2 = base.method_3<Class267<RewardData>>("m_toastRewards");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public bool m_updateCacheValues
            {
                get
                {
                    return base.method_2<bool>("m_updateCacheValues");
                }
            }
        }
    }
}


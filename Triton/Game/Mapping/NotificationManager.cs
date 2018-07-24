namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("NotificationManager")]
    public class NotificationManager : MonoBehaviour
    {
        public NotificationManager(IntPtr address) : this(address, "NotificationManager")
        {
        }

        public NotificationManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ClickNotification(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ClickNotification", objArray1);
        }

        public Triton.Game.Mapping.Notification CreateBouncingArrow(bool addToList)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { addToList };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateBouncingArrow", enumArray1, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateBouncingArrow(Vector3 position, Vector3 rotation)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position, rotation };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateBouncingArrow", enumArray1, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateBouncingArrow(Vector3 position, Vector3 rotation, bool addToList)
        {
            object[] objArray1 = new object[] { position, rotation, addToList };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateBouncingArrow", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateCharacterQuote(string prefabName, string text, string soundName, bool allowRepeatDuringSession, float durationSeconds, CanvasAnchor anchorPoint)
        {
            object[] objArray1 = new object[] { prefabName, text, soundName, allowRepeatDuringSession, durationSeconds, anchorPoint };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateCharacterQuote", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateFadeArrow(bool addToList)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { addToList };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateFadeArrow", enumArray1, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateFadeArrow(Vector3 position, Vector3 rotation)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { position, rotation };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateFadeArrow", enumArray1, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateFadeArrow(Vector3 position, Vector3 rotation, bool addToList)
        {
            object[] objArray1 = new object[] { position, rotation, addToList };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateFadeArrow", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateKTQuote(string stringTag, string soundName, bool allowRepeatDuringSession)
        {
            object[] objArray1 = new object[] { stringTag, soundName, allowRepeatDuringSession };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateKTQuote", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateKTQuote(Vector3 position, string stringTag, string soundName, bool allowRepeatDuringSession)
        {
            object[] objArray1 = new object[] { position, stringTag, soundName, allowRepeatDuringSession };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateKTQuote", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreatePopupDialog(string headlineText, string bodyText, string yesOrOKButtonText, string noButtonText)
        {
            object[] objArray1 = new object[] { headlineText, bodyText, yesOrOKButtonText, noButtonText };
            return base.method_15<Triton.Game.Mapping.Notification>("CreatePopupDialog", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreatePopupDialog(string headlineText, string bodyText, string yesOrOKButtonText, string noButtonText, Vector3 offset)
        {
            object[] objArray1 = new object[] { headlineText, bodyText, yesOrOKButtonText, noButtonText, offset };
            return base.method_15<Triton.Game.Mapping.Notification>("CreatePopupDialog", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreatePopupText(Transform bone, string text, bool convertLegacyPosition)
        {
            object[] objArray1 = new object[] { bone, text, convertLegacyPosition };
            return base.method_15<Triton.Game.Mapping.Notification>("CreatePopupText", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreatePopupText(Vector3 position, Vector3 scale, string text, bool convertLegacyPosition)
        {
            object[] objArray1 = new object[] { position, scale, text, convertLegacyPosition };
            return base.method_15<Triton.Game.Mapping.Notification>("CreatePopupText", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateSpeechBubble(string speechText, Actor actor)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Class };
            object[] objArray1 = new object[] { speechText, actor };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateSpeechBubble", enumArray1, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateSpeechBubble(string speechText, Actor actor, bool bDestroyWhenNewCreated)
        {
            object[] objArray1 = new object[] { speechText, actor, bDestroyWhenNewCreated };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateSpeechBubble", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateSpeechBubble(string speechText, Triton.Game.Mapping.Notification.SpeechBubbleDirection direction, Actor actor)
        {
            object[] objArray1 = new object[] { speechText, direction, actor };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateSpeechBubble", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateSpeechBubble(string speechText, Triton.Game.Mapping.Notification.SpeechBubbleDirection direction, Actor actor, bool bDestroyWhenNewCreated, bool parentToActor)
        {
            object[] objArray1 = new object[] { speechText, direction, actor, bDestroyWhenNewCreated, parentToActor };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateSpeechBubble", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateTirionQuote(string stringTag, string soundName, bool allowRepeatDuringSession)
        {
            object[] objArray1 = new object[] { stringTag, soundName, allowRepeatDuringSession };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateTirionQuote", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateTirionQuote(Vector3 position, string stringTag, string soundName, bool allowRepeatDuringSession)
        {
            object[] objArray1 = new object[] { position, stringTag, soundName, allowRepeatDuringSession };
            return base.method_15<Triton.Game.Mapping.Notification>("CreateTirionQuote", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public Triton.Game.Mapping.Notification CreateZombieNefarianQuote(Vector3 position, string stringTag, string soundName, bool allowRepeatDuringSession)
        {
            object[] objArray1 = new object[] { position, stringTag, soundName, allowRepeatDuringSession };
            return base.method_14<Triton.Game.Mapping.Notification>("CreateZombieNefarianQuote", objArray1);
        }

        public void DestroyActiveNotification(float delaySeconds)
        {
            object[] objArray1 = new object[] { delaySeconds };
            base.method_8("DestroyActiveNotification", objArray1);
        }

        public void DestroyActiveQuote(float delaySeconds)
        {
            object[] objArray1 = new object[] { delaySeconds };
            base.method_8("DestroyActiveQuote", objArray1);
        }

        public void DestroyAllArrows()
        {
            base.method_8("DestroyAllArrows", Array.Empty<object>());
        }

        public void DestroyAllPopUps()
        {
            base.method_8("DestroyAllPopUps", Array.Empty<object>());
        }

        public void DestroyNotification(Triton.Game.Mapping.Notification notification, float delaySeconds)
        {
            object[] objArray1 = new object[] { notification, delaySeconds };
            base.method_8("DestroyNotification", objArray1);
        }

        public void DestroyNotificationNowWithNoAnim(Triton.Game.Mapping.Notification notification)
        {
            object[] objArray1 = new object[] { notification };
            base.method_8("DestroyNotificationNowWithNoAnim", objArray1);
        }

        public void DestroyNotificationWithText(string text, float delaySeconds)
        {
            object[] objArray1 = new object[] { text, delaySeconds };
            base.method_8("DestroyNotificationWithText", objArray1);
        }

        public void DestroyOtherNotifications(Triton.Game.Mapping.Notification.SpeechBubbleDirection direction)
        {
            object[] objArray1 = new object[] { direction };
            base.method_8("DestroyOtherNotifications", objArray1);
        }

        public void ForceAddSoundToPlayedList(string soundName)
        {
            object[] objArray1 = new object[] { soundName };
            base.method_8("ForceAddSoundToPlayedList", objArray1);
        }

        public void ForceRemoveSoundFromPlayedList(string soundName)
        {
            object[] objArray1 = new object[] { soundName };
            base.method_8("ForceRemoveSoundFromPlayedList", objArray1);
        }

        public static NotificationManager Get()
        {
            return MonoClass.smethod_15<NotificationManager>(TritonHs.MainAssemblyPath, "", "NotificationManager", "Get", Array.Empty<object>());
        }

        public bool HasSoundPlayedThisSession(string soundName)
        {
            object[] objArray1 = new object[] { soundName };
            return base.method_11<bool>("HasSoundPlayedThisSession", objArray1);
        }

        public void NukeNotification(Triton.Game.Mapping.Notification notification)
        {
            object[] objArray1 = new object[] { notification };
            base.method_8("NukeNotification", objArray1);
        }

        public void NukeNotificationWithoutPlayingAnim(Triton.Game.Mapping.Notification notification)
        {
            object[] objArray1 = new object[] { notification };
            base.method_8("NukeNotificationWithoutPlayingAnim", objArray1);
        }

        public void OnBigQuoteSoundLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnBigQuoteSoundLoaded", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnQuoteSoundLoaded(string name, GameObject go, object userData)
        {
            object[] objArray1 = new object[] { name, go, userData };
            base.method_8("OnQuoteSoundLoaded", objArray1);
        }

        public void PlayBigCharacterQuote(Triton.Game.Mapping.Notification quote, string text, string soundName, float durationSeconds)
        {
            object[] objArray1 = new object[] { quote, text, soundName, durationSeconds };
            base.method_8("PlayBigCharacterQuote", objArray1);
        }

        public void PlayCharacterQuote(Triton.Game.Mapping.Notification quote, Vector3 position, string text, string soundName, float durationSeconds, CanvasAnchor anchorPoint)
        {
            object[] objArray1 = new object[] { quote, position, text, soundName, durationSeconds, anchorPoint };
            base.method_8("PlayCharacterQuote", objArray1);
        }

        public void PlayQuoteWithoutSound(float durationSeconds)
        {
            object[] objArray1 = new object[] { durationSeconds };
            base.method_8("PlayQuoteWithoutSound", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static Vector3 ALT_ADVENTURE_SCREEN_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "NotificationManager", "ALT_ADVENTURE_SCREEN_POS");
            }
        }

        public List<Triton.Game.Mapping.Notification> arrows
        {
            get
            {
                Class267<Triton.Game.Mapping.Notification> class2 = base.method_3<Class267<Triton.Game.Mapping.Notification>>("arrows");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject bounceArrowPrefab
        {
            get
            {
                return base.method_3<GameObject>("bounceArrowPrefab");
            }
        }

        public static Vector3 DEFAULT_CHARACTER_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "NotificationManager", "DEFAULT_CHARACTER_POS");
            }
        }

        public static float DEFAULT_QUOTE_DURATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "NotificationManager", "DEFAULT_QUOTE_DURATION");
            }
        }

        public static float DEPTH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "NotificationManager", "DEPTH");
            }
        }

        public GameObject dialogBoxPrefab
        {
            get
            {
                return base.method_3<GameObject>("dialogBoxPrefab");
            }
        }

        public GameObject fadeArrowPrefab
        {
            get
            {
                return base.method_3<GameObject>("fadeArrowPrefab");
            }
        }

        public GameObject innkeeperQuotePrefab
        {
            get
            {
                return base.method_3<GameObject>("innkeeperQuotePrefab");
            }
        }

        public bool IsQuotePlaying
        {
            get
            {
                return base.method_11<bool>("get_IsQuotePlaying", Array.Empty<object>());
            }
        }

        public static string KT_PREFAB_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "NotificationManager", "KT_PREFAB_NAME");
            }
        }

        public Triton.Game.Mapping.Notification m_quote
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_quote");
            }
        }

        public List<string> m_quotesThisSession
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_quotesThisSession");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string NORMAL_NEFARIAN_PREFAB_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "NotificationManager", "NORMAL_NEFARIAN_PREFAB_NAME");
            }
        }

        public Vector3 NOTIFICATION_SCALE
        {
            get
            {
                return base.method_2<Vector3>("NOTIFICATION_SCALE");
            }
        }

        public Vector3 NOTIFICATION_SCALE_PHONE
        {
            get
            {
                return base.method_2<Vector3>("NOTIFICATION_SCALE_PHONE");
            }
        }

        public List<Triton.Game.Mapping.Notification> notificationsToDestroyUponNewNotifier
        {
            get
            {
                Class267<Triton.Game.Mapping.Notification> class2 = base.method_3<Class267<Triton.Game.Mapping.Notification>>("notificationsToDestroyUponNewNotifier");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static Vector3 PHONE_CHARACTER_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "NotificationManager", "PHONE_CHARACTER_POS");
            }
        }

        public Triton.Game.Mapping.Notification popUpDialog
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("popUpDialog");
            }
        }

        public GameObject popupTextPrefab
        {
            get
            {
                return base.method_3<GameObject>("popupTextPrefab");
            }
        }

        public List<Triton.Game.Mapping.Notification> popUpTexts
        {
            get
            {
                Class267<Triton.Game.Mapping.Notification> class2 = base.method_3<Class267<Triton.Game.Mapping.Notification>>("popUpTexts");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string RAGNAROS_PREFAB_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "NotificationManager", "RAGNAROS_PREFAB_NAME");
            }
        }

        public GameObject speechBubblePrefab
        {
            get
            {
                return base.method_3<GameObject>("speechBubblePrefab");
            }
        }

        public GameObject speechIndicatorPrefab
        {
            get
            {
                return base.method_3<GameObject>("speechIndicatorPrefab");
            }
        }

        public static string TIRION_PREFAB_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "NotificationManager", "TIRION_PREFAB_NAME");
            }
        }

        public static string ZOMBIE_NEFARIAN_PREFAB_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "NotificationManager", "ZOMBIE_NEFARIAN_PREFAB_NAME");
            }
        }

        [Attribute38("NotificationManager.QuoteSoundCallbackData")]
        public class QuoteSoundCallbackData : MonoClass
        {
            public QuoteSoundCallbackData(IntPtr address) : this(address, "QuoteSoundCallbackData")
            {
            }

            public QuoteSoundCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_durationSeconds
            {
                get
                {
                    return base.method_2<float>("m_durationSeconds");
                }
            }

            public Triton.Game.Mapping.Notification m_quote
            {
                get
                {
                    return base.method_3<Triton.Game.Mapping.Notification>("m_quote");
                }
            }
        }
    }
}


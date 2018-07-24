namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MissionEntity")]
    public class MissionEntity : GameEntity
    {
        public MissionEntity(IntPtr address) : this(address, "MissionEntity")
        {
        }

        public MissionEntity(IntPtr address, string className) : base(address, className)
        {
        }

        public void CycleNextResponseGroupIndex(EmoteResponseGroup responseGroup)
        {
            object[] objArray1 = new object[] { responseGroup };
            base.method_8("CycleNextResponseGroupIndex", objArray1);
        }

        public bool DoAlternateMulliganIntro()
        {
            return base.method_11<bool>("DoAlternateMulliganIntro", Array.Empty<object>());
        }

        public void HandleMissionEvent(int missionEvent)
        {
            object[] objArray1 = new object[] { missionEvent };
            base.method_8("HandleMissionEvent", objArray1);
        }

        public void HandleMulliganTagChange()
        {
            base.method_8("HandleMulliganTagChange", Array.Empty<object>());
        }

        public void HandleStartOfTurn(int turn)
        {
            object[] objArray1 = new object[] { turn };
            base.method_8("HandleStartOfTurn", objArray1);
        }

        public void InitEmoteResponses()
        {
            base.method_8("InitEmoteResponses", Array.Empty<object>());
        }

        public bool IsEnemySpeaking()
        {
            return base.method_11<bool>("IsEnemySpeaking", Array.Empty<object>());
        }

        public void NotifyOfFriendlyPlayedCard(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("NotifyOfFriendlyPlayedCard", objArray1);
        }

        public void NotifyOfGameOver(TAG_PLAYSTATE gameResult)
        {
            object[] objArray1 = new object[] { gameResult };
            base.method_8("NotifyOfGameOver", objArray1);
        }

        public void NotifyOfOpponentPlayedCard(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("NotifyOfOpponentPlayedCard", objArray1);
        }

        public void NotifyOfOpponentWillPlayCard(string cardId)
        {
            object[] objArray1 = new object[] { cardId };
            base.method_8("NotifyOfOpponentWillPlayCard", objArray1);
        }

        public void NotifyOfStartOfTurnEventsFinished()
        {
            base.method_8("NotifyOfStartOfTurnEventsFinished", Array.Empty<object>());
        }

        public void OnEmotePlayed(Card card, EmoteType emoteType, CardSoundSpell emoteSpell)
        {
            object[] objArray1 = new object[] { card, emoteType, emoteSpell };
            base.method_8("OnEmotePlayed", objArray1);
        }

        public void OnTagChanged(TagDelta change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnTagChanged", objArray1);
        }

        public void PlayEmoteResponse(EmoteType emoteType, CardSoundSpell emoteSpell)
        {
            object[] objArray1 = new object[] { emoteType, emoteSpell };
            base.method_8("PlayEmoteResponse", objArray1);
        }

        public void PlaySound(string audioName, float waitTimeScale, bool parentBubbleToActor, bool delayCardSoundSpells)
        {
            object[] objArray1 = new object[] { audioName, waitTimeScale, parentBubbleToActor, delayCardSoundSpells };
            base.method_8("PlaySound", objArray1);
        }

        public void SendCustomEvent(int eventID)
        {
            object[] objArray1 = new object[] { eventID };
            base.method_8("SendCustomEvent", objArray1);
        }

        public bool ShouldDelayCardSoundSpells()
        {
            return base.method_11<bool>("ShouldDelayCardSoundSpells", Array.Empty<object>());
        }

        public bool ShouldUseSecretClassNames()
        {
            return base.method_11<bool>("ShouldUseSecretClassNames", Array.Empty<object>());
        }

        public void ShowBubble(string textKey, Triton.Game.Mapping.Notification.SpeechBubbleDirection direction, Actor speakingActor, bool destroyOnNewNotification, float duration, bool parentToActor)
        {
            object[] objArray1 = new object[] { textKey, direction, speakingActor, destroyOnNewNotification, duration, parentToActor };
            base.method_8("ShowBubble", objArray1);
        }

        public bool m_delayCardSoundSpells
        {
            get
            {
                return base.method_2<bool>("m_delayCardSoundSpells");
            }
        }

        public List<EmoteResponseGroup> m_emoteResponseGroups
        {
            get
            {
                Class267<EmoteResponseGroup> class2 = base.method_3<Class267<EmoteResponseGroup>>("m_emoteResponseGroups");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_enemySpeaking
        {
            get
            {
                return base.method_2<bool>("m_enemySpeaking");
            }
        }

        public static List<EmoteType> STANDARD_EMOTE_RESPONSE_TRIGGERS
        {
            get
            {
                Class266<EmoteType> class2 = MonoClass.smethod_7<Class266<EmoteType>>(TritonHs.MainAssemblyPath, "", "MissionEntity", "STANDARD_EMOTE_RESPONSE_TRIGGERS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static float TIME_TO_WAIT_BEFORE_ENDING_QUOTE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MissionEntity", "TIME_TO_WAIT_BEFORE_ENDING_QUOTE");
            }
        }

        [Attribute38("MissionEntity.EmoteResponse")]
        public class EmoteResponse : MonoClass
        {
            public EmoteResponse(IntPtr address) : this(address, "EmoteResponse")
            {
            }

            public EmoteResponse(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_soundName
            {
                get
                {
                    return base.method_4("m_soundName");
                }
            }

            public string m_stringTag
            {
                get
                {
                    return base.method_4("m_stringTag");
                }
            }
        }

        [Attribute38("MissionEntity.EmoteResponseGroup")]
        public class EmoteResponseGroup : MonoClass
        {
            public EmoteResponseGroup(IntPtr address) : this(address, "EmoteResponseGroup")
            {
            }

            public EmoteResponseGroup(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_responseIndex
            {
                get
                {
                    return base.method_2<int>("m_responseIndex");
                }
            }

            public List<MissionEntity.EmoteResponse> m_responses
            {
                get
                {
                    Class267<MissionEntity.EmoteResponse> class2 = base.method_3<Class267<MissionEntity.EmoteResponse>>("m_responses");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public List<EmoteType> m_triggers
            {
                get
                {
                    Class266<EmoteType> class2 = base.method_3<Class266<EmoteType>>("m_triggers");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }
    }
}


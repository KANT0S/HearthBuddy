namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("JoustSpellController")]
    public class JoustSpellController : SpellController
    {
        public JoustSpellController(IntPtr address) : this(address, "JoustSpellController")
        {
        }

        public JoustSpellController(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerSourceAndTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AddPowerSourceAndTargets", objArray1);
        }

        public Jouster CreateJouster(Player player, Network.HistMetaData metaData)
        {
            object[] objArray1 = new object[] { player, metaData };
            return base.method_14<Jouster>("CreateJouster", objArray1);
        }

        public void CreateJousters()
        {
            base.method_8("CreateJousters", Array.Empty<object>());
        }

        public void DestroyJouster(Jouster jouster)
        {
            object[] objArray1 = new object[] { jouster };
            base.method_8("DestroyJouster", objArray1);
        }

        public void DestroyJousters()
        {
            base.method_8("DestroyJousters", Array.Empty<object>());
        }

        public void DetermineSourceJouster()
        {
            base.method_8("DetermineSourceJouster", Array.Empty<object>());
        }

        public void DetermineWinner(Network.HistMetaData metaData)
        {
            object[] objArray1 = new object[] { metaData };
            base.method_8("DetermineWinner", objArray1);
        }

        public void DriftJouster(Jouster jouster)
        {
            object[] objArray1 = new object[] { jouster };
            base.method_8("DriftJouster", objArray1);
        }

        public float GetRandomSec()
        {
            return base.method_11<float>("GetRandomSec", Array.Empty<object>());
        }

        public void HideJouster(Jouster jouster, float delaySec, float hideSec)
        {
            object[] objArray1 = new object[] { jouster, delaySec, hideSec };
            base.method_8("HideJouster", objArray1);
        }

        public bool IsJousterBusy(Jouster jouster)
        {
            object[] objArray1 = new object[] { jouster };
            return base.method_11<bool>("IsJousterBusy", objArray1);
        }

        public void OnProcessTaskList()
        {
            base.method_8("OnProcessTaskList", Array.Empty<object>());
        }

        public void PlayNoJousterSpell(Player player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("PlayNoJousterSpell", objArray1);
        }

        public bool PlaySpellOnActor(Jouster jouster, Actor actor, Spell spellPrefab)
        {
            object[] objArray1 = new object[] { jouster, actor, spellPrefab };
            return base.method_11<bool>("PlaySpellOnActor", objArray1);
        }

        public void RevealJouster(Jouster jouster, float revealSec)
        {
            object[] objArray1 = new object[] { jouster, revealSec };
            base.method_8("RevealJouster", objArray1);
        }

        public void ShowJouster(Jouster jouster, Vector3 localScale, Quaternion rotation, Vector3 position, float delaySec, float showSec)
        {
            object[] objArray1 = new object[] { jouster, localScale, rotation, position, delaySec, showSec };
            base.method_8("ShowJouster", objArray1);
        }

        public string m_DrawStingerPrefab
        {
            get
            {
                return base.method_4("m_DrawStingerPrefab");
            }
        }

        public float m_DriftCycleTime
        {
            get
            {
                return base.method_2<float>("m_DriftCycleTime");
            }
        }

        public string m_FriendlyBoneName
        {
            get
            {
                return base.method_4("m_FriendlyBoneName");
            }
        }

        public Jouster m_friendlyJouster
        {
            get
            {
                return base.method_3<Jouster>("m_friendlyJouster");
            }
        }

        public string m_HideSoundPrefab
        {
            get
            {
                return base.method_4("m_HideSoundPrefab");
            }
        }

        public string m_HideStingerPrefab
        {
            get
            {
                return base.method_4("m_HideStingerPrefab");
            }
        }

        public float m_HideTime
        {
            get
            {
                return base.method_2<float>("m_HideTime");
            }
        }

        public float m_HoldTime
        {
            get
            {
                return base.method_2<float>("m_HoldTime");
            }
        }

        public int m_joustTaskIndex
        {
            get
            {
                return base.method_2<int>("m_joustTaskIndex");
            }
        }

        public Spell m_LoserSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_LoserSpellPrefab");
            }
        }

        public Spell m_NoJousterSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_NoJousterSpellPrefab");
            }
        }

        public string m_OpponentBoneName
        {
            get
            {
                return base.method_4("m_OpponentBoneName");
            }
        }

        public Jouster m_opponentJouster
        {
            get
            {
                return base.method_3<Jouster>("m_opponentJouster");
            }
        }

        public float m_RandomSecMax
        {
            get
            {
                return base.method_2<float>("m_RandomSecMax");
            }
        }

        public float m_RandomSecMin
        {
            get
            {
                return base.method_2<float>("m_RandomSecMin");
            }
        }

        public iTween.EaseType m_RevealEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_RevealEaseType");
            }
        }

        public float m_RevealTime
        {
            get
            {
                return base.method_2<float>("m_RevealTime");
            }
        }

        public string m_ShowSoundPrefab
        {
            get
            {
                return base.method_4("m_ShowSoundPrefab");
            }
        }

        public float m_ShowTime
        {
            get
            {
                return base.method_2<float>("m_ShowTime");
            }
        }

        public Jouster m_sourceJouster
        {
            get
            {
                return base.method_3<Jouster>("m_sourceJouster");
            }
        }

        public Spell m_WinnerSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_WinnerSpellPrefab");
            }
        }

        public Jouster m_winningJouster
        {
            get
            {
                return base.method_3<Jouster>("m_winningJouster");
            }
        }

        [Attribute38("JoustSpellController.Jouster")]
        public class Jouster : MonoClass
        {
            public Jouster(IntPtr address) : this(address, "Jouster")
            {
            }

            public Jouster(IntPtr address, string className) : base(address, className)
            {
            }

            public Card m_card
            {
                get
                {
                    return base.method_3<Card>("m_card");
                }
            }

            public int m_deckIndex
            {
                get
                {
                    return base.method_2<int>("m_deckIndex");
                }
            }

            public int m_effectsPendingFinish
            {
                get
                {
                    return base.method_2<int>("m_effectsPendingFinish");
                }
            }

            public Actor m_initialActor
            {
                get
                {
                    return base.method_3<Actor>("m_initialActor");
                }
            }

            public Player m_player
            {
                get
                {
                    return base.method_3<Player>("m_player");
                }
            }

            public Actor m_revealedActor
            {
                get
                {
                    return base.method_3<Actor>("m_revealedActor");
                }
            }
        }
    }
}


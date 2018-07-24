namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HistoryManager")]
    public class HistoryManager : MonoBehaviour
    {
        public HistoryManager(IntPtr address) : this(address, "HistoryManager")
        {
        }

        public HistoryManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateVignetteIn()
        {
            base.method_8("AnimateVignetteIn", Array.Empty<object>());
        }

        public void AnimateVignetteOut()
        {
            base.method_8("AnimateVignetteOut", Array.Empty<object>());
        }

        public void AttackHistoryCardLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("AttackHistoryCardLoadedCallback", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BigCardLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("BigCardLoadedCallback", objArray1);
        }

        public void CheckForMouseOff()
        {
            base.method_8("CheckForMouseOff", Array.Empty<object>());
        }

        public void ChildLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("ChildLoadedCallback", objArray1);
        }

        public void CreateAttackTile(Triton.Game.Mapping.Entity attacker, Triton.Game.Mapping.Entity defender, PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { attacker, defender, taskList };
            base.method_8("CreateAttackTile", objArray1);
        }

        public void CreateCardPlayedTile(Triton.Game.Mapping.Entity playedEntity, Triton.Game.Mapping.Entity targetedEntity)
        {
            object[] objArray1 = new object[] { playedEntity, targetedEntity };
            base.method_8("CreateCardPlayedTile", objArray1);
        }

        public void CreateFatigueTile()
        {
            base.method_8("CreateFatigueTile", Array.Empty<object>());
        }

        public void CreateTriggerTile(Triton.Game.Mapping.Entity triggeredEntity)
        {
            object[] objArray1 = new object[] { triggeredEntity };
            base.method_8("CreateTriggerTile", objArray1);
        }

        public void DestroyBigCard()
        {
            base.method_8("DestroyBigCard", Array.Empty<object>());
        }

        public void DestroyHistoryTilesThatFallOffTheEnd()
        {
            base.method_8("DestroyHistoryTilesThatFallOffTheEnd", Array.Empty<object>());
        }

        public void DisableHistory()
        {
            base.method_8("DisableHistory", Array.Empty<object>());
        }

        public void FadeVignetteIn()
        {
            base.method_8("FadeVignetteIn", Array.Empty<object>());
        }

        public void FadeVignetteOut()
        {
            base.method_8("FadeVignetteOut", Array.Empty<object>());
        }

        public static HistoryManager Get()
        {
            return MonoClass.smethod_15<HistoryManager>(TritonHs.MainAssemblyPath, "", "HistoryManager", "Get", Array.Empty<object>());
        }

        public List<Vector3> GetBigCardPath()
        {
            Class246<Vector3> class2 = base.method_14<Class246<Vector3>>("GetBigCardPath", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Vector3 GetBigCardPosition()
        {
            return base.method_11<Vector3>("GetBigCardPosition", Array.Empty<object>());
        }

        public HistoryCard GetCurrentBigCard()
        {
            return base.method_14<HistoryCard>("GetCurrentBigCard", Array.Empty<object>());
        }

        public HistoryEntry GetCurrentHistoryEntry()
        {
            return base.method_14<HistoryEntry>("GetCurrentHistoryEntry", Array.Empty<object>());
        }

        public int GetIndexForTile(HistoryCard tile)
        {
            object[] objArray1 = new object[] { tile };
            return base.method_11<int>("GetIndexForTile", objArray1);
        }

        public int GetNumHistoryTiles()
        {
            return base.method_11<int>("GetNumHistoryTiles", Array.Empty<object>());
        }

        public Vector3 GetTopTilePosition()
        {
            return base.method_11<Vector3>("GetTopTilePosition", Array.Empty<object>());
        }

        public void HandleClickOnBigCard(HistoryCard card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("HandleClickOnBigCard", objArray1);
        }

        public bool HasBigCard()
        {
            return base.method_11<bool>("HasBigCard", Array.Empty<object>());
        }

        public bool IsDeadInLaterHistoryEntry(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsDeadInLaterHistoryEntry", objArray1);
        }

        public bool IsEntityTheAffectedCard(Triton.Game.Mapping.Entity entity, int index)
        {
            object[] objArray1 = new object[] { entity, index };
            return base.method_11<bool>("IsEntityTheAffectedCard", objArray1);
        }

        public bool IsEntityTheLastAttacker(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsEntityTheLastAttacker", objArray1);
        }

        public bool IsEntityTheLastCardPlayed(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsEntityTheLastCardPlayed", objArray1);
        }

        public bool IsEntityTheLastCardTargeted(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsEntityTheLastCardTargeted", objArray1);
        }

        public bool IsEntityTheLastDefender(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsEntityTheLastDefender", objArray1);
        }

        public void LoadNextHistoryEntry()
        {
            base.method_8("LoadNextHistoryEntry", Array.Empty<object>());
        }

        public void MarkCurrentHistoryEntryAsCompleted()
        {
            base.method_8("MarkCurrentHistoryEntryAsCompleted", Array.Empty<object>());
        }

        public void NotifyAboutAdditionalTarget(int entityID)
        {
            object[] objArray1 = new object[] { entityID };
            base.method_8("NotifyAboutAdditionalTarget", objArray1);
        }

        public void NotifyAboutArmorChanged(Triton.Game.Mapping.Entity entity, int newArmor)
        {
            object[] objArray1 = new object[] { entity, newArmor };
            base.method_8("NotifyAboutArmorChanged", objArray1);
        }

        public void NotifyAboutCardDeath(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("NotifyAboutCardDeath", objArray1);
        }

        public void NotifyAboutDamageChanged(Triton.Game.Mapping.Entity entity, int damage)
        {
            object[] objArray1 = new object[] { entity, damage };
            base.method_8("NotifyAboutDamageChanged", objArray1);
        }

        public void NotifyAboutPreDamage(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("NotifyAboutPreDamage", objArray1);
        }

        public void NotifyOfInput(float zPosition)
        {
            object[] objArray1 = new object[] { zPosition };
            base.method_8("NotifyOfInput", objArray1);
        }

        public void NotifyOfMouseOff()
        {
            base.method_8("NotifyOfMouseOff", Array.Empty<object>());
        }

        public void NotifyOfSecretSpellFinished()
        {
            base.method_8("NotifyOfSecretSpellFinished", Array.Empty<object>());
        }

        public void OnDesatInFinished()
        {
            base.method_8("OnDesatInFinished", Array.Empty<object>());
        }

        public void OnDesatOutFinished()
        {
            base.method_8("OnDesatOutFinished", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFullScreenEffectOutFinished()
        {
            base.method_8("OnFullScreenEffectOutFinished", Array.Empty<object>());
        }

        public void OnHistoryTileComplete()
        {
            base.method_8("OnHistoryTileComplete", Array.Empty<object>());
        }

        public void OnUpdateDesatVal(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("OnUpdateDesatVal", objArray1);
        }

        public void OnUpdateVignetteVal(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("OnUpdateVignetteVal", objArray1);
        }

        public void OnVignetteInFinished()
        {
            base.method_8("OnVignetteInFinished", Array.Empty<object>());
        }

        public void OnVignetteOutFinished()
        {
            base.method_8("OnVignetteOutFinished", Array.Empty<object>());
        }

        public void SetAsideTileAndTryToUpdate(HistoryCard tile)
        {
            object[] objArray1 = new object[] { tile };
            base.method_8("SetAsideTileAndTryToUpdate", objArray1);
        }

        public void SetBigCard(HistoryCard newCard, bool delayTimer)
        {
            object[] objArray1 = new object[] { newCard, delayTimer };
            base.method_8("SetBigCard", objArray1);
        }

        public void SetBigTileSize(float size)
        {
            object[] objArray1 = new object[] { size };
            base.method_8("SetBigTileSize", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartBigCardTimer()
        {
            base.method_8("StartBigCardTimer", Array.Empty<object>());
        }

        public void StopTimerAndKillBigCardNow()
        {
            base.method_8("StopTimerAndKillBigCardNow", Array.Empty<object>());
        }

        public void TileHistoryCardLoadedCallback(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("TileHistoryCardLoadedCallback", objArray1);
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public bool UserIsMousedOverAHistoryTile()
        {
            return base.method_11<bool>("UserIsMousedOverAHistoryTile", Array.Empty<object>());
        }

        public static float BATTLEFIELD_CARD_DISPLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryManager", "BATTLEFIELD_CARD_DISPLAY_TIME");
            }
        }

        public List<Vector3> bigCardPath
        {
            get
            {
                Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("bigCardPath");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public HistoryCard currentBigCard
        {
            get
            {
                return base.method_3<HistoryCard>("currentBigCard");
            }
        }

        public HistoryCard currentlyMousedOverTile
        {
            get
            {
                return base.method_3<HistoryCard>("currentlyMousedOverTile");
            }
        }

        public Texture fatigueTexture
        {
            get
            {
                return base.method_3<Texture>("fatigueTexture");
            }
        }

        public static float HERO_POWER_DISPLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryManager", "HERO_POWER_DISPLAY_TIME");
            }
        }

        public bool historyDisabled
        {
            get
            {
                return base.method_2<bool>("historyDisabled");
            }
        }

        public bool m_animatingDesat
        {
            get
            {
                return base.method_2<bool>("m_animatingDesat");
            }
        }

        public bool m_animatingVignette
        {
            get
            {
                return base.method_2<bool>("m_animatingVignette");
            }
        }

        public List<HistoryCard> m_historyTiles
        {
            get
            {
                Class267<HistoryCard> class2 = base.method_3<Class267<HistoryCard>>("m_historyTiles");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Texture m_hunterSecretTexture
        {
            get
            {
                return base.method_3<Texture>("m_hunterSecretTexture");
            }
        }

        public Texture m_mageSecretTexture
        {
            get
            {
                return base.method_3<Texture>("m_mageSecretTexture");
            }
        }

        public Texture m_paladinSecretTexture
        {
            get
            {
                return base.method_3<Texture>("m_paladinSecretTexture");
            }
        }

        public List<HistoryEntry> m_queuedEntries
        {
            get
            {
                Class267<HistoryEntry> class2 = base.method_3<Class267<HistoryEntry>>("m_queuedEntries");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public SoundDucker m_SoundDucker
        {
            get
            {
                return base.method_3<SoundDucker>("m_SoundDucker");
            }
        }

        public static float SECRET_CARD_DISPLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryManager", "SECRET_CARD_DISPLAY_TIME");
            }
        }

        public float sizeOfBigTile
        {
            get
            {
                return base.method_2<float>("sizeOfBigTile");
            }
        }

        public float SPACE_BETWEEN_TILES
        {
            get
            {
                return base.method_2<float>("SPACE_BETWEEN_TILES");
            }
        }

        public static float SPELL_CARD_DISPLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HistoryManager", "SPELL_CARD_DISPLAY_TIME");
            }
        }

        [Attribute38("HistoryManager.BigCardEntry")]
        public class BigCardEntry : MonoClass
        {
            public BigCardEntry(IntPtr address) : this(address, "BigCardEntry")
            {
            }

            public BigCardEntry(IntPtr address, string className) : base(address, className)
            {
            }

            public HistoryInfo cardInfo
            {
                get
                {
                    return base.method_3<HistoryInfo>("cardInfo");
                }
            }

            public bool waitForSecretSpell
            {
                get
                {
                    return base.method_2<bool>("waitForSecretSpell");
                }
            }

            public bool wasCountered
            {
                get
                {
                    return base.method_2<bool>("wasCountered");
                }
            }
        }

        [Attribute38("HistoryManager.HistoryCallbackData")]
        public class HistoryCallbackData : MonoClass
        {
            public HistoryCallbackData(IntPtr address) : this(address, "HistoryCallbackData")
            {
            }

            public HistoryCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public HistoryCard parentCard
            {
                get
                {
                    return base.method_3<HistoryCard>("parentCard");
                }
            }

            public HistoryInfo sourceCard
            {
                get
                {
                    return base.method_3<HistoryInfo>("sourceCard");
                }
            }
        }

        [Attribute38("HistoryManager.HistoryEntry")]
        public class HistoryEntry : MonoClass
        {
            public HistoryEntry(IntPtr address) : this(address, "HistoryEntry")
            {
            }

            public HistoryEntry(IntPtr address, string className) : base(address, className)
            {
            }

            public bool CanDuplicateAllEntities()
            {
                return base.method_11<bool>("CanDuplicateAllEntities", Array.Empty<object>());
            }

            public void DuplicateAllEntities()
            {
                base.method_8("DuplicateAllEntities", Array.Empty<object>());
            }

            public HistoryInfo GetSourceInfo()
            {
                return base.method_14<HistoryInfo>("GetSourceInfo", Array.Empty<object>());
            }

            public HistoryInfo GetTargetInfo()
            {
                return base.method_14<HistoryInfo>("GetTargetInfo", Array.Empty<object>());
            }

            public void SetAttacker(Triton.Game.Mapping.Entity attacker)
            {
                object[] objArray1 = new object[] { attacker };
                base.method_8("SetAttacker", objArray1);
            }

            public void SetCardPlayed(Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { entity };
                base.method_8("SetCardPlayed", objArray1);
            }

            public void SetCardTargeted(Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { entity };
                base.method_8("SetCardTargeted", objArray1);
            }

            public void SetCardTriggered(Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { entity };
                base.method_8("SetCardTriggered", objArray1);
            }

            public void SetDefender(Triton.Game.Mapping.Entity defender)
            {
                object[] objArray1 = new object[] { defender };
                base.method_8("SetDefender", objArray1);
            }

            public void SetFatigue()
            {
                base.method_8("SetFatigue", Array.Empty<object>());
            }

            public bool ShouldDuplicateEntity(HistoryInfo info)
            {
                object[] objArray1 = new object[] { info };
                return base.method_11<bool>("ShouldDuplicateEntity", objArray1);
            }

            public List<HistoryInfo> m_affectedCards
            {
                get
                {
                    Class267<HistoryInfo> class2 = base.method_3<Class267<HistoryInfo>>("m_affectedCards");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public bool m_complete
            {
                get
                {
                    return base.method_2<bool>("m_complete");
                }
            }

            public HistoryInfo m_fatigueInfo
            {
                get
                {
                    return base.method_3<HistoryInfo>("m_fatigueInfo");
                }
            }

            public HistoryInfo m_lastAttacker
            {
                get
                {
                    return base.method_3<HistoryInfo>("m_lastAttacker");
                }
            }

            public HistoryInfo m_lastCardPlayed
            {
                get
                {
                    return base.method_3<HistoryInfo>("m_lastCardPlayed");
                }
            }

            public HistoryInfo m_lastCardTargeted
            {
                get
                {
                    return base.method_3<HistoryInfo>("m_lastCardTargeted");
                }
            }

            public HistoryInfo m_lastCardTriggered
            {
                get
                {
                    return base.method_3<HistoryInfo>("m_lastCardTriggered");
                }
            }

            public HistoryInfo m_lastDefender
            {
                get
                {
                    return base.method_3<HistoryInfo>("m_lastDefender");
                }
            }
        }
    }
}


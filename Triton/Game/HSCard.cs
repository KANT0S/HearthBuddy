namespace Triton.Game
{
    using Buddy.Coroutines;
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;
    using Triton.Game.Mapping;

    public class HSCard
    {
        [CompilerGenerated]
        private Triton.Game.Mapping.Entity entity_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();

        internal HSCard(Triton.Game.Mapping.Card card)
        {
            this.Entity_0 = card.GetEntity();
        }

        internal HSCard(Triton.Game.Mapping.Entity entity)
        {
            this.Entity_0 = entity;
        }

        public void CancelTarget()
        {
            this.Card.Cancel();
        }

        [AsyncStateMachine(typeof(Struct98))]
        public Task DoAttack(HSCard attackee)
        {
            Struct98 struct2;
            struct2.hscard_0 = this;
            struct2.hscard_1 = attackee;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct98>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        [AsyncStateMachine(typeof(S=fyJ2zEw6^2OPg41D`1f\*yF$))]
        public Task DoTarget(HSCard target)
        {
            Struct97 struct2;
            struct2.hscard_0 = this;
            struct2.hscard_1 = target;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct97>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        public int GetTag(GAME_TAG tag)
        {
            return this.Entity_0.GetTag(tag);
        }

        public TAG_ZONE GetZone()
        {
            return this.Entity_0.GetZone();
        }

        public bool IsNull()
        {
            return (this.Entity_0 == null);
        }

        [AsyncStateMachine(typeof(Struct93))]
        public Task Pickup(int timeout = 500)
        {
            Struct93 struct2;
            struct2.hscard_0 = this;
            struct2.int_1 = timeout;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct93>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        public void ToggleMulliganState()
        {
            Client.LeftClickAt(Client.CardInteractPoint(this.Card));
        }

        [AsyncStateMachine(typeof(#kl3BmB<\*j%D^eJssr1n?B=F"))]
        public Task Use()
        {
            Struct94 struct2;
            struct2.hscard_0 = this;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct94>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        [AsyncStateMachine(typeof(Struct96))]
        public Task UseAt(int slot)
        {
            Struct96 struct2;
            struct2.int_1 = slot;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct96>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        [AsyncStateMachine(typeof(Struct95))]
        public Task UseOn(Triton.Game.Mapping.Card target)
        {
            Struct95 struct2;
            struct2.card_0 = target;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct95>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        public List<string> AttachedCardIds
        {
            get
            {
                return this.Entity_0.GetAttachments().Select<Triton.Game.Mapping.Entity, string>((Class238.<>9__108_0 ?? (Class238.<>9__108_0 = new Func<Triton.Game.Mapping.Entity, string>(Class238.<>9.method_1)))).ToList<string>();
            }
        }

        public List<HSCard> AttachedCards
        {
            get
            {
                return this.Entity_0.GetAttachments().Where<Triton.Game.Mapping.Entity>((Class238.<>9__110_0 ?? (Class238.<>9__110_0 = new Func<Triton.Game.Mapping.Entity, bool>(Class238.<>9.method_2)))).Select<Triton.Game.Mapping.Entity, HSCard>((Class238.<>9__110_1 ?? (Class238.<>9__110_1 = new Func<Triton.Game.Mapping.Entity, HSCard>(Class238.<>9.method_3)))).ToList<HSCard>();
            }
        }

        public List<int> AttachedEntitiesIds
        {
            get
            {
                return this.Entity_0.GetAttachments().Select<Triton.Game.Mapping.Entity, int>((Class238.<>9__106_0 ?? (Class238.<>9__106_0 = new Func<Triton.Game.Mapping.Entity, int>(Class238.<>9.method_0)))).ToList<int>();
            }
        }

        public int Attack
        {
            get
            {
                return this.Entity_0.GetRealTimeAttack();
            }
        }

        public bool CanAttack
        {
            get
            {
                return this.Entity_0.CanAttack();
            }
        }

        public bool CanBeAttacked
        {
            get
            {
                return this.Entity_0.CanBeAttacked();
            }
        }

        public bool CanBeDamaged
        {
            get
            {
                return this.Entity_0.CanBeDamaged();
            }
        }

        public bool CanBeTargeted
        {
            get
            {
                Actor actor = this.Card.GetActor();
                if (actor == null)
                {
                    return false;
                }
                if (actor.GetActorStateType() != ActorStateType.CARD_VALID_TARGET)
                {
                    return (actor.GetActorStateType() == ActorStateType.CARD_VALID_TARGET_MOUSE_OVER);
                }
                return true;
            }
        }

        public bool CanBeTargetedByAbilities
        {
            get
            {
                return this.Entity_0.CanBeTargetedByAbilities();
            }
        }

        public bool CanBeTargetedByHeroPowers
        {
            get
            {
                return this.Entity_0.CanBeTargetedByHeroPowers();
            }
        }

        public bool CanBeTargetedByOpponents
        {
            get
            {
                return this.Entity_0.CanBeTargetedByOpponents();
            }
        }

        public bool CanBeUsed
        {
            get
            {
                Actor actor = this.Card.GetActor();
                if (actor == null)
                {
                    return false;
                }
                if (((actor.GetActorStateType() != ActorStateType.CARD_PLAYABLE) && (actor.GetActorStateType() != ActorStateType.CARD_COMBO)) && (actor.GetActorStateType() != ActorStateType.CARD_PLAYABLE_MOUSE_OVER))
                {
                    return (actor.GetActorStateType() == ActorStateType.CARD_COMBO_MOUSE_OVER);
                }
                return true;
            }
        }

        public Triton.Game.Mapping.Card Card
        {
            get
            {
                return this.Entity_0.GetCard();
            }
        }

        public TAG_CLASS Class
        {
            get
            {
                return this.Entity_0.GetClass();
            }
        }

        public int ControllerId
        {
            get
            {
                return this.Entity_0.GetControllerId();
            }
        }

        public int Cost
        {
            get
            {
                return this.Entity_0.GetRealTimeCost();
            }
        }

        public int CreatorId
        {
            get
            {
                return this.Entity_0.GetCreatorId();
            }
        }

        public string DebugName
        {
            get
            {
                return this.Entity_0.GetDebugName();
            }
        }

        public int Durability
        {
            get
            {
                return this.Entity_0.GetDurability();
            }
        }

        internal Triton.Game.Mapping.Entity Entity_0
        {
            [CompilerGenerated]
            get
            {
                return this.entity_0;
            }
            [CompilerGenerated]
            private set
            {
                this.entity_0 = value;
            }
        }

        public int EntityId
        {
            get
            {
                return this.Entity_0.GetEntityId();
            }
        }

        public bool HasBattlecry
        {
            get
            {
                return this.Entity_0.HasBattlecry();
            }
        }

        public bool HasCharge
        {
            get
            {
                return this.Entity_0.HasCharge();
            }
        }

        public bool HasCombo
        {
            get
            {
                return this.Entity_0.HasCombo();
            }
        }

        public bool HasDeathrattle
        {
            get
            {
                return this.Entity_0.HasDeathrattle();
            }
        }

        public bool HasDivineShield
        {
            get
            {
                return this.Entity_0.HasDivineShield();
            }
        }

        public bool HasOverload
        {
            get
            {
                return this.Entity_0.HasOverload();
            }
        }

        public bool HasSpellPower
        {
            get
            {
                return this.Entity_0.HasSpellPower();
            }
        }

        public bool HasTaunt
        {
            get
            {
                if (!this.Entity_0.IsMinion())
                {
                    return false;
                }
                if (this.Card.GetZone() == GameState.Get().GetFriendlySidePlayer().GetHandZone())
                {
                    return this.Entity_0.HasTaunt();
                }
                if ((this.Card.GetActor() == null) || (!this.Card.GetActor().IsSpellActive(SpellType.TAUNT) && !this.Card.GetActor().IsSpellActive(SpellType.TAUNT_PREMIUM)))
                {
                    return false;
                }
                return true;
            }
        }

        public bool HasWindfury
        {
            get
            {
                return this.Entity_0.HasWindfury();
            }
        }

        public int Health
        {
            get
            {
                return this.Entity_0.GetRealTimeRemainingHP();
            }
        }

        public string Id
        {
            get
            {
                return this.Entity_0.GetCardId();
            }
        }

        public bool IsAffectedBySpellPower
        {
            get
            {
                return this.Entity_0.IsAffectedBySpellPower();
            }
        }

        public bool IsAsleep
        {
            get
            {
                return this.Entity_0.IsAsleep();
            }
        }

        public bool IsAttached
        {
            get
            {
                return this.Entity_0.IsAttached();
            }
        }

        public bool IsDamaged
        {
            get
            {
                return this.Entity_0.IsDamaged();
            }
        }

        public bool IsElite
        {
            get
            {
                return this.Entity_0.IsElite();
            }
        }

        public bool IsEnchantment
        {
            get
            {
                return this.Entity_0.IsEnchantment();
            }
        }

        public bool IsEnraged
        {
            get
            {
                return this.Entity_0.IsEnraged();
            }
        }

        public bool IsExhausted
        {
            get
            {
                return this.Entity_0.IsExhausted();
            }
        }

        public bool IsFreeze
        {
            get
            {
                return this.Entity_0.IsFreeze();
            }
        }

        public bool IsFrozen
        {
            get
            {
                return this.Entity_0.IsFrozen();
            }
        }

        public bool IsHero
        {
            get
            {
                return this.Entity_0.IsHero();
            }
        }

        public bool IsHeroPower
        {
            get
            {
                return this.Entity_0.IsHeroPower();
            }
        }

        public bool IsImmune
        {
            get
            {
                return this.Entity_0.IsImmune();
            }
        }

        public bool IsMagnet
        {
            get
            {
                return this.Entity_0.IsMagnet();
            }
        }

        public bool IsMinion
        {
            get
            {
                return this.Entity_0.IsMinion();
            }
        }

        public bool IsPoisonous
        {
            get
            {
                return this.Entity_0.IsPoisonous();
            }
        }

        public bool IsRecentlyArrived
        {
            get
            {
                return this.Entity_0.IsRecentlyArrived();
            }
        }

        public bool IsSecret
        {
            get
            {
                return this.Entity_0.IsSecret();
            }
        }

        public bool IsSilenced
        {
            get
            {
                return this.Entity_0.IsSilenced();
            }
        }

        public bool IsSpell
        {
            get
            {
                return this.Entity_0.IsSpell();
            }
        }

        public bool IsStealthed
        {
            get
            {
                return this.Entity_0.IsStealthed();
            }
        }

        public bool IsWeapon
        {
            get
            {
                return this.Entity_0.IsWeapon();
            }
        }

        public int MaxHp
        {
            get
            {
                return this.Entity_0.GetOriginalHealth();
            }
        }

        public string Name
        {
            get
            {
                return this.Entity_0.GetName();
            }
        }

        public int NumAttackThisTurn
        {
            get
            {
                return this.Entity_0.GetNumAttacksThisTurn();
            }
        }

        public int OriginalATK
        {
            get
            {
                return this.Entity_0.GetOriginalATK();
            }
        }

        public bool OriginalCharge
        {
            get
            {
                return this.Entity_0.GetOriginalCharge();
            }
        }

        public int OriginalCost
        {
            get
            {
                return this.Entity_0.GetOriginalCost();
            }
        }

        public int OriginalDurability
        {
            get
            {
                return this.Entity_0.GetOriginalDurability();
            }
        }

        public int OriginalHealth
        {
            get
            {
                return this.Entity_0.GetOriginalHealth();
            }
        }

        public TAG_RACE Race
        {
            get
            {
                return this.Entity_0.GetRace();
            }
        }

        public TAG_RARITY Rarity
        {
            get
            {
                return this.Entity_0.GetRarity();
            }
        }

        public int ZonePosition
        {
            get
            {
                return this.Entity_0.GetZonePosition();
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class238
        {
            public static readonly HSCard.Class238 <>9 = new HSCard.Class238();
            public static Func<Triton.Game.Mapping.Entity, int> <>9__106_0;
            public static Func<Triton.Game.Mapping.Entity, string> <>9__108_0;
            public static Func<Triton.Game.Mapping.Entity, bool> <>9__110_0;
            public static Func<Triton.Game.Mapping.Entity, HSCard> <>9__110_1;

            internal int method_0(Triton.Game.Mapping.Entity entity_0)
            {
                return entity_0.GetEntityId();
            }

            internal string method_1(Triton.Game.Mapping.Entity entity_0)
            {
                return entity_0.GetCardId();
            }

            internal bool method_2(Triton.Game.Mapping.Entity entity_0)
            {
                return (entity_0 > null);
            }

            internal HSCard method_3(Triton.Game.Mapping.Entity entity_0)
            {
                return new HSCard(entity_0);
            }
        }

        [CompilerGenerated]
        private struct Struct93 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            private bool bool_0;
            public HSCard hscard_0;
            public int int_0;
            public int int_1;
            private Stopwatch stopwatch_0;
            private TaskAwaiter taskAwaiter_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        if (num != 1)
                        {
                            awaiter = this.hscard_0.Card.DoGrab().GetAwaiter();
                            if (!awaiter.IsCompleted)
                            {
                                num = 0;
                                this.int_0 = 0;
                                this.taskAwaiter_0 = awaiter;
                                this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct93>(ref awaiter, ref this);
                                return;
                            }
                            goto Label_008A;
                        }
                        awaiter = this.taskAwaiter_0;
                        this.taskAwaiter_0 = new TaskAwaiter();
                        num = -1;
                        this.int_0 = -1;
                        goto Label_00C3;
                    }
                    awaiter = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                Label_008A:
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                    this.stopwatch_0 = Stopwatch.StartNew();
                    this.bool_0 = false;
                    while (this.stopwatch_0.ElapsedMilliseconds < this.int_1)
                    {
                        awaiter = Coroutine.Sleep(100).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            goto Label_00F4;
                        }
                    Label_00C3:
                        awaiter.GetResult();
                        awaiter = new TaskAwaiter();
                        if (InputManager.Get().GetHeldCard() != null)
                        {
                            goto Label_0114;
                        }
                    }
                    goto Label_011B;
                Label_00F4:
                    num = 1;
                    this.int_0 = 1;
                    this.taskAwaiter_0 = awaiter;
                    this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct93>(ref awaiter, ref this);
                    return;
                Label_0114:
                    this.bool_0 = true;
                Label_011B:
                    if (this.bool_0)
                    {
                        HSCard.ilog_0.InfoFormat("[Pickup] The card was picked up in {0} ms.", this.stopwatch_0.ElapsedMilliseconds);
                    }
                    else
                    {
                        HSCard.ilog_0.InfoFormat("[Pickup] The card was not able to be picked up in {0} ms.", this.int_1);
                    }
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }

        [CompilerGenerated]
        private struct Struct94 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            public HSCard hscard_0;
            public int int_0;
            private TaskAwaiter taskAwaiter_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        awaiter = this.hscard_0.UseOn(GameState.Get().GetFriendlySidePlayer().GetHeroCard()).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = 0;
                            this.int_0 = 0;
                            this.taskAwaiter_0 = awaiter;
                            this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct94>(ref awaiter, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = this.taskAwaiter_0;
                        this.taskAwaiter_0 = new TaskAwaiter();
                        num = -1;
                        this.int_0 = -1;
                    }
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }

        [CompilerGenerated]
        private struct Struct95 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            public Card card_0;
            public int int_0;
            private TaskAwaiter taskAwaiter_0;
            private Vector3 vector3_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        this.vector3_0 = Client.CardInteractPoint(this.card_0);
                        awaiter = Client.MoveCursorHumanLike(this.vector3_0).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = 0;
                            this.int_0 = 0;
                            this.taskAwaiter_0 = awaiter;
                            this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct95>(ref awaiter, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = this.taskAwaiter_0;
                        this.taskAwaiter_0 = new TaskAwaiter();
                        num = -1;
                        this.int_0 = -1;
                    }
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                    Client.LeftClickAt(this.vector3_0);
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }

        [CompilerGenerated]
        private struct Struct96 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            public int int_0;
            public int int_1;
            private int int_2;
            private TaskAwaiter taskAwaiter_0;
            private Vector3 vector3_0;
            private Vector3 vector3_1;
            private Vector3 vector3_2;
            private ZonePlay zonePlay_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    TaskAwaiter awaiter;
                    switch (num)
                    {
                        case 0:
                            break;

                        case 1:
                            goto Label_01FD;

                        case 2:
                            goto Label_0264;

                        case 3:
                            goto Label_029F;

                        case 4:
                            goto Label_0303;

                        default:
                        {
                            HSCard.ilog_0.InfoFormat("[UseAt] {0}", this.int_1);
                            this.zonePlay_0 = GameState.Get().GetFriendlySidePlayer().GetBattlefieldZone();
                            List<Card> cards = this.zonePlay_0.m_cards;
                            this.int_2 = cards.Count;
                            if (this.int_2 == 0)
                            {
                                this.vector3_0 = this.zonePlay_0.GetCardPosition(0);
                                awaiter = Client.MoveCursorHumanLike(this.vector3_0).GetAwaiter();
                                if (awaiter.IsCompleted)
                                {
                                    goto Label_01DE;
                                }
                                num = 0;
                                this.int_0 = 0;
                                this.taskAwaiter_0 = awaiter;
                                this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct96>(ref awaiter, ref this);
                            }
                            else if (this.int_1 > this.int_2)
                            {
                                this.vector3_1 = this.zonePlay_0.GetCardPosition((int) (this.int_2 - 1));
                                this.vector3_1.X += this.zonePlay_0.m_slotWidth / 2f;
                                awaiter = Client.MoveCursorHumanLike(this.vector3_1).GetAwaiter();
                                if (awaiter.IsCompleted)
                                {
                                    goto Label_0219;
                                }
                                num = 1;
                                this.int_0 = 1;
                                this.taskAwaiter_0 = awaiter;
                                this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct96>(ref awaiter, ref this);
                            }
                            else
                            {
                                this.vector3_2 = this.zonePlay_0.GetCardPosition((int) (this.int_1 - 1));
                                this.vector3_2.X -= this.zonePlay_0.m_slotWidth / 2f;
                                awaiter = Client.MoveCursorHumanLike(this.vector3_2).GetAwaiter();
                                if (awaiter.IsCompleted)
                                {
                                    goto Label_02BB;
                                }
                                num = 3;
                                this.int_0 = 3;
                                this.taskAwaiter_0 = awaiter;
                                this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct96>(ref awaiter, ref this);
                            }
                            return;
                        }
                    }
                    awaiter = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                Label_01DE:
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                    Client.LeftClickAt(this.vector3_0);
                    goto Label_0352;
                Label_01FD:
                    awaiter = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                Label_0219:
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                    awaiter = Coroutine.Sleep(250).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto Label_0280;
                    }
                    num = 2;
                    this.int_0 = 2;
                    this.taskAwaiter_0 = awaiter;
                    this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct96>(ref awaiter, ref this);
                    return;
                Label_0264:
                    awaiter = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                Label_0280:
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                    Client.LeftClickAt(this.vector3_1);
                    goto Label_0352;
                Label_029F:
                    awaiter = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                Label_02BB:
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                    awaiter = Coroutine.Sleep(250).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto Label_031F;
                    }
                    num = 4;
                    this.int_0 = 4;
                    this.taskAwaiter_0 = awaiter;
                    this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct96>(ref awaiter, ref this);
                    return;
                Label_0303:
                    awaiter = this.taskAwaiter_0;
                    this.taskAwaiter_0 = new TaskAwaiter();
                    num = -1;
                    this.int_0 = -1;
                Label_031F:
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                    Client.LeftClickAt(this.vector3_2);
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
            Label_0352:
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }

        [CompilerGenerated]
        private struct Struct97 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            public HSCard hscard_0;
            public HSCard hscard_1;
            public int int_0;
            private TaskAwaiter taskAwaiter_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        awaiter = this.hscard_0.Card.DoTargeting(this.hscard_1.Card).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = 0;
                            this.int_0 = 0;
                            this.taskAwaiter_0 = awaiter;
                            this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct97>(ref awaiter, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = this.taskAwaiter_0;
                        this.taskAwaiter_0 = new TaskAwaiter();
                        num = -1;
                        this.int_0 = -1;
                    }
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }

        [CompilerGenerated]
        private struct Struct98 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            public HSCard hscard_0;
            public HSCard hscard_1;
            public int int_0;
            private TaskAwaiter taskAwaiter_0;

            private void MoveNext()
            {
                int num = this.int_0;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        awaiter = this.hscard_0.Card.DoAttack(this.hscard_1.Card).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = 0;
                            this.int_0 = 0;
                            this.taskAwaiter_0 = awaiter;
                            this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, HSCard.Struct98>(ref awaiter, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = this.taskAwaiter_0;
                        this.taskAwaiter_0 = new TaskAwaiter();
                        num = -1;
                        this.int_0 = -1;
                    }
                    awaiter.GetResult();
                    awaiter = new TaskAwaiter();
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                    return;
                }
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }
    }
}


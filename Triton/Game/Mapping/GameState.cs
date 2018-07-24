namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameState")]
    public class GameState : MonoClass
    {
        public GameState(IntPtr address) : this(address, "GameState")
        {
        }

        public GameState(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddChosenEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("AddChosenEntity", objArray1);
        }

        public void AddEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("AddEntity", objArray1);
        }

        public void AddPlayer(Player player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("AddPlayer", objArray1);
        }

        public void AddServerBlockingSpell(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            base.method_8("AddServerBlockingSpell", objArray1);
        }

        public void AddServerBlockingSpellController(SpellController spellController)
        {
            object[] objArray1 = new object[] { spellController };
            base.method_8("AddServerBlockingSpellController", objArray1);
        }

        public string BuildBlockingServerCausesString()
        {
            return base.method_13("BuildBlockingServerCausesString", Array.Empty<object>());
        }

        public void CancelCurrentOptionMode()
        {
            base.method_8("CancelCurrentOptionMode", Array.Empty<object>());
        }

        public void CancelSelectedOptionProposedMana()
        {
            base.method_8("CancelSelectedOptionProposedMana", Array.Empty<object>());
        }

        public bool CanProcessEntitiesChosen(Network.EntitiesChosen chosen)
        {
            object[] objArray1 = new object[] { chosen };
            return base.method_11<bool>("CanProcessEntitiesChosen", objArray1);
        }

        public bool CanProcessEntityChoices(Network.EntityChoices choices)
        {
            object[] objArray1 = new object[] { choices };
            return base.method_11<bool>("CanProcessEntityChoices", objArray1);
        }

        public bool ClearCardBeingDrawn(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("ClearCardBeingDrawn", objArray1);
        }

        public void ClearFriendlyChoices()
        {
            base.method_8("ClearFriendlyChoices", Array.Empty<object>());
        }

        public void ClearLastOptions()
        {
            base.method_8("ClearLastOptions", Array.Empty<object>());
        }

        public void ClearOptions()
        {
            base.method_8("ClearOptions", Array.Empty<object>());
        }

        public void ClearResponseMode()
        {
            base.method_8("ClearResponseMode", Array.Empty<object>());
        }

        public void Concede()
        {
            base.method_8("Concede", Array.Empty<object>());
        }

        public PlayErrors.GameStateInfo ConvertToGameStateInfo()
        {
            return base.method_14<PlayErrors.GameStateInfo>("ConvertToGameStateInfo", Array.Empty<object>());
        }

        public void DebugNukeServerBlocks()
        {
            base.method_8("DebugNukeServerBlocks", Array.Empty<object>());
        }

        public void DebugPrintEntitiesChosen(Network.EntitiesChosen chosen)
        {
            object[] objArray1 = new object[] { chosen };
            base.method_8("DebugPrintEntitiesChosen", objArray1);
        }

        public void DebugPrintEntityChoices(Network.EntityChoices choices, PowerTaskList preChoiceTaskList)
        {
            object[] objArray1 = new object[] { choices, preChoiceTaskList };
            base.method_8("DebugPrintEntityChoices", objArray1);
        }

        public void DebugPrintOptions()
        {
            base.method_8("DebugPrintOptions", Array.Empty<object>());
        }

        public void DebugPrintPower(Logger logger, string callerName, Network.PowerHistory power)
        {
            object[] objArray1 = new object[] { logger, callerName, power };
            base.method_9("DebugPrintPower", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void DebugPrintTags(Logger logger, string callerName, string indentation, Network.Entity netEntity)
        {
            object[] objArray1 = new object[] { logger, callerName, indentation, netEntity };
            base.method_8("DebugPrintTags", objArray1);
        }

        public void DebugSetGameEntity(GameEntity gameEntity)
        {
            object[] objArray1 = new object[] { gameEntity };
            base.method_8("DebugSetGameEntity", objArray1);
        }

        public void EnterChoiceMode()
        {
            base.method_8("EnterChoiceMode", Array.Empty<object>());
        }

        public void EnterMainOptionMode()
        {
            base.method_8("EnterMainOptionMode", Array.Empty<object>());
        }

        public void EnterOptionTargetMode()
        {
            base.method_8("EnterOptionTargetMode", Array.Empty<object>());
        }

        public void EnterSubOptionMode()
        {
            base.method_8("EnterSubOptionMode", Array.Empty<object>());
        }

        public bool EntityHasSubOptions(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("EntityHasSubOptions", objArray1);
        }

        public bool EntityHasTargets(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_10<bool>("EntityHasTargets", enumArray1, objArray1);
        }

        public bool EntityHasTargets(Triton.Game.Mapping.Entity entity, bool isSubEntity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { entity, isSubEntity };
            return base.method_10<bool>("EntityHasTargets", enumArray1, objArray1);
        }

        public void FireCreateGameEvent()
        {
            base.method_8("FireCreateGameEvent", Array.Empty<object>());
        }

        public void FireCurrentPlayerChangedEvent(Player player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("FireCurrentPlayerChangedEvent", objArray1);
        }

        public bool FireEntitiesChosenReceivedEvent(Network.EntitiesChosen chosen)
        {
            object[] objArray1 = new object[] { chosen };
            return base.method_11<bool>("FireEntitiesChosenReceivedEvent", objArray1);
        }

        public void FireEntityChoicesReceivedEvent(Network.EntityChoices choices, PowerTaskList preChoiceTaskList)
        {
            object[] objArray1 = new object[] { choices, preChoiceTaskList };
            base.method_8("FireEntityChoicesReceivedEvent", objArray1);
        }

        public void FireGameOverEvent()
        {
            base.method_8("FireGameOverEvent", Array.Empty<object>());
        }

        public static void FireGameStateInitializedEvent()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "GameState", "FireGameStateInitializedEvent");
        }

        public void FireOptionsReceivedEvent()
        {
            base.method_8("FireOptionsReceivedEvent", Array.Empty<object>());
        }

        public void FireTurnChangedEvent(int oldTurn, int newTurn)
        {
            object[] objArray1 = new object[] { oldTurn, newTurn };
            base.method_8("FireTurnChangedEvent", objArray1);
        }

        public void FireTurnTimerUpdateEvent(TurnTimerUpdate update)
        {
            object[] objArray1 = new object[] { update };
            base.method_8("FireTurnTimerUpdateEvent", objArray1);
        }

        public bool FriendlyHeroIsTargetable()
        {
            return base.method_11<bool>("FriendlyHeroIsTargetable", Array.Empty<object>());
        }

        public static GameState Get()
        {
            return MonoClass.smethod_15<GameState>(TritonHs.MainAssemblyPath, "", "GameState", "Get", Array.Empty<object>());
        }

        public List<Triton.Game.Mapping.Entity> GetChosenEntities()
        {
            Class267<Triton.Game.Mapping.Entity> class2 = base.method_14<Class267<Triton.Game.Mapping.Entity>>("GetChosenEntities", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public CreateGamePhase GetCreateGamePhase()
        {
            return base.method_11<CreateGamePhase>("GetCreateGamePhase", Array.Empty<object>());
        }

        public Player GetCurrentPlayer()
        {
            return base.method_14<Player>("GetCurrentPlayer", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetEntity(int id)
        {
            object[] objArray1 = new object[] { id };
            return base.method_14<Triton.Game.Mapping.Entity>("GetEntity", objArray1);
        }

        public Network.EntityChoices GetEntityChoices(int playerId)
        {
            object[] objArray1 = new object[] { playerId };
            return base.method_14<Network.EntityChoices>("GetEntityChoices", objArray1);
        }

        public Player GetFirstOpponentPlayer(Player player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_14<Player>("GetFirstOpponentPlayer", objArray1);
        }

        public Card GetFriendlyCardBeingDrawn()
        {
            return base.method_14<Card>("GetFriendlyCardBeingDrawn", Array.Empty<object>());
        }

        public Network.EntityChoices GetFriendlyEntityChoices()
        {
            return base.method_14<Network.EntityChoices>("GetFriendlyEntityChoices", Array.Empty<object>());
        }

        public int GetFriendlyPlayerId()
        {
            return base.method_11<int>("GetFriendlyPlayerId", Array.Empty<object>());
        }

        public Player GetFriendlySidePlayer()
        {
            return base.method_14<Player>("GetFriendlySidePlayer", Array.Empty<object>());
        }

        public GameEntity GetGameEntity()
        {
            return base.method_14<GameEntity>("GetGameEntity", Array.Empty<object>());
        }

        public Network.Options GetLastOptions()
        {
            return base.method_14<Network.Options>("GetLastOptions", Array.Empty<object>());
        }

        public int GetLastTurnRemindedOfFullHand()
        {
            return base.method_11<int>("GetLastTurnRemindedOfFullHand", Array.Empty<object>());
        }

        public int GetMaxFriendlyMinionsPerPlayer()
        {
            return base.method_11<int>("GetMaxFriendlyMinionsPerPlayer", Array.Empty<object>());
        }

        public int GetMaxSecretsPerPlayer()
        {
            return base.method_11<int>("GetMaxSecretsPerPlayer", Array.Empty<object>());
        }

        public Card GetOpponentCardBeingDrawn()
        {
            return base.method_14<Card>("GetOpponentCardBeingDrawn", Array.Empty<object>());
        }

        public Network.EntityChoices GetOpponentEntityChoices()
        {
            return base.method_14<Network.EntityChoices>("GetOpponentEntityChoices", Array.Empty<object>());
        }

        public int GetOpposingPlayerId()
        {
            return base.method_11<int>("GetOpposingPlayerId", Array.Empty<object>());
        }

        public Player GetOpposingSidePlayer()
        {
            return base.method_14<Player>("GetOpposingSidePlayer", Array.Empty<object>());
        }

        public Network.Options GetOptionsPacket()
        {
            return base.method_14<Network.Options>("GetOptionsPacket", Array.Empty<object>());
        }

        public Player GetPlayer(int id)
        {
            object[] objArray1 = new object[] { id };
            return base.method_14<Player>("GetPlayer", objArray1);
        }

        public PowerProcessor GetPowerProcessor()
        {
            return base.method_14<PowerProcessor>("GetPowerProcessor", Array.Empty<object>());
        }

        public object GetPrintableEntity(int id)
        {
            object[] objArray1 = new object[] { id };
            return base.method_14<object>("GetPrintableEntity", objArray1);
        }

        public Network.HistTagChange GetRealTimeGameOverTagChange()
        {
            return base.method_14<Network.HistTagChange>("GetRealTimeGameOverTagChange", Array.Empty<object>());
        }

        public ResponseMode GetResponseMode()
        {
            return base.method_11<ResponseMode>("GetResponseMode", Array.Empty<object>());
        }

        public Network.Options.Option GetSelectedNetworkOption()
        {
            return base.method_14<Network.Options.Option>("GetSelectedNetworkOption", Array.Empty<object>());
        }

        public Network.Options.Option.SubOption GetSelectedNetworkSubOption()
        {
            return base.method_14<Network.Options.Option.SubOption>("GetSelectedNetworkSubOption", Array.Empty<object>());
        }

        public int GetSelectedOption()
        {
            return base.method_11<int>("GetSelectedOption", Array.Empty<object>());
        }

        public int GetSelectedOptionPosition()
        {
            return base.method_11<int>("GetSelectedOptionPosition", Array.Empty<object>());
        }

        public int GetSelectedOptionTarget()
        {
            return base.method_11<int>("GetSelectedOptionTarget", Array.Empty<object>());
        }

        public int GetSelectedSubOption()
        {
            return base.method_11<int>("GetSelectedSubOption", Array.Empty<object>());
        }

        public int GetTurn()
        {
            return base.method_11<int>("GetTurn", Array.Empty<object>());
        }

        public bool HasHandPlays()
        {
            return base.method_11<bool>("HasHandPlays", Array.Empty<object>());
        }

        public bool HasResponse(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("HasResponse", objArray1);
        }

        public bool HasSubOptions(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("HasSubOptions", objArray1);
        }

        public bool HasTheCoinBeenSpawned()
        {
            return base.method_11<bool>("HasTheCoinBeenSpawned", Array.Empty<object>());
        }

        public static GameState Initialize()
        {
            return MonoClass.smethod_15<GameState>(TritonHs.MainAssemblyPath, "", "GameState", "Initialize", Array.Empty<object>());
        }

        public bool IsBeginPhase()
        {
            return base.method_11<bool>("IsBeginPhase", Array.Empty<object>());
        }

        public bool IsBeingDrawn(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsBeingDrawn", objArray1);
        }

        public bool IsBlockingServer()
        {
            return base.method_11<bool>("IsBlockingServer", Array.Empty<object>());
        }

        public bool IsBlockingServerImpl()
        {
            return base.method_11<bool>("IsBlockingServerImpl", Array.Empty<object>());
        }

        public bool IsBusy()
        {
            return base.method_11<bool>("IsBusy", Array.Empty<object>());
        }

        public bool IsChoice(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsChoice", objArray1);
        }

        public bool IsChoosableEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsChoosableEntity", objArray1);
        }

        public bool IsChosenEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsChosenEntity", objArray1);
        }

        public bool IsConcedingAllowed()
        {
            return base.method_11<bool>("IsConcedingAllowed", Array.Empty<object>());
        }

        public bool IsEntityInputEnabled(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsEntityInputEnabled", objArray1);
        }

        public bool IsFriendlySidePlayerTurn()
        {
            return base.method_11<bool>("IsFriendlySidePlayerTurn", Array.Empty<object>());
        }

        public bool IsGameCreated()
        {
            return base.method_11<bool>("IsGameCreated", Array.Empty<object>());
        }

        public bool IsGameCreatedOrCreating()
        {
            return base.method_11<bool>("IsGameCreatedOrCreating", Array.Empty<object>());
        }

        public bool IsGameCreating()
        {
            return base.method_11<bool>("IsGameCreating", Array.Empty<object>());
        }

        public bool IsGameOver()
        {
            return base.method_11<bool>("IsGameOver", Array.Empty<object>());
        }

        public bool IsGameOverNowOrPending()
        {
            return base.method_11<bool>("IsGameOverNowOrPending", Array.Empty<object>());
        }

        public bool IsGameOverPending()
        {
            return base.method_11<bool>("IsGameOverPending", Array.Empty<object>());
        }

        public bool IsInChoiceMode()
        {
            return base.method_11<bool>("IsInChoiceMode", Array.Empty<object>());
        }

        public bool IsInMainOptionMode()
        {
            return base.method_11<bool>("IsInMainOptionMode", Array.Empty<object>());
        }

        public bool IsInSubOptionMode()
        {
            return base.method_11<bool>("IsInSubOptionMode", Array.Empty<object>());
        }

        public bool IsInTargetMode()
        {
            return base.method_11<bool>("IsInTargetMode", Array.Empty<object>());
        }

        public bool IsMainPhase()
        {
            return base.method_11<bool>("IsMainPhase", Array.Empty<object>());
        }

        public bool IsMulliganBlockingPowers()
        {
            return base.method_11<bool>("IsMulliganBlockingPowers", Array.Empty<object>());
        }

        public bool IsMulliganManagerActive()
        {
            return base.method_11<bool>("IsMulliganManagerActive", Array.Empty<object>());
        }

        public bool IsMulliganPhase()
        {
            return base.method_11<bool>("IsMulliganPhase", Array.Empty<object>());
        }

        public bool IsMulliganPhaseNowOrPending()
        {
            return base.method_11<bool>("IsMulliganPhaseNowOrPending", Array.Empty<object>());
        }

        public bool IsMulliganPhasePending()
        {
            return base.method_11<bool>("IsMulliganPhasePending", Array.Empty<object>());
        }

        public bool IsOption(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsOption", objArray1);
        }

        public bool IsOptionTarget(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsOptionTarget", objArray1);
        }

        public bool IsPastBeginPhase()
        {
            return base.method_11<bool>("IsPastBeginPhase", Array.Empty<object>());
        }

        public bool IsProcessingPowers()
        {
            return base.method_11<bool>("IsProcessingPowers", Array.Empty<object>());
        }

        public bool IsResponsePacketBlocked()
        {
            return base.method_11<bool>("IsResponsePacketBlocked", Array.Empty<object>());
        }

        public bool IsSelectedOptionFriendlyHero()
        {
            return base.method_11<bool>("IsSelectedOptionFriendlyHero", Array.Empty<object>());
        }

        public bool IsSubOption(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsSubOption", objArray1);
        }

        public bool IsTurnStartManagerActive()
        {
            return base.method_11<bool>("IsTurnStartManagerActive", Array.Empty<object>());
        }

        public bool IsTurnStartManagerBlockingInput()
        {
            return base.method_11<bool>("IsTurnStartManagerBlockingInput", Array.Empty<object>());
        }

        public bool IsUsingFastActorTriggers()
        {
            return base.method_11<bool>("IsUsingFastActorTriggers", Array.Empty<object>());
        }

        public bool IsValidOptionTarget(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("IsValidOptionTarget", objArray1);
        }

        public void NotifyOfCoinSpawn()
        {
            base.method_8("NotifyOfCoinSpawn", Array.Empty<object>());
        }

        public void OnAllOptions(Network.Options options)
        {
            object[] objArray1 = new object[] { options };
            base.method_8("OnAllOptions", objArray1);
        }

        public void OnCurrentPlayerChanged(Player player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("OnCurrentPlayerChanged", objArray1);
        }

        public bool OnEarlyConcedeHideEntity(Network.HistHideEntity hideEntity)
        {
            object[] objArray1 = new object[] { hideEntity };
            return base.method_11<bool>("OnEarlyConcedeHideEntity", objArray1);
        }

        public bool OnEarlyConcedeShowEntity(Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { showEntity };
            return base.method_11<bool>("OnEarlyConcedeShowEntity", objArray1);
        }

        public bool OnEarlyConcedeTagChange(Network.HistTagChange netChange)
        {
            object[] objArray1 = new object[] { netChange };
            return base.method_11<bool>("OnEarlyConcedeTagChange", objArray1);
        }

        public void OnEntitiesChosen(Network.EntitiesChosen chosen)
        {
            object[] objArray1 = new object[] { chosen };
            base.method_8("OnEntitiesChosen", objArray1);
        }

        public void OnEntitiesChosenProcessed(Network.EntitiesChosen chosen)
        {
            object[] objArray1 = new object[] { chosen };
            base.method_8("OnEntitiesChosenProcessed", objArray1);
        }

        public void OnEntityChoices(Network.EntityChoices choices)
        {
            object[] objArray1 = new object[] { choices };
            base.method_8("OnEntityChoices", objArray1);
        }

        public bool OnFullEntity(Network.HistFullEntity fullEntity)
        {
            object[] objArray1 = new object[] { fullEntity };
            return base.method_11<bool>("OnFullEntity", objArray1);
        }

        public void OnGameOver(TAG_PLAYSTATE playState)
        {
            object[] objArray1 = new object[] { playState };
            base.method_8("OnGameOver", objArray1);
        }

        public void OnGameSetup(Network.GameSetup setup)
        {
            object[] objArray1 = new object[] { setup };
            base.method_8("OnGameSetup", objArray1);
        }

        public bool OnHideEntity(Network.HistHideEntity hideEntity)
        {
            object[] objArray1 = new object[] { hideEntity };
            return base.method_11<bool>("OnHideEntity", objArray1);
        }

        public bool OnMetaData(Network.HistMetaData metaData)
        {
            object[] objArray1 = new object[] { metaData };
            return base.method_11<bool>("OnMetaData", objArray1);
        }

        public void OnOptionRejected(int optionId)
        {
            object[] objArray1 = new object[] { optionId };
            base.method_8("OnOptionRejected", objArray1);
        }

        public bool OnRealTimeFullEntity(Network.HistFullEntity fullEntity)
        {
            object[] objArray1 = new object[] { fullEntity };
            return base.method_11<bool>("OnRealTimeFullEntity", objArray1);
        }

        public void OnRealTimeGameOver(Network.HistTagChange change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("OnRealTimeGameOver", objArray1);
        }

        public bool OnRealTimeShowEntity(Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { showEntity };
            return base.method_11<bool>("OnRealTimeShowEntity", objArray1);
        }

        public bool OnRealTimeTagChange(Network.HistTagChange change)
        {
            object[] objArray1 = new object[] { change };
            return base.method_11<bool>("OnRealTimeTagChange", objArray1);
        }

        public void OnReceivedEarlyConcede()
        {
            base.method_8("OnReceivedEarlyConcede", Array.Empty<object>());
        }

        public void OnSelectedOptionsSent()
        {
            base.method_8("OnSelectedOptionsSent", Array.Empty<object>());
        }

        public bool OnShowEntity(Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { showEntity };
            return base.method_11<bool>("OnShowEntity", objArray1);
        }

        public void OnSpellControllerPassedMaxWaitSec(SpellController spellController)
        {
            object[] objArray1 = new object[] { spellController };
            base.method_8("OnSpellControllerPassedMaxWaitSec", objArray1);
        }

        public bool OnTagChange(Network.HistTagChange netChange)
        {
            object[] objArray1 = new object[] { netChange };
            return base.method_11<bool>("OnTagChange", objArray1);
        }

        public void OnTaskListEnded(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            base.method_8("OnTaskListEnded", objArray1);
        }

        public void OnTimeout()
        {
            base.method_8("OnTimeout", Array.Empty<object>());
        }

        public void OnTurnChanged(int oldTurn, int newTurn)
        {
            object[] objArray1 = new object[] { oldTurn, newTurn };
            base.method_8("OnTurnChanged", objArray1);
        }

        public void OnTurnChanged_TurnTimer(int oldTurn, int newTurn)
        {
            object[] objArray1 = new object[] { oldTurn, newTurn };
            base.method_8("OnTurnChanged_TurnTimer", objArray1);
        }

        public void OnTurnTimerUpdate(Network.TurnTimerInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("OnTurnTimerUpdate", objArray1);
        }

        public void PreprocessEarlyConcedeTagChange(Triton.Game.Mapping.Entity entity, TagDelta change)
        {
            object[] objArray1 = new object[] { entity, change };
            base.method_8("PreprocessEarlyConcedeTagChange", objArray1);
        }

        public void PreprocessRealTimeTagChange(Triton.Game.Mapping.Entity entity, Network.HistTagChange change)
        {
            object[] objArray1 = new object[] { entity, change };
            base.method_8("PreprocessRealTimeTagChange", objArray1);
        }

        public void PreprocessTagChange(Triton.Game.Mapping.Entity entity, TagDelta change)
        {
            object[] objArray1 = new object[] { entity, change };
            base.method_8("PreprocessTagChange", objArray1);
        }

        public void ProcessAllQueuedChoices()
        {
            base.method_8("ProcessAllQueuedChoices", Array.Empty<object>());
        }

        public void ProcessEarlyConcedeTagChange(Triton.Game.Mapping.Entity entity, TagDelta change)
        {
            object[] objArray1 = new object[] { entity, change };
            base.method_8("ProcessEarlyConcedeTagChange", objArray1);
        }

        public void ProcessEntitiesChosen(Network.EntitiesChosen chosen)
        {
            object[] objArray1 = new object[] { chosen };
            base.method_8("ProcessEntitiesChosen", objArray1);
        }

        public void ProcessEntityChoices(Network.EntityChoices choices, PowerTaskList preChoiceTaskList)
        {
            object[] objArray1 = new object[] { choices, preChoiceTaskList };
            base.method_8("ProcessEntityChoices", objArray1);
        }

        public bool RemoveChosenEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("RemoveChosenEntity", objArray1);
        }

        public void RemoveEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            base.method_8("RemoveEntity", objArray1);
        }

        public void RemovePlayer(Player player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("RemovePlayer", objArray1);
        }

        public bool RemoveServerBlockingSpell(Spell spell)
        {
            object[] objArray1 = new object[] { spell };
            return base.method_11<bool>("RemoveServerBlockingSpell", objArray1);
        }

        public bool RemoveServerBlockingSpellController(SpellController spellController)
        {
            object[] objArray1 = new object[] { spellController };
            return base.method_11<bool>("RemoveServerBlockingSpellController", objArray1);
        }

        public void SendChoices()
        {
            base.method_8("SendChoices", Array.Empty<object>());
        }

        public void SendOption()
        {
            base.method_8("SendOption", Array.Empty<object>());
        }

        public void SetBusy(bool busy)
        {
            object[] objArray1 = new object[] { busy };
            base.method_8("SetBusy", objArray1);
        }

        public void SetFriendlyCardBeingDrawn(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetFriendlyCardBeingDrawn", objArray1);
        }

        public void SetLastTurnRemindedOfFullHand(int turn)
        {
            object[] objArray1 = new object[] { turn };
            base.method_8("SetLastTurnRemindedOfFullHand", objArray1);
        }

        public void SetMulliganPowerBlocker(bool on)
        {
            object[] objArray1 = new object[] { on };
            base.method_8("SetMulliganPowerBlocker", objArray1);
        }

        public void SetOpponentCardBeingDrawn(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetOpponentCardBeingDrawn", objArray1);
        }

        public void SetSelectedOption(int index)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { index };
            base.method_9("SetSelectedOption", enumArray1, objArray1);
        }

        public void SetSelectedOptionPosition(int position)
        {
            object[] objArray1 = new object[] { position };
            base.method_8("SetSelectedOptionPosition", objArray1);
        }

        public void SetSelectedOptionTarget(int target)
        {
            object[] objArray1 = new object[] { target };
            base.method_8("SetSelectedOptionTarget", objArray1);
        }

        public void SetSelectedSubOption(int index)
        {
            object[] objArray1 = new object[] { index };
            base.method_8("SetSelectedSubOption", objArray1);
        }

        public void SetUsingFastActorTriggers(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("SetUsingFastActorTriggers", objArray1);
        }

        public void ShowEnemyTauntCharacters()
        {
            base.method_8("ShowEnemyTauntCharacters", Array.Empty<object>());
        }

        public static void Shutdown()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "GameState", "Shutdown");
        }

        public bool SubEntityHasTargets(Triton.Game.Mapping.Entity subEntity)
        {
            object[] objArray1 = new object[] { subEntity };
            return base.method_11<bool>("SubEntityHasTargets", objArray1);
        }

        public void TriggerTurnTimerUpdate(TurnTimerUpdate update)
        {
            object[] objArray1 = new object[] { update };
            base.method_8("TriggerTurnTimerUpdate", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateChoiceHighlights()
        {
            base.method_8("UpdateChoiceHighlights", Array.Empty<object>());
        }

        public void UpdateHighlightsBasedOnSelection()
        {
            base.method_8("UpdateHighlightsBasedOnSelection", Array.Empty<object>());
        }

        public void UpdateOptionHighlights()
        {
            base.method_9("UpdateOptionHighlights", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void UpdateOptionHighlights(Network.Options options)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { options };
            base.method_9("UpdateOptionHighlights", enumArray1, objArray1);
        }

        public void UpdateSubOptionHighlights(Network.Options.Option option)
        {
            object[] objArray1 = new object[] { option };
            base.method_8("UpdateSubOptionHighlights", objArray1);
        }

        public void UpdateTargetHighlights(Network.Options.Option.SubOption subOption)
        {
            object[] objArray1 = new object[] { subOption };
            base.method_8("UpdateTargetHighlights", objArray1);
        }

        public bool WasConcedeRequested()
        {
            return base.method_11<bool>("WasConcedeRequested", Array.Empty<object>());
        }

        public bool WasGameCreated()
        {
            return base.method_11<bool>("WasGameCreated", Array.Empty<object>());
        }

        public static float BLOCK_REPORT_INTERVAL_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GameState", "BLOCK_REPORT_INTERVAL_SEC");
            }
        }

        public static float BLOCK_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GameState", "BLOCK_SEC");
            }
        }

        public static int DEFAULT_SUBOPTION
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "GameState", "DEFAULT_SUBOPTION");
            }
        }

        public static string INDENT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameState", "INDENT");
            }
        }

        public bool m_busy
        {
            get
            {
                return base.method_2<bool>("m_busy");
            }
        }

        public List<Triton.Game.Mapping.Entity> m_chosenEntities
        {
            get
            {
                Class267<Triton.Game.Mapping.Entity> class2 = base.method_3<Class267<Triton.Game.Mapping.Entity>>("m_chosenEntities");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_coinHasSpawned
        {
            get
            {
                return base.method_2<bool>("m_coinHasSpawned");
            }
        }

        public bool m_concedeRequested
        {
            get
            {
                return base.method_2<bool>("m_concedeRequested");
            }
        }

        public CreateGamePhase m_createGamePhase
        {
            get
            {
                return base.method_2<CreateGamePhase>("m_createGamePhase");
            }
        }

        public Card m_friendlyCardBeingDrawn
        {
            get
            {
                return base.method_3<Card>("m_friendlyCardBeingDrawn");
            }
        }

        public GameEntity m_gameEntity
        {
            get
            {
                return base.method_3<GameEntity>("m_gameEntity");
            }
        }

        public bool m_gameOver
        {
            get
            {
                return base.method_2<bool>("m_gameOver");
            }
        }

        public float m_lastBlockedReport
        {
            get
            {
                return base.method_2<float>("m_lastBlockedReport");
            }
        }

        public Network.Options m_lastOptions
        {
            get
            {
                return base.method_3<Network.Options>("m_lastOptions");
            }
        }

        public SelectedOption m_lastSelectedOption
        {
            get
            {
                return base.method_3<SelectedOption>("m_lastSelectedOption");
            }
        }

        public float m_lastTimeUnblocked
        {
            get
            {
                return base.method_2<float>("m_lastTimeUnblocked");
            }
        }

        public int m_lastTurnRemindedOfFullHand
        {
            get
            {
                return base.method_2<int>("m_lastTurnRemindedOfFullHand");
            }
        }

        public int m_maxFriendlyMinionsPerPlayer
        {
            get
            {
                return base.method_2<int>("m_maxFriendlyMinionsPerPlayer");
            }
        }

        public int m_maxSecretsPerPlayer
        {
            get
            {
                return base.method_2<int>("m_maxSecretsPerPlayer");
            }
        }

        public bool m_mulliganPowerBlock
        {
            get
            {
                return base.method_2<bool>("m_mulliganPowerBlock");
            }
        }

        public Card m_opponentCardBeingDrawn
        {
            get
            {
                return base.method_3<Card>("m_opponentCardBeingDrawn");
            }
        }

        public Network.Options m_options
        {
            get
            {
                return base.method_3<Network.Options>("m_options");
            }
        }

        public PowerProcessor m_powerProcessor
        {
            get
            {
                return base.method_3<PowerProcessor>("m_powerProcessor");
            }
        }

        public Network.HistTagChange m_realTimeGameOverTagChange
        {
            get
            {
                return base.method_3<Network.HistTagChange>("m_realTimeGameOverTagChange");
            }
        }

        public ResponseMode m_responseMode
        {
            get
            {
                return base.method_2<ResponseMode>("m_responseMode");
            }
        }

        public SelectedOption m_selectedOption
        {
            get
            {
                return base.method_3<SelectedOption>("m_selectedOption");
            }
        }

        public List<SpellController> m_serverBlockingSpellControllers
        {
            get
            {
                Class267<SpellController> class2 = base.method_3<Class267<SpellController>>("m_serverBlockingSpellControllers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Spell> m_serverBlockingSpells
        {
            get
            {
                Class267<Spell> class2 = base.method_3<Class267<Spell>>("m_serverBlockingSpells");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_usingFastActorTriggers
        {
            get
            {
                return base.method_2<bool>("m_usingFastActorTriggers");
            }
        }

        public enum CreateGamePhase
        {
            INVALID,
            CREATING,
            CREATED
        }

        [Attribute38("GameState.QueuedChoice")]
        public class QueuedChoice : MonoClass
        {
            public QueuedChoice(IntPtr address) : this(address, "QueuedChoice")
            {
            }

            public QueuedChoice(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_eventData
            {
                get
                {
                    return base.method_3<object>("m_eventData");
                }
            }

            public object m_packet
            {
                get
                {
                    return base.method_3<object>("m_packet");
                }
            }

            public PacketType m_type
            {
                get
                {
                    return base.method_2<PacketType>("m_type");
                }
            }

            public enum PacketType
            {
                ENTITY_CHOICES,
                ENTITIES_CHOSEN
            }
        }

        public enum ResponseMode
        {
            NONE,
            OPTION,
            SUB_OPTION,
            OPTION_TARGET,
            CHOICE
        }

        [Attribute38("GameState.SelectedOption")]
        public class SelectedOption : MonoClass
        {
            public SelectedOption(IntPtr address) : this(address, "SelectedOption")
            {
            }

            public SelectedOption(IntPtr address, string className) : base(address, className)
            {
            }

            public void Clear()
            {
                base.method_8("Clear", Array.Empty<object>());
            }

            public void CopyFrom(GameState.SelectedOption original)
            {
                object[] objArray1 = new object[] { original };
                base.method_8("CopyFrom", objArray1);
            }

            public int m_main
            {
                get
                {
                    return base.method_2<int>("m_main");
                }
            }

            public int m_position
            {
                get
                {
                    return base.method_2<int>("m_position");
                }
            }

            public int m_sub
            {
                get
                {
                    return base.method_2<int>("m_sub");
                }
            }

            public int m_target
            {
                get
                {
                    return base.method_2<int>("m_target");
                }
            }
        }
    }
}


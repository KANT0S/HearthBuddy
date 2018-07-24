namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendListFrame")]
    public class FriendListFrame : MonoBehaviour
    {
        public FriendListFrame(IntPtr address) : this(address, "FriendListFrame")
        {
        }

        public FriendListFrame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CloseAddFriendFrame()
        {
            base.method_8("CloseAddFriendFrame", Array.Empty<object>());
        }

        public MobileFriendListItem CreateCurrentGameFrame(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_14<MobileFriendListItem>("CreateCurrentGameFrame", objArray1);
        }

        public MobileFriendListItem CreateFriendFrame(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_14<MobileFriendListItem>("CreateFriendFrame", objArray1);
        }

        public void CreateItemsCamera()
        {
            base.method_8("CreateItemsCamera", Array.Empty<object>());
        }

        public MobileFriendListItem CreateNearbyPlayerFrame(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_14<MobileFriendListItem>("CreateNearbyPlayerFrame", objArray1);
        }

        public MobileFriendListItem CreateRecruitFrame(Network.RecruitInfo info)
        {
            object[] objArray1 = new object[] { info };
            return base.method_14<MobileFriendListItem>("CreateRecruitFrame", objArray1);
        }

        public MobileFriendListItem CreateRequestFrame(BnetInvitation invite)
        {
            object[] objArray1 = new object[] { invite };
            return base.method_14<MobileFriendListItem>("CreateRequestFrame", objArray1);
        }

        public void DoPlayersChanged(BnetPlayerChangelist changelist)
        {
            object[] objArray1 = new object[] { changelist };
            base.method_8("DoPlayersChanged", objArray1);
        }

        public FriendListBaseFriendFrame FindBaseFriendFrame(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_14<FriendListBaseFriendFrame>("FindBaseFriendFrame", objArray1);
        }

        public FriendListCurrentGameFrame FindCurrentGameFrame(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return base.method_14<FriendListCurrentGameFrame>("FindCurrentGameFrame", objArray1);
        }

        public FriendListFriendFrame FindFriendFrame(BnetPlayer friend)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { friend };
            return base.method_15<FriendListFriendFrame>("FindFriendFrame", enumArray1, objArray1);
        }

        public FriendListItemHeader FindHeader(MobileFriendListItem.TypeFlags type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_14<FriendListItemHeader>("FindHeader", objArray1);
        }

        public FriendListItemHeader FindOrAddHeader(MobileFriendListItem.TypeFlags type)
        {
            object[] objArray1 = new object[] { type };
            return base.method_14<FriendListItemHeader>("FindOrAddHeader", objArray1);
        }

        public Transform GetBottomRightBone()
        {
            return base.method_14<Transform>("GetBottomRightBone", Array.Empty<object>());
        }

        public bool GetShowHeaderSection(Triton.Game.Mapping.Option setoption)
        {
            object[] objArray1 = new object[] { setoption };
            return base.method_11<bool>("GetShowHeaderSection", objArray1);
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void HandleNearbyPlayersChanged()
        {
            base.method_8("HandleNearbyPlayersChanged", Array.Empty<object>());
        }

        public void InitButtons()
        {
            base.method_8("InitButtons", Array.Empty<object>());
        }

        public void InitItems()
        {
            base.method_8("InitItems", Array.Empty<object>());
        }

        public int ItemsSortCompare(FriendListItem item1, FriendListItem item2)
        {
            object[] objArray1 = new object[] { item1, item2 };
            return base.method_11<int>("ItemsSortCompare", objArray1);
        }

        public void OnAddFriendButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnAddFriendButtonReleased", objArray1);
        }

        public void OnBaseFriendFrameReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBaseFriendFrameReleased", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnEditFriendsButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnEditFriendsButtonReleased", objArray1);
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OnFriendChallengeChanged(FriendChallengeEvent challengeEvent, BnetPlayer player, object userData)
        {
            object[] objArray1 = new object[] { challengeEvent, player, userData };
            base.method_8("OnFriendChallengeChanged", objArray1);
        }

        public void OnFriendsChanged(BnetFriendChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnFriendsChanged", objArray1);
        }

        public void OnHeaderSectionToggle(bool show, object userdata)
        {
            object[] objArray1 = new object[] { show, userdata };
            base.method_8("OnHeaderSectionToggle", objArray1);
        }

        public void OnNearbyPlayerFrameReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnNearbyPlayerFrameReleased", objArray1);
        }

        public void OnNearbyPlayersChanged(BnetNearbyPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnNearbyPlayersChanged", objArray1);
        }

        public void OnPlayersChanged(BnetPlayerChangelist changelist, object userData)
        {
            object[] objArray1 = new object[] { changelist, userData };
            base.method_8("OnPlayersChanged", objArray1);
        }

        public void OnRecentOpponent(BnetPlayer recentOpponent, object userData)
        {
            object[] objArray1 = new object[] { recentOpponent, userData };
            base.method_8("OnRecentOpponent", objArray1);
        }

        public void OnRecentOpponentButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRecentOpponentButtonReleased", objArray1);
        }

        public void OnRecruitAccepted(Network.RecruitInfo recruit)
        {
            object[] objArray1 = new object[] { recruit };
            base.method_8("OnRecruitAccepted", objArray1);
        }

        public void OnRecruitAFriendButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRecruitAFriendButtonReleased", objArray1);
        }

        public void OnRecruitsChanged()
        {
            base.method_8("OnRecruitsChanged", Array.Empty<object>());
        }

        public void OnRemoveFriendButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRemoveFriendButtonReleased", objArray1);
        }

        public bool OnRemoveFriendDialogShown(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnRemoveFriendDialogShown", objArray1);
        }

        public void OnRemoveFriendPopupResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnRemoveFriendPopupResponse", objArray1);
        }

        public void OnScenePreUnload(SceneMgr.Mode prevMode, Scene prevScene, object userData)
        {
            object[] objArray1 = new object[] { prevMode, prevScene, userData };
            base.method_8("OnScenePreUnload", objArray1);
        }

        public void RecruitAFriend_OnClosed()
        {
            base.method_8("RecruitAFriend_OnClosed", Array.Empty<object>());
        }

        public void RegisterFriendEvents()
        {
            base.method_8("RegisterFriendEvents", Array.Empty<object>());
        }

        public bool RemoveItem(bool isHeader, MobileFriendListItem.TypeFlags type, object itemToRemove)
        {
            object[] objArray1 = new object[] { isHeader, type, itemToRemove };
            return base.method_11<bool>("RemoveItem", objArray1);
        }

        public void ResumeItemsLayout()
        {
            base.method_8("ResumeItemsLayout", Array.Empty<object>());
        }

        public void SetShowHeaderSection(Triton.Game.Mapping.Option sectionoption, bool show)
        {
            object[] objArray1 = new object[] { sectionoption, show };
            base.method_8("SetShowHeaderSection", objArray1);
        }

        public void SetWorldHeight(float height)
        {
            object[] objArray1 = new object[] { height };
            base.method_8("SetWorldHeight", objArray1);
        }

        public void SetWorldPosition(Vector3 pos)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { pos };
            base.method_9("SetWorldPosition", enumArray1, objArray1);
        }

        public void SetWorldPosition(float x, float y)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { x, y };
            base.method_9("SetWorldPosition", enumArray1, objArray1);
        }

        public void SetWorldRect(float x, float y, float width, float height)
        {
            object[] objArray1 = new object[] { x, y, width, height };
            base.method_8("SetWorldRect", objArray1);
        }

        public void ShowAddFriendFrame(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("ShowAddFriendFrame", objArray1);
        }

        public void ShowRecruitAFriendFrame()
        {
            base.method_8("ShowRecruitAFriendFrame", Array.Empty<object>());
        }

        public void ShowRemoveFriendPopup(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            base.method_8("ShowRemoveFriendPopup", objArray1);
        }

        public void SortAndRefreshTouchList()
        {
            base.method_8("SortAndRefreshTouchList", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SuspendItemsLayout()
        {
            base.method_8("SuspendItemsLayout", Array.Empty<object>());
        }

        public void ToggleEditFriendsMode()
        {
            base.method_8("ToggleEditFriendsMode", Array.Empty<object>());
        }

        public void UnregisterFriendEvents()
        {
            base.method_8("UnregisterFriendEvents", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateAllHeaderBackgrounds()
        {
            base.method_8("UpdateAllHeaderBackgrounds", Array.Empty<object>());
        }

        public void UpdateAllHeaders()
        {
            base.method_8("UpdateAllHeaders", Array.Empty<object>());
        }

        public void UpdateAllRecruits()
        {
            base.method_8("UpdateAllRecruits", Array.Empty<object>());
        }

        public void UpdateBackgroundCollider()
        {
            base.method_8("UpdateBackgroundCollider", Array.Empty<object>());
        }

        public void UpdateButtonGlows()
        {
            base.method_8("UpdateButtonGlows", Array.Empty<object>());
        }

        public void UpdateCurrentGamesHeader()
        {
            base.method_8("UpdateCurrentGamesHeader", Array.Empty<object>());
        }

        public void UpdateDropShadow()
        {
            base.method_8("UpdateDropShadow", Array.Empty<object>());
        }

        public void UpdateFriendItems()
        {
            base.method_8("UpdateFriendItems", Array.Empty<object>());
        }

        public void UpdateFriendsHeader(FriendListItemHeader header)
        {
            object[] objArray1 = new object[] { header };
            base.method_8("UpdateFriendsHeader", objArray1);
        }

        public void UpdateHeaderBackground(FriendListItemHeader itemHeader)
        {
            object[] objArray1 = new object[] { itemHeader };
            base.method_8("UpdateHeaderBackground", objArray1);
        }

        public void UpdateItems()
        {
            base.method_8("UpdateItems", Array.Empty<object>());
        }

        public void UpdateItemsCamera()
        {
            base.method_8("UpdateItemsCamera", Array.Empty<object>());
        }

        public void UpdateItemsList()
        {
            base.method_8("UpdateItemsList", Array.Empty<object>());
        }

        public void UpdateMyself()
        {
            base.method_8("UpdateMyself", Array.Empty<object>());
        }

        public void UpdateNearbyPlayerItems()
        {
            base.method_8("UpdateNearbyPlayerItems", Array.Empty<object>());
        }

        public void UpdateNearbyPlayersHeader(FriendListItemHeader header)
        {
            object[] objArray1 = new object[] { header };
            base.method_8("UpdateNearbyPlayersHeader", objArray1);
        }

        public void UpdateRecentOpponent()
        {
            base.method_8("UpdateRecentOpponent", Array.Empty<object>());
        }

        public void UpdateRecruitItems()
        {
            base.method_8("UpdateRecruitItems", Array.Empty<object>());
        }

        public void UpdateRecruitsHeader()
        {
            base.method_8("UpdateRecruitsHeader", Array.Empty<object>());
        }

        public void UpdateRequestsHeader(FriendListItemHeader header)
        {
            object[] objArray1 = new object[] { header };
            base.method_8("UpdateRequestsHeader", objArray1);
        }

        public void UpdateSelectedItem()
        {
            base.method_8("UpdateSelectedItem", Array.Empty<object>());
        }

        public FriendListButton addFriendButton
        {
            get
            {
                return base.method_3<FriendListButton>("addFriendButton");
            }
        }

        public GameObject innerShadow
        {
            get
            {
                return base.method_3<GameObject>("innerShadow");
            }
        }

        public bool IsInEditMode
        {
            get
            {
                return base.method_11<bool>("get_IsInEditMode", Array.Empty<object>());
            }
        }

        public TouchList items
        {
            get
            {
                return base.method_3<TouchList>("items");
            }
        }

        public ListInfo listInfo
        {
            get
            {
                return base.method_3<ListInfo>("listInfo");
            }
        }

        public AddFriendFrame m_addFriendFrame
        {
            get
            {
                return base.method_3<AddFriendFrame>("m_addFriendFrame");
            }
        }

        public List<FriendListItem> m_allItems
        {
            get
            {
                Class266<FriendListItem> class2 = base.method_3<Class266<FriendListItem>>("m_allItems");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_editFriendsMode
        {
            get
            {
                return base.method_2<bool>("m_editFriendsMode");
            }
        }

        public BnetPlayer m_friendToRemove
        {
            get
            {
                return base.method_3<BnetPlayer>("m_friendToRemove");
            }
        }

        public Dictionary<MobileFriendListItem.TypeFlags, FriendListItemHeader> m_headers
        {
            get
            {
                Class249<MobileFriendListItem.TypeFlags, FriendListItemHeader> class2 = base.method_3<Class249<MobileFriendListItem.TypeFlags, FriendListItemHeader>>("m_headers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Camera m_itemsCamera
        {
            get
            {
                return base.method_3<Camera>("m_itemsCamera");
            }
        }

        public float m_lastNearbyPlayersUpdate
        {
            get
            {
                return base.method_2<float>("m_lastNearbyPlayersUpdate");
            }
        }

        public VirtualizedFriendsListBehavior m_longListBehavior
        {
            get
            {
                return base.method_3<VirtualizedFriendsListBehavior>("m_longListBehavior");
            }
        }

        public bool m_nearbyPlayersNeedUpdate
        {
            get
            {
                return base.method_2<bool>("m_nearbyPlayersNeedUpdate");
            }
        }

        public List<NearbyPlayerUpdate> m_nearbyPlayerUpdates
        {
            get
            {
                Class267<NearbyPlayerUpdate> class2 = base.method_3<Class267<NearbyPlayerUpdate>>("m_nearbyPlayerUpdates");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public BnetPlayerChangelist m_playersChangeList
        {
            get
            {
                return base.method_3<BnetPlayerChangelist>("m_playersChangeList");
            }
        }

        public FriendListButton m_RecruitAFriendButton
        {
            get
            {
                return base.method_3<FriendListButton>("m_RecruitAFriendButton");
            }
        }

        public RecruitAFriendFrame m_recruitAFriendFrame
        {
            get
            {
                return base.method_3<RecruitAFriendFrame>("m_recruitAFriendFrame");
            }
        }

        public AlertPopup m_removeFriendPopup
        {
            get
            {
                return base.method_3<AlertPopup>("m_removeFriendPopup");
            }
        }

        public Me me
        {
            get
            {
                return base.method_3<Me>("me");
            }
        }

        public PlayerPortrait myPortrait
        {
            get
            {
                return base.method_3<PlayerPortrait>("myPortrait");
            }
        }

        public static float NEARBY_PLAYERS_UPDATE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FriendListFrame", "NEARBY_PLAYERS_UPDATE_TIME");
            }
        }

        public GameObject outerShadow
        {
            get
            {
                return base.method_3<GameObject>("outerShadow");
            }
        }

        public GameObject portraitBackground
        {
            get
            {
                return base.method_3<GameObject>("portraitBackground");
            }
        }

        public Prefabs prefabs
        {
            get
            {
                return base.method_3<Prefabs>("prefabs");
            }
        }

        public Material rankedBackground
        {
            get
            {
                return base.method_3<Material>("rankedBackground");
            }
        }

        public RecentOpponent recentOpponent
        {
            get
            {
                return base.method_3<RecentOpponent>("recentOpponent");
            }
        }

        public FriendListButton removeFriendButton
        {
            get
            {
                return base.method_3<FriendListButton>("removeFriendButton");
            }
        }

        public TouchListScrollbar scrollbar
        {
            get
            {
                return base.method_3<TouchListScrollbar>("scrollbar");
            }
        }

        public BnetPlayer SelectedPlayer
        {
            get
            {
                return base.method_14<BnetPlayer>("get_SelectedPlayer", Array.Empty<object>());
            }
        }

        public bool ShowingAddFriendFrame
        {
            get
            {
                return base.method_11<bool>("get_ShowingAddFriendFrame", Array.Empty<object>());
            }
        }

        public Material unrankedBackground
        {
            get
            {
                return base.method_3<Material>("unrankedBackground");
            }
        }

        public NineSliceElement window
        {
            get
            {
                return base.method_3<NineSliceElement>("window");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FriendListItem
        {
            public object m_item;
        }

        [Attribute38("FriendListFrame.HeaderBackgroundInfo")]
        public class HeaderBackgroundInfo : MonoClass
        {
            public HeaderBackgroundInfo(IntPtr address) : this(address, "HeaderBackgroundInfo")
            {
            }

            public HeaderBackgroundInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public Material material
            {
                get
                {
                    return base.method_3<Material>("material");
                }
            }

            public Mesh mesh
            {
                get
                {
                    return base.method_3<Mesh>("mesh");
                }
            }
        }

        [Attribute38("FriendListFrame.ListInfo")]
        public class ListInfo : MonoClass
        {
            public ListInfo(IntPtr address) : this(address, "ListInfo")
            {
            }

            public ListInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public Transform bottomRight
            {
                get
                {
                    return base.method_3<Transform>("bottomRight");
                }
            }

            public Transform bottomRightWithScrollbar
            {
                get
                {
                    return base.method_3<Transform>("bottomRightWithScrollbar");
                }
            }

            public FriendListFrame.HeaderBackgroundInfo currentGameBackgroundInfo
            {
                get
                {
                    return base.method_3<FriendListFrame.HeaderBackgroundInfo>("currentGameBackgroundInfo");
                }
            }

            public FriendListFrame.HeaderBackgroundInfo requestBackgroundInfo
            {
                get
                {
                    return base.method_3<FriendListFrame.HeaderBackgroundInfo>("requestBackgroundInfo");
                }
            }

            public Transform topLeft
            {
                get
                {
                    return base.method_3<Transform>("topLeft");
                }
            }
        }

        [Attribute38("FriendListFrame.Me")]
        public class Me : MonoClass
        {
            public Me(IntPtr address) : this(address, "Me")
            {
            }

            public Me(IntPtr address, string className) : base(address, className)
            {
            }

            public TournamentMedal m_Medal
            {
                get
                {
                    return base.method_3<TournamentMedal>("m_Medal");
                }
            }

            public GameObject m_MedalPatch
            {
                get
                {
                    return base.method_3<GameObject>("m_MedalPatch");
                }
            }

            public UberText nameText
            {
                get
                {
                    return base.method_3<UberText>("nameText");
                }
            }

            public UberText numberText
            {
                get
                {
                    return base.method_3<UberText>("numberText");
                }
            }

            public Spawner portraitRef
            {
                get
                {
                    return base.method_3<Spawner>("portraitRef");
                }
            }

            public UberText statusText
            {
                get
                {
                    return base.method_3<UberText>("statusText");
                }
            }
        }

        [Attribute38("FriendListFrame.NearbyPlayerUpdate")]
        public class NearbyPlayerUpdate : MonoClass
        {
            public NearbyPlayerUpdate(IntPtr address) : this(address, "NearbyPlayerUpdate")
            {
            }

            public NearbyPlayerUpdate(IntPtr address, string className) : base(address, className)
            {
            }

            public ChangeType Change
            {
                get
                {
                    return base.method_2<ChangeType>("Change");
                }
            }

            public BnetPlayer Player
            {
                get
                {
                    return base.method_3<BnetPlayer>("Player");
                }
            }

            public enum ChangeType
            {
                Added,
                Removed
            }
        }

        [Attribute38("FriendListFrame.Prefabs")]
        public class Prefabs : MonoClass
        {
            public Prefabs(IntPtr address) : this(address, "Prefabs")
            {
            }

            public Prefabs(IntPtr address, string className) : base(address, className)
            {
            }

            public AddFriendFrame addFriendFrame
            {
                get
                {
                    return base.method_3<AddFriendFrame>("addFriendFrame");
                }
            }

            public FriendListCurrentGameFrame currentGameItem
            {
                get
                {
                    return base.method_3<FriendListCurrentGameFrame>("currentGameItem");
                }
            }

            public FriendListFriendFrame friendItem
            {
                get
                {
                    return base.method_3<FriendListFriendFrame>("friendItem");
                }
            }

            public FriendListItemHeader headerItem
            {
                get
                {
                    return base.method_3<FriendListItemHeader>("headerItem");
                }
            }

            public FriendListNearbyPlayerFrame nearbyPlayerItem
            {
                get
                {
                    return base.method_3<FriendListNearbyPlayerFrame>("nearbyPlayerItem");
                }
            }

            public RecruitAFriendFrame recruitAFriendFrame
            {
                get
                {
                    return base.method_3<RecruitAFriendFrame>("recruitAFriendFrame");
                }
            }

            public FriendListRecruitFrame recruitItem
            {
                get
                {
                    return base.method_3<FriendListRecruitFrame>("recruitItem");
                }
            }

            public FriendListRequestFrame requestItem
            {
                get
                {
                    return base.method_3<FriendListRequestFrame>("requestItem");
                }
            }
        }

        [Attribute38("FriendListFrame.RecentOpponent")]
        public class RecentOpponent : MonoClass
        {
            public RecentOpponent(IntPtr address) : this(address, "RecentOpponent")
            {
            }

            public RecentOpponent(IntPtr address, string className) : base(address, className)
            {
            }

            public PegUIElement button
            {
                get
                {
                    return base.method_3<PegUIElement>("button");
                }
            }

            public UberText nameText
            {
                get
                {
                    return base.method_3<UberText>("nameText");
                }
            }
        }

        [Attribute38("FriendListFrame.VirtualizedFriendsListBehavior")]
        public class VirtualizedFriendsListBehavior : MonoClass
        {
            public VirtualizedFriendsListBehavior(IntPtr address) : this(address, "VirtualizedFriendsListBehavior")
            {
            }

            public VirtualizedFriendsListBehavior(IntPtr address, string className) : base(address, className)
            {
            }

            public int GetBoundsByTypeIndex(MobileFriendListItem.TypeFlags itemType)
            {
                object[] objArray1 = new object[] { itemType };
                return base.method_11<int>("GetBoundsByTypeIndex", objArray1);
            }

            public Vector3 GetItemSize(int allItemsIndex)
            {
                object[] objArray1 = new object[] { allItemsIndex };
                return base.method_11<Vector3>("GetItemSize", objArray1);
            }

            public Component GetPrefab(MobileFriendListItem.TypeFlags itemType)
            {
                object[] objArray1 = new object[] { itemType };
                return base.method_14<Component>("GetPrefab", objArray1);
            }

            public static Bounds GetPrefabBounds(GameObject prefabGameObject)
            {
                object[] objArray1 = new object[] { prefabGameObject };
                return MonoClass.smethod_14<Bounds>(TritonHs.MainAssemblyPath, "", "VirtualizedFriendsListBehavior", "GetPrefabBounds", objArray1);
            }

            public void InitializeBoundsByTypeArray()
            {
                base.method_8("InitializeBoundsByTypeArray", Array.Empty<object>());
            }

            public bool IsItemShowable(int allItemsIndex)
            {
                object[] objArray1 = new object[] { allItemsIndex };
                return base.method_11<bool>("IsItemShowable", objArray1);
            }

            public void ReleaseAllItems()
            {
                base.method_8("ReleaseAllItems", Array.Empty<object>());
            }

            public int AllItemsCount
            {
                get
                {
                    return base.method_11<int>("get_AllItemsCount", Array.Empty<object>());
                }
            }

            public List<MobileFriendListItem> FreeList
            {
                get
                {
                    Class267<MobileFriendListItem> class2 = base.method_14<Class267<MobileFriendListItem>>("get_FreeList", Array.Empty<object>());
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public bool HasCollapsedHeaders
            {
                get
                {
                    return base.method_11<bool>("get_HasCollapsedHeaders", Array.Empty<object>());
                }
            }

            public List<Bounds> m_boundsByType
            {
                get
                {
                    Class246<Bounds> class2 = base.method_3<Class246<Bounds>>("m_boundsByType");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public int m_cachedMaxVisibleItems
            {
                get
                {
                    return base.method_2<int>("m_cachedMaxVisibleItems");
                }
            }

            public List<MobileFriendListItem> m_freelist
            {
                get
                {
                    Class267<MobileFriendListItem> class2 = base.method_3<Class267<MobileFriendListItem>>("m_freelist");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public FriendListFrame m_friendList
            {
                get
                {
                    return base.method_3<FriendListFrame>("m_friendList");
                }
            }

            public static int MAX_FREELIST_ITEMS
            {
                get
                {
                    return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "FriendListFrame/VirtualizedFriendsListBehavior", "MAX_FREELIST_ITEMS");
                }
            }

            public int MaxAcquiredItems
            {
                get
                {
                    return base.method_11<int>("get_MaxAcquiredItems", Array.Empty<object>());
                }
            }

            public int MaxVisibleItems
            {
                get
                {
                    return base.method_11<int>("get_MaxVisibleItems", Array.Empty<object>());
                }
            }

            public int MinBuffer
            {
                get
                {
                    return base.method_11<int>("get_MinBuffer", Array.Empty<object>());
                }
            }
        }
    }
}


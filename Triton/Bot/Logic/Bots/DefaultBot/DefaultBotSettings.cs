namespace Triton.Bot.Logic.Bots.DefaultBot
{
    using log4net;
    using Newtonsoft.Json;
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Text;
    using Triton.Bot;
    using Triton.Bot.Settings;
    using Triton.Common;
    using Triton.Game.Mapping;

    public class DefaultBotSettings : JsonSettings
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_10;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        private bool bool_7;
        private bool bool_8;
        private bool bool_9;
        private Triton.Bot.ConstructedMode constructedMode_0;
        private static DefaultBotSettings defaultBotSettings_0;
        private Triton.Bot.GameMode gameMode_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private int int_0;
        private int int_1;
        private int int_2;
        private ObservableCollection<Triton.Bot.GameMode> observableCollection_0;
        private ObservableCollection<Triton.Bot.PracticeDifficulty> observableCollection_1;
        private ObservableCollection<Triton.Bot.ConstructedMode> observableCollection_2;
        private ObservableCollection<TAG_CLASS> observableCollection_3;
        private Triton.Bot.PracticeDifficulty practiceDifficulty_0;
        private string string_1;
        private string string_2;
        private string string_3;
        private string string_4;
        private string string_5;
        private TAG_CLASS tag_CLASS_0;

        internal DefaultBotSettings() : base(JsonSettings.GetSettingsFilePath(textArray1))
        {
            this.int_0 = 0x3a98;
            this.int_1 = 0x7530;
            string[] textArray1 = new string[] { Configuration.Instance.Name, string.Format("{0}.json", "DefaultBot") };
        }

        [JsonIgnore]
        public ObservableCollection<TAG_CLASS> AllClasses
        {
            get
            {
                ObservableCollection<TAG_CLASS> collection1;
                return (new ObservableCollection<TAG_CLASS> { 2, 3, 4, 5, 6, 7, 8, 9, 10 } ?? (this.observableCollection_3 = collection1));
            }
        }

        [JsonIgnore]
        public ObservableCollection<Triton.Bot.ConstructedMode> AllConstructedModes
        {
            get
            {
                ObservableCollection<Triton.Bot.ConstructedMode> collection1;
                return (new ObservableCollection<Triton.Bot.ConstructedMode> { 0, 1 } ?? (this.observableCollection_2 = collection1));
            }
        }

        [JsonIgnore]
        public ObservableCollection<Triton.Bot.GameMode> AllGameModes
        {
            get
            {
                ObservableCollection<Triton.Bot.GameMode> collection1;
                return (new ObservableCollection<Triton.Bot.GameMode> { 0, 1, 2, 3 } ?? (this.observableCollection_0 = collection1));
            }
        }

        [JsonIgnore]
        public ObservableCollection<Triton.Bot.PracticeDifficulty> AllPracticeDifficulties
        {
            get
            {
                ObservableCollection<Triton.Bot.PracticeDifficulty> collection1;
                return (new ObservableCollection<Triton.Bot.PracticeDifficulty> { 0, 1 } ?? (this.observableCollection_1 = collection1));
            }
        }

        [DefaultValue(false)]
        public bool ArenaDontDraft
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                if (!value.Equals(this.bool_0))
                {
                    this.bool_0 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_ArenaDontDraft)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] ArenaDontDraft = {0}.", this.bool_0);
            }
        }

        [DefaultValue(false)]
        public bool ArenaDontOpenRewards
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                if (!value.Equals(this.bool_1))
                {
                    this.bool_1 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_ArenaDontOpenRewards)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] ArenaDontOpenRewards = {0}.", this.bool_1);
            }
        }

        [DefaultValue(false)]
        public bool AutoConcedeAfterConstructedWin
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                if (!value.Equals(this.bool_4))
                {
                    this.bool_4 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_AutoConcedeAfterConstructedWin)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] AutoConcedeAfterConstructedWin = {0}.", this.bool_4);
            }
        }

        [DefaultValue(0x7530)]
        public int AutoConcedeMaxDelayMs
        {
            get
            {
                return this.int_1;
            }
            set
            {
                if (!value.Equals(this.int_1))
                {
                    this.int_1 = value;
                    if (this.int_1 < 0)
                    {
                        this.int_1 = 0;
                    }
                    if (this.int_1 < this.int_0)
                    {
                        this.int_1 = this.int_0;
                    }
                    base.NotifyPropertyChanged<int>(Expression.Lambda<Func<int>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_AutoConcedeMaxDelayMs)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] AutoConcedeMaxDelayMs = {0}.", this.int_1);
            }
        }

        [DefaultValue(0x3a98)]
        public int AutoConcedeMinDelayMs
        {
            get
            {
                return this.int_0;
            }
            set
            {
                if (!value.Equals(this.int_0))
                {
                    this.int_0 = value;
                    if (this.int_0 < 0)
                    {
                        this.int_0 = 0;
                    }
                    if (this.int_0 > this.int_1)
                    {
                        this.int_0 = this.int_1;
                    }
                    base.NotifyPropertyChanged<int>(Expression.Lambda<Func<int>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_AutoConcedeMinDelayMs)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] AutoConcedeMinDelayMs = {0}.", this.int_0);
            }
        }

        [DefaultValue(false)]
        public bool AutoConcedeNextConstructedGame
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                if (!value.Equals(this.bool_5))
                {
                    this.bool_5 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_AutoConcedeNextConstructedGame)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] AutoConcedeNextConstructedGame = {0}.", this.bool_5);
            }
        }

        [DefaultValue(true)]
        public bool AutoGreet
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                if (!value.Equals(this.bool_3))
                {
                    this.bool_3 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_AutoGreet)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] AutoGreet = {0}.", this.bool_3);
            }
        }

        [JsonIgnore, DefaultValue(0)]
        public int ClientBackAttempts
        {
            get
            {
                return this.int_2;
            }
            set
            {
                if (!value.Equals(this.int_2))
                {
                    this.int_2 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_ClientBroken)), new ParameterExpression[0]));
                }
            }
        }

        [JsonIgnore, DefaultValue(false)]
        public bool ClientBroken
        {
            get
            {
                return this.bool_10;
            }
            set
            {
                if (!value.Equals(this.bool_10))
                {
                    this.bool_10 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_ClientBroken)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] ClientBroken = {0}.", this.bool_10);
            }
        }

        [DefaultValue("")]
        public string ConstructedCustomDeck
        {
            get
            {
                return this.string_2;
            }
            set
            {
                if (!value.Equals(this.string_2))
                {
                    this.string_2 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_ConstructedCustomDeck)), new ParameterExpression[0]));
                }
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < this.string_2.Length; i++)
                {
                    if (i <= 2)
                    {
                        builder.Append(this.string_2[i]);
                    }
                    else
                    {
                        builder.Append("*");
                    }
                }
                ilog_0.InfoFormat("[DefaultBotSettings] ConstructedCustomDeck = {0}.", builder.ToString());
            }
        }

        [DefaultValue(0)]
        public Triton.Bot.ConstructedMode ConstructedMode
        {
            get
            {
                return this.constructedMode_0;
            }
            set
            {
                if (!value.Equals(this.constructedMode_0))
                {
                    this.constructedMode_0 = value;
                    base.NotifyPropertyChanged<Triton.Bot.ConstructedMode>(Expression.Lambda<Func<Triton.Bot.ConstructedMode>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_ConstructedMode)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] ConstructedMode = {0}.", this.constructedMode_0);
            }
        }

        [DefaultValue("")]
        public string FriendlyAllowedName
        {
            get
            {
                return this.string_4;
            }
            set
            {
                if (!value.Equals(this.string_4))
                {
                    this.string_4 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_FriendlyAllowedName)), new ParameterExpression[0]));
                }
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < this.string_4.Length; i++)
                {
                    if (i <= 2)
                    {
                        builder.Append(this.string_4[i]);
                    }
                    else
                    {
                        builder.Append("*");
                    }
                }
                ilog_0.InfoFormat("[DefaultBotSettings] FriendlyAllowedName = {0}.", builder.ToString());
            }
        }

        [DefaultValue("")]
        public string FriendlyCustomDeck
        {
            get
            {
                return this.string_3;
            }
            set
            {
                if (!value.Equals(this.string_3))
                {
                    this.string_3 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_FriendlyCustomDeck)), new ParameterExpression[0]));
                }
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < this.string_3.Length; i++)
                {
                    if (i <= 2)
                    {
                        builder.Append(this.string_3[i]);
                    }
                    else
                    {
                        builder.Append("*");
                    }
                }
                ilog_0.InfoFormat("[DefaultBotSettings] FriendlyCustomDeck = {0}.", builder.ToString());
            }
        }

        [DefaultValue(0)]
        public Triton.Bot.GameMode GameMode
        {
            get
            {
                return this.gameMode_0;
            }
            set
            {
                if (!value.Equals(this.gameMode_0))
                {
                    this.gameMode_0 = value;
                    base.NotifyPropertyChanged<Triton.Bot.GameMode>(Expression.Lambda<Func<Triton.Bot.GameMode>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_GameMode)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] GameMode = {0}.", this.gameMode_0);
            }
        }

        [DefaultValue(true)]
        public bool HideInactiveGameMode
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                if (!value.Equals(this.bool_2))
                {
                    this.bool_2 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_HideInactiveGameMode)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] HideInactiveGameMode = {0}.", this.bool_2);
            }
        }

        public static DefaultBotSettings Instance
        {
            get
            {
                return (defaultBotSettings_0 ?? (defaultBotSettings_0 = new DefaultBotSettings()));
            }
        }

        [DefaultValue(false), JsonIgnore]
        public bool NeedsToCacheCustomDecks
        {
            get
            {
                return (!this.ClientBroken && this.bool_8);
            }
            set
            {
                if (!value.Equals(this.bool_8))
                {
                    this.bool_8 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_NeedsToCacheCustomDecks)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] NeedsToCacheCustomDecks = {0}.", this.bool_8);
            }
        }

        [DefaultValue(true), JsonIgnore]
        public bool NeedsToCacheQuests
        {
            get
            {
                return (!this.ClientBroken && this.bool_9);
            }
            set
            {
                if (!value.Equals(this.bool_9))
                {
                    this.bool_9 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_NeedsToCacheQuests)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] NeedsToCacheQuests = {0}.", this.bool_9);
            }
        }

        [JsonIgnore]
        public AdventureDbId PracticeAdventureId
        {
            get
            {
                if (this.GameMode != Triton.Bot.GameMode.Practice)
                {
                    throw new Exception(string.Format("[PracticeAdventureId] GameMode is set to an unexpected value: {0}.", this.GameMode));
                }
                return AdventureDbId.PRACTICE;
            }
        }

        [JsonIgnore]
        public AdventureModeDbId PracticeAdventureModeId
        {
            get
            {
                if (this.PracticeDifficulty == Triton.Bot.PracticeDifficulty.Expert)
                {
                    return AdventureModeDbId.EXPERT;
                }
                if (this.PracticeDifficulty != Triton.Bot.PracticeDifficulty.Normal)
                {
                    throw new Exception(string.Format("[PracticeAdventureModeId] PracticeDifficulty is set to an unexpected value: {0}.", this.PracticeDifficulty));
                }
                return AdventureModeDbId.NORMAL;
            }
        }

        [DefaultValue("")]
        public string PracticeCustomDeck
        {
            get
            {
                return this.string_1;
            }
            set
            {
                if (!value.Equals(this.string_1))
                {
                    this.string_1 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_PracticeCustomDeck)), new ParameterExpression[0]));
                }
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < this.string_1.Length; i++)
                {
                    if (i <= 2)
                    {
                        builder.Append(this.string_1[i]);
                    }
                    else
                    {
                        builder.Append("*");
                    }
                }
                ilog_0.InfoFormat("[DefaultBotSettings] PracticeCustomDeck = {0}.", builder.ToString());
            }
        }

        [DefaultValue(0)]
        public Triton.Bot.PracticeDifficulty PracticeDifficulty
        {
            get
            {
                return this.practiceDifficulty_0;
            }
            set
            {
                if (!value.Equals(this.practiceDifficulty_0))
                {
                    this.practiceDifficulty_0 = value;
                    base.NotifyPropertyChanged<Triton.Bot.PracticeDifficulty>(Expression.Lambda<Func<Triton.Bot.PracticeDifficulty>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_PracticeDifficulty)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] PracticeDifficulty = {0}.", this.practiceDifficulty_0);
            }
        }

        [DefaultValue(3)]
        public TAG_CLASS PracticeOpponentClass
        {
            get
            {
                return this.tag_CLASS_0;
            }
            set
            {
                if (!value.Equals(this.tag_CLASS_0))
                {
                    this.tag_CLASS_0 = value;
                    base.NotifyPropertyChanged<TAG_CLASS>(Expression.Lambda<Func<TAG_CLASS>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_PracticeOpponentClass)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] PracticeOpponentClass = {0}.", this.tag_CLASS_0);
            }
        }

        [DefaultValue(true)]
        public bool RoutineMustDraftArena
        {
            get
            {
                return this.bool_6;
            }
            set
            {
                if (!value.Equals(this.bool_6))
                {
                    this.bool_6 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_RoutineMustDraftArena)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] RoutineMustDraftArena = {0}.", this.bool_6);
            }
        }

        [DefaultValue("")]
        public string SpectateAllowedName
        {
            get
            {
                return this.string_5;
            }
            set
            {
                if (!value.Equals(this.string_5))
                {
                    this.string_5 = value;
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_SpectateAllowedName)), new ParameterExpression[0]));
                }
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < this.string_5.Length; i++)
                {
                    if (i <= 2)
                    {
                        builder.Append(this.string_5[i]);
                    }
                    else
                    {
                        builder.Append("*");
                    }
                }
                ilog_0.InfoFormat("[DefaultBotSettings] SpectateAllowedName = {0}.", builder.ToString());
            }
        }

        [DefaultValue(true)]
        public bool SpectateRandomFriend
        {
            get
            {
                return this.bool_7;
            }
            set
            {
                if (!value.Equals(this.bool_7))
                {
                    this.bool_7 = value;
                    base.NotifyPropertyChanged<bool>(Expression.Lambda<Func<bool>>(Expression.Property(Expression.Constant(this, typeof(DefaultBotSettings)), (MethodInfo) methodof(DefaultBotSettings.get_SpectateRandomFriend)), new ParameterExpression[0]));
                }
                ilog_0.InfoFormat("[DefaultBotSettings] SpectateRandomFriend = {0}.", this.bool_7);
            }
        }
    }
}


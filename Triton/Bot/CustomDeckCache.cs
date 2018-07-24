namespace Triton.Bot
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq.Expressions;
    using System.Reflection;
    using Triton.Bot.Settings;
    using Triton.Common;

    public class CustomDeckCache : JsonSettings
    {
        private long long_0;
        private ObservableCollection<string> observableCollection_0;
        private string string_1;
        private string string_2;

        public CustomDeckCache(long id) : base(GetFileNameFor(id))
        {
            if (this.observableCollection_0 == null)
            {
                this.observableCollection_0 = new ObservableCollection<string>();
            }
        }

        public static string GetFileNameFor(long id)
        {
            string[] subPathParts = new string[] { Configuration.Instance.Name, "CustomDecks", string.Format("{0}.json", id) };
            return JsonSettings.GetSettingsFilePath(subPathParts);
        }

        public ObservableCollection<string> CardIds
        {
            get
            {
                return this.observableCollection_0;
            }
            set
            {
                if (!value.Equals(this.observableCollection_0))
                {
                    this.observableCollection_0 = value;
                    base.NotifyPropertyChanged<ObservableCollection<string>>(Expression.Lambda<Func<ObservableCollection<string>>>(Expression.Property(Expression.Constant(this, typeof(CustomDeckCache)), (MethodInfo) methodof(CustomDeckCache.get_CardIds)), new ParameterExpression[0]));
                }
            }
        }

        public long DeckId
        {
            get
            {
                return this.long_0;
            }
            set
            {
                if (!value.Equals(this.long_0))
                {
                    this.long_0 = value;
                    base.NotifyPropertyChanged<long>(Expression.Lambda<Func<long>>(Expression.Property(Expression.Constant(this, typeof(CustomDeckCache)), (MethodInfo) methodof(CustomDeckCache.get_DeckId)), new ParameterExpression[0]));
                }
            }
        }

        public string HeroCardId
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
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(CustomDeckCache)), (MethodInfo) methodof(CustomDeckCache.get_HeroCardId)), new ParameterExpression[0]));
                }
            }
        }

        public string Name
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
                    base.NotifyPropertyChanged<string>(Expression.Lambda<Func<string>>(Expression.Property(Expression.Constant(this, typeof(CustomDeckCache)), (MethodInfo) methodof(CustomDeckCache.get_Name)), new ParameterExpression[0]));
                }
            }
        }
    }
}


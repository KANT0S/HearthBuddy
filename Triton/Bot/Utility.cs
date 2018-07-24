namespace Triton.Bot
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using Triton.Bot.Settings;
    using Triton.Common;
    using Triton.Game.Mapping;

    public static class Utility
    {
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        public static readonly System.Random Random = new System.Random();

        internal static void smethod_0(object object_0)
        {
            IConfigurable configurable = object_0 as IConfigurable;
            if (configurable != null)
            {
                JsonSettings settings = configurable.Settings;
                if (settings != null)
                {
                    Configuration.Instance.AddSettings(settings);
                }
            }
        }

        internal static void smethod_1(object object_0)
        {
            IConfigurable configurable = object_0 as IConfigurable;
            if (configurable != null)
            {
                JsonSettings settings = configurable.Settings;
                if (settings != null)
                {
                    Configuration.Instance.RemoveSettings(settings);
                }
            }
        }

        internal static bool smethod_2(long long_0, string string_0)
        {
            foreach (CustomDeckCache cache in MainSettings.Instance.CustomDecks)
            {
                if ((cache.DeckId == long_0) && cache.Name.Equals(string_0))
                {
                    return false;
                }
            }
            return true;
        }

        internal static void smethod_3()
        {
            MainSettings.Instance.CustomDecks.Clear();
            MainSettings.Instance.Save();
        }

        internal static void smethod_4()
        {
            try
            {
                CollectionDeckTray tray = CollectionDeckTray.Get();
                if (tray != null)
                {
                    using (List<TraySection>.Enumerator enumerator = tray.m_decksContent.m_traySections.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            CollectionDeckBoxVisual deckBox = enumerator.Current.m_deckBox;
                            long deckID = deckBox.GetDeckID();
                            string text = deckBox.m_deckName.Text;
                            if (((deckID == -1L) || !deckBox.IsValid()) || !smethod_2(deckID, text))
                            {
                                continue;
                            }
                            CustomDeckCache item = null;
                            bool flag = true;
                            using (IEnumerator<CustomDeckCache> enumerator2 = MainSettings.Instance.CustomDecks.GetEnumerator())
                            {
                                CustomDeckCache current;
                                while (enumerator2.MoveNext())
                                {
                                    current = enumerator2.Current;
                                    if (current.DeckId == deckID)
                                    {
                                        goto Label_00A7;
                                    }
                                }
                                goto Label_00CC;
                            Label_00A7:
                                item = current;
                                item.Name = text;
                                item.Save();
                                flag = false;
                            }
                        Label_00CC:
                            if (item == null)
                            {
                                item = new CustomDeckCache(deckID) {
                                    DeckId = deckID,
                                    HeroCardId = deckBox.m_heroCardID,
                                    Name = deckBox.GetDeckNameText().Text
                                };
                            }
                            CollectionDeck deck = CollectionManager.Get().GetDeck(deckID);
                            if (!deck.m_netContentsLoaded)
                            {
                                if ((item.CardIds.Count == 30) && flag)
                                {
                                    MainSettings.Instance.CustomDecks.Add(item);
                                }
                            }
                            else
                            {
                                item.CardIds.Clear();
                                foreach (CollectionDeckSlot slot in deck.m_slots)
                                {
                                    for (int i = 0; i < slot.Count; i++)
                                    {
                                        item.CardIds.Add(slot.CardID);
                                    }
                                }
                                item.Save();
                                if (flag)
                                {
                                    MainSettings.Instance.CustomDecks.Add(item);
                                    MainSettings.Instance.Save();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MainSettings.Instance.CustomDecks.Clear();
                MainSettings.Instance.Save();
                throw;
            }
        }
    }
}


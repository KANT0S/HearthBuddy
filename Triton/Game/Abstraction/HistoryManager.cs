namespace Triton.Game.Abstraction
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public static class HistoryManager
    {
        [CompilerGenerated]
        private static bool bool_0;
        public static readonly List<Triton.Game.Abstraction.HistoryCard> History = new List<Triton.Game.Abstraction.HistoryCard>();
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private static readonly List<IntPtr> list_0 = new List<IntPtr>();
        private static readonly Stopwatch stopwatch_0 = new Stopwatch();
        [CompilerGenerated]
        private static Vector3 vector3_0;

        public static void Reset()
        {
            ilog_0.InfoFormat("[HistoryManager] Now resetting...", Array.Empty<object>());
            list_0.Clear();
            History.Clear();
        }

        public static void Update()
        {
            List<IntPtr> list4;
            Triton.Game.Mapping.HistoryManager manager = Triton.Game.Mapping.HistoryManager.Get();
            if (manager == null)
            {
                return;
            }
            List<Triton.Game.Mapping.HistoryCard> historyTiles = manager.m_historyTiles;
            if (historyTiles == null)
            {
                return;
            }
            List<Triton.Game.Mapping.HistoryManager.HistoryEntry> queuedEntries = manager.m_queuedEntries;
            if ((queuedEntries != null) && queuedEntries.Any<Triton.Game.Mapping.HistoryManager.HistoryEntry>())
            {
                foreach (Triton.Game.Mapping.HistoryManager.HistoryEntry entry in queuedEntries)
                {
                    ilog_0.InfoFormat("0x{0:X}", entry.Address.ToInt32());
                }
            }
            List<IntPtr> list3 = new List<IntPtr>();
            using (List<Triton.Game.Mapping.HistoryCard>.Enumerator enumerator2 = historyTiles.GetEnumerator())
            {
                Triton.Game.Mapping.HistoryCard current;
                while (enumerator2.MoveNext())
                {
                    current = enumerator2.Current;
                    list3.Add(current.Address);
                    if (!list_0.Contains(current.Address))
                    {
                        if (!current.hasBeenShown)
                        {
                            return;
                        }
                        if (!current.ChildrenLoaded() || (!current.historyChildren.Any<Triton.Game.Mapping.HistoryChildCard>() && !current.mousedOver))
                        {
                            goto Label_012E;
                        }
                        NeedsToMouseOver = false;
                        Triton.Game.Abstraction.HistoryCard item = new Triton.Game.Abstraction.HistoryCard(current);
                        History.Add(item);
                        ilog_0.InfoFormat("[HistoryManager] Update is now adding [{0}].", item);
                        list_0.Add(current.Address);
                    }
                }
                goto Label_015D;
            Label_012E:
                NeedsToMouseOver = true;
                MouseOverPosition = current.m_tileActor.Transform.Position;
                return;
            }
        Label_015D:
            list4 = new List<IntPtr>();
            foreach (IntPtr ptr2 in list_0)
            {
                if (!list3.Contains(ptr2))
                {
                    list4.Add(ptr2);
                }
            }
            foreach (IntPtr ptr3 in list4)
            {
                list_0.Remove(ptr3);
            }
        }

        public static Vector3 MouseOverPosition
        {
            [CompilerGenerated]
            get
            {
                return vector3_0;
            }
            [CompilerGenerated]
            private set
            {
                vector3_0 = value;
            }
        }

        public static bool NeedsToMouseOver
        {
            [CompilerGenerated]
            get
            {
                return bool_0;
            }
            [CompilerGenerated]
            private set
            {
                bool_0 = value;
            }
        }
    }
}


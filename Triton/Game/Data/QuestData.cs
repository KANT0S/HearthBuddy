namespace Triton.Game.Data
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class QuestData
    {
        [CompilerGenerated]
        private List<QuestTileData> list_0;

        internal QuestData()
        {
            this.QuestTiles = new List<QuestTileData>();
        }

        public List<QuestTileData> QuestTiles
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            private set
            {
                this.list_0 = value;
            }
        }
    }
}


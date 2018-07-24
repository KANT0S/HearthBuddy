namespace Triton.Game.Data
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class AchievementData
    {
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        [CompilerGenerated]
        private int int_2;
        [CompilerGenerated]
        private List<Triton.Game.Data.RewardData> list_0;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;

        internal AchievementData(Achievement achievement)
        {
            this.Id = achievement.ID;
            this.Name = achievement.Name;
            this.Description = achievement.Description;
            this.CurProgress = achievement.m_progress;
            this.MaxProgress = achievement.m_maxProgress;
            this.RewardData = new List<Triton.Game.Data.RewardData>();
            if (achievement.m_rewards != null)
            {
                foreach (Triton.Game.Mapping.RewardData data in achievement.m_rewards)
                {
                    this.RewardData.Add(new Triton.Game.Data.RewardData(data));
                }
            }
        }

        public int CurProgress
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            private set
            {
                this.int_1 = value;
            }
        }

        public string Description
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            private set
            {
                this.string_1 = value;
            }
        }

        public int Id
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            private set
            {
                this.int_0 = value;
            }
        }

        public int MaxProgress
        {
            [CompilerGenerated]
            get
            {
                return this.int_2;
            }
            [CompilerGenerated]
            private set
            {
                this.int_2 = value;
            }
        }

        public string Name
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }

        public List<Triton.Game.Data.RewardData> RewardData
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


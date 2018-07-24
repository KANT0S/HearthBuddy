namespace Triton.Game.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class QuestTileData
    {
        [CompilerGenerated]
        private AchievementData achievementData_0;
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        [CompilerGenerated]
        private Vector3 vector3_0;

        internal QuestTileData(QuestTile questTile)
        {
            this.Vector3_0 = questTile.m_cancelButton.Transform.Position;
            this.Achievement = new AchievementData(questTile.m_quest);
            this.IsCancelable = questTile.m_cancelButtonRoot.Active;
        }

        public AchievementData Achievement
        {
            [CompilerGenerated]
            get
            {
                return this.achievementData_0;
            }
            [CompilerGenerated]
            private set
            {
                this.achievementData_0 = value;
            }
        }

        public bool IsCancelable
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }

        public bool ShouldCancel
        {
            [CompilerGenerated]
            get
            {
                return this.bool_1;
            }
            [CompilerGenerated]
            set
            {
                this.bool_1 = value;
            }
        }

        internal Vector3 Vector3_0
        {
            [CompilerGenerated]
            get
            {
                return this.vector3_0;
            }
            [CompilerGenerated]
            private set
            {
                this.vector3_0 = value;
            }
        }
    }
}


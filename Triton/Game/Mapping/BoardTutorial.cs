namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BoardTutorial")]
    public class BoardTutorial : MonoBehaviour
    {
        public BoardTutorial(IntPtr address) : this(address, "BoardTutorial")
        {
        }

        public BoardTutorial(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void EnableEnemyHighlight(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableEnemyHighlight", objArray1);
        }

        public void EnableFullHighlight(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableFullHighlight", objArray1);
        }

        public void EnableHighlight(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableHighlight", objArray1);
        }

        public static BoardTutorial Get()
        {
            return MonoClass.smethod_15<BoardTutorial>(TritonHs.MainAssemblyPath, "", "BoardTutorial", "Get", Array.Empty<object>());
        }

        public bool IsHighlightEnabled()
        {
            return base.method_11<bool>("IsHighlightEnabled", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void UpdateEnemyHighlight()
        {
            base.method_8("UpdateEnemyHighlight", Array.Empty<object>());
        }

        public void UpdateHighlight()
        {
            base.method_8("UpdateHighlight", Array.Empty<object>());
        }

        public GameObject m_EnemyHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_EnemyHighlight");
            }
        }

        public bool m_enemyHighlightEnabled
        {
            get
            {
                return base.method_2<bool>("m_enemyHighlightEnabled");
            }
        }

        public GameObject m_Highlight
        {
            get
            {
                return base.method_3<GameObject>("m_Highlight");
            }
        }

        public bool m_highlightEnabled
        {
            get
            {
                return base.method_2<bool>("m_highlightEnabled");
            }
        }
    }
}


namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BoardStandardGame")]
    public class BoardStandardGame : MonoBehaviour
    {
        public BoardStandardGame(IntPtr address) : this(address, "BoardStandardGame")
        {
        }

        public BoardStandardGame(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeckColors()
        {
            base.method_8("DeckColors", Array.Empty<object>());
        }

        public Transform FindBone(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<Transform>("FindBone", objArray1);
        }

        public Collider FindCollider(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<Collider>("FindCollider", objArray1);
        }

        public static BoardStandardGame Get()
        {
            return MonoClass.smethod_15<BoardStandardGame>(TritonHs.MainAssemblyPath, "", "BoardStandardGame", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public Transform m_BoneParent
        {
            get
            {
                return base.method_3<Transform>("m_BoneParent");
            }
        }

        public Transform m_ColliderParent
        {
            get
            {
                return base.method_3<Transform>("m_ColliderParent");
            }
        }

        public List<GameObject> m_DeckGameObjects
        {
            get
            {
                Class247<GameObject> class2 = base.method_3<Class247<GameObject>>("m_DeckGameObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}


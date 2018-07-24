namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SetParenttByName")]
    public class SetParenttByName : MonoBehaviour
    {
        public SetParenttByName(IntPtr address) : this(address, "SetParenttByName")
        {
        }

        public SetParenttByName(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject FindGameObject(string gameObjName)
        {
            object[] objArray1 = new object[] { gameObjName };
            return base.method_14<GameObject>("FindGameObject", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public string m_ParentName
        {
            get
            {
                return base.method_4("m_ParentName");
            }
        }
    }
}


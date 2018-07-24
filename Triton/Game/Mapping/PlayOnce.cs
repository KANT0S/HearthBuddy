namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PlayOnce")]
    public class PlayOnce : MonoBehaviour
    {
        public PlayOnce(IntPtr address) : this(address, "PlayOnce")
        {
        }

        public PlayOnce(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public string notes
        {
            get
            {
                return base.method_4("notes");
            }
        }

        public string notes2
        {
            get
            {
                return base.method_4("notes2");
            }
        }

        public GameObject tester
        {
            get
            {
                return base.method_3<GameObject>("tester");
            }
        }

        public GameObject tester2
        {
            get
            {
                return base.method_3<GameObject>("tester2");
            }
        }

        public string tester2Anim
        {
            get
            {
                return base.method_4("tester2Anim");
            }
        }

        public GameObject tester3
        {
            get
            {
                return base.method_3<GameObject>("tester3");
            }
        }

        public string tester3Anim
        {
            get
            {
                return base.method_4("tester3Anim");
            }
        }

        public string testerAnim
        {
            get
            {
                return base.method_4("testerAnim");
            }
        }
    }
}


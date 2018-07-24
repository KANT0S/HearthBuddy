namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CoinEffect")]
    public class CoinEffect : MonoBehaviour
    {
        public CoinEffect(IntPtr address) : this(address, "CoinEffect")
        {
        }

        public CoinEffect(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoAnim(bool localWin)
        {
            object[] objArray1 = new object[] { localWin };
            base.method_8("DoAnim", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public string animToUse
        {
            get
            {
                return base.method_4("animToUse");
            }
        }

        public GameObject coin
        {
            get
            {
                return base.method_3<GameObject>("coin");
            }
        }

        public string coinDropAnim
        {
            get
            {
                return base.method_4("coinDropAnim");
            }
        }

        public string coinDropAnim2
        {
            get
            {
                return base.method_4("coinDropAnim2");
            }
        }

        public GameObject coinGlow
        {
            get
            {
                return base.method_3<GameObject>("coinGlow");
            }
        }

        public string coinGlowDropAnim
        {
            get
            {
                return base.method_4("coinGlowDropAnim");
            }
        }

        public string coinGlowDropAnim2
        {
            get
            {
                return base.method_4("coinGlowDropAnim2");
            }
        }

        public string coinSpawnAnim
        {
            get
            {
                return base.method_4("coinSpawnAnim");
            }
        }

        public GameObject coinSpawnObject
        {
            get
            {
                return base.method_3<GameObject>("coinSpawnObject");
            }
        }

        public string GlowanimToUse
        {
            get
            {
                return base.method_4("GlowanimToUse");
            }
        }
    }
}


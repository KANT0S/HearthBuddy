namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RankedPlayDisplay")]
    public class RankedPlayDisplay : MonoBehaviour
    {
        public RankedPlayDisplay(IntPtr address) : this(address, "RankedPlayDisplay")
        {
        }

        public RankedPlayDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnCasualButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCasualButtonOut", objArray1);
        }

        public void OnCasualButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCasualButtonOver", objArray1);
        }

        public void OnCasualButtonRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCasualButtonRelease", objArray1);
        }

        public void OnRankedButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRankedButtonOut", objArray1);
        }

        public void OnRankedButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRankedButtonOver", objArray1);
        }

        public void OnRankedButtonRelease(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRankedButtonRelease", objArray1);
        }

        public void SetRankedMedal(NetCache.NetCacheMedalInfo medal)
        {
            object[] objArray1 = new object[] { medal };
            base.method_8("SetRankedMedal", objArray1);
        }

        public void SetRankedMedalTransform(Transform bone)
        {
            object[] objArray1 = new object[] { bone };
            base.method_8("SetRankedMedalTransform", objArray1);
        }

        public void UpdateMode()
        {
            base.method_8("UpdateMode", Array.Empty<object>());
        }

        public RankedPlayToggleButton m_casualButton
        {
            get
            {
                return base.method_3<RankedPlayToggleButton>("m_casualButton");
            }
        }

        public TournamentMedal m_medal
        {
            get
            {
                return base.method_3<TournamentMedal>("m_medal");
            }
        }

        public Transform m_medalBone
        {
            get
            {
                return base.method_3<Transform>("m_medalBone");
            }
        }

        public TournamentMedal m_medalPrefab
        {
            get
            {
                return base.method_3<TournamentMedal>("m_medalPrefab");
            }
        }

        public RankedPlayToggleButton m_rankedButton
        {
            get
            {
                return base.method_3<RankedPlayToggleButton>("m_rankedButton");
            }
        }
    }
}


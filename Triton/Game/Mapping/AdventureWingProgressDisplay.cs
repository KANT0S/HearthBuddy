namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureWingProgressDisplay")]
    public class AdventureWingProgressDisplay : MonoBehaviour
    {
        public AdventureWingProgressDisplay(IntPtr address) : this(address, "AdventureWingProgressDisplay")
        {
        }

        public AdventureWingProgressDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public bool HasProgressAnimationToPlay()
        {
            return base.method_11<bool>("HasProgressAnimationToPlay", Array.Empty<object>());
        }

        public void UpdateProgress(WingDbId wingDbId, bool normalComplete)
        {
            object[] objArray1 = new object[] { wingDbId, normalComplete };
            base.method_8("UpdateProgress", objArray1);
        }
    }
}


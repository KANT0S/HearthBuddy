namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendlyChallengeHelper")]
    public class FriendlyChallengeHelper : MonoClass
    {
        public FriendlyChallengeHelper(IntPtr address) : this(address, "FriendlyChallengeHelper")
        {
        }

        public FriendlyChallengeHelper(IntPtr address, string className) : base(address, className)
        {
        }

        public static FriendlyChallengeHelper Get()
        {
            return MonoClass.smethod_15<FriendlyChallengeHelper>(TritonHs.MainAssemblyPath, "", "FriendlyChallengeHelper", "Get", Array.Empty<object>());
        }

        public void HideFriendChallengeWaitingForOpponentDialog()
        {
            base.method_8("HideFriendChallengeWaitingForOpponentDialog", Array.Empty<object>());
        }

        public bool OnFriendChallengeWaitingForOpponentDialogProcessed(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnFriendChallengeWaitingForOpponentDialogProcessed", objArray1);
        }

        public void StopWaitingForFriendChallenge()
        {
            base.method_8("StopWaitingForFriendChallenge", Array.Empty<object>());
        }

        public void WaitForFriendChallengeToStart()
        {
            base.method_8("WaitForFriendChallengeToStart", Array.Empty<object>());
        }

        public AlertPopup m_friendChallengeWaitingPopup
        {
            get
            {
                return base.method_3<AlertPopup>("m_friendChallengeWaitingPopup");
            }
        }
    }
}


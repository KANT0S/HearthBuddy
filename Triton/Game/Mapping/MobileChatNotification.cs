namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MobileChatNotification")]
    public class MobileChatNotification : MonoBehaviour
    {
        public MobileChatNotification(IntPtr address) : this(address, "MobileChatNotification")
        {
        }

        public MobileChatNotification(IntPtr address, string className) : base(address, className)
        {
        }

        public void FireNotification()
        {
            base.method_8("FireNotification", Array.Empty<object>());
        }

        public string GetStateText(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_13("GetStateText", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OnTurnChanged(int oldTurn, int newTurn, object userData)
        {
            object[] objArray1 = new object[] { oldTurn, newTurn, userData };
            base.method_8("OnTurnChanged", objArray1);
        }

        public void OnTurnTimerUpdate(TurnTimerUpdate update, object userData)
        {
            object[] objArray1 = new object[] { update, userData };
            base.method_8("OnTurnTimerUpdate", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public State state
        {
            get
            {
                return base.method_2<State>("state");
            }
        }

        public enum State
        {
            None,
            GameStarted,
            YourTurn,
            TurnCountdown
        }
    }
}


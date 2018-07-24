namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SetRenderSettings")]
    public class SetRenderSettings : MonoBehaviour
    {
        public SetRenderSettings(IntPtr address) : this(address, "SetRenderSettings")
        {
        }

        public SetRenderSettings(IntPtr address, string className) : base(address, className)
        {
        }

        public void disableAmbientUpdates()
        {
            base.method_8("disableAmbientUpdates", Array.Empty<object>());
        }

        public void enableAmbientUpdates()
        {
            base.method_8("enableAmbientUpdates", Array.Empty<object>());
        }

        public void OnPreviousSceneDestroyed(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnPreviousSceneDestroyed", objArray1);
        }

        public void SetColor(Color newColor)
        {
            object[] objArray1 = new object[] { newColor };
            base.method_8("SetColor", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Color m_ambient
        {
            get
            {
                return base.method_2<Color>("m_ambient");
            }
        }

        public bool m_ambient_shouldUpdate
        {
            get
            {
                return base.method_2<bool>("m_ambient_shouldUpdate");
            }
        }

        public Color m_lastSavedAmbient
        {
            get
            {
                return base.method_2<Color>("m_lastSavedAmbient");
            }
        }
    }
}


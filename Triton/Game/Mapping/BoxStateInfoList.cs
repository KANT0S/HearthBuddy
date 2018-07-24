namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxStateInfoList")]
    public class BoxStateInfoList : MonoClass
    {
        public BoxStateInfoList(IntPtr address) : this(address, "BoxStateInfoList")
        {
        }

        public BoxStateInfoList(IntPtr address, string className) : base(address, className)
        {
        }

        public BoxCameraStateInfo m_CameraInfo
        {
            get
            {
                return base.method_3<BoxCameraStateInfo>("m_CameraInfo");
            }
        }

        public BoxDiskStateInfo m_DiskInfo
        {
            get
            {
                return base.method_3<BoxDiskStateInfo>("m_DiskInfo");
            }
        }

        public BoxDrawerStateInfo m_DrawerInfo
        {
            get
            {
                return base.method_3<BoxDrawerStateInfo>("m_DrawerInfo");
            }
        }

        public BoxDoorStateInfo m_LeftDoorInfo
        {
            get
            {
                return base.method_3<BoxDoorStateInfo>("m_LeftDoorInfo");
            }
        }

        public BoxLogoStateInfo m_LogoInfo
        {
            get
            {
                return base.method_3<BoxLogoStateInfo>("m_LogoInfo");
            }
        }

        public BoxDoorStateInfo m_RightDoorInfo
        {
            get
            {
                return base.method_3<BoxDoorStateInfo>("m_RightDoorInfo");
            }
        }

        public BoxSpinnerStateInfo m_SpinnerInfo
        {
            get
            {
                return base.method_3<BoxSpinnerStateInfo>("m_SpinnerInfo");
            }
        }

        public BoxStartButtonStateInfo m_StartButtonInfo
        {
            get
            {
                return base.method_3<BoxStartButtonStateInfo>("m_StartButtonInfo");
            }
        }
    }
}


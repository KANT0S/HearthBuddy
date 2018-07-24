namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BoardCameras")]
    public class BoardCameras : MonoBehaviour
    {
        public BoardCameras(IntPtr address) : this(address, "BoardCameras")
        {
        }

        public BoardCameras(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static BoardCameras Get()
        {
            return MonoClass.smethod_15<BoardCameras>(TritonHs.MainAssemblyPath, "", "BoardCameras", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }
    }
}


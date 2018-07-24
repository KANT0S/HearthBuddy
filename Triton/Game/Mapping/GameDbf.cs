namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameDbf")]
    public class GameDbf : MonoClass
    {
        public GameDbf(IntPtr address) : this(address, "GameDbf")
        {
        }

        public GameDbf(IntPtr address, string className) : base(address, className)
        {
        }

        public static GameDbfIndex GetIndex()
        {
            return MonoClass.smethod_15<GameDbfIndex>(TritonHs.MainAssemblyPath, "", "GameDbf", "GetIndex", Array.Empty<object>());
        }

        public static void Load()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "GameDbf", "Load");
        }

        public static void Reload(string name, string xml)
        {
            object[] objArray1 = new object[] { name, xml };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "GameDbf", "Reload", objArray1);
        }

        public static GameDbfIndex s_index
        {
            get
            {
                return MonoClass.smethod_7<GameDbfIndex>(TritonHs.MainAssemblyPath, "", "GameDbf", "s_index");
            }
        }
    }
}


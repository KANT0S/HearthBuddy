namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureGenericButton")]
    public class AdventureGenericButton : PegUIElement
    {
        public AdventureGenericButton(IntPtr address) : this(address, "AdventureGenericButton")
        {
        }

        public AdventureGenericButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void ApplyPortraitTexture(string name, object obj, object userdata)
        {
            object[] objArray1 = new object[] { name, obj, userdata };
            base.method_8("ApplyPortraitTexture", objArray1);
        }

        public bool CheckValidMaterialProperties(MaterialProperties matprop)
        {
            object[] objArray1 = new object[] { matprop };
            return base.method_11<bool>("CheckValidMaterialProperties", objArray1);
        }

        public bool IsPortraitLoaded()
        {
            return base.method_11<bool>("IsPortraitLoaded", Array.Empty<object>());
        }

        public void SetButtonText(string str)
        {
            object[] objArray1 = new object[] { str };
            base.method_8("SetButtonText", objArray1);
        }

        public void SetDesaturate(bool desaturate)
        {
            object[] objArray1 = new object[] { desaturate };
            base.method_8("SetDesaturate", objArray1);
        }

        public void SetPortraitOffset(Vector2 offset)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { offset };
            base.method_9("SetPortraitOffset", enumArray1, objArray1);
        }

        public void SetPortraitOffset(Vector2 offset, int index, string mattexprop)
        {
            object[] objArray1 = new object[] { offset, index, mattexprop };
            base.method_9("SetPortraitOffset", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public void SetPortraitTexture(string texturename)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { texturename };
            base.method_9("SetPortraitTexture", enumArray1, objArray1);
        }

        public void SetPortraitTexture(string texturename, int index, string mattexprop)
        {
            object[] objArray1 = new object[] { texturename, index, mattexprop };
            base.method_9("SetPortraitTexture", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void SetPortraitTiling(Vector2 tiling)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { tiling };
            base.method_9("SetPortraitTiling", enumArray1, objArray1);
        }

        public void SetPortraitTiling(Vector2 tiling, int index, string mattexprop)
        {
            object[] objArray1 = new object[] { tiling, index, mattexprop };
            base.method_9("SetPortraitTiling", new Class272.Enum20[] { Class272.Enum20.ValueType }, objArray1);
        }

        public MaterialProperties m_BorderMaterialProperties
        {
            get
            {
                return base.method_3<MaterialProperties>("m_BorderMaterialProperties");
            }
        }

        public MeshRenderer m_BorderRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_BorderRenderer");
            }
        }

        public UberText m_ButtonTextObject
        {
            get
            {
                return base.method_3<UberText>("m_ButtonTextObject");
            }
        }

        public Color m_DisabledTextColor
        {
            get
            {
                return base.method_2<Color>("m_DisabledTextColor");
            }
        }

        public MaterialProperties m_MaterialProperties
        {
            get
            {
                return base.method_3<MaterialProperties>("m_MaterialProperties");
            }
        }

        public Color m_NormalTextColor
        {
            get
            {
                return base.method_2<Color>("m_NormalTextColor");
            }
        }

        public bool m_PortraitLoaded
        {
            get
            {
                return base.method_2<bool>("m_PortraitLoaded");
            }
        }

        public MeshRenderer m_PortraitRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_PortraitRenderer");
            }
        }

        public static int s_DefaultPortraitMaterialIndex
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AdventureGenericButton", "s_DefaultPortraitMaterialIndex");
            }
        }

        public static string s_DefaultPortraitMaterialTextureName
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureGenericButton", "s_DefaultPortraitMaterialTextureName");
            }
        }

        [Attribute38("AdventureGenericButton.MaterialProperties")]
        public class MaterialProperties : MonoClass
        {
            public MaterialProperties(IntPtr address) : this(address, "MaterialProperties")
            {
            }

            public MaterialProperties(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_MaterialIndex
            {
                get
                {
                    return base.method_2<int>("m_MaterialIndex");
                }
            }

            public string m_MaterialPropertyName
            {
                get
                {
                    return base.method_4("m_MaterialPropertyName");
                }
            }
        }
    }
}


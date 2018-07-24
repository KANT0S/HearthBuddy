namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GameObject")]
    public class GameObject : UnityObject
    {
        public GameObject(IntPtr address) : base(address, "GameObject")
        {
        }

        public Component GetComponent<T>() where T: Component
        {
            return this.GetComponent(typeof(T).Name);
        }

        public Component GetComponent(string type)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { type };
            return base.method_15<Component>("GetComponent", enumArray1, objArray1);
        }

        public bool Active
        {
            get
            {
                return base.method_11<bool>("get_active", Array.Empty<object>());
            }
        }

        public bool ActiveInHierarchy
        {
            get
            {
                return base.method_11<bool>("get_activeInHierarchy", Array.Empty<object>());
            }
        }

        public bool ActiveSelf
        {
            get
            {
                return base.method_11<bool>("get_activeSelf", Array.Empty<object>());
            }
        }

        public Triton.Game.Mapping.Renderer Renderer
        {
            get
            {
                Component component = this.GetComponent<Triton.Game.Mapping.Renderer>();
                if (component == null)
                {
                    return null;
                }
                return new Triton.Game.Mapping.Renderer(component.Address);
            }
        }

        public Triton.Game.Mapping.Transform Transform
        {
            get
            {
                return base.method_14<Triton.Game.Mapping.Transform>("get_transform", Array.Empty<object>());
            }
        }
    }
}


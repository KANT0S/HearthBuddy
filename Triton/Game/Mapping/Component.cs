namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Component")]
    public class Component : UnityObject
    {
        public Component(IntPtr address) : base(address, "Component")
        {
        }

        public Component(IntPtr address, string className) : base(address, className)
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

        public Triton.Game.Mapping.Collider Collider
        {
            get
            {
                return base.method_14<Triton.Game.Mapping.Collider>("get_collider", Array.Empty<object>());
            }
        }

        public Triton.Game.Mapping.GameObject GameObject
        {
            get
            {
                return base.method_14<Triton.Game.Mapping.GameObject>("get_gameObject", Array.Empty<object>());
            }
        }

        public Triton.Game.Mapping.Transform Parent
        {
            get
            {
                return base.method_14<Triton.Game.Mapping.Transform>("get_parent", Array.Empty<object>());
            }
        }

        public string Tag
        {
            get
            {
                return base.method_13("get_tag", Array.Empty<object>());
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


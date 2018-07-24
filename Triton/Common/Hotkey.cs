namespace Triton.Common
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class Hotkey : IEquatable<Hotkey>
    {
        [CompilerGenerated]
        private Action<Hotkey> action_0;
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private Keys keys_0;
        [CompilerGenerated]
        private Triton.Common.ModifierKeys modifierKeys_0;
        [CompilerGenerated]
        private string string_0;

        internal Hotkey(string name, Keys key, Triton.Common.ModifierKeys modifierKeys, int id, Action<Hotkey> callback)
        {
            this.Name = name;
            this.Key = key;
            this.ModifierKeys = modifierKeys;
            this.Id = id;
            this.Callback = callback;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this == obj)
            {
                return true;
            }
            if (obj.GetType() != base.GetType())
            {
                return false;
            }
            return this.Equals((Hotkey) obj);
        }

        public bool Equals(Hotkey other)
        {
            if (other == null)
            {
                return false;
            }
            return ((this == other) || ((this.Id == other.Id) && string.Equals(this.Name, other.Name)));
        }

        public override int GetHashCode()
        {
            return ((this.Id * 0x18d) ^ ((this.Name != null) ? this.Name.GetHashCode() : 0));
        }

        private string method_0()
        {
            string str = "";
            if (this.ModifierKeys.HasFlag(Triton.Common.ModifierKeys.Control))
            {
                str = str + "Ctrl + ";
            }
            if (this.ModifierKeys.HasFlag(Triton.Common.ModifierKeys.Alt))
            {
                str = str + "Alt + ";
            }
            if (this.ModifierKeys.HasFlag(Triton.Common.ModifierKeys.Shift))
            {
                str = str + "Shift + ";
            }
            return (str + this.Key);
        }

        public static bool operator ==(Hotkey left, Hotkey right)
        {
            return object.Equals(left, right);
        }

        public static bool operator !=(Hotkey left, Hotkey right)
        {
            return !object.Equals(left, right);
        }

        public override string ToString()
        {
            return (this.Name + " [" + this.method_0() + "]");
        }

        internal bool Boolean_0
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            set
            {
                this.bool_0 = value;
            }
        }

        public Action<Hotkey> Callback
        {
            [CompilerGenerated]
            get
            {
                return this.action_0;
            }
            [CompilerGenerated]
            set
            {
                this.action_0 = value;
            }
        }

        public int Id
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            private set
            {
                this.int_0 = value;
            }
        }

        public Keys Key
        {
            [CompilerGenerated]
            get
            {
                return this.keys_0;
            }
            [CompilerGenerated]
            private set
            {
                this.keys_0 = value;
            }
        }

        public Triton.Common.ModifierKeys ModifierKeys
        {
            [CompilerGenerated]
            get
            {
                return this.modifierKeys_0;
            }
            [CompilerGenerated]
            private set
            {
                this.modifierKeys_0 = value;
            }
        }

        public string Name
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }
    }
}


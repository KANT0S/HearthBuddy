namespace Infralution.Localization.Wpf
{
    using System;
    using System.Collections.Generic;

    public class MarkupExtensionManager1
    {
        private int int_0;
        private int int_1 = 40;
        private List<ManagedMarkupExtension1> list_0 = new List<ManagedMarkupExtension1>();

        public MarkupExtensionManager1(int cleanupInterval)
        {
            this.int_1 = cleanupInterval;
        }

        public void CleanupInactiveExtensions()
        {
            List<ManagedMarkupExtension1> list = new List<ManagedMarkupExtension1>(this.list_0.Count);
            foreach (ManagedMarkupExtension1 extension in this.list_0)
            {
                if (extension.IsTargetAlive)
                {
                    list.Add(extension);
                }
            }
            this.list_0 = list;
        }

        internal void method_0(ManagedMarkupExtension1 managedMarkupExtension1_0)
        {
            if (this.int_0 > this.int_1)
            {
                this.CleanupInactiveExtensions();
                this.int_0 = 0;
            }
            this.list_0.Add(managedMarkupExtension1_0);
            this.int_0++;
        }

        public virtual void UpdateAllTargets()
        {
            using (List<ManagedMarkupExtension1>.Enumerator enumerator = this.list_0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.UpdateTargets();
                }
            }
        }

        public List<ManagedMarkupExtension1> ActiveExtensions
        {
            get
            {
                return this.list_0;
            }
        }
    }
}


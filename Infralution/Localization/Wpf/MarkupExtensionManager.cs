namespace Infralution.Localization.Wpf
{
    using System;
    using System.Collections.Generic;

    public class MarkupExtensionManager
    {
        private int int_0;
        private int int_1 = 40;
        private List<ManagedMarkupExtension> list_0 = new List<ManagedMarkupExtension>();

        public MarkupExtensionManager(int cleanupInterval)
        {
            this.int_1 = cleanupInterval;
        }

        public void CleanupInactiveExtensions()
        {
            List<ManagedMarkupExtension> list = new List<ManagedMarkupExtension>(this.list_0.Count);
            foreach (ManagedMarkupExtension extension in this.list_0)
            {
                if (extension.IsTargetAlive)
                {
                    list.Add(extension);
                }
            }
            this.list_0 = list;
        }

        internal void method_0(ManagedMarkupExtension managedMarkupExtension_0)
        {
            if (this.int_0 > this.int_1)
            {
                this.CleanupInactiveExtensions();
                this.int_0 = 0;
            }
            this.list_0.Add(managedMarkupExtension_0);
            this.int_0++;
        }

        public virtual void UpdateAllTargets()
        {
            using (List<ManagedMarkupExtension>.Enumerator enumerator = this.list_0.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.UpdateTargets();
                }
            }
        }

        public List<ManagedMarkupExtension> ActiveExtensions
        {
            get
            {
                return this.list_0;
            }
        }
    }
}


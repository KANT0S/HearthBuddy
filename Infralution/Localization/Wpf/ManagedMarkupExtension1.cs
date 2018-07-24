namespace Infralution.Localization.Wpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Markup;

    public abstract class ManagedMarkupExtension1 : MarkupExtension
    {
        private List<WeakReference> list_0 = new List<WeakReference>();
        private object object_0;

        public ManagedMarkupExtension1(MarkupExtensionManager1 manager)
        {
            manager.method_0(this);
        }

        protected abstract object GetValue();
        public bool IsTarget(object target)
        {
            foreach (WeakReference reference in this.list_0)
            {
                if (reference.IsAlive && (reference.Target == target))
                {
                    return true;
                }
            }
            return false;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            this.RegisterTarget(serviceProvider);
            object obj2 = this;
            if (this.object_0 != null)
            {
                obj2 = this.GetValue();
            }
            return obj2;
        }

        protected virtual void RegisterTarget(IServiceProvider serviceProvider)
        {
            IProvideValueTarget service = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
            object targetObject = service.TargetObject;
            if ((targetObject != null) && (targetObject.GetType().FullName != "System.Windows.SharedDp"))
            {
                this.object_0 = service.TargetProperty;
                this.list_0.Add(new WeakReference(targetObject));
            }
        }

        protected virtual void UpdateTarget(object target)
        {
            if (this.object_0 is DependencyProperty)
            {
                DependencyObject obj2 = target as DependencyObject;
                if (obj2 != null)
                {
                    obj2.SetValue(this.object_0 as DependencyProperty, this.GetValue());
                }
            }
            else if (this.object_0 is PropertyInfo)
            {
                (this.object_0 as PropertyInfo).SetValue(target, this.GetValue(), null);
            }
        }

        public void UpdateTargets()
        {
            foreach (WeakReference reference in this.list_0)
            {
                if (reference.IsAlive)
                {
                    this.UpdateTarget(reference.Target);
                }
            }
        }

        public bool IsInDesignMode
        {
            get
            {
                using (List<WeakReference>.Enumerator enumerator = this.list_0.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        DependencyObject target = enumerator.Current.Target as DependencyObject;
                        if ((target != null) && DesignerProperties.GetIsInDesignMode(target))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public bool IsTargetAlive
        {
            get
            {
                if (this.list_0.Count == 0)
                {
                    return true;
                }
                using (List<WeakReference>.Enumerator enumerator = this.list_0.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        if (enumerator.Current.IsAlive)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        protected List<WeakReference> TargetObjects
        {
            get
            {
                return this.list_0;
            }
        }

        protected object TargetProperty
        {
            get
            {
                return this.object_0;
            }
        }

        protected Type TargetPropertyType
        {
            get
            {
                Type type = null;
                if (this.object_0 is DependencyProperty)
                {
                    return (this.object_0 as DependencyProperty).PropertyType;
                }
                if (this.object_0 is PropertyInfo)
                {
                    return (this.object_0 as PropertyInfo).PropertyType;
                }
                if (this.object_0 != null)
                {
                    type = this.object_0.GetType();
                }
                return type;
            }
        }
    }
}


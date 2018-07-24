namespace Infralution.Localization.Wpf
{
    using System;
    using System.Windows.Markup;

    [MarkupExtensionReturnType(typeof(XmlLanguage))]
    public class UICultureExtension : ManagedMarkupExtension
    {
        private static MarkupExtensionManager markupExtensionManager_0 = new MarkupExtensionManager(2);

        public UICultureExtension() : base(markupExtensionManager_0)
        {
        }

        protected override object GetValue()
        {
            return XmlLanguage.GetLanguage(CultureManager.UICulture.IetfLanguageTag);
        }

        public static void UpdateAllTargets()
        {
            markupExtensionManager_0.UpdateAllTargets();
        }

        public static MarkupExtensionManager MarkupManager
        {
            get
            {
                return markupExtensionManager_0;
            }
        }
    }
}


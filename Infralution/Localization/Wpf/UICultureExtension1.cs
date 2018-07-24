namespace Infralution.Localization.Wpf
{
    using System;
    using System.Windows.Markup;

    [MarkupExtensionReturnType(typeof(XmlLanguage))]
    public class UICultureExtension1 : ManagedMarkupExtension1
    {
        private static MarkupExtensionManager1 markupExtensionManager1_0 = new MarkupExtensionManager1(2);

        public UICultureExtension1() : base(markupExtensionManager1_0)
        {
        }

        protected override object GetValue()
        {
            return XmlLanguage.GetLanguage(CultureManager1.UICulture.IetfLanguageTag);
        }

        public static void UpdateAllTargets()
        {
            markupExtensionManager1_0.UpdateAllTargets();
        }

        public static MarkupExtensionManager1 MarkupManager
        {
            get
            {
                return markupExtensionManager1_0;
            }
        }
    }
}


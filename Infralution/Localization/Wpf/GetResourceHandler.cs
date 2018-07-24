namespace Infralution.Localization.Wpf
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    public delegate object GetResourceHandler(string resxName, string key, CultureInfo culture);
}


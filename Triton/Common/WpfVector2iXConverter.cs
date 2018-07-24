namespace Triton.Common
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public sealed class WpfVector2iXConverter : IValueConverter
    {
        private WpfVector2iSettingsDelegate wpfVector2iSettingsDelegate_0;

        public WpfVector2iXConverter(WpfVector2iSettingsDelegate get)
        {
            this.wpfVector2iSettingsDelegate_0 = get;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            WpfVector2i vectori = (WpfVector2i) value;
            return vectori.X;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            WpfVector2i vectori = this.wpfVector2iSettingsDelegate_0();
            vectori.X = int.Parse((string) value);
            return vectori;
        }
    }
}


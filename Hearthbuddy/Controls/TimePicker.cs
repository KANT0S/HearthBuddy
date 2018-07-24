namespace Hearthbuddy.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Input;

    [TemplatePart(Name="PART_Hours", Type=typeof(TextBox)), TemplatePart(Name="PART_Minutes", Type=typeof(TextBox)), TemplatePart(Name="PART_Seconds", Type=typeof(TextBox)), TemplatePart(Name="PART_IncreaseTime", Type=typeof(ButtonBase)), TemplatePart(Name="PART_DecrementTime", Type=typeof(ButtonBase))]
    public class TimePicker : Control
    {
        private bool bool_0;
        private int int_0 = 0x17;
        private int int_1 = 0x3b;
        private int int_2 = 0x3b;
        private int int_3;
        private int int_4;
        private int int_5;
        public static readonly DependencyProperty MaxTimeProperty = DependencyProperty.Register("MaxTime", typeof(TimeSpan), typeof(TimePicker), new UIPropertyMetadata(TimeSpan.MaxValue, new PropertyChangedCallback(Class24.<>9.method_1)));
        public static readonly DependencyProperty MinTimeProperty = DependencyProperty.Register("MinTime", typeof(TimeSpan), typeof(TimePicker), new UIPropertyMetadata(TimeSpan.MinValue, new PropertyChangedCallback(Class24.<>9.method_0)));
        public static readonly DependencyProperty SelectedHourProperty = DependencyProperty.Register("SelectedHour", typeof(int), typeof(TimePicker), new UIPropertyMetadata(0, new PropertyChangedCallback(Class24.<>9.method_2)));
        public static readonly DependencyProperty SelectedMinuteProperty = DependencyProperty.Register("SelectedMinute", typeof(int), typeof(TimePicker), new UIPropertyMetadata(0, new PropertyChangedCallback(Class24.<>9.method_3)));
        public static readonly DependencyProperty SelectedSecondProperty = DependencyProperty.Register("SelectedSecond", typeof(int), typeof(TimePicker), new UIPropertyMetadata(0, new PropertyChangedCallback(Class24.<>9.method_4)));
        public static readonly RoutedEvent SelectedTimeChangedEvent = EventManager.RegisterRoutedEvent("SelectedTimeChanged", RoutingStrategy.Bubble, typeof(TimeSelectedChangedEventHandler), typeof(TimePicker));
        public static readonly DependencyProperty SelectedTimeProperty = DependencyProperty.Register("SelectedTime", typeof(TimeSpan), typeof(TimePicker), new UIPropertyMetadata(new TimeSpan(0, 0, 0), new PropertyChangedCallback(TimePicker.smethod_1), new CoerceValueCallback(TimePicker.smethod_0)));
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;

        public event TimeSelectedChangedEventHandler SelectedTimeChanged
        {
            add
            {
                base.AddHandler(SelectedTimeChangedEvent, value);
            }
            remove
            {
                base.RemoveHandler(SelectedTimeChangedEvent, value);
            }
        }

        static TimePicker()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(TimePicker), new FrameworkPropertyMetadata(typeof(TimePicker)));
        }

        public TimePicker()
        {
            this.SelectedTime = DateTime.Now.TimeOfDay;
        }

        private bool method_0(Key key_0)
        {
            if (key_0 == Key.Up)
            {
                this.method_3(true);
            }
            else
            {
                if (key_0 != Key.Down)
                {
                    return false;
                }
                this.method_3(false);
            }
            return true;
        }

        private void method_1(object sender, RoutedEventArgs e)
        {
            this.method_3(false);
        }

        private void method_2(object sender, RoutedEventArgs e)
        {
            this.method_3(true);
        }

        private void method_3(bool bool_1)
        {
            if (this.textBox_0 == this.textBox_3)
            {
                this.SelectedHour = MathUtil.IncrementDecrementNumber(this.textBox_0.Text, this.int_3, this.int_0, bool_1);
            }
            else if (this.textBox_1 == this.textBox_3)
            {
                this.SelectedMinute = MathUtil.IncrementDecrementNumber(this.textBox_1.Text, this.int_4, this.int_1, bool_1);
            }
            else
            {
                this.SelectedSecond = MathUtil.IncrementDecrementNumber(this.textBox_2.Text, this.int_5, this.int_2, bool_1);
            }
        }

        private int method_4(string string_0)
        {
            int num = MathUtil.ValidateNumber(string_0, this.int_3, this.int_0);
            this.SelectedHour = num;
            return num;
        }

        private int method_5(string string_0)
        {
            int num = MathUtil.ValidateNumber(string_0, this.int_4, this.int_1);
            this.SelectedMinute = num;
            return num;
        }

        private int method_6(string string_0)
        {
            int num = MathUtil.ValidateNumber(string_0, this.int_5, this.int_2);
            this.SelectedSecond = num;
            return num;
        }

        private void method_7()
        {
            this.bool_0 = true;
        }

        private void method_8()
        {
            this.bool_0 = false;
        }

        private void method_9(TimeSpan timeSpan_0, TimeSpan timeSpan_1)
        {
            TimeSelectedChangedRoutedEventArgs e = new TimeSelectedChangedRoutedEventArgs(SelectedTimeChangedEvent) {
                NewTime = timeSpan_0,
                OldTime = timeSpan_1
            };
            base.RaiseEvent(e);
        }

        public override void OnApplyTemplate()
        {
            this.textBox_0 = base.GetTemplateChild("PART_Hours") as TextBox;
            this.textBox_0.PreviewTextInput += new TextCompositionEventHandler(this.textBox_0_PreviewTextInput);
            this.textBox_0.KeyUp += new KeyEventHandler(this.textBox_0_KeyUp);
            this.textBox_0.GotFocus += new RoutedEventHandler(this.textBox_2_GotMouseCapture);
            this.textBox_0.GotMouseCapture += new MouseEventHandler(this.textBox_2_GotMouseCapture);
            this.textBox_1 = base.GetTemplateChild("PART_Minutes") as TextBox;
            this.textBox_1.PreviewTextInput += new TextCompositionEventHandler(this.textBox_1_PreviewTextInput);
            this.textBox_1.KeyUp += new KeyEventHandler(this.textBox_1_KeyUp);
            this.textBox_1.GotFocus += new RoutedEventHandler(this.textBox_2_GotMouseCapture);
            this.textBox_1.GotMouseCapture += new MouseEventHandler(this.textBox_2_GotMouseCapture);
            this.textBox_2 = base.GetTemplateChild("PART_Seconds") as TextBox;
            this.textBox_2.PreviewTextInput += new TextCompositionEventHandler(this.textBox_2_PreviewTextInput);
            this.textBox_2.KeyUp += new KeyEventHandler(this.textBox_2_KeyUp);
            this.textBox_2.GotFocus += new RoutedEventHandler(this.textBox_2_GotMouseCapture);
            this.textBox_2.GotMouseCapture += new MouseEventHandler(this.textBox_2_GotMouseCapture);
            (base.GetTemplateChild("PART_IncreaseTime") as ButtonBase).Click += new RoutedEventHandler(this.method_2);
            (base.GetTemplateChild("PART_DecrementTime") as ButtonBase).Click += new RoutedEventHandler(this.method_1);
        }

        private static object smethod_0(DependencyObject dependencyObject_0, object object_0)
        {
            TimePicker picker = (TimePicker) dependencyObject_0;
            TimeSpan span = (TimeSpan) object_0;
            if (span < picker.MinTime)
            {
                return picker.MinTime;
            }
            if (span > picker.MaxTime)
            {
                return picker.MaxTime;
            }
            return span;
        }

        private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
        {
            TimePicker picker = (TimePicker) dependencyObject_0;
            TimeSpan newValue = (TimeSpan) dependencyPropertyChangedEventArgs_0.NewValue;
            TimeSpan oldValue = (TimeSpan) dependencyPropertyChangedEventArgs_0.OldValue;
            if (!picker.bool_0)
            {
                picker.method_7();
                if (picker.SelectedHour != newValue.Hours)
                {
                    picker.SelectedHour = newValue.Hours;
                }
                if (picker.SelectedMinute != newValue.Minutes)
                {
                    picker.SelectedMinute = newValue.Minutes;
                }
                if (picker.SelectedSecond != newValue.Seconds)
                {
                    picker.SelectedSecond = newValue.Seconds;
                }
                picker.method_8();
                picker.method_9(picker.SelectedTime, oldValue);
            }
        }

        private static void smethod_2(TextBox textBox_4, TextBox textBox_5, TextBox textBox_6, Key key_0)
        {
            if (((key_0 == Key.Left) && (textBox_5 != null)) && (textBox_4.CaretIndex == 0))
            {
                textBox_5.Focus();
            }
            else if (((key_0 == Key.Right) && (textBox_6 != null)) && (textBox_4.CaretIndex == textBox_4.Text.Length))
            {
                textBox_6.Focus();
            }
        }

        private static string smethod_3(TextBox textBox_4, string string_0)
        {
            if (textBox_4.Text.Length == 2)
            {
                char ch;
                if (textBox_4.CaretIndex == 0)
                {
                    ch = textBox_4.Text[1];
                    return (string_0 + ch.ToString());
                }
                ch = textBox_4.Text[0];
                return (ch.ToString() + string_0);
            }
            if (textBox_4.CaretIndex != 0)
            {
                return (textBox_4.Text + string_0);
            }
            return (string_0 + textBox_4.Text);
        }

        private static void smethod_4(TextBox textBox_4, TextBox textBox_5)
        {
            if ((textBox_4.CaretIndex == 1) && (textBox_5 != null))
            {
                textBox_5.Focus();
            }
            else if (textBox_4.CaretIndex == 0)
            {
                textBox_4.CaretIndex++;
            }
        }

        private static void smethod_5(TextBox textBox_4)
        {
            if (textBox_4.SelectionLength > 0)
            {
                textBox_4.Text = textBox_4.Text.Remove(textBox_4.SelectionStart, textBox_4.SelectionLength);
            }
        }

        private static void smethod_6(TimePicker timePicker_0)
        {
            if (!timePicker_0.bool_0)
            {
                TimeSpan span = new TimeSpan(timePicker_0.SelectedHour, timePicker_0.SelectedMinute, timePicker_0.SelectedSecond);
                if (timePicker_0.SelectedTime != span)
                {
                    timePicker_0.SelectedTime = span;
                }
            }
        }

        private void textBox_0_KeyUp(object sender, KeyEventArgs e)
        {
            smethod_2(this.textBox_0, null, this.textBox_1, e.Key);
            if (!this.method_0(e.Key))
            {
                this.method_4(this.textBox_0.Text);
            }
        }

        private void textBox_0_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            smethod_5(this.textBox_0);
            string str = smethod_3(this.textBox_0, e.Text);
            this.method_4(str);
            smethod_4(this.textBox_0, this.textBox_1);
            e.Handled = true;
        }

        private void textBox_1_KeyUp(object sender, KeyEventArgs e)
        {
            smethod_2(this.textBox_1, this.textBox_0, this.textBox_2, e.Key);
            if (!this.method_0(e.Key))
            {
                this.method_5(this.textBox_1.Text);
            }
        }

        private void textBox_1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            smethod_5(this.textBox_1);
            string str = smethod_3(this.textBox_1, e.Text);
            this.method_5(str);
            smethod_4(this.textBox_1, this.textBox_2);
            e.Handled = true;
        }

        private void textBox_2_GotMouseCapture(object sender, RoutedEventArgs e)
        {
            TextBox box = (TextBox) sender;
            this.textBox_3 = box;
            box.SelectAll();
        }

        private void textBox_2_KeyUp(object sender, KeyEventArgs e)
        {
            smethod_2(this.textBox_2, this.textBox_1, null, e.Key);
            if (!this.method_0(e.Key))
            {
                this.method_6(this.textBox_2.Text);
            }
        }

        private void textBox_2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            smethod_5(this.textBox_2);
            string str = smethod_3(this.textBox_2, e.Text);
            this.method_6(str);
            smethod_4(this.textBox_2, null);
            e.Handled = true;
        }

        public TimeSpan MaxTime
        {
            get
            {
                return (TimeSpan) base.GetValue(MaxTimeProperty);
            }
            set
            {
                base.SetValue(MaxTimeProperty, value);
            }
        }

        public TimeSpan MinTime
        {
            get
            {
                return (TimeSpan) base.GetValue(MinTimeProperty);
            }
            set
            {
                base.SetValue(MinTimeProperty, value);
            }
        }

        public int SelectedHour
        {
            get
            {
                return (int) base.GetValue(SelectedHourProperty);
            }
            set
            {
                base.SetValue(SelectedHourProperty, value);
            }
        }

        public int SelectedMinute
        {
            get
            {
                return (int) base.GetValue(SelectedMinuteProperty);
            }
            set
            {
                base.SetValue(SelectedMinuteProperty, value);
            }
        }

        public int SelectedSecond
        {
            get
            {
                return (int) base.GetValue(SelectedSecondProperty);
            }
            set
            {
                base.SetValue(SelectedSecondProperty, value);
            }
        }

        public TimeSpan SelectedTime
        {
            get
            {
                return (TimeSpan) base.GetValue(SelectedTimeProperty);
            }
            set
            {
                base.SetValue(SelectedTimeProperty, value);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class24
        {
            public static readonly TimePicker.Class24 <>9 = new TimePicker.Class24();

            internal void method_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
            {
                TimePicker picker1 = (TimePicker) dependencyObject_0;
                picker1.int_3 = picker1.MinTime.Hours;
                picker1.int_4 = picker1.MinTime.Minutes;
                picker1.int_5 = picker1.MinTime.Seconds;
                picker1.CoerceValue(TimePicker.SelectedTimeProperty);
            }

            internal void method_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
            {
                TimePicker picker1 = (TimePicker) dependencyObject_0;
                picker1.int_0 = picker1.MaxTime.Hours;
                picker1.int_1 = picker1.MaxTime.Minutes;
                picker1.int_2 = picker1.MaxTime.Seconds;
                picker1.CoerceValue(TimePicker.SelectedTimeProperty);
            }

            internal void method_2(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
            {
                TimePicker picker = (TimePicker) dependencyObject_0;
                int num = TimePicker.MathUtil.ValidateNumber(picker.SelectedHour, picker.int_3, picker.int_0);
                if (num != picker.SelectedHour)
                {
                    picker.SelectedHour = num;
                }
                TimePicker.smethod_6(picker);
            }

            internal void method_3(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
            {
                TimePicker picker = (TimePicker) dependencyObject_0;
                int num = TimePicker.MathUtil.ValidateNumber(picker.SelectedMinute, picker.int_4, picker.int_1);
                if (num != picker.SelectedMinute)
                {
                    picker.SelectedMinute = num;
                }
                TimePicker.smethod_6(picker);
            }

            internal void method_4(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
            {
                TimePicker picker = (TimePicker) dependencyObject_0;
                int num = TimePicker.MathUtil.ValidateNumber(picker.SelectedSecond, picker.int_5, picker.int_2);
                if (num != picker.SelectedSecond)
                {
                    picker.SelectedSecond = num;
                }
                TimePicker.smethod_6(picker);
            }
        }

        public static class MathUtil
        {
            public static int IncrementDecrementNumber(string num, int minValue, int maxVal, bool increment)
            {
                int num2 = ValidateNumber(num, minValue, maxVal);
                if (increment)
                {
                    return Math.Min(num2 + 1, maxVal);
                }
                return Math.Max(num2 - 1, 0);
            }

            public static int ValidateNumber(int newNum, int minValue, int maxValue)
            {
                newNum = Math.Max(newNum, minValue);
                newNum = Math.Min(newNum, maxValue);
                return newNum;
            }

            public static int ValidateNumber(string newNum, int minValue, int maxValue)
            {
                int num;
                if (!int.TryParse(newNum, out num))
                {
                    return 0;
                }
                return ValidateNumber(num, minValue, maxValue);
            }
        }
    }
}


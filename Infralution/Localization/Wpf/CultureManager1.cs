namespace Infralution.Localization.Wpf
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Forms;

    public static class CultureManager1
    {
        private static bool bool_0 = true;
        private static CultureInfo cultureInfo_0;
        private static CultureSelectWindow cultureSelectWindow_0;
        private static NotifyIcon notifyIcon_0;

        [field: CompilerGenerated]
        public static  event EventHandler UICultureChanged;

        private static void smethod_0(CultureInfo cultureInfo_1)
        {
            if (cultureInfo_1.IsNeutralCulture)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo_1.Name);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = cultureInfo_1;
            }
        }

        internal static void smethod_1()
        {
            if (notifyIcon_0 == null)
            {
                notifyIcon_0 = new NotifyIcon();
                notifyIcon_0.MouseClick += new MouseEventHandler(CultureManager1.smethod_5);
                notifyIcon_0.MouseDoubleClick += new MouseEventHandler(CultureManager1.smethod_6);
                notifyIcon_0.Text = "Select";
                ContextMenuStrip strip = new ContextMenuStrip();
                strip.Items.Add(new ToolStripSeparator());
                ToolStripMenuItem item = new ToolStripMenuItem("Other Cultures");
                item.Click += new EventHandler(CultureManager1.smethod_7);
                strip.Items.Add(item);
                smethod_3(strip);
                notifyIcon_0.ContextMenuStrip = strip;
                notifyIcon_0.Visible = true;
            }
        }

        private static void smethod_2()
        {
            if (cultureSelectWindow_0 == null)
            {
                cultureSelectWindow_0 = new CultureSelectWindow();
                cultureSelectWindow_0.Title = notifyIcon_0.Text;
                cultureSelectWindow_0.Closed += new EventHandler(CultureManager1.smethod_9);
                cultureSelectWindow_0.Show();
            }
        }

        private static void smethod_3(ContextMenuStrip contextMenuStrip_0)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(UICulture.DisplayName) {
                Checked = true,
                CheckOnClick = true,
                Tag = UICulture
            };
            item.CheckedChanged += new EventHandler(CultureManager1.smethod_8);
            contextMenuStrip_0.Items.Insert(contextMenuStrip_0.Items.Count - 2, item);
        }

        private static void smethod_4()
        {
            if (notifyIcon_0 != null)
            {
                ContextMenuStrip contextMenuStrip = notifyIcon_0.ContextMenuStrip;
                bool flag = false;
                foreach (ToolStripMenuItem item in contextMenuStrip.Items)
                {
                    if (item != null)
                    {
                        item.Checked = item.Tag == UICulture;
                        if (item.Checked)
                        {
                            flag = true;
                        }
                    }
                }
                if (!flag)
                {
                    smethod_3(contextMenuStrip);
                }
            }
        }

        private static void smethod_5(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon_0.ContextMenuStrip.Show(Control.MousePosition);
            }
        }

        private static void smethod_6(object sender, MouseEventArgs e)
        {
            smethod_2();
        }

        private static void smethod_7(object sender, EventArgs e)
        {
            smethod_2();
        }

        private static void smethod_8(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item.Checked)
            {
                UICulture = item.Tag as CultureInfo;
            }
        }

        private static void smethod_9(object sender, EventArgs e)
        {
            cultureSelectWindow_0 = null;
        }

        public static bool SynchronizeThreadCulture
        {
            get
            {
                return bool_0;
            }
            set
            {
                bool_0 = value;
                if (value)
                {
                    smethod_0(UICulture);
                }
            }
        }

        public static CultureInfo UICulture
        {
            get
            {
                if (cultureInfo_0 == null)
                {
                    cultureInfo_0 = Thread.CurrentThread.CurrentUICulture;
                }
                return cultureInfo_0;
            }
            set
            {
                if (value != UICulture)
                {
                    cultureInfo_0 = value;
                    Thread.CurrentThread.CurrentUICulture = value;
                    if (SynchronizeThreadCulture)
                    {
                        smethod_0(value);
                    }
                    UICultureExtension1.UpdateAllTargets();
                    ResxExtension1.UpdateAllTargets();
                    if (eventHandler_0 != null)
                    {
                        eventHandler_0(null, EventArgs.Empty);
                    }
                    smethod_4();
                }
            }
        }
    }
}


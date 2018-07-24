namespace Triton.Bot.Logic.Bots.NewDefaultBot
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class NewDefaultBotGui : UserControl, IComponentConnector
    {
        private bool bool_0;

        public NewDefaultBotGui()
        {
            this.InitializeComponent();
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (!this.bool_0)
            {
                this.bool_0 = true;
                Uri resourceLocator = new Uri("/Hearthbuddy;component/logic/bots/newdefaultbot/newdefaultbotgui.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            this.bool_0 = true;
        }
    }
}


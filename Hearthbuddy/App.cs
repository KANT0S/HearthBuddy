namespace Hearthbuddy
{
    using log4net;
    using ns2;
    using ns3;
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Management;
    using System.Reflection;
    using System.Runtime;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using System.Windows;
    using System.Windows.Forms;
    using System.Windows.Threading;
    using Triton.Common;
    using Triton.Common.LogUtilities;
    using Triton.Game;

    public class App : System.Windows.Application
    {
        private bool bool_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (!this.bool_0)
            {
                this.bool_0 = true;
                base.StartupUri = new Uri("Windows/ConfigurationWindow.xaml", UriKind.Relative);
                Uri resourceLocator = new Uri("/Hearthbuddy;component/app.xaml", UriKind.Relative);
                System.Windows.Application.LoadComponent(this, resourceLocator);
            }
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0"), STAThread]
        public static void Main()
        {
            App app1 = new App();
            app1.InitializeComponent();
            app1.Run();
        }

        private void method_0()
        {
            if (typeof(ProcessStartInfo).GetProperty("PasswordInClearText") == null)
            {
                if (System.Windows.MessageBox.Show(string.Format("This application requires one of the following versions of the .NET Framework:{0}  .NETFramework,Version=v{1}{0}{0}Do you want to download this .NET Framework version now?", Environment.NewLine, "4.6.1"), "This application could not be started", MessageBoxButton.YesNo, MessageBoxImage.Hand, MessageBoxResult.Yes) == MessageBoxResult.Yes)
                {
                    Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=49981");
                }
                System.Windows.Application.Current.Shutdown(0x3e7);
            }
            else
            {
                try
                {
                    Assembly.Load(Assembly.GetExecutingAssembly().GetReferencedAssemblies().First<AssemblyName>(Class11.<>9__1_0 ?? (Class11.<>9__1_0 = new Func<AssemblyName, bool>(Class11.<>9.method_0))));
                }
                catch (Exception exception)
                {
                    if ((exception is FileNotFoundException) || (exception is BadImageFormatException))
                    {
                        if (System.Windows.MessageBox.Show(string.Format("This application requires one of the following versions of the Visual C++ Redistributable Package for:{0}   Visual Studio 2015 Update 1 x86, VC++ 14.0{0}{0}Do you want to download this Visual C++ Redistributable Package now?{0}{0}Note: You must download and install the x86 version regardless of your operating system", Environment.NewLine), "This application could not be started", MessageBoxButton.YesNo, MessageBoxImage.Hand, MessageBoxResult.Yes) == MessageBoxResult.Yes)
                        {
                            Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=49984");
                        }
                        System.Windows.Application.Current.Shutdown(0x3e7);
                    }
                    else if (exception is FileLoadException)
                    {
                        System.Windows.MessageBox.Show(string.Format("This application could not be started because required files are either missing or corrupted.{0}Download the application again and perform a clean installation in another folder.{0}{0}Please contact us if the issue persists.", Environment.NewLine), "This application could not be started", MessageBoxButton.OK, MessageBoxImage.Hand, MessageBoxResult.OK);
                        System.Windows.Application.Current.Shutdown(0x3e7);
                    }
                    throw;
                }
            }
        }

        private void method_1()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("Hearthbuddy Version: " + Assembly.GetEntryAssembly().GetName().Version);
            message.AppendLine("Path: " + System.Windows.Forms.Application.ExecutablePath.Replace(Environment.UserName, "<Username>").Replace(AppDomain.CurrentDomain.FriendlyName, "<ExeName>"));
            ManagementObject obj2 = new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get().Cast<ManagementObject>().First<ManagementObject>();
            message.AppendLine();
            message.AppendLine("OS Name: " + ((string) obj2["Caption"]).Trim());
            message.AppendLine("OS Version: " + ((string) obj2["Version"]));
            message.AppendLine("OS Architecture: " + ((string) obj2["OSArchitecture"]));
            message.AppendLine("InstalledUICulture: " + CultureInfo.InstalledUICulture.Name + " [" + CultureInfo.InstalledUICulture.EnglishName + "]");
            message.AppendLine("CurrentUICulture: " + CultureInfo.CurrentUICulture.Name + " [" + CultureInfo.CurrentUICulture.EnglishName + "]");
            message.AppendLine("CurrentCulture: " + CultureInfo.CurrentCulture.Name + " [" + CultureInfo.CurrentCulture.EnglishName + "]");
            ilog_0.Info(message);
        }

        private void method_2()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("Hearthbuddy Version: " + Assembly.GetEntryAssembly().GetName().Version);
            message.AppendLine("Path: " + System.Windows.Forms.Application.ExecutablePath.Replace(Environment.UserName, "<Username>").Replace(AppDomain.CurrentDomain.FriendlyName, "<ExeName>"));
            message.AppendLine();
            message.AppendLine("*** This information may be incorrect ***");
            message.AppendLine();
            message.AppendLine("OS Name: " + OSInfo.Name);
            message.AppendLine("OS Edition: " + OSInfo.Edition);
            message.AppendLine("OS Service Pack: " + OSInfo.ServicePack);
            message.AppendLine("OS Version: " + OSInfo.Version);
            message.AppendLine("OS Architecture: x" + (Environment.Is64BitOperatingSystem ? 0x40 : 0x56));
            ilog_0.Info(message);
        }

        private void method_3(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject != null)
            {
                ilog_0.DebugFormat("Unhandled global exception! {0}", e.ExceptionObject.ToString());
            }
            Class12.smethod_0();
            TritonHs.smethod_1();
            Logger.OpenLogFile();
        }

        private void method_4(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            if (e.Exception != null)
            {
                ilog_0.Error("[Application_DispatcherUnhandledException] Unhandled exception", e.Exception);
                if (e.Exception.InnerException != null)
                {
                    ilog_0.Error("[Application_DispatcherUnhandledException] Unhandled inner exception", e.Exception.InnerException);
                }
            }
            Logger.OpenLogFile();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Class12.smethod_0();
            TritonHs.smethod_1();
            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                this.method_1();
            }
            catch (Exception exception)
            {
                ilog_0.Error("An exception occurred", exception);
                try
                {
                    this.method_2();
                }
                catch (Exception exception2)
                {
                    ilog_0.Error("An exception occurred", exception2);
                    Logger.OpenLogFile();
                    System.Windows.Application.Current.Shutdown();
                    return;
                }
            }
            try
            {
                ilog_0.Info("Now setting up JitProfiles...");
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "JitProfiles");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                ProfileOptimization.SetProfileRoot(path);
                ProfileOptimization.StartProfile("JitProfile.jpf");
                ilog_0.Info("JitProfiles successfully setup!");
            }
            catch (Exception exception3)
            {
                ilog_0.Error("An exception occurred", exception3);
            }
            base.Dispatcher.UnhandledException += new DispatcherUnhandledExceptionEventHandler(this.method_4);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(this.method_3);
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            ilog_0.Info("Now beginning pre-start tasks.");
            try
            {
                ilog_0.Info("Now checking prerequisites...");
                this.method_0();
                ilog_0.Info("Prerequisite check complete!");
            }
            catch (Exception exception4)
            {
                ilog_0.ErrorFormat("{0}", exception4);
                Logger.OpenLogFile();
                base.Shutdown(1);
                return;
            }
            try
            {
                Class6 class2 = new Class7().method_0("Hearthbuddy");
                switch (class2.Enum1_0)
                {
                    case Enum1.Success:
                        Triton.Common.CodeCompiler.smethod_0(class2.String_0);
                        goto Label_0266;

                    case Enum1.Relaunch:
                        if (!CommandLine.Arguments.Exists("noautolaunch"))
                        {
                            break;
                        }
                        ilog_0.Info("Now exiting for manual relaunch.");
                        base.Shutdown(1);
                        return;

                    case Enum1.Error:
                        ilog_0.ErrorFormat("An error was encountered: {0}", class2.String_2);
                        Logger.OpenLogFile();
                        base.Shutdown(1);
                        return;

                    default:
                        goto Label_0266;
                }
                ilog_0.Info("Now relaunching.");
                Process.Start(class2.String_1, string.Join(" ", Environment.GetCommandLineArgs().Skip<string>(1).Select<string, string>(Class11.<>9__4_0 ?? (Class11.<>9__4_0 = new Func<string, string>(Class11.<>9.method_1)))));
                base.Shutdown(1);
                return;
            }
            catch (Exception exception5)
            {
                ilog_0.ErrorFormat("Could not rename ourselves on startup: {0}", exception5);
                Logger.OpenLogFile();
                base.Shutdown(1);
                return;
            }
        Label_0266:
            ilog_0.Info("Pre-start tasks successfully completed.");
            base.OnStartup(e);
        }

        [Serializable, CompilerGenerated]
        private sealed class Class11
        {
            public static readonly App.Class11 <>9 = new App.Class11();
            public static Func<AssemblyName, bool> <>9__1_0;
            public static Func<string, string> <>9__4_0;

            internal bool method_0(AssemblyName assemblyName_0)
            {
                return string.Equals(assemblyName_0.Name, "GreyMagic", StringComparison.OrdinalIgnoreCase);
            }

            internal string method_1(string string_0)
            {
                return ("\"" + string_0 + "\"");
            }
        }
    }
}


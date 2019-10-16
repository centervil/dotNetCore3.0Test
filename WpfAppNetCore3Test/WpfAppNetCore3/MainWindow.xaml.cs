using Microsoft.Toolkit.Wpf.UI.XamlHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppNetCore3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TryCatchAndLog(() => "[NetCoreLib]" + NetCoreLib.CNetCore.GetNowTime(), CheckText1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TryCatchAndLog(() => "[NetStandardLib]" + NetStandardLib.CNetStandard.GetNowTime(), CheckText2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TryCatchAndLog(() => "[NetFrameworkLib]" + NetFrameworkLib.CNetFrm.GetNowTime(), CheckText3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TryCatchAndLog(() =>
            {
                CppLibWrapper.SleepTest();
                return "[CppLib]" + "SleepTest";
            }, CheckText4);

        }

        private void TryCatchAndLog(Func<string> func, TextBlock textBlock)
        {
            try
            {
                string s = func();
                Log.Text += s + "\n";
                textBlock.Text = "\U00002714";
            }
            catch (Exception ex)
            {
                Log.Text += ex.Message + "\n";
                textBlock.Text = "\U00002716";
            }
        }

        private void WindowsXamlHost_ChildChanged(object sender, EventArgs e)
        {
            if (sender is WindowsXamlHost windowsXamlHost &&
                windowsXamlHost.Child is Windows.UI.Xaml.Controls.ProgressRing progressRing)
            {
                progressRing.IsActive = true;
            }
        }
    }
}

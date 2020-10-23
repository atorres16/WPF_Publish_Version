using System;
using System.Collections.Generic;
using System.Deployment.Application;
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

namespace WPF_Publish_Version
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                var _version = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                string v = $"{_version.Major}.{_version.Minor}.{_version.Build}.{_version.Revision}";
                version_lbl.Text = v;
            }
        }

      

    }
}

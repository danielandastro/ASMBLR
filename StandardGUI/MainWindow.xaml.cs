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
using System.Net;
using ASMBLR;
namespace StandardGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Interpreter interpret = new Interpreter();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/danielandastro/ASMBLR/blob/update-branch/stnd.dll?raw=true", "ASMBLR.dll");
                }

            }
            catch (Exception) { Console.WriteLine("Connection Failed"); }
        }

        private void sbmt_Click(object sender, RoutedEventArgs e)
        {
            string tmp = interpret.Runner(cmdInput.Text);
            cmdhist.Text += Environment.NewLine + cmdInput.Text;
            if (!tmp.Equals("")){ cmdhist.Text += Environment.NewLine + tmp; }
            cmdInput.Text = "";
        }
    }
}

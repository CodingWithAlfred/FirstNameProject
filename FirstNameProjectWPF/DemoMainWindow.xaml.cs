using FirstNameProjectWPF.Model;
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
using System.Windows.Shapes;

namespace FirstNameProjectWPF
{
    /// <summary>
    /// Interaction logic for DemoMainWindow.xaml
    /// </summary>
    public partial class DemoMainWindow : Window
    {
        SaveDataModel saveDataModel = new SaveDataModel();
        public DemoMainWindow()
        {
            InitializeComponent();

            TxtUCSaveToFileLocation.txtLimitedInput.Text = saveDataModel.FullPath;
            TxtUCEnteredName.txtLimitedInput.Text = "Alfred";

        }
    }
}

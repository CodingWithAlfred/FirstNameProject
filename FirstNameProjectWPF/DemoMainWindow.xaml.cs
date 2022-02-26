using FirstNameProjectWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<NamesModel> firstNameModels = new ObservableCollection<NamesModel>();
        public DemoMainWindow()
        {
            InitializeComponent();

            TxtUCSaveToFileLocation.txtLimitedInput.Text = saveDataModel.FullPath;
            TxtUCEnteredName.txtLimitedInput.Text = "Alfred";

            firstNameModels.Add(new NamesModel() { FirstName = "Fred" });
            firstNameModels.Add(new NamesModel() { FirstName = "John" });
            firstNameModels.Add(new NamesModel() { FirstName = "Jack" });
            firstNameModels.Add(new NamesModel() { FirstName = "Ada" });

            LstBxNames.DisplayMemberPath = "FirstName";
            LstBxNames.ItemsSource = firstNameModels;

        }

        private void BtnAddName_Click(object sender, RoutedEventArgs e)
        {
            firstNameModels.Add(new NamesModel() { FirstName = TxtUCEnteredName.txtLimitedInput.Text });
        }
    }
}

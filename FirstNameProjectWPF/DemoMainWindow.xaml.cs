using FirstNameProjectWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

        private void BtnDeleteName_Click(object sender, RoutedEventArgs e)
        {
            if (LstBxNames.SelectedItem !=null)
            {
                firstNameModels.Remove(LstBxNames.SelectedItem as NamesModel);
            }
        }

        private void BtnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            saveDataModel.FirstNameData = $"Index, First Names{Environment.NewLine}";

            for (int i = 0; i < firstNameModels.Count; i++)
            {
                saveDataModel.FirstNameData += $"{i + 1}, {firstNameModels[i].FirstName} {Environment.NewLine}";
            }

            File.WriteAllText(saveDataModel.FullPath, saveDataModel.FirstNameData);
            MessageBox.Show($"File saved at{Environment.NewLine} {saveDataModel.FullPath}");
        }     

        private void CMchangeName_Click(object sender, RoutedEventArgs e)
        {
            if (LstBxNames.SelectedItem != null)
            {
                (LstBxNames.SelectedItem as NamesModel).FirstName = TxtUCEnteredName.txtLimitedInput.Text;


            }

          var s =    firstNameModels;
        }
    }
}

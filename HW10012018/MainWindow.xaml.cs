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

namespace HW10012018
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionString = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Excute_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProviderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                connectionString +=  ((ComboBoxItem)ProviderComboBox.SelectedItem).Content;
                ConnectionStringTextBox.Text += connectionString;
            }
            catch (Exception ex)
            {

            }
        }

       
    }
}

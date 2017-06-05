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

namespace FirstWPF
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( "Full name: ");
            sb.Append(FullName.Text);
            sb.Append("\nSex: ");
            sb.Append((bool)Desktop.IsChecked ? "Male" : "Female");
            sb.Append("\nJob: ");
            sb.Append(Job.SelectedItem.ToString());
            sb.Append("\nComputer: ");
            sb.Append((bool)Desktop.IsChecked ? "Desktop" : "");
            sb.Append((bool)Laptop.IsChecked ? "Laptop" : "");
            sb.Append((bool)Tablet.IsChecked ? "Tablet" : "");
            sb.Append("\nDelivery date: ");
            sb.Append(Delivery_Date.SelectedDate.ToString());
            MessageBox.Show(sb.ToString());
        }

        private void Job_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newItems = e.AddedItems[0];
            MessageBox.Show(newItems.ToString());
        }
    }
}

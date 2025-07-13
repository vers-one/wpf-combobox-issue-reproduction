using System.Collections.ObjectModel;
using System.Windows;

namespace ComboBoxIssueReproduction
{
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<string> items = [];

        public MainWindow()
        {
            InitializeComponent();
            comboBox.Width = 250;
            items.Add("Item 1");
            comboBox.ItemsSource = items;
            comboBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (resizeCheckBox.IsChecked == true)
            {
                comboBox.Width -= 10;
            }
            items.Add("Item 2");
        }
    }
}
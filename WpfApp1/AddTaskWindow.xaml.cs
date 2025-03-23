using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TaskManagerApp
{
    public partial class AddTaskWindow : Window
    {
        public Task NewTask { get; set; }

        public AddTaskWindow()
        {
            InitializeComponent();
            NewTask = new Task();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            NewTask.Title = TitleTextBox.Text;
            NewTask.Description = DescriptionTextBox.Text;
            NewTask.Priority = (PriorityComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
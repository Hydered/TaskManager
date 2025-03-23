using System.Threading.Tasks;
using System.Windows;

namespace TaskManagerApp
{
    public partial class EditTaskWindow : Window
    {
        public Task EditedTask { get; set; }

        public EditTaskWindow(Task task)
        {
            InitializeComponent();
            EditedTask = task;
            DataContext = EditedTask;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
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
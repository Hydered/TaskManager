using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

namespace TaskManagerApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Task> Tasks { get; set; }
        private int _nextId = 1;

        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<Task>();
            TaskListBox.ItemsSource = Tasks;
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var addTaskWindow = new AddTaskWindow();
            if (addTaskWindow.ShowDialog() == true)
            {
                addTaskWindow.NewTask.Id = _nextId++;
                Tasks.Add(addTaskWindow.NewTask);
            }
        }

        private void EditTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = TaskListBox.SelectedItem as Task;
            if (selectedTask != null)
            {
                var editTaskWindow = new EditTaskWindow(selectedTask);
                if (editTaskWindow.ShowDialog() == true)
                {
                    TaskListBox.Items.Refresh();
                }
            }
        }

        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = TaskListBox.SelectedItem as Task;
            if (selectedTask != null)
            {
                Tasks.Remove(selectedTask);
            }
        }
    }
}
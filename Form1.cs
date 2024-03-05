namespace CodeChum
{
    public partial class TaskScheduler : Form
    {
        public TaskScheduler()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = TaskName.Text;

            DateTime dueDate = DatePicker.Value;

            string formattedDate = dueDate.ToString("dddd, dd MMMM yyyy");

            lblToDoList.Text += taskName + " - " + formattedDate + Environment.NewLine;

            TaskName.Clear();
        }
    }
}

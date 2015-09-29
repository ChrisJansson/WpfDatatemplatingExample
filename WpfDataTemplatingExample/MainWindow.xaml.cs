namespace WpfDataTemplatingExample
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel(
                new object[]
                {
                    new ChildViewModel1
                    {
                        Name = "Child 1"
                    },
                    new ChildViewModel2
                    {
                        Name2 = "Child 2 Name2"
                    },
                    new ChildViewModel3
                    {
                        Name2 = "Child 3 Name2",
                        Name3 = "Child 3 Name3"
                    }
                });
        }
    }
}
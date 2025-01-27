using System.Windows;
using TaskCalendarApp001.ViewModels;
using TaskCalendarApp001.Views;

namespace TaskCalendarApp001;

public partial class MainWindow : Window
{
    private readonly MainWindowViewModel _viewModel;

    public MainWindow()
    {
        InitializeComponent();
        _viewModel = new MainWindowViewModel();
        DataContext = _viewModel;
    }

    private void NewTask_Click(object sender, RoutedEventArgs e)
    {
        var newTaskWindow = new NewTaskWindow
        {
            Owner = this
        };
        newTaskWindow.ShowDialog();
    }
}
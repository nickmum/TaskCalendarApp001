using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TaskCalendarApp001.Core.Models;

namespace TaskCalendarApp001.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private WeekCalendar _calendar;
    private DateTime _selectedDate;

    public MainWindowViewModel()
    {
        _calendar = new WeekCalendar();
        _selectedDate = DateTime.Now;
        // Future: Load saved tasks
    }

    public DateTime SelectedDate
    {
        get => _selectedDate;
        set
        {
            if (_selectedDate != value)
            {
                _selectedDate = value;
                OnPropertyChanged();
            }
        }
    }

    public ObservableCollection<TaskItem> Tasks => _calendar.Tasks;

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    // Future: Add commands for task CRUD operations
    // Future: Add week navigation commands
    // Future: Add task filtering and search functionality
}
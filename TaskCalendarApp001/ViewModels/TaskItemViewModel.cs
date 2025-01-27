using System.ComponentModel;
using System.Runtime.CompilerServices;
using TaskCalendarApp001.Core.Models;

namespace TaskCalendarApp001.ViewModels;

public class TaskItemViewModel : INotifyPropertyChanged
{
    private readonly TaskItem _taskItem;

    public TaskItemViewModel(TaskItem taskItem)
    {
        _taskItem = taskItem;
    }

    public string Title
    {
        get => _taskItem.Title;
        set
        {
            if (_taskItem.Title != value)
            {
                _taskItem.Title = value;
                OnPropertyChanged();
            }
        }
    }

    // Implement other properties similarly

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    // Future: Add validation logic
    // Future: Add task modification tracking
    // Future: Add undo/redo functionality
}
using System.Collections.ObjectModel;

namespace TaskCalendarApp001.Core.Models;

public class WeekCalendar
{
    public DateTime CurrentWeek { get; set; }
    public ObservableCollection<TaskItem> Tasks { get; set; }

    public WeekCalendar()
    {
        CurrentWeek = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
        Tasks = new ObservableCollection<TaskItem>();
    }

    public void NavigateToNextWeek()
    {
        CurrentWeek = CurrentWeek.AddDays(7);
    }

    public void NavigateToPreviousWeek()
    {
        CurrentWeek = CurrentWeek.AddDays(-7);
    }

    // Future: Add methods for task filtering, sorting, and grouping
    // Future: Add persistence layer integration
    // Future: Add recurring task handling
}
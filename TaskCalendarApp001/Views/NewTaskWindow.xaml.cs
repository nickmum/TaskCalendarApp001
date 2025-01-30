using System;
using System.Windows;
using TaskCalendarApp001.Core.Models;

namespace TaskCalendarApp001.Views;

public partial class NewTaskWindow : Window
{
    private TaskItem? _newTask;

    public TaskItem? NewTask => _newTask;

    public NewTaskWindow()
    {
        InitializeComponent();
        // Future: Initialize date/time pickers with current time
        // Future: Set up data binding for form fields
        // Future: Initialize any default values
    }

    private void Cancel_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }

    private void Create_Click(object sender, RoutedEventArgs e)
    {
        // Future: Validate input fields
        // Future: Create new TaskItem with form data
        // Future: Handle validation errors
        // Future: Set task properties from form fields
        // Future: Add error handling

        _newTask = new TaskItem
        {
            StartTime = DateTime.Now,
            EndTime = DateTime.Now.AddHours(1),
            Title = "New Task",
            Status = TaskCalendarApp001.Core.Models.TaskStatus.NotStarted
        };

        DialogResult = true;
        Close();
    }

    // Future: Add methods for validation
    // Future: Add methods for date/time handling
    // Future: Add methods for recurring task setup
    // Future: Add methods for task template handling
    // Future: Add keyboard shortcuts
    // Future: Add auto-save draft functionality
}
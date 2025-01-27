﻿using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace TaskCalendarApp001.Views;

public partial class CalendarGrid : UserControl
{
    public CalendarGrid()
    {
        InitializeComponent();
        GenerateTimeGrid();
    }

    private void GenerateTimeGrid()
    {
        // Configure TimeGrid rows for half-hour intervals
        for (int i = 0; i < 48; i++) // 24 hours * 2 (half-hour intervals)
        {
            TimeGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        }

        // Add time labels
        for (int i = 0; i < 48; i++)
        {
            int hour = i / 2;
            string minutePart = (i % 2 == 0) ? "00" : "30";
            string amPm = hour < 12 ? "AM" : "PM";
            if (hour == 0) hour = 12;
            if (hour > 12) hour -= 12;

            var timeLabel = new TextBlock
            {
                Text = $"{hour}:{minutePart} {amPm}",
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(5, 2, 5, 0)
            };

            Grid.SetRow(timeLabel, i);
            Grid.SetColumn(timeLabel, 0);
            TimeGrid.Children.Add(timeLabel);

            // Add horizontal gridlines
            var gridLine = new Border
            {
                BorderBrush = Brushes.LightGray,
                BorderThickness = new Thickness(0, 0, 0, 1),
                Margin = new Thickness(0)
            };
            Grid.SetRow(gridLine, i);
            Grid.SetColumnSpan(gridLine, 8);
            TimeGrid.Children.Add(gridLine);
        }

        // Add vertical gridlines
        for (int i = 1; i < 8; i++)
        {
            var gridLine = new Border
            {
                BorderBrush = Brushes.LightGray,
                BorderThickness = new Thickness(1, 0, 0, 0),
                Margin = new Thickness(0)
            };
            Grid.SetColumn(gridLine, i);
            Grid.SetRowSpan(gridLine, 48);
            TimeGrid.Children.Add(gridLine);
        }
    }

    // Future: Add methods for task rendering
    // Future: Add methods for time slot selection
    // Future: Add drag-drop handling
}
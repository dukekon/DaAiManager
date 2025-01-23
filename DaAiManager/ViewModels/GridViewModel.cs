using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using DaAiManager.Models;

namespace DaAiManager.ViewModels;

public partial class GridViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<DataItemModel> _dataItems;

    public GridViewModel()
    {
        var start = DateTime.Parse("2021-01-01 22:00");
        var end = DateTime.Parse("2021-01-02 02:00");
        var timeSpan = end - start;
        var items = new List<DataItemModel>
        {
            new()
            {
                Id = 1,
                Customer = "王小利",
                Caregivers = "张牛逼",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(1),
                ManHour = TimeSpan.FromHours(2),
                Amount = 1000.00m
            },
            new()
            {
                Id = 2,
                Customer = "李小花",
                Caregivers = "李牛逼",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(4),
                ManHour = TimeSpan.FromHours(2),
                Amount = 1000.00m
            },
            new()
            {
                Id = 3,
                Customer = "李小花",
                Caregivers = "李牛逼",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(2),
                ManHour = TimeSpan.FromHours(1),
                Amount = 4000.00m
            },
            new()
            {
                Id = 4,
                Customer = "李小花",
                Caregivers = "李牛逼",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(1),
                ManHour = TimeSpan.FromHours(6),
                Amount = 1000.00m
            },
            new()
            {
                Id = 5,
                Customer = "李小花",
                Caregivers = "李牛逼",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(3),
                ManHour = TimeSpan.FromHours(4),
                Amount = 3000.00m
            },
            new()
            {
                Id = 6,
                Customer = "李小花",
                Caregivers = "李牛逼",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(2),
                ManHour = TimeSpan.FromHours(2),
                Amount = 300.00m
            }
        };

        _dataItems = new ObservableCollection<DataItemModel>(items);
    }
}
using System;
using System.Diagnostics;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.VisualTree;
using DaAiManager.ViewModels;
using VisualExtensions = Avalonia.VisualTree.VisualExtensions;

namespace DaAiManager.Views;

public partial class GridView : UserControl
{
    public GridView()
    {
        InitializeComponent();
        DataContext = new GridViewModel();
    }
}
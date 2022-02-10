using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lab9;

public partial class GradeWindow : Window
{
    private List<Ocena> _ocenaList;
    public GradeWindow(List<Ocena> ocenaList)
    {
        _ocenaList = ocenaList ?? throw new NullReferenceException();
        InitializeComponent();
        dgOceny.Columns.Add(new DataGridTextColumn(){Header = "Przedmiot", Binding = new Binding("przedmiot")});
        dgOceny.Columns.Add(new DataGridTextColumn(){Header = "Ocena", Binding = new Binding("wartosc")});
        dgOceny.AutoGenerateColumns = false;
        dgOceny.ItemsSource = _ocenaList;
    }

    private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new GradeAddWindow();
        if (dialog.ShowDialog() != true) return;
        _ocenaList.Add(dialog.ocena);
        dgOceny.Items.Refresh();
    }
    

    private void ButtonDel_OnClick(object sender, RoutedEventArgs e)
    {
        if(_ocenaList.Remove((Ocena) dgOceny.SelectedItem))
            dgOceny.Items.Refresh();
    }

    private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
    {
        var ocena = (Ocena) dgOceny.SelectedItem;
        int index = _ocenaList.IndexOf(ocena);
        var dialog = new GradeAddWindow(ocena);
        if(dialog.ShowDialog() != true) return;
        _ocenaList[index] = dialog.ocena;
        dgOceny.Items.Refresh();
    }
}
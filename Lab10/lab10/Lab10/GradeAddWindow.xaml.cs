using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace Lab9;

public partial class GradeAddWindow : Window
{
    public Ocena ocena { get; set; }
    
    public GradeAddWindow(Ocena ocena)
    {
        this.ocena = ocena;
        InitializeComponent();
        TextSubj.Text = ocena.przedmiot;
        TextVal.Text = ocena.wartosc.ToString();
    }

    public GradeAddWindow() : this(new Ocena())
    {
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (!Regex.IsMatch(TextVal.Text, "\\d+((.?|,?)\\d+)?")) return;

        ocena.przedmiot = TextSubj.Text;
        ocena.wartosc = Convert.ToDouble(TextVal.Text);
        DialogResult = true;
    }
}
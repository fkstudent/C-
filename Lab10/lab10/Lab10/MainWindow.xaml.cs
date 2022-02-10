using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace Lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }
        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student("Jan", "Kowalski", 1033, "WiMil"),
                new Student("Michał", "Nowak", 1024, "WiMiL")
               
            };
            InitializeComponent();
            dgStudent.Columns.Add(new DataGridTextColumn(){Header = "Imię", Binding = new Binding("imie")});
            dgStudent.Columns.Add(new DataGridTextColumn(){Header = "Nazwisko", Binding = new Binding("nazwisko")});
            dgStudent.Columns.Add(new DataGridTextColumn(){Header = "Nr indeksu", Binding = new Binding("NrIndeksu")});
            dgStudent.Columns.Add(new DataGridTextColumn(){Header = "Wydzial", Binding = new Binding("wydzial")});
            dgStudent.AutoGenerateColumns = false;
            dgStudent.ItemsSource = ListaStudentow;
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() != true) return;
            ListaStudentow.Add(dialog.student);
            dgStudent.Items.Refresh();
        }

        private void ButtonRemove_OnClick(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student)
                ListaStudentow.Remove((Student) dgStudent.SelectedItem);
            dgStudent.Items.Refresh();
        }

        private void ButtonGrades_OnClick(object sender, RoutedEventArgs e)
        {
            new GradeWindow(((Student) dgStudent.SelectedItem).oceny).Show();
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "Pliki tekstowe (*.txt)|*.txt"
            };
            if (sfd.ShowDialog() != true)
                return;
            var fs = sfd.OpenFile();
            var sw = new StreamWriter(fs);
            foreach (var student in ListaStudentow)
            {
                sw.WriteLine("[[Student]]");
                sw.WriteLine("[FirstName]");
                sw.WriteLine(student.imie);
                sw.WriteLine("[Surname]");
                sw.WriteLine(student.nazwisko);
                sw.WriteLine("[StudentNo]");
                sw.WriteLine(student.NrIndeksu);
                sw.WriteLine("[Faculty]");
                sw.WriteLine(student.wydzial);
                if (student.oceny.Count == 0) continue;
                sw.WriteLine("[[Grades]]");
                foreach (var ocena in student.oceny)
                {
                    sw.WriteLine("[[Grade]]");
                    sw.WriteLine("[Subject]");
                    sw.WriteLine(ocena.przedmiot);
                    sw.WriteLine("[Grade]");
                    sw.WriteLine(ocena.wartosc);
                }
            }
            sw.Close();
            MessageBox.Show("Zapisano pomyślnie!");
        }

        private void ButtonLoad_OnClick(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Pliki tekstowe (*.txt)|*.txt"
            };
            if (ofd.ShowDialog() != true)
                return;
            var fs = ofd.OpenFile();
            var sr = new StreamReader(fs);
            ListaStudentow.Clear();
            string? line = null;
            while (!sr.EndOfStream)
            {
                var stud = new Student();
                while (line != "[[Student]]" && !sr.EndOfStream)
                    line = sr.ReadLine();   //[[Student]]
                
                line = sr.ReadLine();    //[FirstName]

                if (line == "[FirstName]")
                    stud.imie = sr.ReadLine();
                else
                {
                    WrongDataError();
                    return;
                }
                line = sr.ReadLine();   //[Surname]
                if (line == "[Surname]")
                    stud.nazwisko = sr.ReadLine();
                else
                {
                    WrongDataError();
                    return;
                }
                line = sr.ReadLine();   //[StudentNo]
                if (line == "[StudentNo]")
                    stud.NrIndeksu = Convert.ToInt32(sr.ReadLine());
                else
                {
                    WrongDataError();
                    return;
                }
                line = sr.ReadLine();   //[Faculty]
                if (line == "[Faculty]")
                    stud.wydzial = sr.ReadLine();
                else
                {
                    WrongDataError();
                    return;
                }
                line = sr.ReadLine();   //[[Student]] || [[Grades]] || null
                if (line == "[[Grades]]")
                {
                    stud.oceny.Clear();
                    line = sr.ReadLine(); //[[Grade]]
                    while (line != null && line != "[[Student]]")
                    {
                        var ocena = new Ocena();
                        line = sr.ReadLine();   //[Subject]
                        if (line == "[Subject]")
                            ocena.przedmiot = sr.ReadLine();
                        else
                        {
                            WrongDataError();
                            return;
                        }
                        line = sr.ReadLine();   //[Grade]
                        if (line == "[Grade]")
                            ocena.wartosc = Convert.ToDouble(sr.ReadLine());
                        else
                        {
                            WrongDataError();
                            return;
                        }
                        stud.oceny.Add(ocena);
                        line = sr.ReadLine();   //[[Grade]] || [[Student]] || null
                    }
                }
                ListaStudentow.Add(stud);
            }
            dgStudent.Items.Refresh();
            sr.Close();
            MessageBox.Show("Wczytano pomyślnie!");
        }

        private void WrongDataError()
        {
            MessageBox.Show("Błędny format pliku!");
        }

        private void ButtonRefSave_OnClick(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "Pliki tekstowe (*.txt)|*.txt"
            };
            if (sfd.ShowDialog() != true)
                return;
            var fs = sfd.OpenFile();
            var sw = new StreamWriter(fs);
            foreach (var student in ListaStudentow)
            {
                Save(student, sw);
            }
            sw.Close();
            MessageBox.Show("Zapisano pomyślnie!");
        }
        private void ButtonRefLoad_OnClick(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Pliki tekstowe (*.txt)|*.txt"
            };
            if (ofd.ShowDialog() != true)
                return;
            var fs = ofd.OpenFile();
            var sr = new StreamReader(fs);
            ListaStudentow.Clear();
            try
            {
                while (!sr.EndOfStream)
                {
                    ListaStudentow.Add(Load<Student>(sr));
                }

                MessageBox.Show("Odczytano pomyślnie!");
            }
            catch (InvalidOperationException ex)
            {
                WrongDataError();
            }
            finally
            {
                sr.Close();
            }
        }

        private static void Save<T>(T ob, StreamWriter sw)
        {
            Type t = ob.GetType();
            sw.WriteLine($"[[{t.FullName}]]");
            foreach (var propertyInfo in t.GetProperties())
            {
                sw.WriteLine($"[{propertyInfo.Name}]");
                sw.WriteLine(propertyInfo.GetValue(ob));
            }
            sw.WriteLine("[[]]");
        }

        private static T Load<T>(StreamReader sr) where T : new()
        {
            var ob = default(T);
            Type tob = null;
            PropertyInfo property = null;
            while (!sr.EndOfStream)
            {
                string? ln = sr.ReadLine();
                if (ln == "[[]]")
                    return ob;
                if (ln.StartsWith("[["))
                {
                    tob = Type.GetType(ln.Trim('[', ']'));
                    if (typeof(T).IsAssignableFrom(tob))
                        ob = (T) Activator.CreateInstance(tob);
                }
                else if (ln.StartsWith("[") && ob != null)
                    property = tob.GetProperty(ln.Trim('[', ']'));
                else if(ob!=null && property!=null)
                    property.SetValue(ob, Convert.ChangeType(ln, property.PropertyType));
                else throw new InvalidDataException();
            }

            return default(T);
        }

        private void ButtonXMLSave_OnClick(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "Pliki XML (*.xml)|*.xml"
            };
            if (sfd.ShowDialog() != true)
                return;
            var fs = sfd.OpenFile();
            var xs = new XmlSerializer(typeof(List<Student>));
            try
            {
                xs.Serialize(fs, ListaStudentow);
                MessageBox.Show("Zapisano pomyślnie!");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Błędny zapis pliku!");
            }
            fs.Close();
        }

        private void ButtonXMLLoad_OnClick(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Pliki XML (*.xml)|*.xml"
            };
            if (ofd.ShowDialog() != true)
                return;
            var fs = ofd.OpenFile();
            var xs = new XmlSerializer(typeof(List<Student>));
            try
            {
                ListaStudentow = (List<Student>) xs.Deserialize(fs);
                dgStudent.ItemsSource = ListaStudentow;
                MessageBox.Show("Odczytano pomyślnie!");
            }
            catch (InvalidOperationException ex)
            {
                WrongDataError();
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
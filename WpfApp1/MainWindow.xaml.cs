using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Human> human;
        public MainWindow()
        {
            InitializeComponent();
            human = new ObservableCollection<Human>()
            {
                 new Human(){Name = "Willa", Surname = "Cather", Age = 10},
                 new Human(){Name = "Isak", Surname = "Dinesen", Age = 22},
                 new Human(){Name = "Victor", Surname = "Hugo", Age = 10},
                 new Human(){Name = "Jules", Surname = "Verne", Age = 20}
            };
            NameList.ItemsSource = human;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            human.Add(new Human(NameTextbox.Text, SurnameTextbox.Text, Convert.ToInt32(AgeTextBox.Text)));
            DataContext = human;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DeleteTextBox.Text != string.Empty)
            {
                var deletePerson = (from p in human
                                    where p.Name == DeleteTextBox.Text
                                    select p).FirstOrDefault();
                human.Remove(deletePerson);
                DeleteTextBox.Text = string.Empty;
            }
        }

    }
}

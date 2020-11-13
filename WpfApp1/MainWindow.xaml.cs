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
        public bool start = true;
        private ObservableCollection<Human> human;
       // public ObservableCollection<Human> data = new ObservableCollection<Human>();
        public MainWindow()
        {
            InitializeComponent();
            human = new ObservableCollection<Human>()
            {
                 new Human(){Name="Willa",Surname="Cather", Age=10},

                 new Human(){Name= "Isak", Surname= "Dinesen", Age = 22}
            };
            lstNames.ItemsSource = human;
        }
        public MainWindow(bool o)
        {
            start = false;
        }
        //public ObservableCollection<Human> GetData() 
        //{
        //    //data.Add(new Human("Willa", "Cather", 18));
        //    //data.Add(new Human("Isak", "Dinesen", 22));
        //    //data.Add(new Human("Victor", "Hugo", 10));
        //    //data.Add(new Human("Jules", "Verne", 20));

        //    //return data;
        //}
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            human.Add(new Human(NameTextbox.Text, SurnameTextbox.Text, Convert.ToInt32(AgeTextBox.Text)));
            DataContext = human;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DeleteByIdTextBox.Text != string.Empty)
            {
                var deletePerson = (from p in human
                                    where p.Name == DeleteByIdTextBox.Text
                                    select p).FirstOrDefault();
                human.Remove(deletePerson);
                DeleteByIdTextBox.Text = string.Empty;
            }
        }

    }
}

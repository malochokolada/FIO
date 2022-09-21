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

namespace WorkFIO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user;
       private ObservableCollection<User> _users;

        public MainWindow()
        {
            InitializeComponent();

            _users = new ObservableCollection<User>();
        }

        private void ButtonRun_Click (object sender, RoutedEventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            user = new User(firstName, middleName, lastName);

            _users.Add(user);

            listView.ItemsSource = _users;
            listView.DisplayMemberPath = "Fio";
        }

    }
}

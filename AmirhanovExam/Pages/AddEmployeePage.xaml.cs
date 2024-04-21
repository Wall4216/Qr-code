using AmirhanovExam.Models;
using System;
using System.Collections.Generic;
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

namespace AmirhanovExam.Pages
{
    /// <summary>
    /// Interaction logic for AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        Employee contextEmployee;
        public AddEmployeePage(Employee _employee)
        {
            InitializeComponent();
            CBRole.ItemsSource = App.DB.Role.ToList();
            contextEmployee = _employee;  
            DataContext = contextEmployee;
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Employee.Add(contextEmployee);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }
    }
}

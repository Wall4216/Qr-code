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
    /// Interaction logic for HRMainPage.xaml
    /// </summary>
    public partial class HRMainPage : Page
    {
        public HRMainPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            DGEmployee.ItemsSource = App.DB.Employee.ToList();
        }

        private void TBName_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadFilter();
        }

        private void CBRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadFilter();
        }

        private void LoadFilter()
        {
            var filteredEmployee = App.DB.Employee.ToList();
            var searchText = TBName.Text;
            Role selectedRoleEmployee = CBRole.SelectedItem as Role;

            if (selectedRoleEmployee != null)
            {
                filteredEmployee = filteredEmployee.Where(x => x.Role == selectedRoleEmployee).ToList();
            }

            if (string.IsNullOrWhiteSpace(searchText) == false) 
            {
                filteredEmployee = filteredEmployee.Where(x => x.Name.ToLower().Contains(searchText)).ToList();
            }

            DGEmployee.ItemsSource = filteredEmployee.ToList();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployeePage(new Employee()));
        }

        private void BRed_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmployee = DGEmployee.SelectedItem as Employee;
            if (selectedEmployee == null)
            {
                MessageBox.Show("Нету такого чела");
                return;
            }
            NavigationService.Navigate(new AddEmployeePage(selectedEmployee));
            Refresh();
        }

        private void BShowQR_Click(object sender, RoutedEventArgs e)
        {
            if (App.image != null)
            {
                QRCodeImage.Source = App.image;
            }
            else
            {
                MessageBox.Show("Имя сотрудника отсутствует, невозможно создать QR-код.");
            }
        }

        private void BDel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

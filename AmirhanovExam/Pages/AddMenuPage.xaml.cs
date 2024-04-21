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
using AmirhanovExam.Models;

namespace AmirhanovExam.Pages
{
    /// <summary>
    /// Interaction logic for AddMenuPage.xaml
    /// </summary>
    public partial class AddMenuPage : Page
    {
        AmirhanovExam.Models.Menu contextMenu;
        public AddMenuPage()
        {
            InitializeComponent();
            CBEmployee.ItemsSource = App.DB.Employee.ToList();
            contextMenu = new AmirhanovExam.Models.Menu();
            DataContext = contextMenu;
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Menu.Add(contextMenu);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }
    }
}

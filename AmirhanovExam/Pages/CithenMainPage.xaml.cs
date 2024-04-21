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
    /// Interaction logic for CithenMainPage.xaml
    /// </summary>
    public partial class CithenMainPage : Page
    {
        public CithenMainPage()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMenuPage());
        }

        private void ShowIngridientsButton_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new IngridientsPage());
        }
    }
}

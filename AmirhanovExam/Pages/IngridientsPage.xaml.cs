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
    /// Interaction logic for IngridientsPage.xaml
    /// </summary>
    public partial class IngridientsPage : Page
    {
        public IngridientsPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            DGIngridient.ItemsSource = App.DB.Ingridients.ToList();
        }
    }
}

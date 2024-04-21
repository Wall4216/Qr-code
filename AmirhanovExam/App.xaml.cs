using AmirhanovExam.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AmirhanovExam
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Amirhanov_ExamEntities DB = new Amirhanov_ExamEntities();
        public static Employee loggedEmployee = new Employee();
        public static BitmapImage image = new BitmapImage();
    }
}

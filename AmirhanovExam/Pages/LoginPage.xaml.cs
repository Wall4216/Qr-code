using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace AmirhanovExam.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var employee = App.DB.Employee.FirstOrDefault(x => x.Login == TBLogin.Text && x.Password == TBPassword.Password);

            if (employee == null)
            {
                MessageBox.Show("Такого пользователя нету");
                return;
            }

            App.loggedEmployee = employee;
            
            App.image = CreateQrCode(employee.Name);

            if (employee.RoleId == 1)
            {
                NavigationService.Navigate(new CithenMainPage());
            }

            else if (employee.RoleId == 2)
            {
                NavigationService.Navigate(new HRMainPage());
            }
        }

        private BitmapImage CreateQrCode(string code)
        {
            var encoder = new QRCodeEncoder();

            Bitmap bitmap = encoder.Encode(code);

            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
            }

            bitmap.Dispose();

            return bitmapImage;
        }
    }
}

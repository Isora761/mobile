using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MangaReader
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btlogin_Clicked(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "123")
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("Ops...", "Tên đăng nhập hoặc mật khẩu của bạn không chính xác", "Ok");
            }
        }

        private async void btsignup_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }
    }
}
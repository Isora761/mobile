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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void btlogin_Tapped(object sender, EventArgs e)
        {
                await Navigation.PushAsync(new Login());
        }

        private async void btSignUp_Clicked(object sender, EventArgs e)
        {
            if (txtTaoPassword.Text == txtNhapLaiMK.Text)
            {
                await Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("Aww...", "Nhập sai mật khẩu, vui lòng nhập lại", "Ok");
            }
        }
    }
}
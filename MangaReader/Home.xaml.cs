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
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lstManga_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PushAsync(new Manga_Description_Page());
        }

        private void btnGenre_Clicked(object sender, EventArgs e)
        {

        }

        private void btnNew_Clicked(object sender, EventArgs e)
        {

        }

        private void btnHot_Clicked(object sender, EventArgs e)
        {

        }

        private void ToolbarSearch_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Search_Manga());
        }
    }
}
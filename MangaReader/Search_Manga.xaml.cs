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
    public partial class Search_Manga : ContentPage
    {
        public Search_Manga()
        {
            InitializeComponent();
        }


        private void lstManga_Searching_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new Manga_Description_Page());
        }

        private void searchManga_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
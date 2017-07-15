using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LB.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Products : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public Products()
        {
            InitializeComponent();
            Items = new ObservableCollection<string>() { "Broodje Gezond", "Broodje Bal", "Broodje Kaas" };
            ListOfProducts.ItemsSource = Items;
            this.BindingContext = Items;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            DisplayAlert("Item Tapped", $"An {e.Item.ToString()} was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("LOl");
            Items.Add("New item");
        }
    }
}
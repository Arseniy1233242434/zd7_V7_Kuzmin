using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterialsPage : ContentPage
    {
        public MaterialsPage()
        {
            InitializeComponent();
            MaterialsListView.ItemsSource = new[]
            {
                new { Name = "Доска берёзовая", Price = "100 руб/м", Image = "wood1.png" },
                new { Name = "Доска сосновая", Price = "150 руб/м", Image = "wood2.png" },
                new { Name = "бревно берёзовое", Price = "200 руб/м", Image = "wood3.png" },
                 new { Name = "бревно сосновое", Price = "250 руб/м", Image = "wood4.png" }
            };
        }
        private async void OnViewMaterialClicked(object sender, EventArgs e)
        {
            var a = MaterialsListView.SelectedItem;
            if (a != null)
            {
                save.name=a.GetType().GetProperty("Name").GetValue(a, null).ToString();
                save.price = a.GetType().GetProperty("Price").GetValue(a, null).ToString();
            }

            ((CarouselPage)Application.Current.MainPage).CurrentPage = ((CarouselPage)Application.Current.MainPage).Children[1];

        }

        private async void OnCalculateClicked(object sender, EventArgs e)
        {
            var a = MaterialsListView.SelectedItem;
            if (a != null)
            {
                save.name = a.GetType().GetProperty("Name").GetValue(a, null).ToString();
                save.price = a.GetType().GetProperty("Price").GetValue(a, null).ToString();
            }
            ((CarouselPage)Application.Current.MainPage).CurrentPage = ((CarouselPage)Application.Current.MainPage).Children[2];
        }
        public void RefreshData()
        {
            DateTime currentDate = DateTime.Now;
            CurrentDateLabel.Text = "Данные по наличию пиломатериалов на текущую дату:" +currentDate.ToString("dd MMMM yyyy");
        }
    }
}
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
    public partial class CalculationPage : ContentPage
    {
        public CalculationPage()
        {
            InitializeComponent();
        }
        private async void OnCalculateClicked(object sender, EventArgs e)
        {
            double price = int.Parse(save.price.Split()[0]);
            int days = int.Parse(DaysEntry.Text);
            string paymentType = PaymentTypePicker.SelectedItem.ToString();

            double discount = 0;

            if (paymentType == "Наличный расчет")
                discount = -0.1;
            else if (paymentType == "Безналичный расчет")
                discount = 0.1;

            if (days >= 20 && days <= 30)
                discount -= 0.05;
            else if (days >= 10 && days <= 18)
                discount += 0.1;
            else if (days >= 1 && days <= 5)
                discount += 0.25;

            double total = price * (1 + discount);
            save.ob = total.ToString();
            await DisplayAlert("Результат", $"Итоговая стоимость: {total}", "OK");
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            // Переход на страницу с материалами
            ((CarouselPage)Application.Current.MainPage).CurrentPage = ((CarouselPage)Application.Current.MainPage).Children[0];
        }
        private void On(object sender, EventArgs e)
        {
            // Переход на страницу с материалами
            ((CarouselPage)Application.Current.MainPage).CurrentPage = ((CarouselPage)Application.Current.MainPage).Children[1];
        }
    }
}
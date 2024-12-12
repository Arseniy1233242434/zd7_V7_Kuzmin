using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zd7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Appearing += OnPageAppearing;
        }
        private void OnPageAppearing(object sender, System.EventArgs e)
        {
            if (save.name == "Доска берёзовая")
            {
                l1.Text = "Название пиломатериала: " + save.name;
                l2.Text = "Вид дерева: берёза";
                l3.Text = "Категория: 1";
                l4.Text = "Цена:" + save.price;
                l11.Text = "Стоимость:" + save.ob;
                im.Source = "wood1.png";

            }
            else
            if (save.name == "Доска сосновая")
            {
                l1.Text = "Название пиломатериала :" + save.name;
                l2.Text = "Вид дерева: сосна";
                l3.Text = "Категория: 1";
                l4.Text = "Цена:" + save.price;
                l11.Text = "Стоимость:" + save.ob;
                im.Source = "wood2.png";
            }
            else
            if (save.name == "бревно берёзовое")
            {
                l1.Text = "Название пиломатериала :" + save.name;
                l2.Text = "Вид дерева: берёза";
                l3.Text = "Категория: 1";
                l4.Text = "Цена:" + save.price;
                l11.Text = "Стоимость:" + save.ob;
                im.Source = "wood3.png";
            }
            else
            if (save.name == "бревно сосновое")
            {
                l1.Text = "Название пиломатериала :" + save.name;
                l2.Text = "Вид дерева: сосна";
                l3.Text = "Категория: 1";
                l4.Text = "Цена:" + save.price;
                l11.Text = "Стоимость:" + save.ob;
                im.Source = "wood4.png";
            }
        }
        private void OnCalculateClicked(object sender, EventArgs e)
        {
            // Переход на страницу расчета (в рамках CarouselPage)
            ((CarouselPage)Application.Current.MainPage).CurrentPage = ((CarouselPage)Application.Current.MainPage).Children[2];
        }

        private void OnReturnClicked(object sender, EventArgs e)
        {
            // Переход на страницу с материалами (в рамках CarouselPage)
            ((CarouselPage)Application.Current.MainPage).CurrentPage = ((CarouselPage)Application.Current.MainPage).Children[0];
        }
    }
}

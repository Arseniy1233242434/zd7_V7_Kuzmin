using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CarouselPage
            {
                Children =
                {
                    new MaterialsPage(),  // Страница с материалами
                    new MainPage(),       // Главная страница
                    new CalculationPage() // Модальная страница для расчета
                }
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

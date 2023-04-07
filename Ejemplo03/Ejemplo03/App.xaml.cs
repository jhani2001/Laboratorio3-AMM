using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejemplo03
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //comentario
            //comentario2
            MainPage = new StackLayoutCode();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejemplo03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutCode : ContentPage
    {
        public StackLayoutCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            Button button = new Button
            {
                Text = "Demo",
                BackgroundColor = Color.Red
            };
            Button button2 = new Button
            {
                Text = "Demo",
                BackgroundColor = Color.Orange
            };

            stack.Children.Add(button);
            stack.Children.Add(button2);


            this.Content = stack;

        }
    }
}
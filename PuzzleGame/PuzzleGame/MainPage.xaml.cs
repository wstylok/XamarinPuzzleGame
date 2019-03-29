using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PuzzleGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void PlayBtn_Clicked(object sender, EventArgs e)
        {
            var game = new Game();
            await Navigation.PushAsync(game);
        }
    }
}

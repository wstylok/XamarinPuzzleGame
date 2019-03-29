using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuzzleGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Game : ContentPage
    {
        static Random rnd = new Random();

        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + rnd.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        public Game()
        {
            InitializeComponent();


            Button[] puzzles = { puz1, puz2, puz3, puz4, puz5, puz6, puz7, puz8, puz9 };

            string[] puz = { "1", "2", "3", "4", "5", "6", "7", "8", "" };

            Shuffle(puz);
            for (int i = 0; i < puzzles.Length; i++)
            {
                puzzles[i].Text = puz[i];
            }
        }

        static string tempValue = "";

        async void BackToMenuBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void EndCheck()
        {
            if (puz1.Text == "1" && puz2.Text == "2" && puz3.Text == "3" && puz4.Text == "4" && puz5.Text == "5" && puz6.Text == "6" && puz7.Text == "7" && puz8.Text == "8" && puz9.Text == "")
            {
                grats.Text = "Gratulations! You win!";
                grats.IsVisible = true;
            }
            else
                grats.IsVisible = false;
        }

        // moving puzzles
        private void Puz1_Clicked(object sender, EventArgs e)
        {
            if (puz2.Text == "")
            {
                puz2.Text = puz1.Text;
                puz1.Text = "";
            }
            if (puz4.Text == "")
            {
                puz4.Text = puz1.Text;
                puz1.Text = "";
            }

            EndCheck();
        }

        private void Puz2_Clicked(object sender, EventArgs e)
        {
            if (puz1.Text == "")
            {
                puz1.Text = puz2.Text;
                puz2.Text = "";
            }
            if (puz3.Text == "")
            {
                puz3.Text = puz2.Text;
                puz2.Text = "";
            }
            if (puz5.Text == "")
            {
                puz5.Text = puz2.Text;
                puz2.Text = "";
            }

            EndCheck();
        }

        private void Puz3_Clicked(object sender, EventArgs e)
        {
            if (puz2.Text == "")
            {
                puz2.Text = puz3.Text;
                puz3.Text = "";
            }
            if (puz6.Text == "")
            {
                puz6.Text = puz3.Text;
                puz3.Text = "";
            }

            EndCheck();
        }

        private void Puz4_Clicked(object sender, EventArgs e)
        {
            if (puz1.Text == "")
            {
                puz1.Text = puz4.Text;
                puz4.Text = "";
            }
            if (puz5.Text == "")
            {
                puz5.Text = puz4.Text;
                puz4.Text = "";
            }
            if (puz7.Text == "")
            {
                puz7.Text = puz4.Text;
                puz4.Text = "";
            }

            EndCheck();
        }

        private void Puz5_Clicked(object sender, EventArgs e)
        {
            if (puz2.Text == "")
            {
                puz2.Text = puz5.Text;
                puz5.Text = "";
            }
            if (puz4.Text == "")
            {
                puz4.Text = puz5.Text;
                puz5.Text = "";
            }
            if (puz6.Text == "")
            {
                puz6.Text = puz5.Text;
                puz5.Text = "";
            }
            if (puz8.Text == "")
            {
                puz8.Text = puz5.Text;
                puz5.Text = "";
            }

            EndCheck();
        }

        private void Puz6_Clicked(object sender, EventArgs e)
        {
            if (puz3.Text == "")
            {
                puz3.Text = puz6.Text;
                puz6.Text = "";
            }
            if (puz5.Text == "")
            {
                puz5.Text = puz6.Text;
                puz6.Text = "";
            }
            if (puz9.Text == "")
            {
                puz9.Text = puz6.Text;
                puz6.Text = "";
            }

            EndCheck();
        }

        private void Puz7_Clicked(object sender, EventArgs e)
        {
            if (puz4.Text == "")
            {
                puz4.Text = puz7.Text;
                puz7.Text = "";
            }
            if (puz8.Text == "")
            {
                puz8.Text = puz7.Text;
                puz7.Text = "";
            }

            EndCheck();
        }

        private void Puz8_Clicked(object sender, EventArgs e)
        {
            if (puz5.Text == "")
            {
                puz5.Text = puz8.Text;
                puz8.Text = "";
            }
            if (puz7.Text == "")
            {
                puz7.Text = puz8.Text;
                puz8.Text = "";
            }
            if (puz9.Text == "")
            {
                puz9.Text = puz8.Text;
                puz8.Text = "";
            }

            EndCheck();
        }

        private void Puz9_Clicked(object sender, EventArgs e)
        {
            if (puz6.Text == "")
            {
                puz6.Text = puz9.Text;
                puz9.Text = "";
            }
            if (puz8.Text == "")
            {
                puz8.Text = puz9.Text;
                puz9.Text = "";
            }

            EndCheck();
        }
    }
}
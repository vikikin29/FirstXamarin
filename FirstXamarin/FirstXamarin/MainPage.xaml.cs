using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string input = entry.Text;
            label2.Text = input;

            string first = input.Substring(0, input.Length / 2);
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            if (first.Equals(second))
            {
                label2.Text = input + " IS PALINDROME";
            }
            else
            {
                label2.Text = input + " IS NOT PALINDROME";
            };
            



        }
    }
}
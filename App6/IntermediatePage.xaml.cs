using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntermediatePage : ContentPage
    {
        public IntermediatePage()
        {
            InitializeComponent();
        }

        private void OnNavigate_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainMenu());
        }
    }
}
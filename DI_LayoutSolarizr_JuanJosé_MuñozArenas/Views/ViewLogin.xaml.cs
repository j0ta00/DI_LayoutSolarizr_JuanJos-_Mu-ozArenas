using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DI_LayoutSolarizr_JuanJosé_MuñozArenas
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ViewLogin: Page
    {
        public ViewLogin()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog fieldsEmpty = new ContentDialog()
            {
                Title = "Any field can be empty",
                CloseButtonText = "Ok",
                Content="Write an user and password registered"
            };
            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                await fieldsEmpty.ShowAsync();
            }else{
                this.Frame.Navigate(typeof(ViewAppoiments));
            }
        }
           
        private void AppBarButton_TappedBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewButtonLogin));
        }
    }
}

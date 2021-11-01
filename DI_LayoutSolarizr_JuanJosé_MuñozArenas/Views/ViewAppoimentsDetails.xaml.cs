using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class ViewAppoimentsDetails : Page
    {
        public ViewAppoimentsDetails()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            var param = (Appoiment)e.Parameter;
            txtAppoimentType.Text += param.AppoimentType;
            txtTime.Text += param.Date.TimeOfDay.ToString();
            txtDate.Text += param.Date.ToShortDateString();
            txtAddress.Text += param.Costumer.Address;
            txtName.Text += param.Costumer.Name;
            txtPhoneNumber.Text += param.Costumer.PhoneNumber;
        }

        private void AppBarButton_TappedBack(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewAppoiments));
        }

        private async void AppBarButton_TappedSend(object sender, TappedRoutedEventArgs e)
        {
            ContentDialog informationSending = new ContentDialog()
            {
                Title = "Send it correctly !",
                CloseButtonText = "Ok"
            };
            await informationSending.ShowAsync();
          
        }
    }
}    

 


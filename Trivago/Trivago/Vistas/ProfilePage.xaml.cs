﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivago.Vista;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HotellWhiteIsaac.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

     //   ProfilesVM vm;
        public ProfilePage()
        {
            InitializeComponent();

           // vm = Resources["vm"] as ProfilesVM;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

          /*  if (!Auth.IsAuthenticated())
            {
                await Task.Delay(300); 
                await Navigation.PushAsync(new RegisterNewUser());
            }
            else
            {
                vm.ReadProfiles();
            }*/
        }

        private void AddNewProfileBtn_Clicked(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new NewProfilePage());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
          //  Navigation.PushAsync(new NewProfilePage());
        }

        private void ShowAvailableRoomsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GuardarHotel());
        }
    }
}
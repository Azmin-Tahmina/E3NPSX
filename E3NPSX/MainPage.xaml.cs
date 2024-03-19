using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace E3NPSX
{
    public partial class MainPage : ContentPage
    {
        private Person[] people = { new Person { firstname = "Joe", lastname="lastname" }, new Person { firstname = "Jane" , lastname = "lastname" }, new Person { firstname = "Jenny", lastname = "lastname" } };
        public MainPage()
        {
            InitializeComponent();
            btnJoe.Clicked += Btn_Clicked;
            btnJane.Clicked += Btn_Clicked;
            btnJenny.Clicked += Btn_Clicked;

            btnJoe2.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new DisplayPage(people[0]));
            };
            btnJane2.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new DisplayPage(people[1]));
            };
            btnJenny2.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new DisplayPage(people[2]));
            };

            btnChanged.Clicked += (sender, e) =>
            {
                btnJoe2.Text = people[0].firstname + " " + people[0].lastname;
                btnJane2.Text = people[1].firstname + " " + people[1].lastname;
                btnJenny2.Text = people[2].firstname + " " + people[2].lastname;
            };

        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DisplayPage(((Button)sender).Text), true);
        }

        protected override void OnAppearing()
        {
            // this is only useful if you there is something you want to do when the page appears/reappears.
            // a good example might be the second page makes changes to data that this page is displaying,
            // so refresh the data. Here we read what the people's current names are
            btnJoe2.Text = people[0].firstname + " " + people[0].lastname;
            btnJane2.Text = people[1].firstname + " " + people[1].lastname;
            btnJenny2.Text = people[2].firstname + " " + people[2].lastname;
            base.OnAppearing();
        }


    }
}

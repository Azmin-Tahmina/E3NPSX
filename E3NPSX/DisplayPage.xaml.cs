using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace E3NPSX
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPage : ContentPage
    {
        public DisplayPage(string name)
        {
            Button btnClose = new Button { Text = "Back" };
            btnClose.Clicked += (sender, e) => { Navigation.PopModalAsync(true); };
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "You clicked on " + name },
                    btnClose
                }
            };
        }

        public DisplayPage(Person p) : this(p.firstname)
        {
            p.lastname = "Changed";
        }

    }
}
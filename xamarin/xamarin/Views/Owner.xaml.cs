using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Owner : ContentPage
    {
        public Owner()
        {
            InitializeComponent();
            this.BindingContext = new OwnerViewModel();
        }
    }
}
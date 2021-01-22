using GitXamarin1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitXamarin1.Views.ViewFunc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTasks : ContentPage
    {
        public AddTasks()
        {
            InitializeComponent();
            BindingContext = new TaskAddViewModel();
        }

        private void Volver_clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
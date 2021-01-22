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
    public partial class ViewTasks : ContentPage
    {
        public ViewTasks()
        {
            InitializeComponent();
            BindingContext = new TaskViewModel();
        }

        private void TaskAdd_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddTasks());
        }

        private void ListViewName_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //todo when selected item
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttons : ContentPage
    {
        public ICommand ButtonCommand => new Command<string>(CommandButtonClick);
        public Buttons()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lblMessage.Text = "Save Sucess";
        }

        public void CommandButtonClick(string strCommand)
        {
            lblMessage.Text = strCommand;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}
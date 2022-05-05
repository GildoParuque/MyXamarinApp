using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckBoxes : ContentPage
    {
        public CheckBoxes()
        {
            InitializeComponent();
        }

        private void chkXamarin_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if(e.Value == true)
            {
                lblMessage.Text = "Yes, Of Course";
            }
            else
            {
                lblMessage.Text = "No, Never!";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyXamarinApp
{
    public class ItemInfoViewModel: INotifyPropertyChanged
    {
        public ICommand SubmitCommand => new Command(Submit);
        public string ItemName { get; set; }
        public string Price { get; set; }

        public string message { get; set; }
        public string Message 
        {
            get { return message; }

            set { message = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        private void Submit()
        {


            Message = "Saved Item Name:" + this.ItemName + "," + " & Price :" + this.Price;
        }
    }
}

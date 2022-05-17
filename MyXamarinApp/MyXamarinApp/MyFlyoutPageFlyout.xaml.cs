using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public MyFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MyFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MyFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public MyFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MyFlyoutPageFlyoutMenuItem>(new[]
                {
                    new MyFlyoutPageFlyoutMenuItem { Id = 0, Title = "Labels", TargetType=typeof(Labels) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 1, Title = "Entries", TargetType=typeof(Entries) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 2, Title = "Buttons", TargetType=typeof(Buttons) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 3, Title = "Images", TargetType=typeof(Images) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 3, Title = "Check Boxes", TargetType=typeof(CheckBoxes) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 3, Title = "Products", TargetType=typeof(ProductPage) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 3, Title = "Camera", TargetType=typeof(Camera) }

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
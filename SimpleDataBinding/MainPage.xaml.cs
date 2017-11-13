using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SimpleDataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Person charlie = Init();
            // BindingContext binds the object to assocciated XMAL view bindings
            BindingContext = charlie;
            InitializeComponent();
        }
        private Person Init()
        {
            return new Person { 
                FullName = "George Washington", 
                Phone = "1234-555-8767", 
                Email = "george.washington@gmail.com"
            };
        }
    }
}

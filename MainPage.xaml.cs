using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XF_BasicBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
            label1.BindingContext = slider1;
            label1.SetBinding(Label.RotationProperty, "Value");


            s1.Toggled += (sender, e) =>
            {

                if (s1.IsToggled == true)
                    label1.Text = name.Text;
                else
                    label1.Text = "Text";
            };
        }
    }
}

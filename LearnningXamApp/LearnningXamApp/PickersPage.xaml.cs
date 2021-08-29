using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnningXamApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickersPage : ContentPage
    {
        public PickersPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            var date = dp.Date.ToString("mm-dd-yy");
            var time = tp.Time;

            details.Text = string.Format("Date : {0} \n Time : {1}", date, time);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinBirth
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            main.Text = $"Day difference: {Math.Round(Math.Abs((e.NewDate - DateTime.Now).TotalDays), 0).ToString()}";
            mainYear.Text = $"Years difference: {Math.Round(Math.Abs((e.NewDate - DateTime.Now).TotalDays) / 365.2425, 2).ToString()}";
            mainDay.Text = $"Day of the week: {e.NewDate.DayOfWeek}";
        }
    }
}

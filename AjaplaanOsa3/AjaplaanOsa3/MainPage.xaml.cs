using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AjaplaanOsa3
{
    public partial class MainPage : ContentPage
    {
        TimeSpan _triggerTime;

        public MainPage()
        {
            InitializeComponent();
        }

        private void _timePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _triggerTime = _timePicker.Time;

            if (_triggerTime.Hours.ToString() == "1")
            {
                //Food Time"
                LabelInfo.Text = "Food Time";
                imageforpicker.Source = "Food.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "2")
            {
                //School Time
                LabelInfo.Text = "School Time";
                imageforpicker.Source = "School.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "3")
            {
                //Lunch Time
                LabelInfo.Text = "Lunch Time";
                imageforpicker.Source = "Lunch.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "4")
            {
                //Film Time
                LabelInfo.Text = "Film Time";
                imageforpicker.Source = "Film.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "5")
            {
                //Street Time
                LabelInfo.Text = "Street Time";
                imageforpicker.Source = "Sreet.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "6")
            {
                //Cleaning Time
                LabelInfo.Text = "Cleaning Time";
                imageforpicker.Source = "Cleaning.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "7")
            {
                //Lessons Time
                LabelInfo.Text = "Lessons Time";
                imageforpicker.Source = "Lessons.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "8")
            {
                //Dinner Time
                LabelInfo.Text = "Dinner Time";
                imageforpicker.Source = "Dinner.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "9")
            {
                //Recreation Time
                LabelInfo.Text = "Recreation Time";
                imageforpicker.Source = "Recreation.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "10")
            {
                //Recreation Time
                LabelInfo.Text = "Bath Time";
                imageforpicker.Source = "Bath.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "11")
            {
                //Tv Time
                LabelInfo.Text = "Tv Time";
                imageforpicker.Source = "Tv.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "0")
            {
                //Sleep
                LabelInfo.Text = "Sleep";
                imageforpicker.Source = "Sleep.jpg";
            }
        }
    }
}
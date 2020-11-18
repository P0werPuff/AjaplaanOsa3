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
                LabelInfo.Text = "Food Time";
                imageforpicker.Source = "Food.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "2")
            {
                LabelInfo.Text = "School Time";
                imageforpicker.Source = "School.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "3")
            {
                LabelInfo.Text = "Lunch Time";
                imageforpicker.Source = "Lunch.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "4")
            {
                LabelInfo.Text = "Film Time";
                imageforpicker.Source = "Film.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "5")
            {
                LabelInfo.Text = "Street Time";
                imageforpicker.Source = "Sreet.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "6")
            {
                LabelInfo.Text = "Cleaning Time";
                imageforpicker.Source = "Cleaning.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "7")
            {
                LabelInfo.Text = "Lessons Time";
                imageforpicker.Source = "Lessons.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "8")
            {
                LabelInfo.Text = "Dinner Time";
                imageforpicker.Source = "Dinner.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "9")
            {
                LabelInfo.Text = "Recreation Time";
                imageforpicker.Source = "Recreation.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "10")
            {
                LabelInfo.Text = "Bath Time";
                imageforpicker.Source = "Bath.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "11")
            {
                LabelInfo.Text = "Tv Time";
                imageforpicker.Source = "Tv.jpg";
            }
            else if (_triggerTime.Hours.ToString() == "0")
            {
                LabelInfo.Text = "Sleep";
                imageforpicker.Source = "Sleep.jpg";
            }
        }
    }
}
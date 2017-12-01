using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BMI_Button_Click(object sender, EventArgs e)
        {
            double dHeight = double.Parse(height.Text);

            double dWeight = 50.0;

            double BMI = dWeight / dHeight / dHeight;

            DisplayAlert("BMI",dBMI+":太りすぎ", "OK");


            double dBMI = double.Parse(weight.Text);

            double dBMI = 50.0;

            double BMI = dWeight / dHeight / dHeight;

            if (dBMI < 185)
            {
                DisplayAlert("BMI", dBMI + ":低体重(やせ型)", "OK");
            } else if(dBMI < 25.0)
                { 
                DisplayAlert("BMI", dBMI + ":普通体重", "OK");
            }       
        }
    }
}

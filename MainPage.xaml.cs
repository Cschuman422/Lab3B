using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Alcohol_App
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
        void Btn_Clicked(object sender, System.EventArgs e)
        {
            int age = Int32.Parse(Inp_age.Text);
            if(age > 21)
            {
                Lbl_BMI.Text = "You can buy alcohol";
            }
            else if (age < 21)
            {
                int years = 21 - age;
                Lbl_BMI.Text = $"You can buy alcohol in {years} years";
            }
           
            
        }
    }
}

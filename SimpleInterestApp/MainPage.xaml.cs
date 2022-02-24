using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleInterestApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
         
        }



        private void Calculate(object sender, EventArgs e)
        {
            double Total = (Convert.ToDouble(txtPrincipal_amt.Text) * Convert.ToDouble(txtMonths.Text) * Convert.ToDouble(txtInterest.Text)) / 100;
            txtTotal_amt.Text = Total.ToString();

        }

        private void Clear(object sender, EventArgs e)
        {
            txtPrincipal_amt.Text = "";
            txtInterest.Text = "";
            txtMonths.Text = "";
            txtTotal_amt.Text = "";
        }


    }
}
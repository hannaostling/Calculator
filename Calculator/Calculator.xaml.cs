using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Calculator
{
    public partial class Calculator : ContentPage
    {
        public Calculator()
        {
            InitializeComponent();
        }

        void ClearButton_Clicked(object sender, System.EventArgs e)
        {
            UserOutput.Text = "0";
        }

        void AbsButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("+/-");
        }

        void PercentButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("%");
        }

        void DivideButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("÷");
        }

        void SevenButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("7");
        }

        void EightButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("8");
        }

        void NineButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("9");
        }

        void MultiplyButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("x");
        }

        void FourButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("4");
        }

        void FiveButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("5");
        }

        void SixButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("6");
        }

        void SubtractButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("-");
        }

        void OneButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("1");
        }

        void TwoButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("2");
        }

        void ThreeButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("3");
        }

        void AddButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("+");
        }

        void ZeroButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("0");
        }

        void CommaButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine(",");
        }

        void ResultButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("=");
        }
    }
}
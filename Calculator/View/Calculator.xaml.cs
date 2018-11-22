using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Calculator
{
    public partial class Calculator : ContentPage
    {

        private String output; 

        public Calculator()
        {
            InitializeComponent();
        }

        void ClearButton_Clicked(object sender, System.EventArgs e)
        {
            output = "";
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
            UpdateLabel("7");
        }

        void EightButton_Clicked(object sender, System.EventArgs e)
        {
            UpdateLabel("8");
        }

        void NineButton_Clicked(object sender, System.EventArgs e)
        {
            UpdateLabel("9");
        }

        void MultiplyButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("x");
        }

        void FourButton_Clicked(object sender, System.EventArgs e)
        {
            UpdateLabel("4");
        }

        void FiveButton_Clicked(object sender, System.EventArgs e)
        {
            UpdateLabel("5");
        }

        void SixButton_Clicked(object sender, System.EventArgs e)
        {
            UpdateLabel("6");
        }

        void SubtractButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("-");
        }

        void OneButton_Clicked(object sender, System.EventArgs e)
        {
            UpdateLabel("1");
        }

        void TwoButton_Clicked(object sender, System.EventArgs e)
        {
            UpdateLabel("2");
        }

        void ThreeButton_Clicked(object sender, System.EventArgs e)
        {
            UpdateLabel("3");
        }

        void AddButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("+");
        }

        void ZeroButton_Clicked(object sender, System.EventArgs e)
        {
            string firstNumber = output.Substring(0, 1);
            if (firstNumber != "0" && output.Length != 0)
            {
                UpdateLabel("0");
            }
        }

        void CommaButton_Clicked(object sender, System.EventArgs e)
        {
            if (!output.Contains(","))
            {
                UpdateLabel(",");
            }
        }

        void ResultButton_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("=");
        }

        void UpdateLabel(string number)
        {
            output += number;
            UserOutput.Text = output;
        }
    }
}
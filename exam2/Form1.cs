using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //when convert click
        private void convert_Click(object sender, EventArgs e)
        {
            try
            {
                //convert the given temprature into real number
                double temperature = Convert.ToDouble(temp.Text);

                output.ForeColor = Color.Green;
                //check if celsius radio button is clicked
                if (celsius.Checked)
                {
                    //if yes convert temp to celsius
                    convert_to_celsius(temperature);
                }
                else
                {
                    //if not convert to fahrenheit
                    convert_to_fahrenheit(temperature);
                }
            }
            //when error converting temprature
            catch (Exception)
            {
                //show error message
                output.ForeColor = Color.Red;
                output.Text = "ERROR: Please enter a numeric temperature to convert";
            }
        }
        //method that converts given temperature into fahrenheit
        private void convert_to_fahrenheit(double temperature)
        {
            double temp_fahr = (temperature * 1.8) + 32;

            output.Text = String.Format("{0:0.00} degrees Celsius converts to {1:0.00} degrees Fahrenheit.", temperature, temp_fahr);
        }
        //method that converts given temperature into celsius
        private void convert_to_celsius(double temperature)
        {
            double temp_cels = (temperature - 32) / 1.8;

            output.Text = String.Format("{0:0.00} degrees Fahrenheit converts to {1:0.00} degrees Celsius.", temperature, temp_cels);

        }
        //clear everything when clear button clicked
        private void clear_Click(object sender, EventArgs e)
        {
            temp.Text = "";
            celsius.Checked = true;
            output.Text = "";
        }
        //close form
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
    }


}

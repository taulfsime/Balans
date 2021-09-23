using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fsChange();
        }

        private int getFs1To12Sum()
        {
            return (int)fs1.Value + (int)fs2.Value + (int)fs3.Value + (int)fs4.Value +
                    (int)fs5.Value + (int)fs6.Value + (int)fs7.Value + (int)fs8.Value +
                    (int)fs9.Value + (int)fs10.Value + (int)fs11.Value + (int)fs12.Value;
        }

        private void fsChange()
        {
            float sumValue = (float)getFs1To12Sum();
            float avg = sumValue / 12.0f;

            float fs13Value = ((float)fs13.Value * (float)avg) / 100.0f;
            fs13Result.Text = "% -> " + Math.Round(fs13Value, 1) + " кг";

            float m3 = ((float)fs14_15_16_17.Value * 230) / 100;
            float fs14_15_16_17Value = (m3 / 119) * avg;

            fs14_15_16_17Result.Text = "% -> " + Math.Round(fs14_15_16_17Value, 1) + " кг";

            if(fs13AddToSum.Checked)
            {
                sumValue += fs13Value;
            }

            if (fs14_15_16_17AddToSum.Checked)
            {
                sumValue += fs14_15_16_17Value;
            }

            sum.Text = Math.Round(sumValue, 1).ToString();
        }

        private void fs9_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs11_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs1_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs10_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs12_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs2_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs5_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs7_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs3_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs6_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs8_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs4_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs13_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs14_15_16_17_ValueChanged(object sender, EventArgs e) => fsChange();
        private void fs13AddToSum_CheckedChanged(object sender, EventArgs e) => fsChange();
        private void fs14_15_16_17AddToSum_CheckedChanged(object sender, EventArgs e) => fsChange();
    }
}

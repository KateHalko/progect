using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_Lab._12
{
	public partial class Trigon_Calc : Form
	{

		double a = 0,b, rez;
		int count;

		public Trigon_Calc()
		{
			InitializeComponent();
			
		}

		private void calculate()
		{
			switch ( count )
			{
				case 1:
					
					rez = Math.Sin(a * Math.PI / 180);
					label2.Text = rez.ToString();
					break;

				case 2:
					
					rez = Math.Cos(a * Math.PI / 180);
					label2.Text = rez.ToString();
					break;

				case 3:

					rez = Math.Tan(a * Math.PI / 180);
					label2.Text = rez.ToString();
					break;
				case 4:

					if ( a < -1 || a > 1 )
					{
						label2.Text = "НЕВЕРНЫЕ ДАННЫЕ !!!";
						break;
					}

					rez = Math.Asin(a ) * 180 / Math.PI;
					label2.Text = rez.ToString();
					break;
				case 5:

					if ( a < -1 || a > 1 )
					{
						label2.Text = "НЕВЕРНЫЕ ДАННЫЕ !!!";
						break;
					}

					rez = Math.Acos(a) * 180 / Math.PI;
					label2.Text = rez.ToString();
					break;
				case 6:

					rez = Math.Atan(a) * 180 / Math.PI;
					label2.Text = rez.ToString();
					break;

				default:
					break;
			}

		}






		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			label2.Text += "0";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			label2.Text += "1";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			label2.Text += "2";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			label2.Text += "3";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			label2.Text += "4";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			label2.Text += "5";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			label2.Text += "6";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			label2.Text += "7";
		}

		private void button11_Click(object sender, EventArgs e)
		{
			label2.Text += "8";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			label2.Text += "9";
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if ( ( label2.Text.IndexOf(",") == -1 ) && ( label2.Text.IndexOf("∞") == -1 ) )
				label2.Text += ",";
		}

		private void button17_Click(object sender, EventArgs e)
		{
			if ( label2.Text[0] == '-' )
				label2.Text = label2.Text.Remove(0, 1);
			else
				label2.Text = "-" + label2.Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label2.Text = "";
			
		}

		private void button15_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			count = 1;
			calculate();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			count = 2;
			calculate();

		}

		private void button14_Click(object sender, EventArgs e)
		{

			a = double.Parse(label2.Text);
			count = 3;
			calculate();
		}

		private void button16_Click(object sender, EventArgs e)
		{

			a = double.Parse(label2.Text);
			count = 4;
			calculate();
		}

		private void button18_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			count = 5;
			calculate();

		}

		private void button19_Click(object sender, EventArgs e)
		{

			a = double.Parse(label2.Text);
			count = 6;
			calculate();
		}

		private void button20_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);			
			label2.Text =Math.Pow(a, 2).ToString();
		}

		private void button21_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			label2.Text = Math.Pow(2, a).ToString();
		}

		private void button22_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			label2.Text = Math.Exp(a).ToString();

		}

		private void button24_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			label2.Text = Math.Pow(a, 3).ToString();
		}

		private void button23_Click(object sender, EventArgs e)
		{

			a = double.Parse(label2.Text);
			label2.Text = Math.Pow(10, a).ToString();
		}

		private void button26_Click(object sender, EventArgs e)
		{
			b = double.Parse(label2.Text);
			label2.Text = Math.Pow(a, b).ToString();

		}

		private void button25_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			label2.Text = "";

		}

		private void button3_Click(object sender, EventArgs e)
		{
		}
	}
}

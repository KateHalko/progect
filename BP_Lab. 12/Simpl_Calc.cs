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
	public partial class Simpl_Calc : Form
	{
		private void calculate()
		{
			switch ( count )
			{
				case 1:
					b = a + double.Parse(label2.Text);
					label2.Text = b.ToString();
					break;
				case 2:
					b = a - double.Parse(label2.Text);
					label2.Text = b.ToString();
					break;
				case 3:
					b = a * double.Parse(label2.Text);
					label2.Text = b.ToString();
					break;
				case 4:
					if ( double.Parse(label2.Text) == 0 )
					{
						label2.Text = "НЕВЕРНЫЕ ДАННЫЕ !!!";
						break;
					}
					b = a / double.Parse(label2.Text);
					label2.Text = b.ToString();
					break;

				default:
					break;
			}

		}
		public Simpl_Calc()
		{
			InitializeComponent();
		}

		double a=0, b;
		int count;

		private void button1_Click(object sender, EventArgs e)
		{

			label2.Text += "0";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

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

		private void button15_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			label2.Text = "";
			count = 1;
			label1.Text = a.ToString() + "+";
		}

		private void button14_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			label2.Text = "";
			count = 2;
			label1.Text = a.ToString() + "-";
		}

		private void button13_Click(object sender, EventArgs e)
		{
			a = double.Parse(label2.Text);
			label2.Text = "";
			count = 3;
			label1.Text = a.ToString() + "*";
		}

		private void button16_Click(object sender, EventArgs e)
		{

			a = double.Parse(label2.Text);
			label2.Text = "";
			count = 4;
			label1.Text = a.ToString() + "/";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			calculate();
			label1.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label2.Text = "";
			label1.Text = "";
		}

		private void button17_Click(object sender, EventArgs e)
		{
			if ( label2.Text[0] == '-' )
				label2.Text = label2.Text.Remove(0, 1);
			else
				label2.Text = "-" + label2.Text;
		}

			private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button12_Click(object sender, EventArgs e)
		{
			label2.Text += "9";
		}
	}
}

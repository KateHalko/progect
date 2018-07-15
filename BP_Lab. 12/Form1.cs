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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Simpl_Calc f = new Simpl_Calc();
			f.Hide();
			f.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Trigon_Calc f = new Trigon_Calc();
			f.Hide();
			f.Show();
		}
	}
}

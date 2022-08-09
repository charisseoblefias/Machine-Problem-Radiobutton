/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/15/2021
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Machine_Problem_Radiobutton
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void RadFirstYearCheckedChanged(object sender, EventArgs e)
		{
			this.textBox1.Text = "Freshman";
		}
		void RadSecondYearCheckedChanged(object sender, EventArgs e)
		{
			this.textBox1.Text = "Sophomore";
		}
		void RadThirdYearCheckedChanged(object sender, EventArgs e)
		{
			this.textBox1.Text = "Junior";
		}
		void RadFourthYearCheckedChanged(object sender, EventArgs e)
		{
			this.textBox1.Text = "Senior";
		}
		void ClearbuttonClick(object sender, EventArgs e)
		{
			textBox1.Clear();
			radFirstYear.Checked = false;
			radSecondYear.Checked = false;
			radThirdYear.Checked = false;
			radFourthYear.Checked = false;
		}
		void ExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

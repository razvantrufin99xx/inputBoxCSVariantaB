/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/18/2024
 * Time: 9:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace inputForm
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
		public  string inputdatas = "";
		public  void returninputstring(string s)
		{
			inputdatas = s;
			textBox1.Text = inputdatas;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			inputforma ifr = new inputforma();
			ifr.setReturnMainForm(this);
			ifr.Show();
		}
	}
}

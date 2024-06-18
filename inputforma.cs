/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/18/2024
 * Time: 9:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace inputForm
{
	/// <summary>
	/// Description of inputforma.
	/// </summary>
	public partial class inputforma : Form
	{
		public inputforma()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		MainForm mf;
		public void setReturnMainForm(MainForm pmf)
		{
			try{
				mf = (MainForm)pmf;
			}
			catch{};
		}
		void InputformaLoad(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			mf.returninputstring(this.textBox1.Text);
			this.Close();
		}
	}
}

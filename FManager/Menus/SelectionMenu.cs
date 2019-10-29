/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 25-02-2017
 * Time: 12:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FManager.TestViews;

namespace FManager.Menus
{
	/// <summary>
	/// Description of SelectionMenu.
	/// </summary>
	public partial class SelectionMenu : Form
	{
		public static string type;
		
		public SelectionMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//
		//
		//
		void Button1Click(object sender, EventArgs e)
		{
			MainForm.table = "skærme";
			Hide();
			ScreenTest screen = new ScreenTest();
			screen.ShowDialog();
			Close();
		}
		//
		//
		//
		void Button2Click(object sender, EventArgs e)
		{
			MainForm.table = "pc";			
			type = "Laptop";
			Hide();
			LaptopTest pc = new LaptopTest();
			pc.ShowDialog();
			Close();
			
		}
		//
		//
		//
		void Button3Click(object sender, EventArgs e)
		{
			MainForm.table = "pc";			
			type = "Desktop";
			Hide();
			DesktopTest pc = new DesktopTest();
			pc.ShowDialog();
			Close();
		}
		//
		//
		//
		void Button4Click(object sender, EventArgs e)
		{
			MainForm.table = "printere";			
			Hide();
			PrinterTest printer = new PrinterTest();
			printer.ShowDialog();
			Close();			
		}
		//
		//
		//
	}
}

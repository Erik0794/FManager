/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 23-02-2017
 * Time: 08:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FManager.Views
{
	/// <summary>
	/// Description of deleteform.
	/// </summary>
	public partial class Deleteform : Form
	{
		public Deleteform()
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
		//DATABASE STUFF
		MySqlConnection mcon;
		ConnectionStringSettings mcons = ConfigurationManager.ConnectionStrings["MySql"];
		//
		//
		//
		void Button1Click(object sender, EventArgs e)
		{
			string serialno = textBox1.Text;
			string q = "DELETE FROM "+ MainForm.database + "." + MainForm.table + " WHERE `Serienummer`= @sn";
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = q;
				mcmd.Parameters.AddWithValue("@sn", serialno);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			this.Close();
		}
		void DeleteformLoad(object sender, EventArgs e)
		{
			this.AcceptButton = button1;
			label2.Text = MainForm.table;
		}
		//
		//
		//
	}
}

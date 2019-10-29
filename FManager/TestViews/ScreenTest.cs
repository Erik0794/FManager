/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 25-02-2017
 * Time: 17:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using FManager;
using FManager.Menus;
using FManager.Views;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FManager.TestViews
{
	/// <summary>
	/// Description of ScreenTest.
	/// </summary>
	public partial class ScreenTest : Form
	{
		//Database stuff
		MySqlConnection mcon; //connection to the database
		ConnectionStringSettings mcons = ConfigurationManager.ConnectionStrings["MySql"]; //Just the connection string to login to DB
		//Variables comes after this line
		string status;
		//
		static string lastentry;
		//		
		public ScreenTest()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ScreenTestLoad(object sender, EventArgs e)
		{
			//
			string mcs = mcons.ConnectionString; //string to contain connection string	
			using(mcon = new MySqlConnection(mcs)) //create a new connection to the DB
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					const string query = "SELECT * FROM `adm_test`.`skærme`"; //command to get information from the database
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView1.DataSource = dt;
				}
			}			
		}
		void StatusBtnOKClick(object sender, EventArgs e)
		{
			//
			status = comboBox1.Text + ", " + comboBox2.Text + ", " + comboBox3.Text;
			if(comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "") MessageBox.Show("Please check status selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//
			if(idbox.Text == "" || brandbox.Text == "==GRUPPE==" ||	modelbox.Text == "==Type==" || 
			   serialbox.Text == "==Mærke==" || screensizebox.Text == "" || notebox.Text == "")
			{
				MessageBox.Show("Please check the entered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//^ Check if any boxes are empty and break if yes
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				lastentry = idbox.Text;				
				mcon.Open();
				const string query = "INSERT INTO `adm_test`.`skærme` (`Medarbejder_ID`, `ID`, `Mærke`, `Model`, `Størrelse`, `Serienummer`, `Status`, `Noter`) VALUES(@mid, @lid, @me, @ml, @se, @sn, @ss, @nr)";
				MySqlCommand mcmd = new MySqlCommand(query, mcon);
					mcmd.Parameters.AddWithValue("@mid"		,	 	LoginForm.MID);
					mcmd.Parameters.AddWithValue("@lid"		,	 	idbox.Text);
					mcmd.Parameters.AddWithValue("@me"		,	 	brandbox.Text);
					mcmd.Parameters.AddWithValue("@ml"		,	 	modelbox.Text);
					mcmd.Parameters.AddWithValue("@se"		,	 	screensizebox.Text);
					mcmd.Parameters.AddWithValue("@sn"		,	 	serialbox.Text);
					mcmd.Parameters.AddWithValue("@ss"		,	 	status);
					mcmd.Parameters.AddWithValue("@nr"		,	 	notebox.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}//Insert the data from the form into the database
			clearboxes();
			reload();
		}
		void StatusBtnDEFClick(object sender, EventArgs e)
		{
			//
			status = "Defekt";
			//
			if(idbox.Text == "" || brandbox.Text == "==GRUPPE==" ||	modelbox.Text == "==Type==" || 
			   serialbox.Text == "==Mærke==" || screensizebox.Text == "" || notebox.Text == "")
			{
				MessageBox.Show("Please check the entered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//^ Check if any boxes are empty and break if yes
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				lastentry = idbox.Text;
				mcon.Open();
				const string query = "INSERT INTO `adm_test`.`skærme` (`Medarbejder_ID`, `ID`, `Mærke`, `Model`, `Størrelse`, `Serienummer`, `Status`, `Noter`) VALUES(@mid, @lid, @me, @ml, @se, @sn, @ss, @nr)";
				MySqlCommand mcmd = new MySqlCommand(query, mcon);
					mcmd.Parameters.AddWithValue("@mid"		,	 	LoginForm.MID);
					mcmd.Parameters.AddWithValue("@lid"		,	 	idbox.Text);
					mcmd.Parameters.AddWithValue("@me"		,	 	brandbox.Text);
					mcmd.Parameters.AddWithValue("@ml"		,	 	modelbox.Text);
					mcmd.Parameters.AddWithValue("@se"		,	 	screensizebox.Text);
					mcmd.Parameters.AddWithValue("@sn"		,	 	serialbox.Text);
					mcmd.Parameters.AddWithValue("@ss"		,	 	status);
					mcmd.Parameters.AddWithValue("@nr"		,	 	notebox.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}//Insert the data from the form into the database
			clearboxes();
			reload();
		}
		void PauseBtnClick(object sender, EventArgs e)
		{
			using(Pause p1 = new Pause())
			{
			  	  Hide();
				    if(p1.ShowDialog() == DialogResult.OK)
					{
						p1.ShowDialog();
					}
				  Show();
			}	
		}
		void ExitBtnClick(object sender, EventArgs e)
		{
			Close();
		}
		//
		//
		//
		void clearboxes()
		{
			idbox.Clear();
			brandbox.Clear();
			modelbox.Clear();
			serialbox.Clear();
			screensizebox.Clear();
			notebox.Clear();
		}
		//
		//
		//
		void reload()
		{
			string mcs = mcons.ConnectionString; //string to contain connection string	
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					const string query = "SELECT * FROM `adm_test`.`skærme`"; //command to get information from the database
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView1.DataSource = dt;
				}
			}			
		}
		void DeletebtnClick(object sender, EventArgs e)
		{
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				string query = "DELETE FROM `adm_test`.`skærme` WHERE `ID` = @id";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@id", lastentry);
				MySqlDataReader mdr = mcmd.ExecuteReader();				  
			}			
		}
	}
}

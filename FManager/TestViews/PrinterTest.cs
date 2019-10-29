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
	/// Description of PrinterTest.
	/// </summary>
	public partial class PrinterTest : Form
	{
		//Database stuff
		MySqlConnection mcon; //connection to the database
		ConnectionStringSettings mcons = ConfigurationManager.ConnectionStrings["MySql"]; //Just the connection string to login to DB
		//Variables comes after this line
		string status;
		string colorselection;
		//
		static string lastentry;
		//		
		public PrinterTest()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PrinterTestLoad(object sender, EventArgs e)
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
			evaluate();
			//
			status = comboBox1.Text + ", " + comboBox2.Text + ", " + comboBox3.Text;
			if(comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "") MessageBox.Show("Please check status selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//
			if(idbox.Text == "" || brandbox.Text == "==GRUPPE==" ||	modelbox.Text == "==Type==" || 
			   serialbox.Text == "==Mærke==" || notebox.Text == "")
			{
				MessageBox.Show("Please check the entered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//^ Check if any boxes are empty and break if yes
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO `adm_test`.`printere` (`Medarbejder_ID`, `ID`, `Mærke`, `Serienummer`, `Type`, `Farvetype`, `Tonerindhold`, `Status`, `Noter`) VALUES(@mid, @lid, @me, @sn, @te, @ft, @ti, @ss, @nr)";
				MySqlCommand mcmd = new MySqlCommand(query, mcon);
					mcmd.Parameters.AddWithValue("@mid"		,	 	LoginForm.MID);
					mcmd.Parameters.AddWithValue("@lid"		,	 	idbox.Text);
					mcmd.Parameters.AddWithValue("@me"		,	 	brandbox.Text);
					mcmd.Parameters.AddWithValue("@ml"		,	 	modelbox.Text);
					mcmd.Parameters.AddWithValue("@sn"		,	 	serialbox.Text);
					mcmd.Parameters.AddWithValue("@te"		, 		typebox.Text);
					mcmd.Parameters.AddWithValue("@ft"		,		colorselection);
					mcmd.Parameters.AddWithValue("@ti"		,		leftoverbox.Text + "%");
					mcmd.Parameters.AddWithValue("@ss"		,	 	status);
					mcmd.Parameters.AddWithValue("@nr"		,	 	notebox.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}//Insert the data from the form into the database
			clearboxes();
			reload();
			lastentry = idbox.Text;
		}
		void StatusBtnDEFClick(object sender, EventArgs e)
		{
			evaluate();
			//
			status = "Defekt";
			//
			if(idbox.Text == "" || brandbox.Text == "==GRUPPE==" ||	modelbox.Text == "==Type==" || 
			   serialbox.Text == "==Mærke==" || notebox.Text == "")
			{
				MessageBox.Show("Please check the entered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//^ Check if any boxes are empty and break if yes
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO `adm_test`.`printere` (`Medarbejder_ID`, `ID`, `Mærke`, `Serienummer`, `Type`, `Farvetype`, `Tonerindhold`, `Status`, `Noter`) VALUES(@mid, @lid, @me, @sn, @te, @ft, @ti, @ss, @nr)";
				MySqlCommand mcmd = new MySqlCommand(query, mcon);
					mcmd.Parameters.AddWithValue("@mid"		,	 	LoginForm.MID);
					mcmd.Parameters.AddWithValue("@lid"		,	 	idbox.Text);
					mcmd.Parameters.AddWithValue("@me"		,	 	brandbox.Text);
					mcmd.Parameters.AddWithValue("@ml"		,	 	modelbox.Text);
					mcmd.Parameters.AddWithValue("@sn"		,	 	serialbox.Text);
					mcmd.Parameters.AddWithValue("@te"		, 		typebox.Text);
					mcmd.Parameters.AddWithValue("@ft"		,		colorselection);
					mcmd.Parameters.AddWithValue("@ti"		,		leftoverbox.Text + "%");
					mcmd.Parameters.AddWithValue("@ss"		,	 	status);
					mcmd.Parameters.AddWithValue("@nr"		,	 	notebox.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}//Insert the data from the form into the database
			clearboxes();
			reload();
			lastentry = idbox.Text;
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
		void evaluate()
		{
			if(radioButton1.Checked)
			{
				colorselection = "farve";
			}
			if(radioButton2.Checked)
			{
				colorselection = "sort/hvid";
			}
			if(radioButton1.Checked == false && radioButton2.Checked == false){MessageBox.Show("Please select a color option!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;}
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
		//
		//
		//
		void clearboxes()
		{
			idbox.Clear();
			brandbox.Clear();
			modelbox.Clear();
			serialbox.Clear();
			typebox.SelectedIndex = 0;
			leftoverbox.Clear();
			notebox.Clear();
			radioButton1.Checked = false;
			radioButton2.Checked = false;
		}
		void DeletebtnClick(object sender, EventArgs e)
		{
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				string query = "DELETE FROM `adm_test`.`printere` WHERE `ID` = @id";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@id", lastentry);
				MySqlDataReader mdr = mcmd.ExecuteReader();				  
			}			
		}
	}
	//
	//
	//
	
}
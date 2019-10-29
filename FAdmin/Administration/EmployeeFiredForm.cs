/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 03-07-2017
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace FAdmin.Administration
{
	/// <summary>
	/// Description of EmployeeFiredForm.
	/// </summary>
	public partial class EmployeeFiredForm : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//		
		int empid;
		//
		public EmployeeFiredForm()
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
		void EmployeeFiredFormLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet ds = new DataSet()) 															//DataSet to contain the information gotten from the database
				{
					string query = "SELECT `Navn` FROM `adm_ansatte`.`personlig_info`"; 	//command to get information from the text in placemenu(combobox)
					DataTable dt = new DataTable(); 														//table to hold the rows from the database
					ds.Tables.Add(dt); 																		//add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); 												//command to execute the mysql adapter
					  mcmd.Connection = mcon; 																//specify which connection to use
					  mcmd.CommandText = query;																//specify the command text to use
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);										//execute the adapter
					  mda.Fill(dt);																			//and fill the tables
					namebox.Items.Clear();																	//remove existing data to avoid duplicates
					foreach(DataTable table in ds.Tables)													//this does table
					{
						foreach(DataRow row in table.Rows)													//this does rows
						{
							foreach(DataColumn column in dt.Columns)										//this dows columns
							{
								if(row[column] == (null) || row[column].ToString() == "")					//Clears any null values from the list of items
								{
									continue;
								}
								namebox.Items.Add(row[column]);												//print selected column with selected rows
							}
						}
					}
				}
			}
		}
		//
		//
		//
		void YourefiredClick(object sender, EventArgs e)
		{
			//
			yourefired.Visible = false;
			yesbtn.Visible = true;
			nobtn.Visible = true;
			text.Visible = true;
			//
		}
		//
		//
		//
		void NobtnClick(object sender, EventArgs e)
		{
			Close();
		}
		//
		//
		//
		void YesbtnClick(object sender, EventArgs e)
		{
			//
			//
				//TODO: Add feature to print data from textbox into pdf and onto paper
			//
			//
			using(mcon = new MySqlConnection(mcs))
			{
				string query = "SELECT `Medarbejder_ID` FROM `adm_ansatte`.`personlig_info` WHERE `Navn` = @empname";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				mcmd.Parameters.AddWithValue("@empname", namebox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					empid = mdr.GetInt16("Medarbejder_ID");
				}
			}
			//
			using(mcon = new MySqlConnection(mcs))
			{
				string query = "DELETE FROM `adm_ansatte`.`personlig_info` WHERE `Medarbejder_ID` = @empid";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				mcmd.Parameters.AddWithValue("@empid", empid);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			//
			using(mcon = new MySqlConnection(mcs))
			{
				string query = "DELETE FROM `adm_ansatte`.`ice` WHERE `Medarbejder_ID` = @empid";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				mcmd.Parameters.AddWithValue("@empid", empid);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			//			
			using(mcon = new MySqlConnection(mcs))
			{
				string query = "DELETE FROM `adm_ansatte`.`bankinfo` WHERE `Medarbejder_ID` = @empid";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				mcmd.Parameters.AddWithValue("@empid", empid);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			//
			using(mcon = new MySqlConnection(mcs))
			{
				string query = "DELETE FROM `adm_konti`.`konti` WHERE `Medarbejder_ID` = @empid";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				mcmd.Parameters.AddWithValue("@empid", empid);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}			
			//
			Close();			
		}
	}
}

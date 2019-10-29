/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 10-07-2017
 * Time: 09:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FAdmin.Administration
{
	/// <summary>
	/// Description of EmployeeRosterForm.
	/// </summary>
	public partial class EmployeeRosterForm : Form
	{
		//
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//
		public EmployeeRosterForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void EmployeeRosterFormLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
			using(MySqlConnection mcon = new MySqlConnection(mcs))
			{
				using(DataSet ds = new DataSet()) 															//DataSet to contain the information gotten from the database
				{
					string query = "SELECT * FROM `adm_ansatte`.`personlig_info`"; 	//command to get information from the text in placemenu(combobox)
					DataTable dt = new DataTable(); 														//table to hold the rows from the database
					ds.Tables.Add(dt); 																		//add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); 												//command to execute the mysql adapter
					  mcmd.Connection = mcon; 																//specify which connection to use
					  mcmd.CommandText = query;																//specify the command text to use
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);										//execute the adapter
					  mda.Fill(dt);
					dataGridView1.DataSource = dt;
				}
			}
		}
	}
}

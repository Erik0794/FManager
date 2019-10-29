/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 31-03-2017
 * Time: 08:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FAdmin.Clients
{
	/// <summary>
	/// Description of SBAdresser.
	/// </summary>
	public partial class SBAdresser : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//
		//
		//
		public SBAdresser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void SBAdresserLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;			
		}
		//
		//
		//		
		void GetbtnClick(object sender, EventArgs e)
		{
			if(cvrbox.Text == "")
			{MessageBox.Show("Please enter CVR no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;}
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "SELECT * FROM `adm_klientind`.`slutbrugere` WHERE `CVR` = @cvr";
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					companyname.Text = mdr.GetString("Firmanavn");
				}
			}
			using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
			{
				const string query = "SELECT * FROM `adm_klientind`.`adresser` WHERE CVR = @cvr"; //command to get information from the database
				DataTable dt = new DataTable(); //table to hold the rows from the database
				dst.Tables.Add(dt); //add table to dataset
				MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
				  mcmd.Connection = mcon; //specify which connection to use
				  mcmd.CommandText = query;	//specify the command text to use
				  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
				MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
				  mda.Fill(dt);	//and fill the tables
				  dataGridView1.DataSource = dt;
			}
		}
		//
		//
		//
		void CreatebtnClick(object sender, EventArgs e)
		{
			Hide();
			AddressAdd aa = new AddressAdd();
			aa.ShowDialog();
			Show();			
		}
		//
		//
		//
		void EditbtnClick(object sender, EventArgs e)
		{
			Hide();
			AddressEditor ae = new AddressEditor();
			ae.ShowDialog();
			Show();
		}
		//
		//
		//
		void ExitbtnClick(object sender, EventArgs e)
		{
			Close();
		}		
	}
}

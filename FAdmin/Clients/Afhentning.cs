/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 10-04-2017
 * Time: 12:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FAdmin.Clients
{
	/// <summary>
	/// Description of Afhentning.
	/// </summary>
	public partial class Afhentning : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//
		//
		//
		public Afhentning()
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
		void AfhentningLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
		}
		//
		//
		//
		void GetbtnClick(object sender, EventArgs e)
		{
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				using(DataSet dst = new DataSet())
				{
					DataTable dt = new DataTable();
					dst.Tables.Add(dt);
					string query = "SELECT * FROM `adm_klientind`.`adresser` WHERE `CVR` = @cvr";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView1.DataSource = dt; 					
				}
				using(DataSet ds = new DataSet())
				{
					DataTable dt = new DataTable();
					ds.Tables.Add(dt);
					string query = "SELECT `Adresse` FROM `adm_klientind`.`adresser` WHERE `CVR` = @cvr";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables					
					foreach(DataTable table in ds.Tables) //this does table
					{
						foreach(DataRow row in table.Rows) //this does rows
						{
							foreach(DataColumn column in dt.Columns) //this dows columns
							{
								if(row[column] == (null) || row[column].ToString() == "") //Clears any null values from the list of items
								{
									continue;
								}
								comboBox1.Items.Add(row[column]); //print selected column with selected rows
							}
						}
					}
				}
			}			
		}		
		//
		//
		//
		void AddbtnClick(object sender, EventArgs e)
		{
			
			string query = "INSERT INTO `adm_klientind`.`ordrer` (`Adresse`,`Palle`,`Bur`,`Lille Bil`,`Stor Bil`) VALUES(@adr,@pal,@bur,@lil,@big)";
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				using(DataSet dst = new DataSet())
				{
					DataTable dt = new DataTable();
					dst.Tables.Add(dt);
					MySqlCommand mcmd = mcon.CreateCommand();
					  mcmd.CommandText = query;
					  mcmd.Parameters.AddWithValue("@adr", comboBox1.Text);
					  mcmd.Parameters.AddWithValue("@pal", pallebox.Text);
					  mcmd.Parameters.AddWithValue("@bur", burebox.Text);
					  mcmd.Parameters.AddWithValue("@lil", smallcarbox.Text);
					  mcmd.Parameters.AddWithValue("@big", bigcarbox.Text);
					MySqlDataReader mdr = mcmd.ExecuteReader();
				}
			}
		}
		//
		//
		//
		void DelbtnClick(object sender, EventArgs e)
		{
			
		}
		//
		//
		//
		void ExitbtnClick(object sender, EventArgs e)
		{
			Close();
		}
		//
		//
		//
	}
}

/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 12-03-2017
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using FAdmin.Clients;
using MySql.Data.MySqlClient;


namespace FAdmin.Administration
{
	/// <summary>
	/// Description of AdminForm.
	/// </summary>
	public partial class AdminForm : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//
		public AdminForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			tabControl1.SelectedIndexChanged += TabControl1SelectedIndexChanged;
			//
			// 
			//
		}
		//
		//
		//
		void selectedtab1()
		{
			//Bure
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					const string query = "SELECT * FROM `adm_lager`.`inventory_bure`";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute as the mysql adapter
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
		void selectedtab2()
		{
			//Statistik Indmelding
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					const string query = "SELECT * FROM `adm_stationlogs`.`station_indmelding_logs`";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute as the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView2.DataSource = dt;		
				}				
			}
		}
		//
		//
		//
		void selectedtab3()
		{
			//Statistik Test
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					const string query = "SELECT * FROM `adm_stationlogs`.`station_test_log`";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute as the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView3.DataSource = dt;		
				}				
			}
		}
		//
		//
		//
		void selectedtab4()
		{
			//Statistik Skrot
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					const string query = "SELECT * FROM `adm_stationlogs`.`station_skrot_logs`";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute as the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView4.DataSource = dt;		
				}				
			}	
		}
		//
		//
		//
		void selectedtab5()
		{
			//Statistik Sletning
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					const string query = "SELECT * FROM `adm_stationlogs`.`station_sletning_logs`";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute as the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView5.DataSource = dt;		
				}				
			}
		}
		//
		//
		//
		void selectedtab6()
		{
			//Statistik Salg
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					const string query = "SELECT * FROM `adm_stationlogs`.`station_salg_logs`";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute as the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView6.DataSource = dt;		
				}				
			}
		}
		//
		//
		//
		void selectedtab7()
		{
			//Restopgaver
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					const string query = "SELECT * FROM `adm_stationlogs`.`bure_manglende_log`";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute as the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text; //no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView7.DataSource = dt;		
				}				
			}	
		}
		//
		//
		//
		void AdminFormLoad(object sender, EventArgs e)
		{
			//
			mcs = mconcs.ConnectionString;
			//
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					const string query = "SELECT * FROM `adm_lager`.`inventory_bure`";
					MySqlCommand mcmd = new MySqlCommand(); //command to execute as the mysql adapter
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
		void OpretSlutbrugerToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			SBAdd sba = new SBAdd();
			sba.ShowDialog();
			Show();
		}
		//
		//
		//
		void SlutbrugerKartotekToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			SBAdresser sba = new SBAdresser();
			sba.ShowDialog();
			Show();
		}
		//
		//
		//
		void AfhentningToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			Afhentning afh = new Afhentning();
			afh.ShowDialog();
			Show();
		}
		//
		//
		//
		void OpretBrugereToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			EmployeeCreateForm emp = new EmployeeCreateForm();
			emp.ShowDialog();
			Show();
		}
		//
		//
		//
		void StatistikToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			StatisticsForm stats = new StatisticsForm();
			stats.ShowDialog();
			Show();
		}
		//
		//
		//
		void Button1Click(object sender, EventArgs e)
		{
			opretBrugereToolStripMenuItem.PerformClick();
		}
		//
		//
		//
		void Button2Click(object sender, EventArgs e)
		{
			afhentningToolStripMenuItem.PerformClick();
		}
		//
		//
		//
		void Button3Click(object sender, EventArgs e)
		{
			//
		}
		//
		//
		//		
		void Button4Click(object sender, EventArgs e)
		{
			opretKundeToolStripMenuItem.PerformClick();
		}
		//
		//
		//
		void Button5Click(object sender, EventArgs e)
		{
			//
		}
		//
		//
		//		
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = tabControl1.SelectedIndex + 1;
			switch(i)
			{
				case 1:
					selectedtab1();
					break;
				case 2:
					selectedtab2();
					break;
				case 3:
					selectedtab3();
					break;
				case 4:
					selectedtab4();
					break;
				case 5:
					selectedtab5();
					break;
				case 6:
					selectedtab6();
					break;
				case 7:
					selectedtab7();
					break;
			}
		}
		//
		//
		//
		void OpretKundeToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			UserMakeForm umf = new UserMakeForm();
			umf.ShowDialog();
			Show();
		}
		//
		//
		//
		void RedigerKundeinformationToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			ClientEditForm cef = new ClientEditForm();
			cef.ShowDialog();
			Show();
		}
		//
		//
		//
		void RedigerBrugerToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			EmployeeEditForm eef = new EmployeeEditForm();
			eef.ShowDialog();
			Show();				
		}		
		//
		//
		//
		void FyringAfBrugerToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			EmployeeFiredForm eff = new EmployeeFiredForm();
			eff.ShowDialog();
			Show();			
		}
		void AnsatteToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hide();
			EmployeeRosterForm erf = new EmployeeRosterForm();
			erf.ShowDialog();
			Show();
		}
		//
		//
		//
		void AfslutToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		//
		//
		//		
	}
}

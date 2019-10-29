/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 26-03-2017
 * Time: 12:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FManager
{
	/// <summary>
	/// Description of ExitForm.
	/// </summary>
	public partial class ExitForm : Form
	{
		//
		//Database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		string mfat;		
		//
		string station;
		//
		public static int choice;
		//
		public ExitForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ExitFormLoad(object sender, EventArgs e)
		{
			station = Dns.GetHostEntry("localhost").HostName;
			mcs = mconcs.ConnectionString;
		}		
		//
		//
		//
		void GohomebtnClick(object sender, EventArgs e)
		{
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				using(MySqlCommand mcmd = mcon.CreateCommand()) //This function gets data from exit of user
				{
					const string query = "SELECT `Forventet Afgang` FROM `adm_ansatte`.`personlig_info` WHERE `Medarbejder_ID` = @mid";
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
					MySqlDataReader mdr = mcmd.ExecuteReader();
					while(mdr.Read())
					{
						mfat = mdr.GetString("Forventet Afgang");
					}
				}
			}
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				using(MySqlCommand mcmd = mcon.CreateCommand()) //This function inserts data from exit of user
				{
					const string query = "UPDATE `adm_logs`.`medarbejdere` SET `Forventet Afgang` = @mfat, `Afgang` = @afg WHERE `Medarbejder_ID` = @mid AND `Dato` = @dt";
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@afg", DateTime.Now.ToString("T"));
					mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
					mcmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd"));
					mcmd.Parameters.AddWithValue("@mfat", mfat);
					MySqlDataReader mdr = mcmd.ExecuteReader();
				}
			}
			choice = 1;
			Close();
		}
		//
		//
		//
		void LogoutbtnClick(object sender, EventArgs e)
		{
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				using(MySqlCommand mcmd = mcon.CreateCommand()) //This function inserts data from exit of user
				{
					const string query = "UPDATE `adm_logs`.`stationlogs` SET `Udskrevet`=@uds WHERE `Medarbejder_ID`=@mid AND `Station`=@stn AND `Dato`=@dt"; //updates the users logout info
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@uds", DateTime.Now.ToString("T"));
					mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
					mcmd.Parameters.AddWithValue("@stn", station);
					mcmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd"));
					MySqlDataReader mdr = mcmd.ExecuteReader();
				}
			}
			choice = 2;
			Close();
		}
		//
		//
		//
		void CancelbtnClick(object sender, EventArgs e)
		{
			choice = 3;
			Close();
		}
		//
		//
		//
	}
}

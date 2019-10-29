/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 16-02-2017
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using FManager.Views;
using System;
using System.Net;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace FManager.Views
{
	/// <summary>
	/// Description of Pause.
	/// </summary>
	public partial class Pause : Form
	{
		//list of DB stuff
		MySqlConnection mcon;
		ConnectionStringSettings mcons = ConfigurationManager.ConnectionStrings["MySql"];
		//list of open stuff to use everywhere
		public static string value1
		{
			get {return Indmelding.hold;}
		}
		public static string value2
		{
			get {return Indmelding.logtime;}
		}
		private string jesus = Dns.GetHostEntry("LocalHost").HostName;
		//
		public Pause()
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
		//
		//
		//
		void PauseLoad(object sender, EventArgs e)
		{
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string read = "SELECT `Navn` FROM `adm_ansatte`.`personlig_info` WHERE Medarbejder_ID=@id";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = read;
				  mcmd.Parameters.AddWithValue("@id", LoginForm.MID);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					midholder.Text = mdr.GetString("Navn");
				}
			}
		}
		//
		//
		//
		void Button1Click(object sender, EventArgs e)
		{

			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string log = "INSERT INTO `adm_logs`.`pause` (`Medarbejder_ID`,`Pause Start`,`Pause Slut`,`Station`,`Dato`) VALUES(@mid,@pb,@pe,@sn,@dt)";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = log;
				  mcmd.Parameters.AddWithValue("@mid", value1);
				  mcmd.Parameters.AddWithValue("@pb", value2);
				  mcmd.Parameters.AddWithValue("@pe", DateTime.Now.ToString("HH:mm:ss"));
				  mcmd.Parameters.AddWithValue("@sn", jesus);
				  mcmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd"));
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			this.Close();
		}
	}
}

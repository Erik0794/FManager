/*
 * Created by SharpDevelop.
 * User: DemiGod
 * Date: 19-10-2016
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
//
//
//
namespace FManager
{
	/// <summary>
	/// Description of LoginForm.
	/// </summary>
	public partial class LoginForm : Form
	{
		//
		//
		//MySql Connector
		MySqlConnection mcon;
		//
		//
		//
		public static string MID;
		string L_navn;
		//
		//
		// disable once ConvertToAutoProperty
		public string GetName
		{
			get {return L_navn;}
			set {L_navn = value;}
		}
		//
		//
		//
		public LoginForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void LoginFormLoad(object sender, EventArgs e)
		{
			
		}		
		//
		//
		//
		private void connection() //Collected method to handle the authentication and connection to the database
		{
			try //ConnectionString handler for the MySql server
			{
			ConnectionStringSettings mconsettings = ConfigurationManager.ConnectionStrings["MySQL"]; //Collects info from app.config
			string mconcs = mconsettings.ConnectionString; //stored connection string
			mcon = new MySqlConnection(mconcs); //Connection manager 'mcon' creates a connection based on settings from mconcs
			mcon.Open();
			}
			
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "error");
			}
		}
		// 		
		//
		//
		private bool validate_login(string ID, string Password)
        {
            connection(); //opens the connection to the database
            
            MySqlCommand cmd = mcon.CreateCommand();
            	cmd.CommandText = "SELECT * FROM adm_konti.konti WHERE Medarbejder_ID=@user AND Password=@pass"; //selects the accounts from the database at
            	cmd.Parameters.AddWithValue("@user", ID);
            	cmd.Parameters.AddWithValue("@pass", Password);
            	cmd.Connection = mcon;
            MySqlDataReader login = cmd.ExecuteReader(); //Executes the selection query
            
            if(login.Read()){mcon.Close(); return true;} else {mcon.Close(); return false;}
        }
		//
		//
		//
		private void logwrite()
		{	
			string S_navn = Dns.GetHostEntry("localhost").HostName;
			string L_time = DateTime.Now.ToString("HH:mm:ss");
			string L_date = DateTime.Now.ToString("yyyy-MM-dd");
			//Second command to insert values into the logs db
			mcon.Open();
			const string query2 = "INSERT INTO adm_logs.stationlogs (`Medarbejder_ID`, `Indskrevet`, `Station`, `Dato`) VALUES(@mid, @ind, @stn, @dt)"; //insert this data into logs database
			MySqlCommand cmd2 = mcon.CreateCommand(); 			//command to be executed
				cmd2.CommandText = query2; 						//holds the commands information
				cmd2.Parameters.AddWithValue("@mid", MID); 		//add the user ID from the Variable MID (Medarbejder ID)
				cmd2.Parameters.AddWithValue("@ind", L_time); 	//add the name of the station
				cmd2.Parameters.AddWithValue("@stn", S_navn);	//add the actual time of login
				cmd2.Parameters.AddWithValue("@dt", L_date);	//add the actual date
			MySqlDataReader writer = cmd2.ExecuteReader();		//Write to log
		}
		//
		//
		//
		void LoginbtnClick(object sender, EventArgs e)
		{		
			//Load the string containing the password
			string Password = pwdbox.Text;
			MID = midbox.Text;
			//This part is supposed to check if the ID is a match for anyone in the server
			if(MID == ""){MessageBox.Show("Venligst Indtast ID"); return;}
			if(Password == ""){MessageBox.Show("Venligst Indtast Adgangskode"); return;}
			//			
			bool c = validate_login(MID, Password); //returns value to check if password/ID is correct
			//
			//Gets L_navn from database (hopefully)
			ConnectionStringSettings mconsettings = ConfigurationManager.ConnectionStrings["MySQL"]; //Collects info from app.config
			string mconcs = mconsettings.ConnectionString; //stored connection string			
			using(mcon = new MySqlConnection(mconcs))
			{
				mcon.Open();
				using(MySqlCommand mcmd = mcon.CreateCommand())
				{
					const string query = "SELECT `Navn` FROM `adm_ansatte`.`personlig_info` WHERE Medarbejder_ID = @mid";
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", MID);
					MySqlDataReader mdr = mcmd.ExecuteReader();
					while (mdr.Read())
					{
						L_navn = mdr.GetString("Navn");
					}
				}
			}
			//
			if (c) 
			{
				MessageBox.Show("Velkommen " + L_navn);
				this.Hide();
				MainForm main = new MainForm();
				main.Name = GetName;
				main.Show();	//This part is where the main window is opened and selected
				logwrite();
			}
			//
			else{MessageBox.Show("Forkert Login"); return;}
			//
		}
		//
		//
		//
		void Timer1Tick(object sender, EventArgs e)
		{
			var culture = new System.Globalization.CultureInfo("da-DK");
			var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
			label3.Text = day + " d. " + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
		}
		//
		//
		//
		void LoginFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		// 
		//
		//
	}
}

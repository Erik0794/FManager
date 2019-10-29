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
		private string L_navn;
		private string L_fmt;
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
            	cmd.CommandText = "Select * from adm_konti.konti where Medarbejder_ID=@user and Password=@pass"; //selects the accounts from the database at
            	cmd.Parameters.AddWithValue("@user", ID);
            	cmd.Parameters.AddWithValue("@pass", Password);
            	cmd.Connection = mcon;
            MySqlDataReader login = cmd.ExecuteReader(); //Executes the selection query
            
            if(login.Read()){mcon.Close(); return true;} else {mcon.Close(); return false;}
        }
		//
		//
		//
		private void dataread()
		{
			//First command to request the name of the person logging into the system
			const string query1 = "SELECT `Navn`,`Forventet Mødetid` FROM adm_ansatte.personlig_info WHERE Medarbejder_ID=@mid"; //Select command
			mcon.Open();										//open connection to db
			MID = midbox.Text;									//call the MID variable into the method
			MySqlCommand cmd1 = mcon.CreateCommand(); 			//Command to store the selection query
				cmd1.CommandText = query1;						//variable to store the command
				cmd1.Parameters.AddWithValue("@mid", MID); 		//Variable from ID textbox on form
				MySqlDataReader reader = cmd1.ExecuteReader(); 	//execute the datareader
				while(reader.Read())							//gets
				{
					L_navn = reader.GetString("Navn");
					L_fmt = reader.GetString("Forventet Mødetid");
				}
				reader.Close();
		}
		//
		//
		//
		private void logwrite()
		{	
			string L_time = DateTime.Now.ToString("HH:mm:ss");
			string L_date = DateTime.Now.ToString("yyyy-MM-dd");
			//Second command to insert values into the logs db
			const string query2 = "INSERT INTO adm_logs.medarbejdere (`Medarbejder_ID`, `Navn`, `Forventet Mødetid`, `Mødetid`, `Dato`) VALUES(@mid, @name, @fmt, @mt, @dt)"; //insert this data into logs database
			MySqlCommand cmd2 = mcon.CreateCommand(); 			//command to be executed
				cmd2.CommandText = query2; 						//holds the commands information
				cmd2.Parameters.AddWithValue("@mid", MID); 		//add the user ID from the Variable MID (Medarbejder ID)
				cmd2.Parameters.AddWithValue("@name", L_navn); 	//add the name of the user ID
				cmd2.Parameters.AddWithValue("@fmt", L_fmt);	//add the expected time of meeting
				cmd2.Parameters.AddWithValue("@mt", L_time);	//add the actual time of login
				cmd2.Parameters.AddWithValue("@dt", L_date);	//add the actual date
			MySqlDataReader writer = cmd2.ExecuteReader();		//Write to log
		}
		//
		//
		//
		private void callcheck()
		{
			mcon.Open();
			if(mcon != null)
			{
				MessageBox.Show("It works!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		} //Message if there is connection to the database
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
						
			bool c = validate_login(MID, Password); //returns value to check if password/ID is correct
			if (c) 
			{
				dataread(); //runs the dataread method to read the data from the workers database
				MessageBox.Show("Velkommen " + L_navn);
				logwrite();
			}
			else{MessageBox.Show("Forkert Login"); return;}
			//
			midbox.Clear();
			pwdbox.Clear();
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
			
		}
		// 
		//
		//
	}
}

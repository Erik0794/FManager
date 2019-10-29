/*
 * Created by SharpDevelop.
 * User: DemiGod
 * Date: 19-10-2016
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Net;
using FManager.Views;
using FManager.Menus;
using MySql.Data.MySqlClient;

namespace FManager
{
	/// <summary>
	/// this is the primary workspace, where all functions are utilized
	/// for better control of the back-end environment.
	/// 
	/// All users must see this screen.
	/// </summary>
	public partial class MainForm : Form
	{
		//
		//Database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//
		private string time;
		public static string database;
		public static string table;
		public static string station;
		//
		int reference;
		//
		//
		public MainForm()
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
		void MainFormLoad(object sender, EventArgs e)
		{
			/*
			 * When the main window loads, run the following code:
			 */
			mcs = mconcs.ConnectionString;
			textBox1.Text = DateTime.Now.ToString("HH:mm");
			time = DateTime.Now.ToString("HH:mm");
			showname.Text = Name;
			station = Dns.GetHostEntry("LocalHost").HostName;
			showrole.Text = station;
		}		
		//
		//
		//
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			/*
			 * When the window closes, reopen the login window:
			 */
			LoginForm login = new LoginForm();
			login.Show();
		}
		//
		//
		//
		void ClockTick(object sender, EventArgs e)
		{
			/*
			 * Timer for counting the time, clock control:
			 */
			time = DateTime.Now.ToString("HH:mm");
			textBox1.Text = time;
		}
		//
		//
		//		
		void Button2Click(object sender, EventArgs e) //Button2 = Exit
		{
			/*
			 * This menu controls which function writes what, if user presses "Leave" 
			 * Program writes to the the logs and states that the user has quit for the day, 
			 * if user presses "Switch" the program writes to another log that states the user switched station
			 */
			Hide();
			ExitForm menu = new ExitForm();
			menu.ShowDialog();
			int i = ExitForm.choice;
			switch(i) //evaluates the choice made in ExitForm
			{
				case 1:
				case 2:
					{
						Close();
						break;
					}
				case 3:
					{
						Show();
						break;
					}
			}
		}
		//
		//
		//
		void Button3Click(object sender, EventArgs e)
		{
			/*
			 * Opens the entry window where items are added to the database
			 */
			database = "adm_lager";
			table = "inventory_it";
			Hide();
			Indmelding ind1 = new Indmelding();
			ind1.Name = Name;
			ind1.ShowDialog();
			Show();
		}
		//
		//
		//
		void Button4Click(object sender, EventArgs e)
		{
			/*
			 * Same as above, but with medical equipment/items
			 */
			database = "adm_lager";
			table = "inventory_medico";
			Hide();
			Medico med = new Medico();
			med.ShowDialog();
			Show();
		}
		//
		//
		//
		void Button5Click(object sender, EventArgs e)
		{
			/*
			 * opens the testing menu, user selects test items from this menu
			 */
			database = "adm_test";
			Hide();
			SelectionMenu select = new SelectionMenu();
			select.ShowDialog();
			Show();
		}
		//
		//
		//
		bool IsAdmin()
		{
			/*
			 * This evaluates whether the user has access to the adminmenu or not
			 */
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "SELECT `Role` FROM `adm_konti`.`konti` WHERE `Medarbejder_ID` = @mid";
				using(MySqlCommand mcmd = mcon.CreateCommand())
				{
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
					MySqlDataReader mdr = mcmd.ExecuteReader();
					while(mdr.Read())
					{
						reference = mdr.GetUInt16("role");
					}
				}
			}
			int i = reference;
			switch(i)
			{
				case 9:
					return true;
				default:
					return false;
			}
		}
	}
}

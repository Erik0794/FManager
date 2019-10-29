/*
 * Created by SharpDevelop.
 * User: DemiGod
 * Date: 27-11-2016
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FManager.Views
{
	/// <summary>
	/// Description of Indmelding.
	/// </summary>
	public partial class Indmelding : Form
	{
		MySqlConnection mcon; //connection to database
		public static string hold; //Worker ID holder
		public static string logtime = DateTime.Now.ToString("HH:mm:ss"); //Time of log
		string serialmemory; //Holding a serialnumber for processing
		public static string barcode; //Holds the barcode information for printing id strips
		string dateinfo; //what year is this O_o?
		ConnectionStringSettings mcons = ConfigurationManager.ConnectionStrings["MySql"]; //Just the connectionstring		
		//
		//
		//
		public Indmelding()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			placemenu.SelectedIndexChanged += PlacemenuSelectedIndexChanged; //Assign a handler to the event
		}
		//
		//
		//
		void IndmeldingLoad(object sender, EventArgs e)
		{
			string mcs = mcons.ConnectionString; //string to contain connection string	
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					const string query = "SELECT * FROM `adm_lager`.`inventory_it`"; //command to get information from the database
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
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
		void nextbtnClick(object sender, EventArgs e)
		{
			if(
					orderidbox.Text == "" || 
					placemenu.Text == "==GRUPPE==" || 
					typemenu.Text == "==Type==" || 
					brandmenu.Text == "==Mærke==" ||
					modelbox.Text == "" ||
					serialnobox.Text == "" || 
					weightbox.Text == ""
			  )	
			{
				MessageBox.Show("Please check the entered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//^ Check if any boxes are empty and break if yes
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO adm_lager.inventory_it (`Medarbejder_ID`,`Bur_ID`,`Gruppe`,`Type`,`Mærke`, `Model`,`Serienummer`,`Vægt`) VALUES(@mid, @bid, @ge, @te, @me, @ml, @sn, @vt)";
				MySqlCommand mcmd = new MySqlCommand(query, mcon);
					mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
					mcmd.Parameters.AddWithValue("@bid", orderidbox.Text);
					mcmd.Parameters.AddWithValue("@ge", placemenu.Text);
					mcmd.Parameters.AddWithValue("@te", typemenu.Text);
					mcmd.Parameters.AddWithValue("@me", brandmenu.Text);
					mcmd.Parameters.AddWithValue("@ml", modelbox.Text);
					mcmd.Parameters.AddWithValue("@sn", serialnobox.Text);
					mcmd.Parameters.AddWithValue("@vt", weightbox.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
				
			}//Insert the data from the form into the database
			placemenu.Text = "==Gruppe=="; typemenu.Text = "==Type=="; brandmenu.Text = "==Mærke=="; //Reset the comboboxes
			serialmemory = serialnobox.Text; serialnobox.Clear(); weightbox.Clear(); //Reset all textboxes except Cage ID
			reload(); //Reload the datagridview
			getid(); //loads the unique id into the data
			sendzpl(); //prints barcode to Zebra
			
		}
		//
		//
		//
		void pausebtnClick(object sender, EventArgs e)
		{	
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string read = "SELECT `Medarbejder_ID` FROM `adm_ansatte`.`personlig_info` WHERE Navn=@name";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = read;
				  mcmd.Parameters.AddWithValue("@name", Name);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					hold = mdr.GetString("Medarbejder_ID");
				}
			}
			using(Pause p1 = new Pause())
			{
			  	  Hide();
				    if(p1.ShowDialog() == DialogResult.OK)
					{
						p1.ShowDialog();
					}
				  Show();
			}
		}
		//
		//
		//
		void deletebtnClick(object sender, EventArgs e)
		{
			string q = "DELETE FROM `adm_lager`.`inventory_it` WHERE `Serienummer`= @sn";
			string mcs = mcons.ConnectionString; //string to contain connection string	
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = q;
				mcmd.Parameters.AddWithValue("@sn", serialmemory);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			reload();
		}
		//
		//
		//		
		void exitbtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		//
		//
		//
		void resetbtnClick(object sender, EventArgs e)
		{
			orderidbox.Clear();
			placemenu.Text = "==Gruppe==";
			typemenu.Text = "==Type==";
			brandmenu.Text = "==Mærke==";
			serialnobox.Clear();
			weightbox.Clear();
		}
		//
		//
		//
		void medicobtnClick(object sender, EventArgs e)
		{
			Hide();
			using(Medico med = new Medico())
				med.ShowDialog();
			Show();
		}
		//
		//
		//
		void Button1Click(object sender, EventArgs e)
		{
			using(Deleteform del = new Deleteform())
			{
			    if(del.ShowDialog() == DialogResult.OK)
				{
					del.ShowDialog();
				}
			}
			reload();
		}
		//
		//
		//
		void PlacemenuSelectedIndexChanged(object sender, EventArgs e)
		{
			loadtypeinfo();
		}
		//
		//
		//	Methods for usage
		void loadtypeinfo()
		{
			/*
			 * This method is made to use the placemenu combobox to fill typemenu combobox with data based on what placemenu.Text is.
			 * That way it is possible to constantly update the combobox based on what you select from it.
			 * */
			string mcs = mcons.ConnectionString; //string to contain connection string
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet ds = new DataSet()) //DataSet to contain the information gotten from the database
				{
					string query = "SELECT " + placemenu.Text + " FROM `adm_lager`.`itemtypes`"; //command to get information from the text in placemenu(combobox)
					DataTable dt = new DataTable(); //table to hold the rows from the database
					ds.Tables.Add(dt); //add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					typemenu.Items.Clear();	//remove existing data to avoid duplicates
					foreach(DataTable table in ds.Tables)											//this does table
					{
						foreach(DataRow row in table.Rows)											//this does rows
						{
							foreach(DataColumn column in dt.Columns)								//this dows columns
							{
								if(row[column] == (null) || row[column].ToString() == "")			//Clears any null values from the list of items
								{
									continue;
								}
								typemenu.Items.Add(row[column]);									//print selected column with selected rows
							}
						}
					}
				}
			}
		}
		//
		//
		//
		void reload()
		{
			string mcs = mcons.ConnectionString; //string to contain connection string	
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					const string query = "SELECT * FROM `adm_lager`.`inventory_it`"; //command to get information from the database
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView1.DataSource = dt;
				}
			}			
		}
		void getid()
		{
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				string q = "SELECT `UNIQUEID` FROM adm_lager.inventory_it WHERE `Serienummer` = @sn";
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = q;
				mcmd.Parameters.AddWithValue("@sn", serialmemory);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					barcode = "000000"+mdr.GetUInt16("UNIQUEID");
				}
				
			} // Get UNIQUEID
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				const string q = "SELECT `Indtastning` FROM `adm_lager`.`inventory_it` ORDER BY `Indtastning` DESC LIMIT 1";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = q;
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read()){dateinfo = mdr.GetDateTime("Indtastning").ToString("yyyy-MM-dd HH:mm:ss");}
			}
			reloadboxes();
		}
		//
		//
		//
		void reloadboxes()
		{
			string mcs = mcons.ConnectionString;			
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string q = "SELECT `Bur_ID`,`Gruppe`,`Type`,`Mærke`,`Serienummer`,`Vægt` FROM `adm_lager`.`inventory_it` WHERE Indtastning = @dt";
				var mcmd = mcon.CreateCommand();
				mcmd.CommandText = q;
				mcmd.Parameters.AddWithValue("@dt", dateinfo);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					orderidbox.Text = mdr.GetUInt16("Bur_ID").ToString();
					placemenu.Text = mdr.GetString("Gruppe");
					typemenu.Text = mdr.GetString("Type");
					brandmenu.Text = mdr.GetString("Mærke");
					serialnobox.Text = mdr.GetString("Serienummer");
					weightbox.Text = mdr.GetString("Vægt");
				}
			}
		}
		//
		//
		//
		void sendzpl()
		{
			// Printer IP Address and communication port
			const string ipAddress = "192.168.2.216";
			const int port = 9100;
 
			// ZPL Command(s)
			string ZPLString = "^XA^FO50,5^B3N,N,50,N,N^FD"+barcode+"^FS^FO50,70^ADN,28,20^FD"+barcode+"^FS^XZ";
 
			try
			{
    			// Open connection
    			System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
    			client.Connect(ipAddress, port);
 
    			// Write ZPL String to connection
    			System.IO.StreamWriter writer = new System.IO.StreamWriter(client.GetStream());
    			writer.Write(ZPLString);
    			writer.Flush();
 
    			// Close Connection
    			writer.Close();
    			client.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");// Catch Exception
			}			
		}
		//
		//
		//
  	}
}
	
	
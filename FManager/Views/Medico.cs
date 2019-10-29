/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 17-02-2017
 * Time: 08:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FManager.Views
{
	/// <summary>
	/// Description of Medico.
	/// </summary>
	public partial class Medico : Form
	{
		public Medico()
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
		//Database Stuff
		MySqlConnection mcon;
		ConnectionStringSettings mcons = ConfigurationManager.ConnectionStrings["MySql"];
		//
		
		//Public stuff
		//
		
		//private stuff
		string mcs;
		string serialmemory;
		string barcode;
		//
		//
		//
		void MedicoLoad(object sender, EventArgs e)
		{
			mcs = mcons.ConnectionString; //string to contain connection string	
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					const string query = "SELECT * FROM `adm_lager`.`inventory_medico`"; //command to get information from the database
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
		void NextbtnClick(object sender, EventArgs e)
		{
			if(textBox1.Text == "" || groupBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
			{
				MessageBox.Show("Please check the entered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO adm_lager.inventory_medico (`Medarbejder_ID`,`Bur_ID`,`Type`,`Klassifikation`,`Mærke`,`Serienummer`) VALUES(@mid, @bid, @te, @kn, @me, @sn)";
				MySqlCommand mcmd = new MySqlCommand(query, mcon);
					mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
				    mcmd.Parameters.AddWithValue("@bid", textBox1.Text);
					mcmd.Parameters.AddWithValue("@te", groupBox1.Text);
					mcmd.Parameters.AddWithValue("@kn", textBox4.Text);
					mcmd.Parameters.AddWithValue("@me", textBox2.Text);
					mcmd.Parameters.AddWithValue("@sn", textBox3.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
				
			}//Insert the data from the form into the database
			textBox2.Clear(); serialmemory = textBox3.Text; textBox3.Clear();	textBox4.Clear(); comboBox1.SelectedText=""; //clear all textboxes except Cage ID
			reload(); //Reload the datagridview
			getid(); //loads the unique id into the data
			sendzpl(); //prints barcode to Zebra
		}
		//
		//
		//
		void ClearbtnClick(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			comboBox1.ResetText();
		}
		//
		//
		//
		void DeletebtnClick(object sender, EventArgs e)
		{
			string q = "DELETE FROM `adm_lager`.`inventory_medico` WHERE `Serienummer`= @sn";
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = q;
				mcmd.Parameters.AddWithValue("@sn", serialmemory);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
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
		void PausebtnClick(object sender, EventArgs e)
		{
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
		void reload()
		{
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
				{
					const string query = "SELECT * FROM `adm_lager`.`inventory_medico`"; //command to get information from the database
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
		void getid()
		{
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
	}
}

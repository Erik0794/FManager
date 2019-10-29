/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 04-07-2017
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace FAdmin.Administration
{
	/// <summary>
	/// Description of EmployeeEditForm.
	/// </summary>
	public partial class EmployeeEditForm : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//
		//Variables
		string itcertificate;
		string truckcertificate;
		int empid;
		//
		public EmployeeEditForm()
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
		void EmployeeEditFormLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet ds = new DataSet()) 															//DataSet to contain the information gotten from the database
				{
					string query = "SELECT `Medarbejder_ID` FROM `adm_ansatte`.`personlig_info`"; 	//command to get information from the text in placemenu(combobox)
					DataTable dt = new DataTable(); 														//table to hold the rows from the database
					ds.Tables.Add(dt); 																		//add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); 												//command to execute the mysql adapter
					  mcmd.Connection = mcon; 																//specify which connection to use
					  mcmd.CommandText = query;																//specify the command text to use
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);										//execute the adapter
					  mda.Fill(dt);																			//and fill the tables
					idbox.Items.Clear();																	//remove existing data to avoid duplicates
					foreach(DataTable table in ds.Tables)													//this does table
					{
						foreach(DataRow row in table.Rows)													//this does rows
						{
							foreach(DataColumn column in dt.Columns)										//this dows columns
							{
								if(row[column] == (null) || row[column].ToString() == "")					//Clears any null values from the list of items
								{
									continue;
								}
								idbox.Items.Add(row[column]);												//print selected column with selected rows
							}
						}
					}
				}
			}
			idbox.SelectedIndex = 0;
			
		}
		//
		//
		//
		void UpdatebtnClick(object sender, EventArgs e)
		{
			if(accesslevel.SelectedIndex == -1)
			{
				MessageBox.Show("Please Choose Access level!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			foreach (Control c in this.Controls)
			{
				if (c is TextBox) 
				{
					TextBox textBox = c as TextBox;
					if (textBox.Text == string.Empty) 
					{
						MessageBox.Show("Please fill out all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;				
					}
				}
			}
			writetodb();
			Close();
		}
		//
		//
		//
		void writetodb()
		{
			checkbuttons();
			//Personal Info
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "UPDATE `adm_ansatte`.`personlig_info` SET `Navn` = @name, `Adresse` = @address, `Postnummer` = @zipcode, `By` = @city, `Telefonnummer` = @phone, `Mobilnummer` = @mobile, `Email` = @email, `Straffeattest` = @crimrec, `Kørekort` = @licence, `IT_Certifikater` = @itcertif, `Truck_Certifikat` = @tkcertif WHERE `Medarbejder_ID` = @mid";
				MySqlCommand mcmd = mcon.CreateCommand();
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", empid);
					mcmd.Parameters.AddWithValue("@name", namebox.Text);
					mcmd.Parameters.AddWithValue("@address", addressbox.Text);
					mcmd.Parameters.AddWithValue("@zipcode", zipcodebox.Text);
					mcmd.Parameters.AddWithValue("@city", citybox.Text);
					mcmd.Parameters.AddWithValue("@phone", phonenobox.Text);
					mcmd.Parameters.AddWithValue("@mobile", mobilenobox.Text);
					mcmd.Parameters.AddWithValue("@email", emailbox.Text);
					mcmd.Parameters.AddWithValue("@crimrec", crimrecbox.Text);
					mcmd.Parameters.AddWithValue("@licence", licencetype.Text);
					mcmd.Parameters.AddWithValue("@itcertif", itcertificate);
					mcmd.Parameters.AddWithValue("@tkcertif", truckcertificate);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}
			//Bank account info
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "UPDATE `adm_ansatte`.`bankinfo` SET `Navn` = @name, `Bank` = @bname, `Reg_Nr` = @regno, `Konto_Nr` = @accno WHERE `Medarbejder_ID` = @mid";
				MySqlCommand mcmd = mcon.CreateCommand();
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", empid);
					mcmd.Parameters.AddWithValue("@name", namebox.Text);
					mcmd.Parameters.AddWithValue("@regno", regnobox.Text);
					mcmd.Parameters.AddWithValue("@accno", accountnobox.Text);
					mcmd.Parameters.AddWithValue("@bname", banknamebox.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}			
			//Employee account info
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "UPDATE `adm_konti`.`konti` SET `Password` = @pass, `Role` = @alvl WHERE `Medarbejder_ID` = @mid";
				MySqlCommand mcmd = mcon.CreateCommand(); 
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", empid);
					mcmd.Parameters.AddWithValue("@pass", passwordbox.Text);
					mcmd.Parameters.AddWithValue("@alvl", accesslevel.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}
			//in case of emergency contact info
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "UPDATE `adm_ansatte`.`ice` SET `Navn` = @name, `Telefonnummer` = @phone WHERE `Medarbejder_ID` = @mid";
				MySqlCommand mcmd = mcon.CreateCommand(); 
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", empid);
					mcmd.Parameters.AddWithValue("@name", icenamebox.Text);
					mcmd.Parameters.AddWithValue("@phone", icephonebox.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}
		}
		//
		//
		//
		void checkbuttons()
		{
			bool it = itcertified.Checked;
			bool truck = truckcertified.Checked;
			itcertificate = it ? "Yes" : "No";
			truckcertificate = truck ? "Yes" : "No";
		}
		//
		//
		//
		void startup()
		{
			using(mcon = new MySqlConnection(mcs))
			{
				string query = "INSERT INTO `adm_ansatte`.`personlig_info` (Status) VALUES(@status)";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@status", "Ny");
				MySqlDataReader mdr = mcmd.ExecuteReader();
			} //Creates new raw entry
			using(mcon = new MySqlConnection(mcs))
			{
				string query = "SELECT `Medarbejder_ID` FROM `adm_ansatte`.`personlig_info` WHERE `Status` = 'Ny'";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
					mcmd.CommandText = query;
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					empid = mdr.GetUInt16("Medarbejder_ID");
					idbox.Text = empid.ToString(); 
				}
			}
		}
		//
		//
		//
		void EmployeeFormShown(object sender, EventArgs e)
		{
			startup();
			accesslevel.SelectedIndex = 1;
		}
		//
		//
		//
		void ShowpassCheckedChanged(object sender, EventArgs e)
		{
			if(showpass.Checked)
				passwordbox.PasswordChar = default(char);
			else
				passwordbox.PasswordChar = '*';
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

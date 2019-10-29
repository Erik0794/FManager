/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 12-03-2017
 * Time: 22:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FAdmin.Clients
{
	/// <summary>
	/// Description of AddressEditor.
	/// </summary>
	public partial class AddressEditor : Form
	{
		//
		//database stuff
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"]; //Just the connection string
		MySqlConnection mcon;
		string mcs;
		//
		string cvr;
		//		
		public AddressEditor()
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
		void AddressEditorLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
			using(DataSet dst = new DataSet()) //DataSet to contain the information gotten from the database
			{
				const string query = "SELECT * FROM `adm_klientind`.`adresser`"; //command to get information from the database
				DataTable dt = new DataTable(); //table to hold the rows from the database
				dst.Tables.Add(dt); //add table to dataset
				MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
				  mcmd.Connection = mcon; //specify which connection to use
				  mcmd.CommandText = query;	//specify the command text to use
				MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
				  mda.Fill(dt);	//and fill the tables
				  dataGridView1.DataSource = dt;
			}				
		}
		//
		//
		//
		void GetinfobtnClick(object sender, EventArgs e)
		{
			if(addressidbox.Text == "")
				{MessageBox.Show("Please enter Address ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;}
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "SELECT * FROM `adm_klientind`.`adresser` WHERE `AdresseID` = @aid";
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				mcmd.Parameters.AddWithValue("@aid", addressidbox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					cvr = mdr.GetString("CVR");
					addressbox.Text = mdr.GetString("Adresse");
					zipcodebox.Text = mdr.GetString("Postnummer");
					citynamebox.Text = mdr.GetString("By");
					contactnamebox.Text = mdr.GetString("Kontaktperson");
					phonenumberbox.Text = mdr.GetString("Telefonnummer");
					directnumberbox.Text = mdr.GetString("Direkte");
					emailbox.Text = mdr.GetString("Email");
					availablebox.Text = mdr.GetString("Træffetid");
				}
			}
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "SELECT `Firmanavn` FROM `adm_klientind`.`slutbrugere` WHERE `CVR` = @cvr";
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				mcmd.Parameters.AddWithValue("@cvr", cvr);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					companyname.Text = mdr.GetString("Firmanavn");
				}
			}	
		}
		//
		//
		//
		void UpdatebtnClick(object sender, EventArgs e)
		{
			//
			if
			(
				addressidbox.Text == "" || 
				addressbox.Text == "" || 
				zipcodebox.Text == "" || 
				citynamebox.Text == "" || 
				contactnamebox.Text == "" || 
				phonenumberbox.Text == "" ||
				directnumberbox.Text == "" || 
				emailbox.Text == "" ||
				availablebox.Text == ""
			)
			{MessageBox.Show("Please check entered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;}
			//
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "UPDATE `adm_klientind`.`adresser` SET `Adresse`=@adr, `Postnummer`=@pnr, `By`=@byn, `Kontaktperson`=@ktp, `Telefonnummer`=@tlf, `Direkte`=@dnr, `Email`=@eml, `Træffetid`=@ttd WHERE `AdresseID`=@aid";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@aid", addressidbox.Text);
				  mcmd.Parameters.AddWithValue("@adr", addressbox.Text);
				  mcmd.Parameters.AddWithValue("@pnr", zipcodebox.Text);
				  mcmd.Parameters.AddWithValue("@byn", citynamebox.Text);
				  mcmd.Parameters.AddWithValue("@ktp", contactnamebox.Text);
				  mcmd.Parameters.AddWithValue("@tlf", phonenumberbox.Text);
				  mcmd.Parameters.AddWithValue("@dnr", directnumberbox.Text);
				  mcmd.Parameters.AddWithValue("@eml", emailbox.Text);
				  mcmd.Parameters.AddWithValue("@ttd", availablebox.Text); 
				MySqlDataReader mdr = mcmd.ExecuteReader();			
			}
			clearboxes();
		}
		//
		//
		//
		void DeletebtnClick(object sender, EventArgs e)
		{
			if
			(
				addressidbox.Text == "" || 
				addressbox.Text == "" || 
				zipcodebox.Text == "" || 
				citynamebox.Text == "" || 
				contactnamebox.Text == "" || 
				phonenumberbox.Text == "" ||
				directnumberbox.Text == "" || 
				emailbox.Text == "" ||
				availablebox.Text == ""
			)
			{MessageBox.Show("Please check entered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;}			
			using(mcon = new MySqlConnection(mcs))
			{			
				mcon.Open();
				const string query = "DELETE FROM `adm_klientind`.`adresser` WHERE  `AdresseID`=@aid AND `Adresse`=@adr AND `Postnummer`=@pnr AND `By`=@byn AND `Kontaktperson`=@ktp AND `Telefonnummer`=@tlf AND `Direkte`=@dnr AND `Email`=@eml AND `Træffetid`=@ttd";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@aid", addressidbox.Text);
				  mcmd.Parameters.AddWithValue("@adr", addressbox.Text);
				  mcmd.Parameters.AddWithValue("@pnr", zipcodebox.Text);
				  mcmd.Parameters.AddWithValue("@byn", citynamebox.Text);
				  mcmd.Parameters.AddWithValue("@ktp", contactnamebox.Text);
				  mcmd.Parameters.AddWithValue("@tlf", phonenumberbox.Text);
				  mcmd.Parameters.AddWithValue("@dnr", directnumberbox.Text);
				  mcmd.Parameters.AddWithValue("@eml", emailbox.Text);
				  mcmd.Parameters.AddWithValue("@ttd", availablebox.Text); 
				MySqlDataReader mdr = mcmd.ExecuteReader();				
			}
			clearboxes();
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
		void clearboxes()
		{
    	 	Action<Control.ControlCollection> func = null;

     		func = (controls) =>
         	{
             	foreach (Control control in controls)
                 	if (control is TextBox)
                     	(control as TextBox).Clear();
                 	else
                     	func(control.Controls);
         	};
     		func(Controls);					
		}		
	}
}

/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 30-03-2017
 * Time: 15:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FAdmin.Clients
{
	/// <summary>
	/// Description of SBAdd.
	/// </summary>
	public partial class SBAdd : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//
		//
		string id;
		//
		public SBAdd()
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
		void SBAddLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
		}
		//
		//
		//
		void CreatebtnClick(object sender, EventArgs e)
		{
			//
			 if
			  (
			  	companynamebox.Text == "" || 
			  	cvrbox.Text == "" || 
			  	contactnamebox.Text == "" || 
			  	addressbox.Text == "" || 
			  	zipcodebox.Text == "" || 
			  	citynamebox.Text == "" || 
			  	phonenumberbox.Text == "" || 
			  	directnumberbox.Text == "" || 
			  	emailbox.Text == ""
			  )	
			{MessageBox.Show("Please check the entered information!", "Error"); return;}
			//
			const string query = "INSERT INTO adm_klientind.slutbrugere (`Firmanavn`, `CVR`,`Kontaktperson`,`Adresse`,`Postnummer`,`By`,`Telefon`, `Direkte`, `Email`) VALUES(@fn,@cvr,@kp,@ae,@pr,@by,@tn,@de,@el)";
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@fn", companynamebox.Text);
				  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
				  mcmd.Parameters.AddWithValue("@kp", contactnamebox.Text);
				  mcmd.Parameters.AddWithValue("@ae", addressbox.Text);
				  mcmd.Parameters.AddWithValue("@pr", zipcodebox.Text);
				  mcmd.Parameters.AddWithValue("@by", citynamebox.Text);
				  mcmd.Parameters.AddWithValue("@tn", phonenumberbox.Text);
				  mcmd.Parameters.AddWithValue("@de", directnumberbox.Text);
				  mcmd.Parameters.AddWithValue("@el", emailbox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader(); //Write to client database
			}
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string getid = "SELECT `ID` FROM `adm_klientind`.`slutbrugere` WHERE `CVR` = @cvr";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = getid;
				  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					id = mdr.GetString("ID");
				}
			}			
			using(mcon = new MySqlConnection(mcs))
			{
				const string query2 = "INSERT INTO adm_klientind.adresser (`ID`,`CVR`,`Adresse`,`Postnummer`,`By`,`Kontaktperson`,`Telefonnummer`,`Direkte`,`Email`,`Træffetid`) VALUES(@id,@cvr,@ae,@pr,@by,@kp,@tn,@de,@el,@tt)";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query2;
				  mcmd.Parameters.AddWithValue("@id", id);
				  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
				  mcmd.Parameters.AddWithValue("@ae", addressbox.Text);
				  mcmd.Parameters.AddWithValue("@pr", zipcodebox.Text);
				  mcmd.Parameters.AddWithValue("@by", citynamebox.Text);
				  mcmd.Parameters.AddWithValue("@kp", contactnamebox.Text);
				  mcmd.Parameters.AddWithValue("@tn", phonenumberbox.Text);
				  mcmd.Parameters.AddWithValue("@de", directnumberbox.Text);
				  mcmd.Parameters.AddWithValue("@el", emailbox.Text);
				  mcmd.Parameters.AddWithValue("@tt", "Hovedkontor (før kl. 16)");
				MySqlDataReader mdr = mcmd.ExecuteReader(); //Write to address table
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

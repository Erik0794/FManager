/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 11-03-2017
 * Time: 16:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FAdmin.Clients
{
	/// <summary>
	/// Description of AddressAdd.
	/// </summary>
	public partial class AddressAdd : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"]; //Just the connectionstring
		string mcs;
		//
		//
		public AddressAdd()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AddressAddLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
		}
		//
		//
		//
		void AddbtnClick(object sender, EventArgs e)
		{
			//
			if
			(
				cvrbox.Text == "" || 
				addressbox.Text == "" || 
				zipcodebox.Text == "" || 
				citybox.Text == "" || 
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
				const string query = "INSERT INTO `adm_klientind`.`adresser` (`CVR`,`Adresse`,`Postnummer`,`By`,`Kontaktperson`,`Telefonnummer`,`Direkte`,`Email`,`Træffetid`) VALUES(@cvr,@adr,@pnr,@byn,@ktp,@tlf,@dnr,@eml,@ttd)";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
				  mcmd.Parameters.AddWithValue("@adr", addressbox.Text);
				  mcmd.Parameters.AddWithValue("@pnr", zipcodebox.Text);
				  mcmd.Parameters.AddWithValue("@byn", citybox.Text);
				  mcmd.Parameters.AddWithValue("@ktp", contactnamebox.Text);
				  mcmd.Parameters.AddWithValue("@tlf", phonenumberbox.Text);
				  mcmd.Parameters.AddWithValue("@dnr", directnumberbox.Text);
				  mcmd.Parameters.AddWithValue("@eml", emailbox.Text);
				  mcmd.Parameters.AddWithValue("@ttd", availablebox.Text); 
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			//
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

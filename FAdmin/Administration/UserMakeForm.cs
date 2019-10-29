/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 07-04-2017
 * Time: 16:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FAdmin.Administration
{
	/// <summary>
	/// Description of UserMakeForm.
	/// </summary>
	public partial class UserMakeForm : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		//
		//
		//
		public UserMakeForm()
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
		void CreatebtnClick(object sender, EventArgs e)
		{
			string query = "INSERT INTO `adm_klientud`.`kundeinfo` (`Navn`, `CVR`, `Kontaktperson`, `Adresse`, `Postnummer`, `By`, `Telefonnummer`, `Direkte`, `Email`) VALUES(@nme,@cvr,@ktp,@adr,@pnr,@byn,@tlf,@drt,@eml)";
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@nme", customernamebox.Text);
				  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
				  mcmd.Parameters.AddWithValue("@ktp", contactnamebox.Text);
				  mcmd.Parameters.AddWithValue("@adr", addressbox.Text);
				  mcmd.Parameters.AddWithValue("@pnr", zipcodebox.Text);
				  mcmd.Parameters.AddWithValue("@byn", citynamebox.Text);
				  mcmd.Parameters.AddWithValue("@tlf", phonenumberbox.Text);
				  mcmd.Parameters.AddWithValue("@drt", directnumberbox.Text);
				  mcmd.Parameters.AddWithValue("@eml", emailbox.Text);
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
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked)
			{
				label1.Text = "Firmanavn";
				label2.Visible = true;
				cvrbox.Visible = true;
			}
			else
			{
				label1.Text = "Kundenavn";
				label2.Visible = false;
				cvrbox.Visible = false;
			}
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
		void UserMakeFormLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
		}			
	}
}

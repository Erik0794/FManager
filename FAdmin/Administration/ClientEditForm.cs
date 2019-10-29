/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 07-04-2017
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace FAdmin.Administration
{
	/// <summary>
	/// Description of UserEditForm.
	/// </summary>
	public partial class ClientEditForm : Form
	{
		//
		//database stuff
		MySqlConnection mcon;
		ConnectionStringSettings mconcs = ConfigurationManager.ConnectionStrings["MySQL"];
		string mcs;
		string query;
		//
		//
		//
		public ClientEditForm()
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
		void UserEditFormLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
		}
		//
		//
		//
		void GetinfobtnClick(object sender, EventArgs e)
		{
			using(mcon = new MySqlConnection(mcs))
			{
				using(DataSet dst = new DataSet())
				{
					mcon.Open();
					query = "SELECT * FROM `adm_klientud`.`kundeinfo` WHERE `Kundenummer` = @knr";
					DataTable dt = new DataTable(); //table to hold the rows from the database
					dst.Tables.Add(dt); //add table to dataset
					MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
					  mcmd.Connection = mcon; //specify which connection to use
					  mcmd.CommandText = query;	//specify the command text to use
					  mcmd.Parameters.AddWithValue("@knr", customernobox.Text);
					  mcmd.CommandType = CommandType.Text;	//no idea why
					MySqlDataAdapter mda = new MySqlDataAdapter(mcmd);//execute the adapter
					  mda.Fill(dt);	//and fill the tables
					  dataGridView1.DataSource = dt;					  
				}
				using(MySqlCommand mcmd = mcon.CreateCommand())
				{
					query = "SELECT * FROM `adm_klientud`.`kundeinfo` WHERE `Kundenummer` = @knr";
				  	  mcmd.CommandText = query;
				  	  mcmd.Parameters.AddWithValue("@knr", customernobox.Text);
				  	  //
				  	  mcmd.Parameters.AddWithValue("@cvr", cvrbox.Text);
				  	  mcmd.Parameters.AddWithValue("@ktp", contactnamebox.Text);
				  	  mcmd.Parameters.AddWithValue("@adr", addressbox.Text);
				  	  mcmd.Parameters.AddWithValue("@pnr", zipcodebox.Text);
				  	  mcmd.Parameters.AddWithValue("@byn", citynamebox.Text);
				  	  mcmd.Parameters.AddWithValue("@tlf", phonenumberbox.Text);
				  	  mcmd.Parameters.AddWithValue("@drt", directnumberbox.Text);
				  	  mcmd.Parameters.AddWithValue("@eml", emailbox.Text);
					  //				  	  
					MySqlDataReader mdr = mcmd.ExecuteReader();
					while(mdr.Read())
					{
						customernamebox.Text = mdr.GetString("Navn");
						cvrbox.Text = mdr.GetString("CVR");
						contactnamebox.Text = mdr.GetString("Kontaktperson");
						addressbox.Text = mdr.GetString("Adresse");
						zipcodebox.Text = mdr.GetString("Postnummer");
						citynamebox.Text = mdr.GetString("By");
						phonenumberbox.Text = mdr.GetString("Telefonnummer");
						directnumberbox.Text = mdr.GetString("Direkte");
						emailbox.Text = mdr.GetString("Email");
					}
				}
			}
		}
		//
		//
		//
		void CompanyCheckedChanged(object sender, EventArgs e)
		{
			if(company.Checked)
			{
				label2.Text = "Firmanavn";
				query = "SELECT * FROM `adm_klientud`.`kundeinfo` WHERE `Kundenummer` = @knr AND `Firma` = true";
				cvrbox.Visible = true;
				label3.Visible = true;
			}
			else
			{
				label2.Text = "Kundenavn";
				query = "SELECT * FROM `adm_klientud`.`kundeinfo` WHERE `Kundenummer` = @knr AND `Firma` = false";
				cvrbox.Visible = false;
				label3.Visible = false;
			}
		}
		//
		//
		//
		void DeletebtnClick(object sender, EventArgs e)
		{
			query = "DELETE FROM `adm_klientud`.`kundeinfo` WHERE `Kundenummer` = @knr";
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@knr", customernobox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			clearboxes();
		}
		//
		//
		//
		void EditinfobtnClick(object sender, EventArgs e)
		{
			query = "UPDATE `adm_klientud`.`kundeinfo` SET `Navn` = @nme, `CVR` = @cvr, `Kontaktperson` = @ktp, `Adresse` = @adr, `Postnummer` = @pnr, `By` = @byn, `Telefonnummer` = @tlf, `Direkte` = @drt, `Email` = @eml WHERE `Kundenummer` = @knr";
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
				  mcmd.Parameters.AddWithValue("@knr", customernobox.Text);
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
		void update()
		{
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				MySqlCommand mcmd = new MySqlCommand(); //command to execute the mysql adapter
				  mcmd.Connection = mcon; //specify which connection to use
				  mcmd.CommandText = query;	//specify the command text to use
				  mcmd.CommandType = CommandType.Text;	//no idea why
				MySqlDataReader mdr = mcmd.ExecuteReader();
				while(mdr.Read())
				{
					customernamebox.Text = mdr.GetString("Navn");
					cvrbox.Text = mdr.GetString("CVR");
					contactnamebox.Text = mdr.GetString("Kontaktperson");
					addressbox.Text = mdr.GetString("Adresse");
					zipcodebox.Text = mdr.GetString("Postnummer");
					citynamebox.Text = mdr.GetString("By");
					phonenumberbox.Text = mdr.GetString("Telefonnummer");
					directnumberbox.Text = mdr.GetString("Direkte");
					emailbox.Text = mdr.GetString("Email");
				}
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
	}
}

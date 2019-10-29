/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 19-03-2017
 * Time: 11:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace FAdmin.Administration
{
	/// <summary>
	/// Description of EmployeeCreateForm.
	/// </summary>
	public partial class EmployeeCreateForm : Form
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
		string empstatus;
		int status;
		int empid;
		//
		public EmployeeCreateForm()
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
		void EmployeeFormLoad(object sender, EventArgs e)
		{
			mcs = mconcs.ConnectionString;
			status = 0;
		}
		//
		//
		//		
		void AcceptbtnClick(object sender, EventArgs e)
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
			employeestatus();
			//Personal Info
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "UPDATE `adm_ansatte`.`personlig_info` SET `Navn` = @name, `Adresse` = @address, `Postnummer` = @zipcode, `By` = @city, `Telefonnummer` = @phone, `Mobilnummer` = @mobile, `CPR-Nummer` = @cprno, `Email` = @email, `Straffeattest` = @crimrec, `Kørekort` = @licence, `IT_Certifikater` = @itcertif, `Truck_Certifikat` = @tkcertif, `Status` = @status, `Noter` = @note WHERE `Medarbejder_ID` = @mid";
				MySqlCommand mcmd = mcon.CreateCommand();
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", empid);
					mcmd.Parameters.AddWithValue("@name", namebox.Text);
					mcmd.Parameters.AddWithValue("@address", addressbox.Text);
					mcmd.Parameters.AddWithValue("@zipcode", zipcodebox.Text);
					mcmd.Parameters.AddWithValue("@city", citybox.Text);
					mcmd.Parameters.AddWithValue("@phone", phonenobox.Text);
					mcmd.Parameters.AddWithValue("@mobile", mobilenobox.Text);
					mcmd.Parameters.AddWithValue("@cprno", cprnobox.Text);
					mcmd.Parameters.AddWithValue("@email", emailbox.Text);
					mcmd.Parameters.AddWithValue("@crimrec", crimrecbox.Text);
					mcmd.Parameters.AddWithValue("@licence", licencetype.Text);
					mcmd.Parameters.AddWithValue("@itcertif", itcertificate);
					mcmd.Parameters.AddWithValue("@tkcertif", truckcertificate);
					mcmd.Parameters.AddWithValue("@status", empstatus);
					mcmd.Parameters.AddWithValue("@note", notebox.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}
			//Bank account info
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO `adm_ansatte`.`bankinfo` (`Medarbejder_ID`, `Navn`, `Bank`, `Reg_Nr`, `Konto_Nr`, `Lønsats`, `Løntype`) VALUES(@mid,@name,@regno,@accno,@bname,@prate,@ptype)";
				MySqlCommand mcmd = mcon.CreateCommand();
					mcmd.CommandText = query;
					mcmd.Parameters.AddWithValue("@mid", empid);
					mcmd.Parameters.AddWithValue("@name", namebox.Text);
					mcmd.Parameters.AddWithValue("@regno", regnobox.Text);
					mcmd.Parameters.AddWithValue("@accno", accountnobox.Text);
					mcmd.Parameters.AddWithValue("@bname", banknamebox.Text);
					mcmd.Parameters.AddWithValue("@prate", payratebox.Text);
					mcmd.Parameters.AddWithValue("@ptype", paytype.Text);
				MySqlDataReader reader = mcmd.ExecuteReader();
			}			
			//Employee account info
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO `adm_konti`.`konti` (`Medarbejder_ID`, `Password`, `Role`) VALUES(@mid,@pass,@alvl)";
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
				const string query = "INSERT INTO `adm_ansatte`.`ice` (`Medarbejder_ID`, `Navn`,`Telefonnummer`) VALUES(@mid,@name,@phone)";
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
		void employeestatus()
		{
			status = 0;
			//
			if(fulltime.Checked)
				status = 1;
			if(parttime.Checked)
				status = 2;
			if(flextime.Checked)
				status = 3;
			if(prunit.Checked)
				status = 4;
			if(apprentice.Checked)
				status = 5;
			if(intern.Checked)
				status = 6;
			if(hourly.Checked)
				status = 7;
			if(tryout.Checked)
				status = 8;
			//
			int i = status;
			switch(i)
			{
				case 1:
					empstatus = "Fuldtid";
					break;
				case 2:
					empstatus = "Deltid";
					break;
				case 3:
					empstatus = "Flex";
					break;
				case 4:
					empstatus = "Akkord";
					break;
				case 5:
					empstatus = "Elev";
					break;
				case 6:
					empstatus = "Praktikant";
					break;
				case 7:
					empstatus = "Timelønnet";
					break;
				case 8:
					empstatus = "Prøveansat";
					break;
			}
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
		void ExitbtnClick(object sender, EventArgs e)
		{
			using(mcon = new MySqlConnection(mcs))
			{
				string query = "DELETE FROM `adm_ansatte`.`personlig_info` WHERE `Status` = 'Ny'";
				mcon.Open();
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			Close();
		}
	}
}

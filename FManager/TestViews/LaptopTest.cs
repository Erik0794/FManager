/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 25-02-2017
 * Time: 18:10
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
using FManager;
using FManager.Menus;
using FManager.Views;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FManager.TestViews
{
	/// <summary>
	/// Description of LaptopTest.
	/// </summary>
	public partial class LaptopTest : Form
	{
		//Database stuff
		MySqlConnection mcon; //connection to the database
		ConnectionStringSettings mcons = ConfigurationManager.ConnectionStrings["MySql"]; //Just the connection string to login to DB
		//
		string status;
		//
		//Variables for checkboxstates in preinstalledeq
		string inhdd;
		string inssd;
		string inodd;
		string incpu;
		string inram;
		string inlcd;
		string inbat;
		string inkbd;
		string inmpd;
		//Varialbes for checkboxstates in installedeq
		string outhdd;
		string outssd;
		string outodd;
		string outcpu;
		string outram;
		string outlcd;
		string outbat;
		string outkbd;
		string outmpd;
		//
		bool isssd(){return hasssd.Checked;}
		bool ishdd(){return hashdd.Checked;}
		string hddtype;		
		//
		static string lastentry;		
		//
		public LaptopTest()
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
		void LaptopTestLoad(object sender, EventArgs e)
		{
			//nothing to load	
		}	
		//
		//
		//
		void StatusBtnOKClick(object sender, EventArgs e)
		{
			evaluate();
			preinstalledeq();
			installedeq();
			//
			status = comboBox2.Text + ", " + comboBox1.Text + ", " + comboBox3.Text + ", " +  "TESTET OK";
			//
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO adm_test.pc (`Medarbejder_ID`, `ID`, `Type`, `Mærke`, `Model`, `Serienummer`, `CPU_Type`, `CPU_Frekvens`, `RAM_Størrelse`, `RAM_Type`, `Harddisk`, `HDD_Type`, `HDD_Kapacitet`, `Optisk_Drev`, `Batteri`, `Skærm`, `Skærmstørrelse`, `Keyboard`, `Mousepad`, `Status`, `Noter`) VALUES(@mid,@lid,@typ,@mrk,@mdl,@sno,@cput,@cpuf,@ramk,@ramt,@hdd,@hddt,@hddk,@odd,@bat,@scr,@scrs,@kbd,@mpd,@sts,@note)";
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
				  mcmd.Parameters.AddWithValue("@lid", idbox.Text);
				  mcmd.Parameters.AddWithValue("@typ", SelectionMenu.type);
				  mcmd.Parameters.AddWithValue("@mrk", brand.Text);
				  mcmd.Parameters.AddWithValue("@mdl", model.Text);
				  mcmd.Parameters.AddWithValue("@sno", serialno.Text);
				  mcmd.Parameters.AddWithValue("@cput", cputypebox.Text);
				  mcmd.Parameters.AddWithValue("@cpuf", cpufreqbox.Text);
				  mcmd.Parameters.AddWithValue("@ramk", ramcapbox.Text);
				  mcmd.Parameters.AddWithValue("@ramt", ramtypebox.Text);
				  mcmd.Parameters.AddWithValue("@hdd", inhdd);
				  mcmd.Parameters.AddWithValue("@hddt", hddtype);
				  mcmd.Parameters.AddWithValue("@hddk", hddcapbox.Text);
				  mcmd.Parameters.AddWithValue("@odd", inodd);
				  mcmd.Parameters.AddWithValue("@bat", inbat);
				  mcmd.Parameters.AddWithValue("@scr", inlcd);
				  mcmd.Parameters.AddWithValue("@scrs", screensizebox.Text);
				  mcmd.Parameters.AddWithValue("@kbd", inkbd);
				  mcmd.Parameters.AddWithValue("@mpd", inmpd);
				  mcmd.Parameters.AddWithValue("@sts", status);
				  mcmd.Parameters.AddWithValue("@note", notebox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO `adm_test`.`spenthw` (`Medarbejder_ID`, `ID`, `Type`, `Mærke`, `Model`, `Serienummer`,`HDD`, `HDD_Cap`, `SSD`, `ODD`, `CPU_Type`, `CPU_Freq`, `RAM_Cap`, `RAM_Type`, `Skærm`, `Skærmstørrelse`, `Keyboard`, `Mousepad`, `Batteri`, `Noter`) VALUES(@mid,@lid,@typ,@mrk,@mdl,@sno,@cput,@cpuf,@ramk,@ramt,@hdd,@hddk,@ssd,@odd,@bat,@scr,@scrs,@kbd,@mpd,@note)";
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
				  mcmd.Parameters.AddWithValue("@lid", idbox.Text);
				  mcmd.Parameters.AddWithValue("@typ", SelectionMenu.type);
				  mcmd.Parameters.AddWithValue("@mrk", brand.Text);
				  mcmd.Parameters.AddWithValue("@mdl", model.Text);
				  mcmd.Parameters.AddWithValue("@sno", serialno.Text);
				  mcmd.Parameters.AddWithValue("@hdd", outhdd);
				  mcmd.Parameters.AddWithValue("@hddk", ihddcapbox.Text);
				  mcmd.Parameters.AddWithValue("@ssd", outssd);
				  mcmd.Parameters.AddWithValue("@odd", outodd);
				  mcmd.Parameters.AddWithValue("@cput", icputypebox.Text);
				  mcmd.Parameters.AddWithValue("@cpuf", icpufreqbox.Text);
				  mcmd.Parameters.AddWithValue("@ramk", iramcapbox.Text);
				  mcmd.Parameters.AddWithValue("@ramt", iramtypebox.Text);
				  mcmd.Parameters.AddWithValue("@scr", outlcd);
				  mcmd.Parameters.AddWithValue("@scrs", iscreensizebox.Text);
				  mcmd.Parameters.AddWithValue("@kbd", outkbd);
				  mcmd.Parameters.AddWithValue("@mpd", outmpd);
				  mcmd.Parameters.AddWithValue("@bat", outbat);
				  mcmd.Parameters.AddWithValue("@note", notebox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader();				  
			}
			clearselections();
			lastentry = idbox.Text;			
		}
		//
		//
		//
		void StatusBtnDEFClick(object sender, EventArgs e)
		{
			evaluate();
			preinstalledeq();
			installedeq();
			//
			status = comboBox2.Text + ", " + comboBox1.Text + ", " + comboBox3.Text + ", " +  "DEFEKT";
			//
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				const string query = "INSERT INTO adm_test.pc (`Medarbejder_ID`, `ID`, `Type`, `Mærke`, `Model`, `Serienummer`, `CPU_Type`, `CPU_Frekvens`, `RAM_Størrelse`, `RAM_Type`, `Harddisk`, `HDD_Type`, `HDD_Kapacitet`, `Optisk_Drev`, `Batteri`, `Skærm`, `Skærmstørrelse`, `Keyboard`, `Mousepad`, `Status`, `Noter`) VALUES(@mid,@lid,@typ,@mrk,@mdl,@sno,@cput,@cpuf,@ramk,@ramt,@hdd,@hddt,@hddk,@odd,@bat,@scr,@scrs,@kbd,@mpd,@sts,@note)";
				MySqlCommand mcmd = mcon.CreateCommand();
				mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@mid", LoginForm.MID);
				  mcmd.Parameters.AddWithValue("@lid", idbox.Text);
				  mcmd.Parameters.AddWithValue("@typ", SelectionMenu.type);
				  mcmd.Parameters.AddWithValue("@mrk", brand.Text);
				  mcmd.Parameters.AddWithValue("@mdl", model.Text);
				  mcmd.Parameters.AddWithValue("@sno", serialno.Text);
				  mcmd.Parameters.AddWithValue("@cput", cputypebox.Text);
				  mcmd.Parameters.AddWithValue("@cpuf", cpufreqbox.Text);
				  mcmd.Parameters.AddWithValue("@ramk", ramcapbox.Text);
				  mcmd.Parameters.AddWithValue("@ramt", ramtypebox.Text);
				  mcmd.Parameters.AddWithValue("@hdd", inhdd);
				  mcmd.Parameters.AddWithValue("@hddt", hddtype);
				  mcmd.Parameters.AddWithValue("@hddk", hddcapbox.Text);
				  mcmd.Parameters.AddWithValue("@odd", inodd);
				  mcmd.Parameters.AddWithValue("@bat", inbat);
				  mcmd.Parameters.AddWithValue("@scr", inlcd);
				  mcmd.Parameters.AddWithValue("@scrs", screensizebox.Text);
				  mcmd.Parameters.AddWithValue("@kbd", inkbd);
				  mcmd.Parameters.AddWithValue("@mpd", inmpd);
				  mcmd.Parameters.AddWithValue("@sts", status);
				  mcmd.Parameters.AddWithValue("@note", notebox.Text);
				MySqlDataReader mdr = mcmd.ExecuteReader();
			}
			clearselections();
			lastentry = idbox.Text;			
		}
		//
		//
		//
		void PauseBtnClick(object sender, EventArgs e)
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
		void ExitBtnClick(object sender, EventArgs e)
		{
			Close();
		}
		//
		//
		//
		void preinstalledeq()
		{
			inhdd = hashdd.Checked ? "yes" : "no";
			inssd = hasssd.Checked ? "yes" : "no";
			inodd = hasodd.Checked ? "yes" : "no";
			incpu = hascpu.Checked ? "yes" : "no";
			inram = hasram.Checked ? "yes" : "no";
			inlcd = haslcd.Checked ? "yes" : "no";
			inbat = hasbat.Checked ? "yes" : "no";
			inkbd = haskbd.Checked ? "yes" : "no";
			inmpd = hasmpd.Checked ? "yes" : "no";
		}
		void installedeq()
		{
			outhdd = ihdd.Checked ? "yes" : "no";
			outssd = issd.Checked ? "yes" : "no";
			outodd = iodd.Checked ? "yes" : "no";
			outcpu = icpu.Checked ? "yes" : "no";
			outram = iram.Checked ? "yes" : "no";
			outlcd = ilcd.Checked ? "yes" : "no";
			outbat = ibat.Checked ? "yes" : "no";
			outkbd = ikbd.Checked ? "yes" : "no";
			outmpd = impd.Checked ? "yes" : "no";
		}
		void evaluate()
		{
			if(isssd() == false && ishdd() == true) hddtype = "HDD";
			if(isssd() == true && ishdd() == false) hddtype = "SSD";
			if(isssd() == true && ishdd() == true) 	hddtype = "HDD + SSD";
			if(isssd() == false && ishdd() == false) hddtype = "None";
		}
		void clearselections()
		{
			hashdd.Checked = true;
			hasssd.Checked = true;
			hasodd.Checked = true;
			hascpu.Checked = true;
			hasram.Checked = true;
			haslcd.Checked = true;
			hasbat.Checked = true;
			haskbd.Checked = true;
			hasmpd.Checked = true;
			cputypebox.Clear();
			cpufreqbox.Clear();
			ramcapbox.SelectedIndex = 0;
			ramtypebox.SelectedIndex = 0;
			hddcapbox.Clear();
			screensizebox.SelectedIndex = 0;
			ihdd.Checked = false;
			issd.Checked = false;
			iodd.Checked = false;
			icpu.Checked = false;
			iram.Checked = false;
			ilcd.Checked = false;
			ibat.Checked = false;
			ikbd.Checked = false;
			impd.Checked = false;
			icputypebox.Clear();
			icpufreqbox.Clear();
			iramcapbox.SelectedIndex = 0;
			iramtypebox.SelectedIndex = 0;
			ihddcapbox.Clear();
			iscreensizebox.SelectedIndex = 0;
			notebox.Text = "Noter";
		}
		void DeletebtnClick(object sender, EventArgs e)
		{
			string mcs = mcons.ConnectionString;
			using(mcon = new MySqlConnection(mcs))
			{
				mcon.Open();
				string query = "DELETE FROM `adm_test`.`pc` WHERE `ID` = @id";
				MySqlCommand mcmd = mcon.CreateCommand();
				  mcmd.CommandText = query;
				  mcmd.Parameters.AddWithValue("@id", lastentry);
				MySqlDataReader mdr = mcmd.ExecuteReader();				  
			}			
		}
		void IdboxKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				string mcs = mcons.ConnectionString;
				using(mcon = new MySqlConnection(mcs))
				{
					mcon.Open();
					string query = "SELECT `Mærke`,`Model`,`Serienummer` FROM `adm_lager`.`inventory_it` WHERE `UNIQUEID` = @uid";
					MySqlCommand mcmd = mcon.CreateCommand();
					  mcmd.CommandText = query;
					  mcmd.Parameters.AddWithValue("@uid",idbox.Text);
					MySqlDataReader mdr = mcmd.ExecuteReader();
					while(mdr.Read())
					{
						brand.Text = mdr.GetString("Mærke");
						model.Text = mdr.GetString("Model");
						serialno.Text = mdr.GetString("Serienummer");
					}
				}
			}			
		}
	}
}

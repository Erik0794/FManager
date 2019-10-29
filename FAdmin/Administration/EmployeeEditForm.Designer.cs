/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 04-07-2017
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FAdmin.Administration
{
	partial class EmployeeEditForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox regnobox;
		private System.Windows.Forms.RadioButton fulltime;
		private System.Windows.Forms.RadioButton parttime;
		private System.Windows.Forms.RadioButton flextime;
		private System.Windows.Forms.RadioButton prunit;
		private System.Windows.Forms.RadioButton apprentice;
		private System.Windows.Forms.RadioButton intern;
		private System.Windows.Forms.RadioButton hourly;
		private System.Windows.Forms.RadioButton tryout;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox accesslevel;
		private System.Windows.Forms.CheckBox showpass;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox passwordbox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox paytype;
		private System.Windows.Forms.TextBox payratebox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox banknamebox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox accountnobox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox truckcertified;
		private System.Windows.Forms.CheckBox itcertified;
		private System.Windows.Forms.ComboBox licencetype;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox icephonebox;
		private System.Windows.Forms.TextBox icenamebox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox crimrecbox;
		private System.Windows.Forms.TextBox emailbox;
		private System.Windows.Forms.TextBox cprnobox;
		private System.Windows.Forms.TextBox mobilenobox;
		private System.Windows.Forms.TextBox phonenobox;
		private System.Windows.Forms.TextBox citybox;
		private System.Windows.Forms.TextBox zipcodebox;
		private System.Windows.Forms.TextBox addressbox;
		private System.Windows.Forms.TextBox namebox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button updatebtn;
		private System.Windows.Forms.ComboBox idbox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeEditForm));
			this.regnobox = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.idbox = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.accesslevel = new System.Windows.Forms.ComboBox();
			this.showpass = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.passwordbox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.paytype = new System.Windows.Forms.ComboBox();
			this.payratebox = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.banknamebox = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.accountnobox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.exitbtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.truckcertified = new System.Windows.Forms.CheckBox();
			this.itcertified = new System.Windows.Forms.CheckBox();
			this.licencetype = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.icephonebox = new System.Windows.Forms.TextBox();
			this.icenamebox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.crimrecbox = new System.Windows.Forms.TextBox();
			this.emailbox = new System.Windows.Forms.TextBox();
			this.cprnobox = new System.Windows.Forms.TextBox();
			this.mobilenobox = new System.Windows.Forms.TextBox();
			this.phonenobox = new System.Windows.Forms.TextBox();
			this.citybox = new System.Windows.Forms.TextBox();
			this.zipcodebox = new System.Windows.Forms.TextBox();
			this.addressbox = new System.Windows.Forms.TextBox();
			this.namebox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.updatebtn = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.fulltime = new System.Windows.Forms.RadioButton();
			this.parttime = new System.Windows.Forms.RadioButton();
			this.flextime = new System.Windows.Forms.RadioButton();
			this.prunit = new System.Windows.Forms.RadioButton();
			this.apprentice = new System.Windows.Forms.RadioButton();
			this.intern = new System.Windows.Forms.RadioButton();
			this.hourly = new System.Windows.Forms.RadioButton();
			this.tryout = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// regnobox
			// 
			this.regnobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.regnobox.Location = new System.Drawing.Point(10, 48);
			this.regnobox.Name = "regnobox";
			this.regnobox.Size = new System.Drawing.Size(50, 29);
			this.regnobox.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.idbox);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.accesslevel);
			this.groupBox3.Controls.Add(this.showpass);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.passwordbox);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox3.Location = new System.Drawing.Point(365, 13);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(245, 170);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Konto Opsætning";
			// 
			// idbox
			// 
			this.idbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.idbox.FormattingEnabled = true;
			this.idbox.Location = new System.Drawing.Point(98, 28);
			this.idbox.Name = "idbox";
			this.idbox.Size = new System.Drawing.Size(100, 29);
			this.idbox.TabIndex = 6;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(4, 130);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 29);
			this.label12.TabIndex = 5;
			this.label12.Text = "Tilladelser:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// accesslevel
			// 
			this.accesslevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.accesslevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.accesslevel.FormattingEnabled = true;
			this.accesslevel.Items.AddRange(new object[] {
			"1",
			"10",
			"11",
			"14",
			"18",
			"2",
			"21",
			"4",
			"5"});
			this.accesslevel.Location = new System.Drawing.Point(98, 130);
			this.accesslevel.Name = "accesslevel";
			this.accesslevel.Size = new System.Drawing.Size(60, 29);
			this.accesslevel.Sorted = true;
			this.accesslevel.TabIndex = 2;
			// 
			// showpass
			// 
			this.showpass.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.showpass.Location = new System.Drawing.Point(98, 100);
			this.showpass.Name = "showpass";
			this.showpass.Size = new System.Drawing.Size(146, 24);
			this.showpass.TabIndex = 1;
			this.showpass.Text = "Show Password?";
			this.showpass.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label11.Location = new System.Drawing.Point(7, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 29);
			this.label11.TabIndex = 2;
			this.label11.Text = "Password";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// passwordbox
			// 
			this.passwordbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.passwordbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.passwordbox.Location = new System.Drawing.Point(98, 64);
			this.passwordbox.Name = "passwordbox";
			this.passwordbox.PasswordChar = '*';
			this.passwordbox.Size = new System.Drawing.Size(100, 29);
			this.passwordbox.TabIndex = 0;
			this.passwordbox.Text = "password";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label10.Location = new System.Drawing.Point(7, 28);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(85, 29);
			this.label10.TabIndex = 0;
			this.label10.Text = "ID:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.paytype);
			this.groupBox4.Controls.Add(this.payratebox);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.banknamebox);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.accountnobox);
			this.groupBox4.Controls.Add(this.regnobox);
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox4.Location = new System.Drawing.Point(366, 189);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(298, 175);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Konto Oplysninger";
			// 
			// paytype
			// 
			this.paytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.paytype.FormattingEnabled = true;
			this.paytype.Items.AddRange(new object[] {
			"kr./time",
			"kr./enhed"});
			this.paytype.Location = new System.Drawing.Point(157, 138);
			this.paytype.Name = "paytype";
			this.paytype.Size = new System.Drawing.Size(90, 29);
			this.paytype.TabIndex = 4;
			// 
			// payratebox
			// 
			this.payratebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.payratebox.Location = new System.Drawing.Point(77, 138);
			this.payratebox.Name = "payratebox";
			this.payratebox.Size = new System.Drawing.Size(80, 29);
			this.payratebox.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label17.Location = new System.Drawing.Point(10, 138);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(69, 29);
			this.label17.TabIndex = 5;
			this.label17.Text = "Lønsats:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// banknamebox
			// 
			this.banknamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.banknamebox.Location = new System.Drawing.Point(10, 102);
			this.banknamebox.Name = "banknamebox";
			this.banknamebox.Size = new System.Drawing.Size(270, 29);
			this.banknamebox.TabIndex = 2;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label16.Location = new System.Drawing.Point(7, 80);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 23);
			this.label16.TabIndex = 3;
			this.label16.Text = "Bank:";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label15.Location = new System.Drawing.Point(8, 24);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(273, 23);
			this.label15.TabIndex = 2;
			this.label15.Text = "Reg.:     Kontonummer:";
			// 
			// accountnobox
			// 
			this.accountnobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.accountnobox.Location = new System.Drawing.Point(65, 48);
			this.accountnobox.Name = "accountnobox";
			this.accountnobox.Size = new System.Drawing.Size(215, 29);
			this.accountnobox.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(732, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.exitbtn.Location = new System.Drawing.Point(710, 371);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(150, 75);
			this.exitbtn.TabIndex = 13;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.truckcertified);
			this.groupBox1.Controls.Add(this.itcertified);
			this.groupBox1.Controls.Add(this.licencetype);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.icephonebox);
			this.groupBox1.Controls.Add(this.icenamebox);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.crimrecbox);
			this.groupBox1.Controls.Add(this.emailbox);
			this.groupBox1.Controls.Add(this.cprnobox);
			this.groupBox1.Controls.Add(this.mobilenobox);
			this.groupBox1.Controls.Add(this.phonenobox);
			this.groupBox1.Controls.Add(this.citybox);
			this.groupBox1.Controls.Add(this.zipcodebox);
			this.groupBox1.Controls.Add(this.addressbox);
			this.groupBox1.Controls.Add(this.namebox);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(346, 537);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personlig Information";
			// 
			// truckcertified
			// 
			this.truckcertified.Location = new System.Drawing.Point(138, 385);
			this.truckcertified.Name = "truckcertified";
			this.truckcertified.Size = new System.Drawing.Size(200, 25);
			this.truckcertified.TabIndex = 11;
			this.truckcertified.Text = "Truck Certifikat";
			this.truckcertified.UseVisualStyleBackColor = true;
			// 
			// itcertified
			// 
			this.itcertified.Location = new System.Drawing.Point(138, 355);
			this.itcertified.Name = "itcertified";
			this.itcertified.Size = new System.Drawing.Size(200, 25);
			this.itcertified.TabIndex = 10;
			this.itcertified.Text = "IT Certifikater";
			this.itcertified.UseVisualStyleBackColor = true;
			// 
			// licencetype
			// 
			this.licencetype.FormattingEnabled = true;
			this.licencetype.Items.AddRange(new object[] {
			"Ingen",
			"B",
			"B+",
			"B/E",
			"C1",
			"C1/E",
			"C",
			"C/E"});
			this.licencetype.Location = new System.Drawing.Point(138, 317);
			this.licencetype.Name = "licencetype";
			this.licencetype.Size = new System.Drawing.Size(200, 29);
			this.licencetype.TabIndex = 9;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label14.Location = new System.Drawing.Point(7, 317);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(125, 29);
			this.label14.TabIndex = 16;
			this.label14.Text = "Kørekort";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// icephonebox
			// 
			this.icephonebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.icephonebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
			this.icephonebox.Location = new System.Drawing.Point(138, 446);
			this.icephonebox.Name = "icephonebox";
			this.icephonebox.Size = new System.Drawing.Size(200, 29);
			this.icephonebox.TabIndex = 14;
			this.icephonebox.Text = "Telefonnummer";
			this.icephonebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// icenamebox
			// 
			this.icenamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.icenamebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
			this.icenamebox.Location = new System.Drawing.Point(138, 416);
			this.icenamebox.Name = "icenamebox";
			this.icenamebox.Size = new System.Drawing.Size(200, 29);
			this.icenamebox.TabIndex = 13;
			this.icenamebox.Text = "Navn";
			this.icenamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(9, 430);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(123, 29);
			this.label13.TabIndex = 12;
			this.label13.Text = "ICE Kontakt:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// crimrecbox
			// 
			this.crimrecbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crimrecbox.Location = new System.Drawing.Point(138, 285);
			this.crimrecbox.Name = "crimrecbox";
			this.crimrecbox.Size = new System.Drawing.Size(200, 29);
			this.crimrecbox.TabIndex = 8;
			// 
			// emailbox
			// 
			this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.emailbox.Location = new System.Drawing.Point(138, 253);
			this.emailbox.Name = "emailbox";
			this.emailbox.Size = new System.Drawing.Size(200, 29);
			this.emailbox.TabIndex = 7;
			// 
			// cprnobox
			// 
			this.cprnobox.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.cprnobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cprnobox.Location = new System.Drawing.Point(138, 221);
			this.cprnobox.Name = "cprnobox";
			this.cprnobox.ReadOnly = true;
			this.cprnobox.Size = new System.Drawing.Size(200, 29);
			this.cprnobox.TabIndex = 6;
			// 
			// mobilenobox
			// 
			this.mobilenobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mobilenobox.Location = new System.Drawing.Point(138, 189);
			this.mobilenobox.Name = "mobilenobox";
			this.mobilenobox.Size = new System.Drawing.Size(200, 29);
			this.mobilenobox.TabIndex = 5;
			// 
			// phonenobox
			// 
			this.phonenobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.phonenobox.Location = new System.Drawing.Point(138, 157);
			this.phonenobox.Name = "phonenobox";
			this.phonenobox.Size = new System.Drawing.Size(200, 29);
			this.phonenobox.TabIndex = 4;
			// 
			// citybox
			// 
			this.citybox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.citybox.Location = new System.Drawing.Point(138, 125);
			this.citybox.Name = "citybox";
			this.citybox.Size = new System.Drawing.Size(200, 29);
			this.citybox.TabIndex = 3;
			// 
			// zipcodebox
			// 
			this.zipcodebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.zipcodebox.Location = new System.Drawing.Point(138, 93);
			this.zipcodebox.Name = "zipcodebox";
			this.zipcodebox.Size = new System.Drawing.Size(200, 29);
			this.zipcodebox.TabIndex = 2;
			// 
			// addressbox
			// 
			this.addressbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addressbox.Location = new System.Drawing.Point(138, 61);
			this.addressbox.Name = "addressbox";
			this.addressbox.Size = new System.Drawing.Size(200, 29);
			this.addressbox.TabIndex = 1;
			// 
			// namebox
			// 
			this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.namebox.Location = new System.Drawing.Point(138, 29);
			this.namebox.Name = "namebox";
			this.namebox.Size = new System.Drawing.Size(200, 29);
			this.namebox.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label9.Location = new System.Drawing.Point(7, 285);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(125, 29);
			this.label9.TabIndex = 7;
			this.label9.Text = "Straffeattest";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label8.Location = new System.Drawing.Point(7, 253);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 29);
			this.label8.TabIndex = 6;
			this.label8.Text = "Email";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label7.Location = new System.Drawing.Point(7, 221);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(125, 29);
			this.label7.TabIndex = 5;
			this.label7.Text = "CPR Nummer";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label6.Location = new System.Drawing.Point(7, 189);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 29);
			this.label6.TabIndex = 4;
			this.label6.Text = "Mobilnummer";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label5.Location = new System.Drawing.Point(7, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Telefonnummer";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.Location = new System.Drawing.Point(7, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Postnummer";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.Location = new System.Drawing.Point(6, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "By";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(7, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Adresse";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label1.Location = new System.Drawing.Point(7, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Navn";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// updatebtn
			// 
			this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.updatebtn.Location = new System.Drawing.Point(710, 462);
			this.updatebtn.Name = "updatebtn";
			this.updatebtn.Size = new System.Drawing.Size(150, 75);
			this.updatebtn.TabIndex = 11;
			this.updatebtn.Text = "Opdater";
			this.updatebtn.UseVisualStyleBackColor = false;
			this.updatebtn.Click += new System.EventHandler(this.UpdatebtnClick);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.fulltime);
			this.flowLayoutPanel1.Controls.Add(this.parttime);
			this.flowLayoutPanel1.Controls.Add(this.flextime);
			this.flowLayoutPanel1.Controls.Add(this.prunit);
			this.flowLayoutPanel1.Controls.Add(this.apprentice);
			this.flowLayoutPanel1.Controls.Add(this.intern);
			this.flowLayoutPanel1.Controls.Add(this.hourly);
			this.flowLayoutPanel1.Controls.Add(this.tryout);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 151);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// fulltime
			// 
			this.fulltime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fulltime.Location = new System.Drawing.Point(8, 3);
			this.fulltime.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.fulltime.Name = "fulltime";
			this.fulltime.Size = new System.Drawing.Size(130, 30);
			this.fulltime.TabIndex = 0;
			this.fulltime.Text = "Fuldtid";
			this.fulltime.UseVisualStyleBackColor = true;
			// 
			// parttime
			// 
			this.parttime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.parttime.Location = new System.Drawing.Point(149, 3);
			this.parttime.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.parttime.Name = "parttime";
			this.parttime.Size = new System.Drawing.Size(130, 30);
			this.parttime.TabIndex = 4;
			this.parttime.Text = "Deltid";
			this.parttime.UseVisualStyleBackColor = true;
			// 
			// flextime
			// 
			this.flextime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flextime.Location = new System.Drawing.Point(8, 39);
			this.flextime.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.flextime.Name = "flextime";
			this.flextime.Size = new System.Drawing.Size(130, 30);
			this.flextime.TabIndex = 1;
			this.flextime.Text = "Flex";
			this.flextime.UseVisualStyleBackColor = true;
			// 
			// prunit
			// 
			this.prunit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prunit.Location = new System.Drawing.Point(149, 39);
			this.prunit.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.prunit.Name = "prunit";
			this.prunit.Size = new System.Drawing.Size(141, 30);
			this.prunit.TabIndex = 5;
			this.prunit.Text = "Mængdelønnet";
			this.prunit.UseVisualStyleBackColor = true;
			// 
			// apprentice
			// 
			this.apprentice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apprentice.Location = new System.Drawing.Point(8, 75);
			this.apprentice.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.apprentice.Name = "apprentice";
			this.apprentice.Size = new System.Drawing.Size(130, 30);
			this.apprentice.TabIndex = 2;
			this.apprentice.Text = "Elev";
			this.apprentice.UseVisualStyleBackColor = true;
			// 
			// intern
			// 
			this.intern.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.intern.Location = new System.Drawing.Point(149, 75);
			this.intern.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.intern.Name = "intern";
			this.intern.Size = new System.Drawing.Size(130, 30);
			this.intern.TabIndex = 6;
			this.intern.Text = "Praktikant";
			this.intern.UseVisualStyleBackColor = true;
			// 
			// hourly
			// 
			this.hourly.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hourly.Location = new System.Drawing.Point(8, 111);
			this.hourly.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.hourly.Name = "hourly";
			this.hourly.Size = new System.Drawing.Size(130, 30);
			this.hourly.TabIndex = 3;
			this.hourly.Text = "Timelønnet";
			this.hourly.UseVisualStyleBackColor = true;
			// 
			// tryout
			// 
			this.tryout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tryout.Location = new System.Drawing.Point(149, 111);
			this.tryout.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.tryout.Name = "tryout";
			this.tryout.Size = new System.Drawing.Size(130, 30);
			this.tryout.TabIndex = 7;
			this.tryout.Text = "På Prøve";
			this.tryout.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.flowLayoutPanel1);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(365, 371);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(299, 179);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Medarbejder Status";
			// 
			// EmployeeEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 566);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.updatebtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EmployeeEditForm";
			this.Text = "EmployeeEditForm";
			this.Load += new System.EventHandler(this.EmployeeEditFormLoad);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

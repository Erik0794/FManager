/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 30-03-2017
 * Time: 15:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FAdmin.Clients
{
	partial class SBAdd
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox companynamebox;
		private System.Windows.Forms.TextBox cvrbox;
		private System.Windows.Forms.TextBox contactnamebox;
		private System.Windows.Forms.TextBox addressbox;
		private System.Windows.Forms.TextBox zipcodebox;
		private System.Windows.Forms.TextBox citynamebox;
		private System.Windows.Forms.TextBox phonenumberbox;
		private System.Windows.Forms.TextBox directnumberbox;
		private System.Windows.Forms.TextBox emailbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button createbtn;
		private System.Windows.Forms.Button exitbtn;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBAdd));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.emailbox = new System.Windows.Forms.TextBox();
			this.directnumberbox = new System.Windows.Forms.TextBox();
			this.phonenumberbox = new System.Windows.Forms.TextBox();
			this.citynamebox = new System.Windows.Forms.TextBox();
			this.zipcodebox = new System.Windows.Forms.TextBox();
			this.addressbox = new System.Windows.Forms.TextBox();
			this.contactnamebox = new System.Windows.Forms.TextBox();
			this.cvrbox = new System.Windows.Forms.TextBox();
			this.companynamebox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.createbtn = new System.Windows.Forms.Button();
			this.exitbtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.emailbox);
			this.groupBox1.Controls.Add(this.directnumberbox);
			this.groupBox1.Controls.Add(this.phonenumberbox);
			this.groupBox1.Controls.Add(this.citynamebox);
			this.groupBox1.Controls.Add(this.zipcodebox);
			this.groupBox1.Controls.Add(this.addressbox);
			this.groupBox1.Controls.Add(this.contactnamebox);
			this.groupBox1.Controls.Add(this.cvrbox);
			this.groupBox1.Controls.Add(this.companynamebox);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(369, 387);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Slutbruger Information";
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label9.Location = new System.Drawing.Point(220, 33);
			this.label9.Margin = new System.Windows.Forms.Padding(8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(138, 29);
			this.label9.TabIndex = 19;
			this.label9.Text = "Firmanavn";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label8.Location = new System.Drawing.Point(220, 72);
			this.label8.Margin = new System.Windows.Forms.Padding(8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(138, 29);
			this.label8.TabIndex = 17;
			this.label8.Text = "CVR Nummer";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label6.Location = new System.Drawing.Point(220, 111);
			this.label6.Margin = new System.Windows.Forms.Padding(8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(138, 29);
			this.label6.TabIndex = 16;
			this.label6.Text = "Kontaktperson";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label5.Location = new System.Drawing.Point(220, 150);
			this.label5.Margin = new System.Windows.Forms.Padding(8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 29);
			this.label5.TabIndex = 15;
			this.label5.Text = "Adresse";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label7.Location = new System.Drawing.Point(220, 189);
			this.label7.Margin = new System.Windows.Forms.Padding(8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(138, 29);
			this.label7.TabIndex = 14;
			this.label7.Text = "Postnummer";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.Location = new System.Drawing.Point(220, 228);
			this.label3.Margin = new System.Windows.Forms.Padding(8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 29);
			this.label3.TabIndex = 13;
			this.label3.Text = "By";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.Location = new System.Drawing.Point(220, 267);
			this.label4.Margin = new System.Windows.Forms.Padding(8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 29);
			this.label4.TabIndex = 12;
			this.label4.Text = "Telefonnummer";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(220, 306);
			this.label2.Margin = new System.Windows.Forms.Padding(8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 29);
			this.label2.TabIndex = 18;
			this.label2.Text = "Direkte Nummer";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label1.Location = new System.Drawing.Point(220, 345);
			this.label1.Margin = new System.Windows.Forms.Padding(8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 29);
			this.label1.TabIndex = 11;
			this.label1.Text = "Email";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// emailbox
			// 
			this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.emailbox.Location = new System.Drawing.Point(4, 345);
			this.emailbox.Margin = new System.Windows.Forms.Padding(8);
			this.emailbox.Name = "emailbox";
			this.emailbox.Size = new System.Drawing.Size(215, 29);
			this.emailbox.TabIndex = 9;
			// 
			// directnumberbox
			// 
			this.directnumberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.directnumberbox.Location = new System.Drawing.Point(4, 306);
			this.directnumberbox.Margin = new System.Windows.Forms.Padding(8);
			this.directnumberbox.Name = "directnumberbox";
			this.directnumberbox.Size = new System.Drawing.Size(215, 29);
			this.directnumberbox.TabIndex = 8;
			// 
			// phonenumberbox
			// 
			this.phonenumberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.phonenumberbox.Location = new System.Drawing.Point(4, 267);
			this.phonenumberbox.Margin = new System.Windows.Forms.Padding(8);
			this.phonenumberbox.Name = "phonenumberbox";
			this.phonenumberbox.Size = new System.Drawing.Size(215, 29);
			this.phonenumberbox.TabIndex = 7;
			// 
			// citynamebox
			// 
			this.citynamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.citynamebox.Location = new System.Drawing.Point(4, 228);
			this.citynamebox.Margin = new System.Windows.Forms.Padding(8);
			this.citynamebox.Name = "citynamebox";
			this.citynamebox.Size = new System.Drawing.Size(215, 29);
			this.citynamebox.TabIndex = 6;
			// 
			// zipcodebox
			// 
			this.zipcodebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.zipcodebox.Location = new System.Drawing.Point(4, 189);
			this.zipcodebox.Margin = new System.Windows.Forms.Padding(8);
			this.zipcodebox.Name = "zipcodebox";
			this.zipcodebox.Size = new System.Drawing.Size(215, 29);
			this.zipcodebox.TabIndex = 5;
			// 
			// addressbox
			// 
			this.addressbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addressbox.Location = new System.Drawing.Point(4, 150);
			this.addressbox.Margin = new System.Windows.Forms.Padding(8);
			this.addressbox.Name = "addressbox";
			this.addressbox.Size = new System.Drawing.Size(215, 29);
			this.addressbox.TabIndex = 4;
			// 
			// contactnamebox
			// 
			this.contactnamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.contactnamebox.Location = new System.Drawing.Point(4, 111);
			this.contactnamebox.Margin = new System.Windows.Forms.Padding(8);
			this.contactnamebox.Name = "contactnamebox";
			this.contactnamebox.Size = new System.Drawing.Size(215, 29);
			this.contactnamebox.TabIndex = 3;
			// 
			// cvrbox
			// 
			this.cvrbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cvrbox.Location = new System.Drawing.Point(4, 72);
			this.cvrbox.Margin = new System.Windows.Forms.Padding(8);
			this.cvrbox.Name = "cvrbox";
			this.cvrbox.Size = new System.Drawing.Size(215, 29);
			this.cvrbox.TabIndex = 10;
			// 
			// companynamebox
			// 
			this.companynamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.companynamebox.Location = new System.Drawing.Point(4, 33);
			this.companynamebox.Margin = new System.Windows.Forms.Padding(8);
			this.companynamebox.Name = "companynamebox";
			this.companynamebox.Size = new System.Drawing.Size(215, 29);
			this.companynamebox.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(392, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// createbtn
			// 
			this.createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.createbtn.Location = new System.Drawing.Point(112, 431);
			this.createbtn.Name = "createbtn";
			this.createbtn.Size = new System.Drawing.Size(125, 65);
			this.createbtn.TabIndex = 3;
			this.createbtn.Text = "Godkend";
			this.createbtn.UseVisualStyleBackColor = false;
			this.createbtn.Click += new System.EventHandler(this.CreatebtnClick);
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.exitbtn.Location = new System.Drawing.Point(309, 431);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(125, 65);
			this.exitbtn.TabIndex = 3;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// SBAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 522);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.createbtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "SBAdd";
			this.Text = "Tilføj Slutbruger";
			this.Load += new System.EventHandler(this.SBAddLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

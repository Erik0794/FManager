/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 11-03-2017
 * Time: 16:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FAdmin.Clients
{
	partial class AddressAdd
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox cvrbox;
		private System.Windows.Forms.TextBox zipcodebox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox citybox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox addressbox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox emailbox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox directnumberbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox phonenumberbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox contactnamebox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button addbtn;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.TextBox availablebox;
		private System.Windows.Forms.Label label9;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressAdd));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cvrbox = new System.Windows.Forms.TextBox();
			this.zipcodebox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.citybox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.addressbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.availablebox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.emailbox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.directnumberbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.phonenumberbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.contactnamebox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addbtn = new System.Windows.Forms.Button();
			this.exitbtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cvrbox);
			this.groupBox1.Controls.Add(this.zipcodebox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.citybox);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.addressbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(341, 175);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(6, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "CVR";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cvrbox
			// 
			this.cvrbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cvrbox.Location = new System.Drawing.Point(135, 28);
			this.cvrbox.Name = "cvrbox";
			this.cvrbox.Size = new System.Drawing.Size(200, 29);
			this.cvrbox.TabIndex = 0;
			// 
			// zipcodebox
			// 
			this.zipcodebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.zipcodebox.Location = new System.Drawing.Point(135, 133);
			this.zipcodebox.Name = "zipcodebox";
			this.zipcodebox.Size = new System.Drawing.Size(200, 29);
			this.zipcodebox.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label8.Location = new System.Drawing.Point(6, 133);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(124, 29);
			this.label8.TabIndex = 0;
			this.label8.Text = "Postnummer";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// citybox
			// 
			this.citybox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.citybox.Location = new System.Drawing.Point(135, 98);
			this.citybox.Name = "citybox";
			this.citybox.Size = new System.Drawing.Size(200, 29);
			this.citybox.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label7.Location = new System.Drawing.Point(6, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 29);
			this.label7.TabIndex = 0;
			this.label7.Text = "By";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// addressbox
			// 
			this.addressbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addressbox.Location = new System.Drawing.Point(135, 63);
			this.addressbox.Name = "addressbox";
			this.addressbox.Size = new System.Drawing.Size(200, 29);
			this.addressbox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label1.Location = new System.Drawing.Point(6, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adresse";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(432, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.availablebox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.emailbox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.directnumberbox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.phonenumberbox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.contactnamebox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(13, 190);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(341, 204);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kontaktinformation";
			// 
			// availablebox
			// 
			this.availablebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.availablebox.Location = new System.Drawing.Point(135, 167);
			this.availablebox.Name = "availablebox";
			this.availablebox.Size = new System.Drawing.Size(200, 29);
			this.availablebox.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label9.Location = new System.Drawing.Point(6, 167);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 29);
			this.label9.TabIndex = 2;
			this.label9.Text = "Træffetid";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// emailbox
			// 
			this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.emailbox.Location = new System.Drawing.Point(135, 132);
			this.emailbox.Name = "emailbox";
			this.emailbox.Size = new System.Drawing.Size(200, 29);
			this.emailbox.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label6.Location = new System.Drawing.Point(6, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 29);
			this.label6.TabIndex = 2;
			this.label6.Text = "Email";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// directnumberbox
			// 
			this.directnumberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.directnumberbox.Location = new System.Drawing.Point(135, 98);
			this.directnumberbox.Name = "directnumberbox";
			this.directnumberbox.Size = new System.Drawing.Size(200, 29);
			this.directnumberbox.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label5.Location = new System.Drawing.Point(6, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 29);
			this.label5.TabIndex = 3;
			this.label5.Text = "Direkte nummer";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// phonenumberbox
			// 
			this.phonenumberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.phonenumberbox.Location = new System.Drawing.Point(135, 63);
			this.phonenumberbox.Name = "phonenumberbox";
			this.phonenumberbox.Size = new System.Drawing.Size(200, 29);
			this.phonenumberbox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.Location = new System.Drawing.Point(6, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 29);
			this.label4.TabIndex = 4;
			this.label4.Text = "Telefonnummer";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// contactnamebox
			// 
			this.contactnamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.contactnamebox.Location = new System.Drawing.Point(135, 28);
			this.contactnamebox.Name = "contactnamebox";
			this.contactnamebox.Size = new System.Drawing.Size(200, 29);
			this.contactnamebox.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.Location = new System.Drawing.Point(6, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "Kontaktperson";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// addbtn
			// 
			this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addbtn.Location = new System.Drawing.Point(432, 215);
			this.addbtn.Name = "addbtn";
			this.addbtn.Size = new System.Drawing.Size(120, 65);
			this.addbtn.TabIndex = 2;
			this.addbtn.Text = "Tilføj";
			this.addbtn.UseVisualStyleBackColor = false;
			this.addbtn.Click += new System.EventHandler(this.AddbtnClick);
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Location = new System.Drawing.Point(432, 311);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(120, 65);
			this.exitbtn.TabIndex = 3;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// AddressAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 402);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.addbtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AddressAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddressAdd";
			this.Load += new System.EventHandler(this.AddressAddLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

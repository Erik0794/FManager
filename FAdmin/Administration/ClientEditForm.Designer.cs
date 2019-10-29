/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 07-04-2017
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FAdmin.Administration
{
	partial class ClientEditForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button getinfobtn;
		private System.Windows.Forms.Button deletebtn;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.Button editinfobtn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox customernobox;
		private System.Windows.Forms.CheckBox company;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox emailbox;
		private System.Windows.Forms.TextBox directnumberbox;
		private System.Windows.Forms.TextBox phonenumberbox;
		private System.Windows.Forms.TextBox citynamebox;
		private System.Windows.Forms.TextBox zipcodebox;
		private System.Windows.Forms.TextBox contactnamebox;
		private System.Windows.Forms.TextBox cvrbox;
		private System.Windows.Forms.TextBox customernamebox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox addressbox;
		private System.Windows.Forms.Label label10;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEditForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.customernobox = new System.Windows.Forms.TextBox();
			this.company = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.getinfobtn = new System.Windows.Forms.Button();
			this.deletebtn = new System.Windows.Forms.Button();
			this.exitbtn = new System.Windows.Forms.Button();
			this.editinfobtn = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.emailbox = new System.Windows.Forms.TextBox();
			this.directnumberbox = new System.Windows.Forms.TextBox();
			this.phonenumberbox = new System.Windows.Forms.TextBox();
			this.citynamebox = new System.Windows.Forms.TextBox();
			this.zipcodebox = new System.Windows.Forms.TextBox();
			this.addressbox = new System.Windows.Forms.TextBox();
			this.contactnamebox = new System.Windows.Forms.TextBox();
			this.cvrbox = new System.Windows.Forms.TextBox();
			this.customernamebox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(856, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(459, 541);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tilmeldte Kunder";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(453, 513);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.customernobox);
			this.groupBox2.Controls.Add(this.company);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.getinfobtn);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.Location = new System.Drawing.Point(484, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(349, 119);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kundeinfo";
			// 
			// customernobox
			// 
			this.customernobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.customernobox.Location = new System.Drawing.Point(134, 33);
			this.customernobox.Name = "customernobox";
			this.customernobox.Size = new System.Drawing.Size(200, 29);
			this.customernobox.TabIndex = 1;
			// 
			// company
			// 
			this.company.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.company.Location = new System.Drawing.Point(134, 77);
			this.company.Name = "company";
			this.company.Size = new System.Drawing.Size(104, 24);
			this.company.TabIndex = 12;
			this.company.Text = "Firma";
			this.company.UseVisualStyleBackColor = true;
			this.company.CheckedChanged += new System.EventHandler(this.CompanyCheckedChanged);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(6, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kundenummer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// getinfobtn
			// 
			this.getinfobtn.BackColor = System.Drawing.Color.White;
			this.getinfobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getinfobtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.getinfobtn.Location = new System.Drawing.Point(247, 68);
			this.getinfobtn.Name = "getinfobtn";
			this.getinfobtn.Size = new System.Drawing.Size(87, 41);
			this.getinfobtn.TabIndex = 10;
			this.getinfobtn.Text = "&Hent Info";
			this.getinfobtn.UseVisualStyleBackColor = false;
			this.getinfobtn.Click += new System.EventHandler(this.GetinfobtnClick);
			// 
			// deletebtn
			// 
			this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.deletebtn.Location = new System.Drawing.Point(866, 253);
			this.deletebtn.Name = "deletebtn";
			this.deletebtn.Size = new System.Drawing.Size(120, 65);
			this.deletebtn.TabIndex = 10;
			this.deletebtn.Text = "&Fjern Bruger";
			this.deletebtn.UseVisualStyleBackColor = false;
			this.deletebtn.Click += new System.EventHandler(this.DeletebtnClick);
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.exitbtn.Location = new System.Drawing.Point(876, 489);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(120, 65);
			this.exitbtn.TabIndex = 10;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// editinfobtn
			// 
			this.editinfobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.editinfobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editinfobtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.editinfobtn.Location = new System.Drawing.Point(866, 170);
			this.editinfobtn.Name = "editinfobtn";
			this.editinfobtn.Size = new System.Drawing.Size(120, 65);
			this.editinfobtn.TabIndex = 10;
			this.editinfobtn.Text = "&Rediger Info";
			this.editinfobtn.UseVisualStyleBackColor = false;
			this.editinfobtn.Click += new System.EventHandler(this.EditinfobtnClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.emailbox);
			this.groupBox3.Controls.Add(this.directnumberbox);
			this.groupBox3.Controls.Add(this.phonenumberbox);
			this.groupBox3.Controls.Add(this.citynamebox);
			this.groupBox3.Controls.Add(this.zipcodebox);
			this.groupBox3.Controls.Add(this.addressbox);
			this.groupBox3.Controls.Add(this.contactnamebox);
			this.groupBox3.Controls.Add(this.cvrbox);
			this.groupBox3.Controls.Add(this.customernamebox);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox3.Location = new System.Drawing.Point(484, 138);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(349, 416);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Oplysninger";
			// 
			// emailbox
			// 
			this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.emailbox.Location = new System.Drawing.Point(134, 313);
			this.emailbox.Name = "emailbox";
			this.emailbox.Size = new System.Drawing.Size(200, 29);
			this.emailbox.TabIndex = 10;
			// 
			// directnumberbox
			// 
			this.directnumberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.directnumberbox.Location = new System.Drawing.Point(134, 278);
			this.directnumberbox.Name = "directnumberbox";
			this.directnumberbox.Size = new System.Drawing.Size(200, 29);
			this.directnumberbox.TabIndex = 11;
			// 
			// phonenumberbox
			// 
			this.phonenumberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.phonenumberbox.Location = new System.Drawing.Point(134, 243);
			this.phonenumberbox.Name = "phonenumberbox";
			this.phonenumberbox.Size = new System.Drawing.Size(200, 29);
			this.phonenumberbox.TabIndex = 12;
			// 
			// citynamebox
			// 
			this.citynamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.citynamebox.Location = new System.Drawing.Point(134, 208);
			this.citynamebox.Name = "citynamebox";
			this.citynamebox.Size = new System.Drawing.Size(200, 29);
			this.citynamebox.TabIndex = 13;
			// 
			// zipcodebox
			// 
			this.zipcodebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.zipcodebox.Location = new System.Drawing.Point(134, 173);
			this.zipcodebox.Name = "zipcodebox";
			this.zipcodebox.Size = new System.Drawing.Size(200, 29);
			this.zipcodebox.TabIndex = 14;
			// 
			// addressbox
			// 
			this.addressbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addressbox.Location = new System.Drawing.Point(134, 138);
			this.addressbox.Name = "addressbox";
			this.addressbox.Size = new System.Drawing.Size(200, 29);
			this.addressbox.TabIndex = 15;
			// 
			// contactnamebox
			// 
			this.contactnamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.contactnamebox.Location = new System.Drawing.Point(134, 103);
			this.contactnamebox.Name = "contactnamebox";
			this.contactnamebox.Size = new System.Drawing.Size(200, 29);
			this.contactnamebox.TabIndex = 15;
			// 
			// cvrbox
			// 
			this.cvrbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cvrbox.Location = new System.Drawing.Point(134, 68);
			this.cvrbox.Name = "cvrbox";
			this.cvrbox.Size = new System.Drawing.Size(200, 29);
			this.cvrbox.TabIndex = 16;
			this.cvrbox.Visible = false;
			// 
			// customernamebox
			// 
			this.customernamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.customernamebox.Location = new System.Drawing.Point(134, 33);
			this.customernamebox.Name = "customernamebox";
			this.customernamebox.Size = new System.Drawing.Size(200, 29);
			this.customernamebox.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Location = new System.Drawing.Point(6, 313);
			this.label9.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(125, 29);
			this.label9.TabIndex = 2;
			this.label9.Text = "Email";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Location = new System.Drawing.Point(6, 138);
			this.label10.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(125, 29);
			this.label10.TabIndex = 4;
			this.label10.Text = "Adresse";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Location = new System.Drawing.Point(6, 278);
			this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 29);
			this.label8.TabIndex = 3;
			this.label8.Text = "Direkte Nummer";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(6, 103);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 29);
			this.label4.TabIndex = 4;
			this.label4.Text = "Kontaktperson";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(6, 243);
			this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(125, 29);
			this.label7.TabIndex = 5;
			this.label7.Text = "Telefonnummer";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(6, 68);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "CVR";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Visible = false;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(6, 208);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 29);
			this.label6.TabIndex = 7;
			this.label6.Text = "By";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(6, 33);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 29);
			this.label2.TabIndex = 8;
			this.label2.Text = "Kundenavn";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(6, 173);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 29);
			this.label5.TabIndex = 9;
			this.label5.Text = "Postnummer";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UserEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 566);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.editinfobtn);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.deletebtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "UserEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UserEditForm";
			this.Load += new System.EventHandler(this.UserEditFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

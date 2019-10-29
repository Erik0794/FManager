/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 07-04-2017
 * Time: 16:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FAdmin.Administration
{
	partial class UserMakeForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox directnumberbox;
		private System.Windows.Forms.TextBox phonenumberbox;
		private System.Windows.Forms.TextBox citynamebox;
		private System.Windows.Forms.TextBox zipcodebox;
		private System.Windows.Forms.TextBox addressbox;
		private System.Windows.Forms.TextBox contactnamebox;
		private System.Windows.Forms.TextBox cvrbox;
		private System.Windows.Forms.TextBox customernamebox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.Button createbtn;
		private System.Windows.Forms.TextBox emailbox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMakeForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.emailbox = new System.Windows.Forms.TextBox();
			this.directnumberbox = new System.Windows.Forms.TextBox();
			this.phonenumberbox = new System.Windows.Forms.TextBox();
			this.citynamebox = new System.Windows.Forms.TextBox();
			this.zipcodebox = new System.Windows.Forms.TextBox();
			this.addressbox = new System.Windows.Forms.TextBox();
			this.contactnamebox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.exitbtn = new System.Windows.Forms.Button();
			this.createbtn = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.cvrbox = new System.Windows.Forms.TextBox();
			this.customernamebox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(392, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.emailbox);
			this.groupBox1.Controls.Add(this.directnumberbox);
			this.groupBox1.Controls.Add(this.phonenumberbox);
			this.groupBox1.Controls.Add(this.citynamebox);
			this.groupBox1.Controls.Add(this.zipcodebox);
			this.groupBox1.Controls.Add(this.addressbox);
			this.groupBox1.Controls.Add(this.contactnamebox);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.groupBox1.Location = new System.Drawing.Point(12, 127);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 308);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informationer";
			// 
			// emailbox
			// 
			this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.emailbox.Location = new System.Drawing.Point(152, 268);
			this.emailbox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.emailbox.Name = "emailbox";
			this.emailbox.Size = new System.Drawing.Size(200, 29);
			this.emailbox.TabIndex = 8;
			// 
			// directnumberbox
			// 
			this.directnumberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.directnumberbox.Location = new System.Drawing.Point(152, 228);
			this.directnumberbox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.directnumberbox.Name = "directnumberbox";
			this.directnumberbox.Size = new System.Drawing.Size(200, 29);
			this.directnumberbox.TabIndex = 8;
			// 
			// phonenumberbox
			// 
			this.phonenumberbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.phonenumberbox.Location = new System.Drawing.Point(152, 188);
			this.phonenumberbox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.phonenumberbox.Name = "phonenumberbox";
			this.phonenumberbox.Size = new System.Drawing.Size(200, 29);
			this.phonenumberbox.TabIndex = 8;
			// 
			// citynamebox
			// 
			this.citynamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.citynamebox.Location = new System.Drawing.Point(152, 148);
			this.citynamebox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.citynamebox.Name = "citynamebox";
			this.citynamebox.Size = new System.Drawing.Size(200, 29);
			this.citynamebox.TabIndex = 8;
			// 
			// zipcodebox
			// 
			this.zipcodebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.zipcodebox.Location = new System.Drawing.Point(152, 108);
			this.zipcodebox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.zipcodebox.Name = "zipcodebox";
			this.zipcodebox.Size = new System.Drawing.Size(200, 29);
			this.zipcodebox.TabIndex = 8;
			// 
			// addressbox
			// 
			this.addressbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addressbox.Location = new System.Drawing.Point(152, 68);
			this.addressbox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.addressbox.Name = "addressbox";
			this.addressbox.Size = new System.Drawing.Size(200, 29);
			this.addressbox.TabIndex = 8;
			// 
			// contactnamebox
			// 
			this.contactnamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.contactnamebox.Location = new System.Drawing.Point(152, 28);
			this.contactnamebox.Name = "contactnamebox";
			this.contactnamebox.Size = new System.Drawing.Size(200, 29);
			this.contactnamebox.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Location = new System.Drawing.Point(6, 268);
			this.label9.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(145, 29);
			this.label9.TabIndex = 7;
			this.label9.Text = "Email";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Location = new System.Drawing.Point(6, 228);
			this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(145, 29);
			this.label8.TabIndex = 7;
			this.label8.Text = "Direkte Nummer";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(6, 188);
			this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145, 29);
			this.label7.TabIndex = 6;
			this.label7.Text = "Telefonnummer";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(6, 148);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 29);
			this.label6.TabIndex = 5;
			this.label6.Text = "By";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(6, 108);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Postnummer";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(6, 68);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Adresse";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(6, 28);
			this.label3.Margin = new System.Windows.Forms.Padding(3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kontaktperson";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.exitbtn.Location = new System.Drawing.Point(333, 445);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(125, 65);
			this.exitbtn.TabIndex = 9;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// createbtn
			// 
			this.createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.createbtn.Location = new System.Drawing.Point(99, 445);
			this.createbtn.Name = "createbtn";
			this.createbtn.Size = new System.Drawing.Size(125, 65);
			this.createbtn.TabIndex = 10;
			this.createbtn.Text = "Godkend";
			this.createbtn.UseVisualStyleBackColor = false;
			this.createbtn.Click += new System.EventHandler(this.CreatebtnClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Controls.Add(this.cvrbox);
			this.groupBox2.Controls.Add(this.customernamebox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.groupBox2.Location = new System.Drawing.Point(13, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(362, 117);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kundenavn/Firmanavn";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(281, 90);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(69, 22);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Firma";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// cvrbox
			// 
			this.cvrbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cvrbox.Location = new System.Drawing.Point(152, 57);
			this.cvrbox.Name = "cvrbox";
			this.cvrbox.Size = new System.Drawing.Size(200, 29);
			this.cvrbox.TabIndex = 11;
			this.cvrbox.Visible = false;
			// 
			// customernamebox
			// 
			this.customernamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.customernamebox.Location = new System.Drawing.Point(152, 25);
			this.customernamebox.Name = "customernamebox";
			this.customernamebox.Size = new System.Drawing.Size(200, 29);
			this.customernamebox.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(6, 57);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 29);
			this.label2.TabIndex = 10;
			this.label2.Text = "CVR";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 29);
			this.label1.TabIndex = 9;
			this.label1.Text = "Kundenavn";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UserMakeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 522);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.createbtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "UserMakeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tilføj Bruger";
			this.Load += new System.EventHandler(this.UserMakeFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

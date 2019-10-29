/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 10-04-2017
 * Time: 12:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FAdmin.Clients
{
	partial class Afhentning
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox bigcarbox;
		private System.Windows.Forms.TextBox smallcarbox;
		private System.Windows.Forms.TextBox burebox;
		private System.Windows.Forms.TextBox pallebox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.Button addbtn;
		private System.Windows.Forms.Button delbtn;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button getbtn;
		private System.Windows.Forms.TextBox cvrbox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Afhentning));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.bigcarbox = new System.Windows.Forms.TextBox();
			this.smallcarbox = new System.Windows.Forms.TextBox();
			this.burebox = new System.Windows.Forms.TextBox();
			this.pallebox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.exitbtn = new System.Windows.Forms.Button();
			this.addbtn = new System.Windows.Forms.Button();
			this.delbtn = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.getbtn = new System.Windows.Forms.Button();
			this.cvrbox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(221, 263);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kundeinformation";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.label8.Location = new System.Drawing.Point(14, 228);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(175, 25);
			this.label8.TabIndex = 7;
			this.label8.Text = "Email";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.label7.Location = new System.Drawing.Point(14, 199);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(175, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "Telefonnummer";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.label6.Location = new System.Drawing.Point(14, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(175, 25);
			this.label6.TabIndex = 5;
			this.label6.Text = "Kontaktperson";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.label5.Location = new System.Drawing.Point(14, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(175, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "By";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.label4.Location = new System.Drawing.Point(14, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Postnummer";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.label3.Location = new System.Drawing.Point(14, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Adresse";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.label2.Location = new System.Drawing.Point(14, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "CVR";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.label1.Location = new System.Drawing.Point(14, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Firma";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.bigcarbox);
			this.groupBox2.Controls.Add(this.smallcarbox);
			this.groupBox2.Controls.Add(this.burebox);
			this.groupBox2.Controls.Add(this.pallebox);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.Location = new System.Drawing.Point(246, 76);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(253, 200);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Afhentingsinformation";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 28);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(240, 29);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "Adresse";
			// 
			// bigcarbox
			// 
			this.bigcarbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bigcarbox.Location = new System.Drawing.Point(149, 144);
			this.bigcarbox.Name = "bigcarbox";
			this.bigcarbox.Size = new System.Drawing.Size(97, 29);
			this.bigcarbox.TabIndex = 4;
			// 
			// smallcarbox
			// 
			this.smallcarbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.smallcarbox.Location = new System.Drawing.Point(149, 116);
			this.smallcarbox.Name = "smallcarbox";
			this.smallcarbox.Size = new System.Drawing.Size(97, 29);
			this.smallcarbox.TabIndex = 3;
			// 
			// burebox
			// 
			this.burebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.burebox.Location = new System.Drawing.Point(149, 88);
			this.burebox.Name = "burebox";
			this.burebox.Size = new System.Drawing.Size(97, 29);
			this.burebox.TabIndex = 2;
			// 
			// pallebox
			// 
			this.pallebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pallebox.Location = new System.Drawing.Point(149, 60);
			this.pallebox.Name = "pallebox";
			this.pallebox.Size = new System.Drawing.Size(97, 29);
			this.pallebox.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Location = new System.Drawing.Point(6, 144);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(144, 29);
			this.label12.TabIndex = 3;
			this.label12.Text = "Oprydning, Stor Bil";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Location = new System.Drawing.Point(6, 116);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(144, 29);
			this.label11.TabIndex = 2;
			this.label11.Text = "Oprydning, Lille bil";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Location = new System.Drawing.Point(6, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 29);
			this.label10.TabIndex = 1;
			this.label10.Text = "Antal Bure";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Location = new System.Drawing.Point(6, 60);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(144, 29);
			this.label9.TabIndex = 0;
			this.label9.Text = "Antal Paller";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 282);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(838, 436);
			this.dataGridView1.TabIndex = 2;
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.exitbtn.Location = new System.Drawing.Point(876, 653);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(120, 65);
			this.exitbtn.TabIndex = 5;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// addbtn
			// 
			this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.addbtn.Location = new System.Drawing.Point(876, 136);
			this.addbtn.Name = "addbtn";
			this.addbtn.Size = new System.Drawing.Size(120, 65);
			this.addbtn.TabIndex = 3;
			this.addbtn.Text = "&Opret Afhentning";
			this.addbtn.UseVisualStyleBackColor = false;
			this.addbtn.Click += new System.EventHandler(this.AddbtnClick);
			// 
			// delbtn
			// 
			this.delbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.delbtn.Location = new System.Drawing.Point(876, 241);
			this.delbtn.Name = "delbtn";
			this.delbtn.Size = new System.Drawing.Size(120, 65);
			this.delbtn.TabIndex = 4;
			this.delbtn.Text = "&Fjern Afhentning";
			this.delbtn.UseVisualStyleBackColor = false;
			this.delbtn.Click += new System.EventHandler(this.DelbtnClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.getbtn);
			this.groupBox3.Controls.Add(this.cvrbox);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox3.Location = new System.Drawing.Point(246, 13);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(253, 61);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Firmainfo";
			// 
			// getbtn
			// 
			this.getbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.getbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getbtn.Location = new System.Drawing.Point(185, 19);
			this.getbtn.Name = "getbtn";
			this.getbtn.Size = new System.Drawing.Size(61, 33);
			this.getbtn.TabIndex = 2;
			this.getbtn.Text = "&Hent";
			this.getbtn.UseVisualStyleBackColor = false;
			this.getbtn.Click += new System.EventHandler(this.GetbtnClick);
			// 
			// cvrbox
			// 
			this.cvrbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cvrbox.Location = new System.Drawing.Point(48, 21);
			this.cvrbox.Name = "cvrbox";
			this.cvrbox.Size = new System.Drawing.Size(130, 29);
			this.cvrbox.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Location = new System.Drawing.Point(6, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(43, 29);
			this.label13.TabIndex = 0;
			this.label13.Text = "CVR";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox6);
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox4.Location = new System.Drawing.Point(506, 13);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(344, 263);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Bemærkning";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(7, 29);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(331, 224);
			this.textBox6.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(856, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// Afhentning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.delbtn);
			this.Controls.Add(this.addbtn);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.Name = "Afhentning";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Afhentning";
			this.Load += new System.EventHandler(this.AfhentningLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

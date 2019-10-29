/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 31-03-2017
 * Time: 08:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FAdmin.Clients
{
	partial class SBAdresser
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button getbtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox cvrbox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.Button createbtn;
		private System.Windows.Forms.Button editbtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label companyname;
		private System.Windows.Forms.Label label2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBAdresser));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.getbtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cvrbox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.exitbtn = new System.Windows.Forms.Button();
			this.createbtn = new System.Windows.Forms.Button();
			this.editbtn = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.companyname = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.getbtn);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cvrbox);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(265, 128);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// getbtn
			// 
			this.getbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.getbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getbtn.Location = new System.Drawing.Point(159, 72);
			this.getbtn.Name = "getbtn";
			this.getbtn.Size = new System.Drawing.Size(100, 50);
			this.getbtn.TabIndex = 2;
			this.getbtn.Text = "&Hent Info";
			this.getbtn.UseVisualStyleBackColor = false;
			this.getbtn.Click += new System.EventHandler(this.GetbtnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "CVR Nummer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cvrbox
			// 
			this.cvrbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cvrbox.Location = new System.Drawing.Point(129, 28);
			this.cvrbox.Name = "cvrbox";
			this.cvrbox.Size = new System.Drawing.Size(130, 29);
			this.cvrbox.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(432, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 246);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(559, 204);
			this.dataGridView1.TabIndex = 8;
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.exitbtn.Location = new System.Drawing.Point(447, 175);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(125, 65);
			this.exitbtn.TabIndex = 9;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// createbtn
			// 
			this.createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.createbtn.Location = new System.Drawing.Point(292, 35);
			this.createbtn.Name = "createbtn";
			this.createbtn.Size = new System.Drawing.Size(125, 65);
			this.createbtn.TabIndex = 9;
			this.createbtn.Text = "&Opret Adresse";
			this.createbtn.UseVisualStyleBackColor = false;
			this.createbtn.Click += new System.EventHandler(this.CreatebtnClick);
			// 
			// editbtn
			// 
			this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.editbtn.Location = new System.Drawing.Point(292, 117);
			this.editbtn.Name = "editbtn";
			this.editbtn.Size = new System.Drawing.Size(125, 65);
			this.editbtn.TabIndex = 9;
			this.editbtn.Text = "&Rediger Adresse";
			this.editbtn.UseVisualStyleBackColor = false;
			this.editbtn.Click += new System.EventHandler(this.EditbtnClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.companyname);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.Location = new System.Drawing.Point(13, 141);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 41);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			// 
			// companyname
			// 
			this.companyname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
			this.companyname.ForeColor = System.Drawing.Color.RoyalBlue;
			this.companyname.Location = new System.Drawing.Point(102, 15);
			this.companyname.Name = "companyname";
			this.companyname.Size = new System.Drawing.Size(156, 23);
			this.companyname.TabIndex = 1;
			this.companyname.Text = "Firma A/S";
			this.companyname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(6, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Firmanavn:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SBAdresser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 462);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.editbtn);
			this.Controls.Add(this.createbtn);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "SBAdresser";
			this.Text = "SBAdresser";
			this.Load += new System.EventHandler(this.SBAdresserLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

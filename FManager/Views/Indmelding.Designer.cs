/*
 * Created by SharpDevelop.
 * User: DemiGod
 * Date: 27-11-2016
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FManager.Views
{
	partial class Indmelding
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox orderidbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox placemenu;
		private System.Windows.Forms.ComboBox typemenu;
		private System.Windows.Forms.ComboBox brandmenu;
		private System.Windows.Forms.TextBox serialnobox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox weightbox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button nextbtn;
		private System.Windows.Forms.Button pausebtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button deletebtn;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.Button resetbtn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox modelbox;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indmelding));
			this.orderidbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.placemenu = new System.Windows.Forms.ComboBox();
			this.typemenu = new System.Windows.Forms.ComboBox();
			this.brandmenu = new System.Windows.Forms.ComboBox();
			this.serialnobox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.weightbox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.nextbtn = new System.Windows.Forms.Button();
			this.pausebtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.modelbox = new System.Windows.Forms.TextBox();
			this.resetbtn = new System.Windows.Forms.Button();
			this.deletebtn = new System.Windows.Forms.Button();
			this.exitbtn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// orderidbox
			// 
			this.orderidbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.orderidbox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.orderidbox.Location = new System.Drawing.Point(6, 28);
			this.orderidbox.Name = "orderidbox";
			this.orderidbox.Size = new System.Drawing.Size(275, 29);
			this.orderidbox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label1.Location = new System.Drawing.Point(288, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bur ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// placemenu
			// 
			this.placemenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.placemenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.placemenu.Cursor = System.Windows.Forms.Cursors.Default;
			this.placemenu.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.placemenu.Items.AddRange(new object[] {
			"Hardware",
			"IT",
			"Media",
			"Medico",
			"Network"});
			this.placemenu.Location = new System.Drawing.Point(6, 136);
			this.placemenu.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
			this.placemenu.Name = "placemenu";
			this.placemenu.Size = new System.Drawing.Size(275, 29);
			this.placemenu.Sorted = true;
			this.placemenu.TabIndex = 3;
			this.placemenu.Text = "    ==Gruppe==";
			this.placemenu.SelectedIndexChanged += new System.EventHandler(this.PlacemenuSelectedIndexChanged);
			// 
			// typemenu
			// 
			this.typemenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.typemenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.typemenu.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.typemenu.Location = new System.Drawing.Point(6, 171);
			this.typemenu.Name = "typemenu";
			this.typemenu.Size = new System.Drawing.Size(275, 29);
			this.typemenu.TabIndex = 4;
			this.typemenu.Text = "    ==Type==";
			// 
			// brandmenu
			// 
			this.brandmenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.brandmenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.brandmenu.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.brandmenu.Location = new System.Drawing.Point(6, 206);
			this.brandmenu.Name = "brandmenu";
			this.brandmenu.Size = new System.Drawing.Size(275, 29);
			this.brandmenu.TabIndex = 5;
			this.brandmenu.Text = "    ==Mærke==";
			// 
			// serialnobox
			// 
			this.serialnobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.serialnobox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.serialnobox.Location = new System.Drawing.Point(6, 67);
			this.serialnobox.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
			this.serialnobox.Name = "serialnobox";
			this.serialnobox.Size = new System.Drawing.Size(275, 29);
			this.serialnobox.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label5.Location = new System.Drawing.Point(287, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 29);
			this.label5.TabIndex = 9;
			this.label5.Text = "Serienummer";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// weightbox
			// 
			this.weightbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.weightbox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.weightbox.Location = new System.Drawing.Point(6, 101);
			this.weightbox.Name = "weightbox";
			this.weightbox.Size = new System.Drawing.Size(275, 29);
			this.weightbox.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label6.Location = new System.Drawing.Point(287, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 29);
			this.label6.TabIndex = 11;
			this.label6.Text = "Vægt";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 315);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(984, 400);
			this.dataGridView1.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(856, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// nextbtn
			// 
			this.nextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nextbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.nextbtn.Location = new System.Drawing.Point(510, 220);
			this.nextbtn.Name = "nextbtn";
			this.nextbtn.Size = new System.Drawing.Size(120, 65);
			this.nextbtn.TabIndex = 1;
			this.nextbtn.Text = "Næste vare";
			this.nextbtn.UseVisualStyleBackColor = false;
			this.nextbtn.Click += new System.EventHandler(this.nextbtnClick);
			// 
			// pausebtn
			// 
			this.pausebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pausebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pausebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.pausebtn.Location = new System.Drawing.Point(876, 173);
			this.pausebtn.Name = "pausebtn";
			this.pausebtn.Size = new System.Drawing.Size(120, 65);
			this.pausebtn.TabIndex = 4;
			this.pausebtn.Text = "Pause";
			this.pausebtn.UseVisualStyleBackColor = false;
			this.pausebtn.Click += new System.EventHandler(this.pausebtnClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.modelbox);
			this.groupBox1.Controls.Add(this.resetbtn);
			this.groupBox1.Controls.Add(this.orderidbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.placemenu);
			this.groupBox1.Controls.Add(this.typemenu);
			this.groupBox1.Controls.Add(this.brandmenu);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.serialnobox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.weightbox);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(475, 300);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(287, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 29);
			this.label2.TabIndex = 13;
			this.label2.Text = "Model";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// modelbox
			// 
			this.modelbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.modelbox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.modelbox.Location = new System.Drawing.Point(6, 241);
			this.modelbox.Name = "modelbox";
			this.modelbox.Size = new System.Drawing.Size(275, 29);
			this.modelbox.TabIndex = 6;
			// 
			// resetbtn
			// 
			this.resetbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.resetbtn.Location = new System.Drawing.Point(364, 18);
			this.resetbtn.Name = "resetbtn";
			this.resetbtn.Size = new System.Drawing.Size(105, 45);
			this.resetbtn.TabIndex = 7;
			this.resetbtn.Text = "Nyt Bur";
			this.resetbtn.UseVisualStyleBackColor = false;
			this.resetbtn.Click += new System.EventHandler(this.resetbtnClick);
			// 
			// deletebtn
			// 
			this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.deletebtn.Location = new System.Drawing.Point(680, 220);
			this.deletebtn.Name = "deletebtn";
			this.deletebtn.Size = new System.Drawing.Size(120, 65);
			this.deletebtn.TabIndex = 3;
			this.deletebtn.Text = "Fortryd";
			this.deletebtn.UseVisualStyleBackColor = false;
			this.deletebtn.Click += new System.EventHandler(this.deletebtnClick);
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.exitbtn.Location = new System.Drawing.Point(876, 244);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(120, 65);
			this.exitbtn.TabIndex = 5;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.exitbtnClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.button1.Location = new System.Drawing.Point(680, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 65);
			this.button1.TabIndex = 2;
			this.button1.Text = "Fjern vare";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Indmelding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.deletebtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pausebtn);
			this.Controls.Add(this.nextbtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Indmelding";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Indmelding";
			this.Load += new System.EventHandler(this.IndmeldingLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

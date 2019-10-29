/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 25-02-2017
 * Time: 17:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FManager.TestViews
{
	partial class ScreenTest
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button StatusBtnDEF;
		private System.Windows.Forms.Button StatusBtnOK;
		private System.Windows.Forms.Button pauseBtn;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.TextBox notebox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox screensizebox;
		private System.Windows.Forms.TextBox idbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox modelbox;
		private System.Windows.Forms.TextBox serialbox;
		private System.Windows.Forms.TextBox brandbox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button deletebtn;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenTest));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.deletebtn = new System.Windows.Forms.Button();
			this.StatusBtnDEF = new System.Windows.Forms.Button();
			this.StatusBtnOK = new System.Windows.Forms.Button();
			this.pauseBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.notebox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.screensizebox = new System.Windows.Forms.TextBox();
			this.idbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.modelbox = new System.Windows.Forms.TextBox();
			this.serialbox = new System.Windows.Forms.TextBox();
			this.brandbox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.comboBox3);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.deletebtn);
			this.groupBox2.Controls.Add(this.StatusBtnDEF);
			this.groupBox2.Controls.Add(this.StatusBtnOK);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.Location = new System.Drawing.Point(473, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(325, 306);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Status";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label13.Location = new System.Drawing.Point(164, 94);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(115, 29);
			this.label13.TabIndex = 21;
			this.label13.Text = "Tilbehør";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label12.Location = new System.Drawing.Point(164, 58);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(115, 29);
			this.label12.TabIndex = 22;
			this.label12.Text = "Funktionalitet";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label11.Location = new System.Drawing.Point(164, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(115, 29);
			this.label11.TabIndex = 23;
			this.label11.Text = "Kosmetisk";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
			"Missing feet",
			"Missing Ext. PSU",
			"Ext. PSU incl."});
			this.comboBox3.Location = new System.Drawing.Point(9, 94);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(149, 29);
			this.comboBox3.TabIndex = 18;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"OK",
			"Light Scratches",
			"No boot",
			"Signal error",
			"Pixel error",
			"Pressure marks"});
			this.comboBox1.Location = new System.Drawing.Point(9, 59);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(149, 29);
			this.comboBox1.TabIndex = 19;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"OK",
			"Removed Label",
			"Scratches",
			"Broken Cabinet"});
			this.comboBox2.Location = new System.Drawing.Point(9, 24);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(149, 29);
			this.comboBox2.TabIndex = 20;
			// 
			// deletebtn
			// 
			this.deletebtn.BackColor = System.Drawing.Color.White;
			this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.deletebtn.ForeColor = System.Drawing.Color.Black;
			this.deletebtn.Location = new System.Drawing.Point(103, 235);
			this.deletebtn.Name = "deletebtn";
			this.deletebtn.Size = new System.Drawing.Size(120, 65);
			this.deletebtn.TabIndex = 15;
			this.deletebtn.Text = "&SLET";
			this.deletebtn.UseVisualStyleBackColor = false;
			this.deletebtn.Click += new System.EventHandler(this.DeletebtnClick);
			// 
			// StatusBtnDEF
			// 
			this.StatusBtnDEF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.StatusBtnDEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StatusBtnDEF.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.StatusBtnDEF.Location = new System.Drawing.Point(199, 149);
			this.StatusBtnDEF.Name = "StatusBtnDEF";
			this.StatusBtnDEF.Size = new System.Drawing.Size(120, 65);
			this.StatusBtnDEF.TabIndex = 1;
			this.StatusBtnDEF.Text = "&DEFEKT";
			this.StatusBtnDEF.UseVisualStyleBackColor = false;
			this.StatusBtnDEF.Click += new System.EventHandler(this.StatusBtnDEFClick);
			// 
			// StatusBtnOK
			// 
			this.StatusBtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.StatusBtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StatusBtnOK.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.StatusBtnOK.Location = new System.Drawing.Point(6, 149);
			this.StatusBtnOK.Name = "StatusBtnOK";
			this.StatusBtnOK.Size = new System.Drawing.Size(120, 65);
			this.StatusBtnOK.TabIndex = 0;
			this.StatusBtnOK.Text = "&OK";
			this.StatusBtnOK.UseVisualStyleBackColor = false;
			this.StatusBtnOK.Click += new System.EventHandler(this.StatusBtnOKClick);
			// 
			// pauseBtn
			// 
			this.pauseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pauseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.pauseBtn.Location = new System.Drawing.Point(875, 217);
			this.pauseBtn.Name = "pauseBtn";
			this.pauseBtn.Size = new System.Drawing.Size(120, 65);
			this.pauseBtn.TabIndex = 1;
			this.pauseBtn.Text = "&Pause";
			this.pauseBtn.UseVisualStyleBackColor = false;
			this.pauseBtn.Click += new System.EventHandler(this.PauseBtnClick);
			// 
			// exitBtn
			// 
			this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.exitBtn.Location = new System.Drawing.Point(875, 297);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(120, 65);
			this.exitBtn.TabIndex = 2;
			this.exitBtn.Text = "Afslut";
			this.exitBtn.UseVisualStyleBackColor = false;
			this.exitBtn.Click += new System.EventHandler(this.ExitBtnClick);
			// 
			// notebox
			// 
			this.notebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.notebox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.notebox.Location = new System.Drawing.Point(6, 254);
			this.notebox.Multiline = true;
			this.notebox.Name = "notebox";
			this.notebox.Size = new System.Drawing.Size(384, 87);
			this.notebox.TabIndex = 5;
			this.notebox.Text = "Noter";
			this.notebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.screensizebox);
			this.groupBox1.Controls.Add(this.notebox);
			this.groupBox1.Controls.Add(this.idbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.modelbox);
			this.groupBox1.Controls.Add(this.serialbox);
			this.groupBox1.Controls.Add(this.brandbox);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(397, 349);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// screensizebox
			// 
			this.screensizebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.screensizebox.Location = new System.Drawing.Point(6, 168);
			this.screensizebox.Name = "screensizebox";
			this.screensizebox.Size = new System.Drawing.Size(200, 29);
			this.screensizebox.TabIndex = 4;
			// 
			// idbox
			// 
			this.idbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.idbox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.idbox.Location = new System.Drawing.Point(6, 28);
			this.idbox.Name = "idbox";
			this.idbox.Size = new System.Drawing.Size(200, 29);
			this.idbox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label1.Location = new System.Drawing.Point(212, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label9.Location = new System.Drawing.Point(212, 168);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 29);
			this.label9.TabIndex = 1;
			this.label9.Text = "Størrelse (\'\')";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(212, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mærke";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.Location = new System.Drawing.Point(212, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 29);
			this.label4.TabIndex = 1;
			this.label4.Text = "Serienummer";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.Location = new System.Drawing.Point(211, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 29);
			this.label3.TabIndex = 1;
			this.label3.Text = "Model";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// modelbox
			// 
			this.modelbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.modelbox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.modelbox.Location = new System.Drawing.Point(5, 98);
			this.modelbox.Name = "modelbox";
			this.modelbox.Size = new System.Drawing.Size(200, 29);
			this.modelbox.TabIndex = 2;
			// 
			// serialbox
			// 
			this.serialbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.serialbox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.serialbox.Location = new System.Drawing.Point(6, 133);
			this.serialbox.Name = "serialbox";
			this.serialbox.Size = new System.Drawing.Size(200, 29);
			this.serialbox.TabIndex = 3;
			// 
			// brandbox
			// 
			this.brandbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.brandbox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.brandbox.Location = new System.Drawing.Point(6, 63);
			this.brandbox.Name = "brandbox";
			this.brandbox.Size = new System.Drawing.Size(200, 29);
			this.brandbox.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 368);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(984, 350);
			this.dataGridView1.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(856, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// ScreenTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.pauseBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ScreenTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ScreenTest";
			this.Load += new System.EventHandler(this.ScreenTestLoad);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

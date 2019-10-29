/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 17-02-2017
 * Time: 08:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FManager.Views
{
	partial class Medico
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button nextbtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button clearbtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button deletebtn;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.Button pausebtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medico));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nextbtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.clearbtn = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.deletebtn = new System.Windows.Forms.Button();
			this.exitbtn = new System.Windows.Forms.Button();
			this.pausebtn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 315);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(984, 400);
			this.dataGridView1.TabIndex = 0;
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
			this.nextbtn.Click += new System.EventHandler(this.NextbtnClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.clearbtn);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(475, 272);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label5.Location = new System.Drawing.Point(287, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 29);
			this.label5.TabIndex = 10;
			this.label5.Text = "Klassifikation";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(5, 131);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(275, 29);
			this.textBox4.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.Location = new System.Drawing.Point(287, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 29);
			this.label4.TabIndex = 8;
			this.label4.Text = "Serienummer";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(5, 213);
			this.textBox3.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(275, 29);
			this.textBox3.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.Location = new System.Drawing.Point(287, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mærke";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// clearbtn
			// 
			this.clearbtn.BackColor = System.Drawing.Color.White;
			this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.clearbtn.Location = new System.Drawing.Point(364, 18);
			this.clearbtn.Name = "clearbtn";
			this.clearbtn.Size = new System.Drawing.Size(105, 45);
			this.clearbtn.TabIndex = 5;
			this.clearbtn.Text = "Nyt Bur";
			this.clearbtn.UseVisualStyleBackColor = false;
			this.clearbtn.Click += new System.EventHandler(this.ClearbtnClick);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(5, 172);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(275, 29);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(287, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Type";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Accessories",
			"Diagnostics",
			"Generic",
			"Imaging",
			"Lab Equipment",
			"Measurement"});
			this.comboBox1.Location = new System.Drawing.Point(5, 87);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(275, 29);
			this.comboBox1.Sorted = true;
			this.comboBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label1.Location = new System.Drawing.Point(288, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bur ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBox1.Location = new System.Drawing.Point(5, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(275, 29);
			this.textBox1.TabIndex = 0;
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
			this.deletebtn.Click += new System.EventHandler(this.DeletebtnClick);
			// 
			// exitbtn
			// 
			this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.exitbtn.Location = new System.Drawing.Point(876, 244);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(120, 65);
			this.exitbtn.TabIndex = 5;
			this.exitbtn.Text = "Afslut";
			this.exitbtn.UseVisualStyleBackColor = false;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// pausebtn
			// 
			this.pausebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pausebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pausebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.pausebtn.Location = new System.Drawing.Point(876, 173);
			this.pausebtn.Name = "pausebtn";
			this.pausebtn.Size = new System.Drawing.Size(120, 65);
			this.pausebtn.TabIndex = 4;
			this.pausebtn.Text = "Pause";
			this.pausebtn.UseVisualStyleBackColor = false;
			this.pausebtn.Click += new System.EventHandler(this.PausebtnClick);
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
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
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
			// Medico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pausebtn);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.deletebtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.nextbtn);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Medico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Medico";
			this.Load += new System.EventHandler(this.MedicoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

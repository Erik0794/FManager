/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 03-07-2017
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FAdmin.Administration
{
	partial class EmployeeFiredForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button yourefired;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button yesbtn;
		private System.Windows.Forms.Button nobtn;
		private System.Windows.Forms.Label text;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox namebox;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFiredForm));
			this.yourefired = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.yesbtn = new System.Windows.Forms.Button();
			this.nobtn = new System.Windows.Forms.Button();
			this.text = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.namebox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// yourefired
			// 
			this.yourefired.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yourefired.BackgroundImage")));
			this.yourefired.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.yourefired.Cursor = System.Windows.Forms.Cursors.Hand;
			this.yourefired.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.yourefired.FlatAppearance.BorderSize = 5;
			this.yourefired.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.yourefired.Location = new System.Drawing.Point(212, 390);
			this.yourefired.Name = "yourefired";
			this.yourefired.Size = new System.Drawing.Size(200, 200);
			this.yourefired.TabIndex = 0;
			this.yourefired.UseVisualStyleBackColor = true;
			this.yourefired.Click += new System.EventHandler(this.YourefiredClick);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(599, 70);
			this.label1.TabIndex = 1;
			this.label1.Text = "FYRING AF MEDARBEJDER";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBox1.Location = new System.Drawing.Point(66, 198);
			this.textBox1.MaxLength = 65565;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(493, 152);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(66, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(493, 33);
			this.label2.TabIndex = 3;
			this.label2.Text = "Afskedigelsesgrund";
			// 
			// yesbtn
			// 
			this.yesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.yesbtn.FlatAppearance.BorderSize = 3;
			this.yesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yesbtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.yesbtn.Location = new System.Drawing.Point(119, 439);
			this.yesbtn.Name = "yesbtn";
			this.yesbtn.Size = new System.Drawing.Size(100, 100);
			this.yesbtn.TabIndex = 4;
			this.yesbtn.Text = "JA";
			this.yesbtn.UseVisualStyleBackColor = false;
			this.yesbtn.Visible = false;
			this.yesbtn.Click += new System.EventHandler(this.YesbtnClick);
			// 
			// nobtn
			// 
			this.nobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.nobtn.FlatAppearance.BorderSize = 3;
			this.nobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nobtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.nobtn.Location = new System.Drawing.Point(406, 439);
			this.nobtn.Name = "nobtn";
			this.nobtn.Size = new System.Drawing.Size(100, 100);
			this.nobtn.TabIndex = 4;
			this.nobtn.Text = "NEJ";
			this.nobtn.UseVisualStyleBackColor = false;
			this.nobtn.Visible = false;
			this.nobtn.Click += new System.EventHandler(this.NobtnClick);
			// 
			// text
			// 
			this.text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.text.Location = new System.Drawing.Point(212, 361);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(200, 23);
			this.text.TabIndex = 5;
			this.text.Text = "Er du sikker?";
			this.text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.text.Visible = false;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(66, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "Medarbejder Navn";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// namebox
			// 
			this.namebox.BackColor = System.Drawing.SystemColors.Window;
			this.namebox.Cursor = System.Windows.Forms.Cursors.Default;
			this.namebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.namebox.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.namebox.FormattingEnabled = true;
			this.namebox.Location = new System.Drawing.Point(237, 116);
			this.namebox.Name = "namebox";
			this.namebox.Size = new System.Drawing.Size(322, 29);
			this.namebox.TabIndex = 7;
			// 
			// EmployeeFiredForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 602);
			this.Controls.Add(this.namebox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.text);
			this.Controls.Add(this.nobtn);
			this.Controls.Add(this.yesbtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.yourefired);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "EmployeeFiredForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EmployeeFiredForm";
			this.Load += new System.EventHandler(this.EmployeeFiredFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

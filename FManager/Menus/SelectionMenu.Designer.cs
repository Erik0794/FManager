/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 25-02-2017
 * Time: 12:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FManager.Menus
{
	partial class SelectionMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.button3);
			this.flowLayoutPanel1.Controls.Add(this.button4);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(25, 16, 8, 8);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(631, 141);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(25, 16);
			this.button1.Margin = new System.Windows.Forms.Padding(25, 16, 8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 110);
			this.button1.TabIndex = 0;
			this.button1.Text = "TEST &SKÆRM";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(178, 16);
			this.button2.Margin = new System.Windows.Forms.Padding(25, 16, 8, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 110);
			this.button2.TabIndex = 0;
			this.button2.Text = "TEST &LAPTOP";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(331, 16);
			this.button3.Margin = new System.Windows.Forms.Padding(25, 16, 8, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 110);
			this.button3.TabIndex = 0;
			this.button3.Text = "TEST &DESKTOP";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.button4.Location = new System.Drawing.Point(484, 16);
			this.button4.Margin = new System.Windows.Forms.Padding(25, 16, 8, 8);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 110);
			this.button4.TabIndex = 0;
			this.button4.Text = "TEST &PRINTER";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// SelectionMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 141);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SelectionMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SelectionMenu";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

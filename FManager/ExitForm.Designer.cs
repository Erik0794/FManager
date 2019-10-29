/*
 * Created by SharpDevelop.
 * User: Erik Klint
 * Date: 26-03-2017
 * Time: 12:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FManager
{
	partial class ExitForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button gohomebtn;
		private System.Windows.Forms.Button logoutbtn;
		private System.Windows.Forms.Button cancelbtn;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.gohomebtn = new System.Windows.Forms.Button();
			this.logoutbtn = new System.Windows.Forms.Button();
			this.cancelbtn = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.gohomebtn);
			this.flowLayoutPanel1.Controls.Add(this.logoutbtn);
			this.flowLayoutPanel1.Controls.Add(this.cancelbtn);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(422, 137);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// gohomebtn
			// 
			this.gohomebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.gohomebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gohomebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.gohomebtn.Location = new System.Drawing.Point(10, 8);
			this.gohomebtn.Margin = new System.Windows.Forms.Padding(10, 8, 10, 10);
			this.gohomebtn.Name = "gohomebtn";
			this.gohomebtn.Size = new System.Drawing.Size(120, 120);
			this.gohomebtn.TabIndex = 0;
			this.gohomebtn.Text = "Hold Fri";
			this.gohomebtn.UseVisualStyleBackColor = false;
			this.gohomebtn.Click += new System.EventHandler(this.GohomebtnClick);
			// 
			// logoutbtn
			// 
			this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.logoutbtn.Location = new System.Drawing.Point(150, 8);
			this.logoutbtn.Margin = new System.Windows.Forms.Padding(10, 8, 10, 10);
			this.logoutbtn.Name = "logoutbtn";
			this.logoutbtn.Size = new System.Drawing.Size(120, 120);
			this.logoutbtn.TabIndex = 0;
			this.logoutbtn.Text = "Skift Station";
			this.logoutbtn.UseVisualStyleBackColor = false;
			this.logoutbtn.Click += new System.EventHandler(this.LogoutbtnClick);
			// 
			// cancelbtn
			// 
			this.cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.cancelbtn.Location = new System.Drawing.Point(290, 8);
			this.cancelbtn.Margin = new System.Windows.Forms.Padding(10, 8, 10, 10);
			this.cancelbtn.Name = "cancelbtn";
			this.cancelbtn.Size = new System.Drawing.Size(120, 120);
			this.cancelbtn.TabIndex = 0;
			this.cancelbtn.Text = "Fortryd";
			this.cancelbtn.UseVisualStyleBackColor = false;
			this.cancelbtn.Click += new System.EventHandler(this.CancelbtnClick);
			// 
			// ExitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 137);
			this.ControlBox = false;
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExitForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Valgmuligheder";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ExitFormLoad);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

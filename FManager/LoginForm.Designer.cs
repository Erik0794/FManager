/*
 * Created by SharpDevelop.
 * User: DemiGod
 * Date: 19-10-2016
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FManager
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button loginbtn;
		private System.Windows.Forms.Label IDLabel;
		private System.Windows.Forms.TextBox midbox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label PWDLabel;
		private System.Windows.Forms.TextBox pwdbox;
		private System.Windows.Forms.Label label3;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.loginbtn = new System.Windows.Forms.Button();
			this.IDLabel = new System.Windows.Forms.Label();
			this.midbox = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.PWDLabel = new System.Windows.Forms.Label();
			this.pwdbox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// loginbtn
			// 
			this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginbtn.Location = new System.Drawing.Point(272, 171);
			this.loginbtn.Name = "loginbtn";
			this.loginbtn.Size = new System.Drawing.Size(120, 60);
			this.loginbtn.TabIndex = 2;
			this.loginbtn.Text = "Login";
			this.loginbtn.UseVisualStyleBackColor = false;
			this.loginbtn.Click += new System.EventHandler(this.LoginbtnClick);
			// 
			// IDLabel
			// 
			this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IDLabel.Location = new System.Drawing.Point(13, 49);
			this.IDLabel.Name = "IDLabel";
			this.IDLabel.Size = new System.Drawing.Size(119, 23);
			this.IDLabel.TabIndex = 1;
			this.IDLabel.Text = "Medarbejder ID";
			this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// midbox
			// 
			this.midbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.midbox.Cursor = System.Windows.Forms.Cursors.Default;
			this.midbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.midbox.Location = new System.Drawing.Point(138, 49);
			this.midbox.Name = "midbox";
			this.midbox.Size = new System.Drawing.Size(254, 33);
			this.midbox.TabIndex = 0;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "";
			this.dateTimePicker1.Location = new System.Drawing.Point(394, 22);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(10, 20);
			this.dateTimePicker1.TabIndex = 6;
			this.dateTimePicker1.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// PWDLabel
			// 
			this.PWDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PWDLabel.Location = new System.Drawing.Point(13, 88);
			this.PWDLabel.Name = "PWDLabel";
			this.PWDLabel.Size = new System.Drawing.Size(119, 23);
			this.PWDLabel.TabIndex = 1;
			this.PWDLabel.Text = "Adgangskode";
			this.PWDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pwdbox
			// 
			this.pwdbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pwdbox.Cursor = System.Windows.Forms.Cursors.Default;
			this.pwdbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pwdbox.Location = new System.Drawing.Point(138, 88);
			this.pwdbox.Name = "pwdbox";
			this.pwdbox.PasswordChar = '*';
			this.pwdbox.Size = new System.Drawing.Size(254, 33);
			this.pwdbox.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 137);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(141, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(376, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Date and Time";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginbtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 243);
			this.ControlBox = false;
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pwdbox);
			this.Controls.Add(this.PWDLabel);
			this.Controls.Add(this.midbox);
			this.Controls.Add(this.IDLabel);
			this.Controls.Add(this.loginbtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFormFormClosed);
			this.Load += new System.EventHandler(this.LoginFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}


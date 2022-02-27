/*
 * Created by SharpDevelop.
 * User: Sally
 * Date: 2/26/2022
 * Time: 8:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimpelProjcet01
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.add_button = new System.Windows.Forms.Button();
			this.celcius = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.inpSuhu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.fahrenheit = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// add_button
			// 
			this.add_button.Location = new System.Drawing.Point(365, 69);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(72, 32);
			this.add_button.TabIndex = 1;
			this.add_button.Tag = "add_button";
			this.add_button.Text = "Tambah";
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.add_buttonClick);
			// 
			// celcius
			// 
			this.celcius.FormattingEnabled = true;
			this.celcius.ItemHeight = 16;
			this.celcius.Location = new System.Drawing.Point(43, 167);
			this.celcius.Name = "celcius";
			this.celcius.Size = new System.Drawing.Size(168, 260);
			this.celcius.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Masukan Suhu :";
			// 
			// inpSuhu
			// 
			this.inpSuhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inpSuhu.Location = new System.Drawing.Point(191, 72);
			this.inpSuhu.Name = "inpSuhu";
			this.inpSuhu.Size = new System.Drawing.Size(154, 24);
			this.inpSuhu.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(43, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "°Celcius";
			// 
			// fahrenheit
			// 
			this.fahrenheit.FormattingEnabled = true;
			this.fahrenheit.ItemHeight = 16;
			this.fahrenheit.Location = new System.Drawing.Point(313, 167);
			this.fahrenheit.Name = "fahrenheit";
			this.fahrenheit.Size = new System.Drawing.Size(168, 260);
			this.fahrenheit.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(313, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "°Fahrenheit";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(223, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(79, 64);
			this.button1.TabIndex = 8;
			this.button1.Tag = "add_button";
			this.button1.Text = "Konversi Semua >>";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.konversi_all_button);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(217, 321);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 48);
			this.button2.TabIndex = 9;
			this.button2.Tag = "add_button";
			this.button2.Text = "Konversi >>";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.konversi_selected_button);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(43, 433);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(70, 27);
			this.button3.TabIndex = 10;
			this.button3.Tag = "add_button";
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.delete_button);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(128, 433);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(73, 42);
			this.button4.TabIndex = 11;
			this.button4.Tag = "add_button";
			this.button4.Text = "Hapus Semua";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.delete_all_button);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 521);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.fahrenheit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.inpSuhu);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.celcius);
			this.Controls.Add(this.add_button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Konversi Celcius-Fahrenheit";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox fahrenheit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox inpSuhu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox celcius;
		private System.Windows.Forms.Button add_button;
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpelProjcet01
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		void add_buttonClick(object sender, EventArgs e)
		{
			string suhu = this.inpSuhu.Text;
			if(suhu.Length<=0)
				MessageBox.Show("Suhu belum dimasukan", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				celcius.Items.Add(suhu);
				this.inpSuhu.Clear();
				this.inpSuhu.Focus();
			}
		}
		
		void delete_button(object sender, EventArgs e)
		{
			//jika data dalam list kosong
			if(celcius.Items.Count==0)
				//menampilkan message box dengan isi Data Kosong dan button "ok" pada message box
				MessageBox.Show("Data Kosong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
				celcius.Items.RemoveAt(celcius.SelectedIndex);
		}
		
		void delete_all_button(object sender, EventArgs e)
		{
			//jika data dalam list kosong
			if (celcius.Items.Count==0)
				//menampilkan message box dengan isi Data Kosong dan button "ok" pada message box
				MessageBox.Show("Data Kosong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
				this.celcius.Items.Clear();
			
		}
		
		void konversi_selected_button(object sender, EventArgs e)
		{
			if(celcius.Items.Count==0)
				MessageBox.Show("Tidak Ada Data yang Dikonversi","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else{
				this.fahrenheit.Items.Clear();
				string data = celcius.SelectedItem.ToString();
				double dataInt = double.Parse(data);
				dataInt = dataInt*9/5+32;
				fahrenheit.Items.Add(dataInt.ToString());
				
			}
		}
		
		void konversi_all_button(object sender, EventArgs e)
		{
			
			if(celcius.Items.Count==0)
				MessageBox.Show("Tidak Ada Data yang Dikonversi","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			else{
				//membersihkan listbox fahrenheit sebelum menampilkan hasil konversi
				this.fahrenheit.Items.Clear();
				//mengambil semua data dilist box celcius
				foreach(var data_celcius in celcius.Items){
					//mengubah objek data pada list celcius kebentuk string
					string data_celcius2 = data_celcius.ToString();
					//mengubah bentuk string ke double
					double data_celcius3 = double.Parse(data_celcius2);
					data_celcius3 = data_celcius3*9/5+32;
					fahrenheit.Items.Add(data_celcius3.ToString());
				}
			}
		}
	}
}

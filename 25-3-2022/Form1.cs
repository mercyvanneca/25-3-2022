using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_3_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label_Mode_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Proses_Click(object sender, EventArgs e)
        {
            if (TextBox_Data.Text.Length > 0)
            {
                ListBox_Kiri.Items.Add(TextBox_Data.Text);
                TextBox_Data.Clear();
                TextBox_Data.Focus();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void ListBox_Kiri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_Kanan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBox_Kiri.Items.Count; i++)
            {
                ListBox_Kanan.Items.Add(ListBox_Kiri.Items[i]);
            }
            ListBox_Kiri.Items.Clear();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListBox_Kanan.Items.Add(ListBox_Kiri.SelectedItem);
            ListBox_Kiri.Items.Remove(ListBox_Kiri.SelectedItem);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ListBox_Kiri.Items.Add(ListBox_Kanan.SelectedItem);
            ListBox_Kanan.Items.Remove(ListBox_Kanan.SelectedItem);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBox_Kanan.Items.Count; i++)
            {
                ListBox_Kiri.Items.Add(ListBox_Kanan.Items[i]);
            }
            ListBox_Kanan.Items.Clear();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ListBox_Kanan.Items.Remove(ListBox_Kanan.SelectedItem);
            ListBox_Kiri.Items.Remove(ListBox_Kiri.SelectedItem);
        }

        private void CheckBox_Block_CheckedChanged(object sender, EventArgs e)

        {
            if (CheckBox_Block.Checked == true)
            {
                this.Button1.Enabled = false;
                this.Button2.Enabled = false;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                this.Button5.Enabled = false;
            }
            if (CheckBox_Block.Checked == false)
            {
                this.Button1.Enabled = true;
                this.Button2.Enabled = true;
                this.Button3.Enabled = true;
                this.Button4.Enabled = true;
                this.Button5.Enabled = true;
            }
        }

        private void ComboBox_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox_Mode.Items.Add("Add");
            ComboBox_Mode.Items.Add("Replace");
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Devexpress
        }

        private void rb_AH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Kadın_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Erkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string ısActive;
            if (ch_is_active.Checked) { ısActive = "Aktif"; }
            else { ısActive = "Aktif Değil"; }
            string Sex;
            if (rb_Erkek.Checked) { Sex = "Erkek"; }
            else if (rb_Kadın.Checked) { Sex = "Kadın"; }
            else if (rb_AH.Checked) { Sex = "Attack Helicopter"; }
            else { Sex = "Sabunluk"; }
            string sehir = cmb_Sehir.Text;
            string birthdayy = birthday.Text;
            List<string> list = new List<string>()
            {
                name, surname, ısActive, Sex, sehir, birthdayy
                
            };
            foreach (var item in list)
            {
                lst_change.Items.Add(item);
            }

            ListViewItem lvi = new ListViewItem();
            lvi.Text = name;
            for (int i = 1; i < list.Count; i++)
            {
                lvi.SubItems.Add(list[i]);
            }
            //lst_change.Items.Add(name + "" + surname + " " + ısActive + " " + Sex + " " + sehir + " " + birthdayy); 
            listView1.Items.Add(lvi);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_change_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

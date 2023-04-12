using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shut_The_Box
{
    public partial class UsersNickLogin : Form
    {
        public static string db = @"C:\Users\202\Desktop\UcuncuBinyil.cs\db.txt";
        public static string nick;
        public UsersNickLogin()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string nll = "";
            nick = nickname.Text;
            if(nickname.Text == nll )
            {
                MessageBox.Show("Boş bırakılamaz");
            }
            else {
                using (StreamWriter sw = File.AppendText(db))
                {
                    sw.WriteLine(nick + Environment.NewLine);
                }
                MessageBox.Show("Metin dosyasına yazdırıldı!");

                Form1 game = new Form1();
                game.Show();
                this.Hide();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shut_The_Box
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SinglePlayer_Click(object sender, EventArgs e)
        {
            UsersNickLogin single_player = new UsersNickLogin();
            single_player.Show();
            this.Hide();

        }

        private void multi_Click(object sender, EventArgs e)
        {
            label2.Text = "Coming Soon";
        }
    }
}

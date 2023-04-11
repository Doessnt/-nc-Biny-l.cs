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
    public partial class Form1 : Form
    {
        public static int score = 0;
        public static int total;
        public static List<int> scorelist_db = new List<int>()
        {
            1,2,3,4,5,6,7,8,9

        };

        public static List<int> scorelist = new List<int>()
        {
            1,2,3,4,5,6,7,8,9

        };
        
        

        public Form1()
        {
            InitializeComponent();
        }

        // Zarların toplamları ile butonlara basınca sayı düşmesi

        private void btn_diceRoll_Click(object sender, EventArgs e)
        {
            // Random 2 zar atıyor
            Mechnic.dice_roll(Dice_1, Dıce2);
            dice_total.Text = Convert.ToString(total);
            

        }
        

        private void btn_1_Click(object sender, EventArgs e)
        {

            Mechnic.game_mechanic(btn_1, error,dice_total);

            Mechnic.turn_red(btn_1);

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_2, error, dice_total);
            Mechnic.turn_red(btn_2);

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_3, error, dice_total);
            Mechnic.turn_red(btn_3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_4, error, dice_total);

            Mechnic.turn_red(btn_4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_5, error, dice_total);

            Mechnic.turn_red(btn_5);


        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_6, error, dice_total);

            Mechnic.turn_red(btn_6);

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_7, error, dice_total);

            Mechnic.turn_red(btn_7);

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_8, error, dice_total);

            Mechnic.turn_red(btn_8);

        }

        private void btn_9l_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_9l, error, dice_total);

            Mechnic.turn_red(btn_9l);


        }


        private void finish_step_Click(object sender, EventArgs e)
        {
            Mechnic.turn_white(btn_1);
            Mechnic.turn_white(btn_2);
            Mechnic.turn_white(btn_3);
            Mechnic.turn_white(btn_4);
            Mechnic.turn_white(btn_5);
            Mechnic.turn_white(btn_6);
            Mechnic.turn_white(btn_7);
            Mechnic.turn_white(btn_8);
            Mechnic.turn_white(btn_9l);

            score = 0;
            foreach (int item in scorelist) { score += item;}
             
            listBox1.Items.Add(score);
            scorelist = scorelist_db;

        }
    }   
}

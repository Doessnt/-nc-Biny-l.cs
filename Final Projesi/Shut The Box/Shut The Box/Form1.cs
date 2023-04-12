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
        int _count = 60;


        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_diceRoll_Click(object sender, EventArgs e)
        {
            
            // Random 2 zar atıyor
            Mechnic.dice_roll(Dice_1, Dıce2);
            dice_total.Text = Convert.ToString(total);
            timer1.Enabled = true;
            timer1.Interval = 2000; // 2 saniye
            timer1.Tick += timer1_Tick;
            



        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _count--;
            label1.Text = _count.ToString(); // Sayacın görüneceği yer
            if(_count == 0)
            {
                MessageBox.Show("Zamanınız doldu");
                finish_step_Click(sender, e);
                timer1.Enabled = false;
            }
        }


        private void btn_1_Click(object sender, EventArgs e)
        {

            Mechnic.game_mechanic(btn_1,dice_total);

            

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_2,dice_total);
            
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_3,  dice_total);
           
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_4,  dice_total);

            
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_5,  dice_total);

            


        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_6, dice_total);

            

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_7, dice_total);

            

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_8, dice_total);

            

        }

        private void btn_9l_Click(object sender, EventArgs e)
        {
            Mechnic.game_mechanic(btn_9l, dice_total);

            


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
            
            Mechnic.score_keaper(listBox1);
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      
    }   
}

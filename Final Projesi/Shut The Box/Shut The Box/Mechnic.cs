using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace Shut_The_Box
{
    internal class Mechnic
    {

        public static int number_of_button;
        public static void dice_roll(Label dice1, Label dice2)
        {
            Random r = new Random();
            int random = r.Next(1, 6);
            int random2 = r.Next(1, 6);
            dice1.Text = Convert.ToString(random);
            dice2.Text = Convert.ToString(random2);
            Form1.total = random + random2;
        }

        public static void game_mechanic(Button button, Label dice_total)
        {
            number_of_button = Convert.ToInt32(button.Text);
            //Butona basıldıktan sonra eğer eksikse yazı döndürülücek
            if (number_of_button > Form1.total)
            {
                MessageBox.Show("Yeterli sayınız yok");
                button.BackColor = Color.White; //Burdali button rakamların olduğu buttonları temsil ediyor.

            }
            else if (Form1.total == 0)
            {
                MessageBox.Show("YOU WON");
            }
            else // Eksik değil ise kırmızıya dönüştürüp totalden düşücek
            {
                Form1.total -= number_of_button;
                dice_total.Text = Convert.ToString(Form1.total);
                turn_red(button);

            }


        }
        public static void turn_red(Button btn)
        {
            btn.BackColor = Color.Red;
            btn.Enabled = false;
            Form1.scorelist.Remove(number_of_button);
        }
        public static void turn_white(Button btn)
        {
            btn.BackColor = Color.White;
            btn.Enabled = true;

        }
        public static void score_keaper (ListBox listBox1){
            Form1.score = 0;
            foreach (int item in Form1.scorelist) { Form1.score += item; }
            using (StreamReader sr = new StreamReader(UsersNickLogin.db))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Metin kutusuna okunan satırı yazdırın
                   listBox1.Items.Add(line + Environment.NewLine);
                }
                
            }

            listBox1.Items.Add(Form1.score);
            Form1.scorelist = Form1.scorelist_db;
        }
        

    }
}

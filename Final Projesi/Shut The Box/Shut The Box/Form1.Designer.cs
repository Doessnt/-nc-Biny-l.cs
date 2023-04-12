namespace Shut_The_Box
{
   public  partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9l = new System.Windows.Forms.Button();
            this.btn_diceRoll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Dice_1 = new System.Windows.Forms.Label();
            this.Dıce2 = new System.Windows.Forms.Label();
            this.dice_total = new System.Windows.Forms.Label();
            this.finish_step = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_1.Location = new System.Drawing.Point(30, 12);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 112);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_2.Location = new System.Drawing.Point(142, 12);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 112);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_3.Location = new System.Drawing.Point(256, 12);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 112);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_4.Location = new System.Drawing.Point(371, 12);
            this.btn_4.Name = "btn_4";
            this.btn_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_4.Size = new System.Drawing.Size(75, 112);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_5.Location = new System.Drawing.Point(487, 12);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 112);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_6.Location = new System.Drawing.Point(612, 12);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 112);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_7.Location = new System.Drawing.Point(738, 12);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 112);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_8.Location = new System.Drawing.Point(863, 12);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 112);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9l
            // 
            this.btn_9l.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_9l.Location = new System.Drawing.Point(984, 12);
            this.btn_9l.Name = "btn_9l";
            this.btn_9l.Size = new System.Drawing.Size(75, 112);
            this.btn_9l.TabIndex = 8;
            this.btn_9l.Text = "9";
            this.btn_9l.UseVisualStyleBackColor = true;
            this.btn_9l.Click += new System.EventHandler(this.btn_9l_Click);
            // 
            // btn_diceRoll
            // 
            this.btn_diceRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_diceRoll.Location = new System.Drawing.Point(30, 354);
            this.btn_diceRoll.Name = "btn_diceRoll";
            this.btn_diceRoll.Size = new System.Drawing.Size(169, 75);
            this.btn_diceRoll.TabIndex = 9;
            this.btn_diceRoll.Text = "Dice in roll";
            this.btn_diceRoll.UseVisualStyleBackColor = true;
            this.btn_diceRoll.Click += new System.EventHandler(this.btn_diceRoll_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(925, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 199);
            this.listBox1.TabIndex = 10;
            // 
            // Dice_1
            // 
            this.Dice_1.AutoSize = true;
            this.Dice_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dice_1.Location = new System.Drawing.Point(450, 259);
            this.Dice_1.Name = "Dice_1";
            this.Dice_1.Size = new System.Drawing.Size(0, 42);
            this.Dice_1.TabIndex = 11;
            // 
            // Dıce2
            // 
            this.Dıce2.AutoSize = true;
            this.Dıce2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dıce2.Location = new System.Drawing.Point(595, 259);
            this.Dıce2.Name = "Dıce2";
            this.Dıce2.Size = new System.Drawing.Size(0, 42);
            this.Dıce2.TabIndex = 12;
            // 
            // dice_total
            // 
            this.dice_total.AutoSize = true;
            this.dice_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dice_total.Location = new System.Drawing.Point(531, 369);
            this.dice_total.Name = "dice_total";
            this.dice_total.Size = new System.Drawing.Size(0, 16);
            this.dice_total.TabIndex = 13;
            // 
            // finish_step
            // 
            this.finish_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.finish_step.Location = new System.Drawing.Point(30, 315);
            this.finish_step.Name = "finish_step";
            this.finish_step.Size = new System.Drawing.Size(169, 33);
            this.finish_step.TabIndex = 15;
            this.finish_step.Text = "Finish the Turn";
            this.finish_step.UseVisualStyleBackColor = true;
            this.finish_step.Click += new System.EventHandler(this.finish_step_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(484, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "timee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finish_step);
            this.Controls.Add(this.dice_total);
            this.Controls.Add(this.Dıce2);
            this.Controls.Add(this.Dice_1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_diceRoll);
            this.Controls.Add(this.btn_9l);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shut The Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_1;
        public System.Windows.Forms.Button btn_2;
        public System.Windows.Forms.Button btn_3;
        public System.Windows.Forms.Button btn_4;
        public System.Windows.Forms.Button btn_5;
        public System.Windows.Forms.Button btn_6;
        public System.Windows.Forms.Button btn_7;
        public System.Windows.Forms.Button btn_8;
        public System.Windows.Forms.Button btn_9l;
        public System.Windows.Forms.Button btn_diceRoll;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label Dice_1;
        public System.Windows.Forms.Label Dıce2;
        public System.Windows.Forms.Label dice_total;
        private System.Windows.Forms.Button finish_step;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}


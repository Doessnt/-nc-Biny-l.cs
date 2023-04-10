namespace Windows_Form2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.Label();
            this.ch_is_active = new System.Windows.Forms.CheckBox();
            this.rb_Erkek = new System.Windows.Forms.RadioButton();
            this.rb_Kadın = new System.Windows.Forms.RadioButton();
            this.rb_AH = new System.Windows.Forms.RadioButton();
            this.cmb_Sehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lst_change = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.lst_change);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.birthday);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_Sehir);
            this.groupBox1.Controls.Add(this.rb_AH);
            this.groupBox1.Controls.Add(this.rb_Kadın);
            this.groupBox1.Controls.Add(this.rb_Erkek);
            this.groupBox1.Controls.Add(this.ch_is_active);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txt_Surname);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SS SUBAY GIRIS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name.Location = new System.Drawing.Point(19, 39);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(65, 20);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "Name :";
            this.txt_name.Click += new System.EventHandler(this.txt_name_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 5;
            // 
            // txt_Surname
            // 
            this.txt_Surname.AutoSize = true;
            this.txt_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Surname.Location = new System.Drawing.Point(13, 75);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(91, 20);
            this.txt_Surname.TabIndex = 4;
            this.txt_Surname.Text = "Surname :";
            // 
            // ch_is_active
            // 
            this.ch_is_active.AutoSize = true;
            this.ch_is_active.Location = new System.Drawing.Point(31, 124);
            this.ch_is_active.Name = "ch_is_active";
            this.ch_is_active.Size = new System.Drawing.Size(75, 17);
            this.ch_is_active.TabIndex = 6;
            this.ch_is_active.Text = "Aktif mi?";
            this.ch_is_active.UseVisualStyleBackColor = true;
            // 
            // rb_Erkek
            // 
            this.rb_Erkek.AutoSize = true;
            this.rb_Erkek.Location = new System.Drawing.Point(31, 160);
            this.rb_Erkek.Name = "rb_Erkek";
            this.rb_Erkek.Size = new System.Drawing.Size(58, 17);
            this.rb_Erkek.TabIndex = 7;
            this.rb_Erkek.TabStop = true;
            this.rb_Erkek.Text = "Erkek";
            this.rb_Erkek.UseVisualStyleBackColor = true;
            this.rb_Erkek.CheckedChanged += new System.EventHandler(this.rb_Erkek_CheckedChanged);
            // 
            // rb_Kadın
            // 
            this.rb_Kadın.AutoSize = true;
            this.rb_Kadın.Location = new System.Drawing.Point(110, 160);
            this.rb_Kadın.Name = "rb_Kadın";
            this.rb_Kadın.Size = new System.Drawing.Size(57, 17);
            this.rb_Kadın.TabIndex = 8;
            this.rb_Kadın.TabStop = true;
            this.rb_Kadın.Text = "Kadın";
            this.rb_Kadın.UseVisualStyleBackColor = true;
            this.rb_Kadın.CheckedChanged += new System.EventHandler(this.rb_Kadın_CheckedChanged);
            // 
            // rb_AH
            // 
            this.rb_AH.AutoSize = true;
            this.rb_AH.Location = new System.Drawing.Point(180, 160);
            this.rb_AH.Name = "rb_AH";
            this.rb_AH.Size = new System.Drawing.Size(124, 17);
            this.rb_AH.TabIndex = 9;
            this.rb_AH.TabStop = true;
            this.rb_AH.Text = "Attack Helicopter";
            this.rb_AH.UseVisualStyleBackColor = true;
            this.rb_AH.CheckedChanged += new System.EventHandler(this.rb_AH_CheckedChanged);
            // 
            // cmb_Sehir
            // 
            this.cmb_Sehir.FormattingEnabled = true;
            this.cmb_Sehir.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara ",
            "Rize ",
            "Trabzon",
            "Sakarya",
            "Berlin"});
            this.cmb_Sehir.Location = new System.Drawing.Point(79, 212);
            this.cmb_Sehir.Name = "cmb_Sehir";
            this.cmb_Sehir.Size = new System.Drawing.Size(121, 21);
            this.cmb_Sehir.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Şehir";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(121, 259);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(200, 20);
            this.birthday.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dogum Tarihi";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(79, 337);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(113, 31);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lst_change
            // 
            this.lst_change.BackColor = System.Drawing.Color.Red;
            this.lst_change.FormattingEnabled = true;
            this.lst_change.Location = new System.Drawing.Point(646, 19);
            this.lst_change.Name = "lst_change";
            this.lst_change.Size = new System.Drawing.Size(227, 238);
            this.lst_change.TabIndex = 15;
            this.lst_change.SelectedIndexChanged += new System.EventHandler(this.lst_change_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Red;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(509, 275);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 168);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Surname";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Aktif ?";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sex";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Şehir";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dogum Tarihi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 513);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HEIL HITLER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_AH;
        private System.Windows.Forms.RadioButton rb_Kadın;
        private System.Windows.Forms.RadioButton rb_Erkek;
        private System.Windows.Forms.CheckBox ch_is_active;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txt_Surname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Sehir;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.ListBox lst_change;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}


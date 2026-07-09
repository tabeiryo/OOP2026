using System.Globalization;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Section01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            dTP1 = new DateTimePicker();
            bt1 = new System.Windows.Forms.Button();
            tbout = new System.Windows.Forms.TextBox();
            day = new NumericUpDown();
            label1 = new Label();
            VARSE = new DateTimePicker();
            texbox = new System.Windows.Forms.TextBox();
            keisan = new System.Windows.Forms.Button();
            numericUpDown1 = new NumericUpDown();
            texbox2 = new System.Windows.Forms.TextBox();
            notuse = new System.Windows.Forms.Button();
            dateTimePicker1 = new DateTimePicker();
            bt3 = new System.Windows.Forms.Button();
            Datepit = new DateTimePicker();
            birthbt = new System.Windows.Forms.Button();
            tukawanai = new NumericUpDown();
            birthdaypic = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            bt5 = new System.Windows.Forms.Button();
            texBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)day).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tukawanai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // dTP1
            // 
            dTP1.Font = new Font("Yu Gothic UI", 15F);
            dTP1.Location = new Point(112, 77);
            dTP1.Name = "dTP1";
            dTP1.Size = new Size(203, 34);
            dTP1.TabIndex = 0;
            // 
            // bt1
            // 
            bt1.Font = new Font("Yu Gothic UI", 11F);
            bt1.Location = new Point(331, 82);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 29);
            bt1.TabIndex = 1;
            bt1.Text = "åvéZ";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // tbout
            // 
            tbout.Location = new Point(112, 185);
            tbout.Name = "tbout";
            tbout.Size = new Size(312, 23);
            tbout.TabIndex = 2;
            // 
            // day
            // 
            day.Font = new Font("Yu Gothic UI", 15F);
            day.Location = new Point(430, 77);
            day.Name = "day";
            day.Size = new Size(120, 34);
            day.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 217);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "ì˙å„";
            // 
            // VARSE
            // 
            VARSE.Font = new Font("Yu Gothic UI", 15F);
            VARSE.Location = new Point(112, 254);
            VARSE.Name = "VARSE";
            VARSE.Size = new Size(203, 34);
            VARSE.TabIndex = 5;
            // 
            // texbox
            // 
            texbox.Location = new Point(112, 214);
            texbox.Name = "texbox";
            texbox.Size = new Size(312, 23);
            texbox.TabIndex = 6;
            // 
            // keisan
            // 
            keisan.Font = new Font("Yu Gothic UI", 11F);
            keisan.Location = new Point(321, 254);
            keisan.Name = "keisan";
            keisan.Size = new Size(75, 29);
            keisan.TabIndex = 7;
            keisan.Text = "åvéZ";
            keisan.UseVisualStyleBackColor = true;
            keisan.Click += keisan_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Yu Gothic UI", 15F);
            numericUpDown1.Location = new Point(416, 257);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 34);
            numericUpDown1.TabIndex = 8;
            // 
            // texbox2
            // 
            texbox2.Location = new Point(112, 332);
            texbox2.Multiline = true;
            texbox2.Name = "texbox2";
            texbox2.Size = new Size(331, 58);
            texbox2.TabIndex = 6;
            // 
            // notuse
            // 
            notuse.Font = new Font("Yu Gothic UI", 11F);
            notuse.ForeColor = SystemColors.ActiveCaptionText;
            notuse.Location = new Point(430, 396);
            notuse.Name = "notuse";
            notuse.Size = new Size(167, 29);
            notuse.TabIndex = 7;
            notuse.Text = "ëÊéOèTÇÃì˙ójì˙É{É^Éì";
            notuse.UseVisualStyleBackColor = true;
            notuse.Click += notuse_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Yu Gothic UI", 15F);
            dateTimePicker1.Location = new Point(112, 254);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 34);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // bt3
            // 
            bt3.Font = new Font("Yu Gothic UI", 5F);
            bt3.ForeColor = SystemColors.ButtonHighlight;
            bt3.Location = new Point(2, 0);
            bt3.Name = "bt3";
            bt3.Size = new Size(25, 11);
            bt3.TabIndex = 7;
            bt3.Text = "Ç¬Ç©ÇÌÇ»Ç¢";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // Datepit
            // 
            Datepit.Font = new Font("Yu Gothic UI", 15F);
            Datepit.Location = new Point(221, 396);
            Datepit.Name = "Datepit";
            Datepit.Size = new Size(203, 34);
            Datepit.TabIndex = 5;
            Datepit.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // birthbt
            // 
            birthbt.Location = new Point(112, 400);
            birthbt.Name = "birthbt";
            birthbt.Size = new Size(96, 23);
            birthbt.TabIndex = 9;
            birthbt.Text = "íaê∂ì˙É{É^Éì";
            birthbt.UseVisualStyleBackColor = true;
            birthbt.Click += birthbt_Click;
            // 
            // tukawanai
            // 
            tukawanai.Font = new Font("Yu Gothic UI", 1F);
            tukawanai.Location = new Point(2, 4);
            tukawanai.Name = "tukawanai";
            tukawanai.Size = new Size(120, 9);
            tukawanai.TabIndex = 10;
            // 
            // birthdaypic
            // 
            birthdaypic.Location = new Point(128, 442);
            birthdaypic.Name = "birthdaypic";
            birthdaypic.Size = new Size(200, 23);
            birthdaypic.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 448);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 12;
            label2.Text = "íaê∂ì˙Å®";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 442);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 13;
            label3.Text = "ç°ì˙Å™";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(729, 25);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 14;
            label4.Text = "íaê∂ì˙Ç‹Ç≈";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Yu Gothic UI", 1F);
            numericUpDown2.Location = new Point(2, 17);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 9);
            numericUpDown2.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Yu Gothic UI", 18F);
            dateTimePicker2.Location = new Point(634, 125);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 39);
            dateTimePicker2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 15F);
            label5.Location = new Point(742, 88);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 17;
            label5.Text = "íaê∂ì˙Å´";
            // 
            // bt5
            // 
            bt5.Font = new Font("Yu Gothic UI", 15F);
            bt5.Location = new Point(840, 121);
            bt5.Name = "bt5";
            bt5.Size = new Size(227, 43);
            bt5.TabIndex = 18;
            bt5.Text = "íaê∂ì˙Ç‹Ç≈ÅõÅõì˙É{É^Éì";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // texBox6
            // 
            texBox6.Font = new Font("Yu Gothic UI", 15F);
            texBox6.Location = new Point(659, 194);
            texBox6.Name = "texBox6";
            texBox6.Size = new Size(351, 34);
            texBox6.TabIndex = 19;
            // 
            // Form1
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(1096, 489);
            Controls.Add(texBox6);
            Controls.Add(bt5);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(numericUpDown2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(birthdaypic);
            Controls.Add(tukawanai);
            Controls.Add(birthbt);
            Controls.Add(numericUpDown1);
            Controls.Add(bt3);
            Controls.Add(notuse);
            Controls.Add(keisan);
            Controls.Add(texbox2);
            Controls.Add(Datepit);
            Controls.Add(dateTimePicker1);
            Controls.Add(texbox);
            Controls.Add(VARSE);
            Controls.Add(label1);
            Controls.Add(day);
            Controls.Add(tbout);
            Controls.Add(bt1);
            Controls.Add(dTP1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)day).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tukawanai).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void bt3_Click(object? sender, EventArgs e)
        {

        }

        private void notuse_Click(object? sender, EventArgs e)
        {
            var date = Datepit.Value;
            var day = dayweek(date.Year, date.Month, DayOfWeek.Sunday, 3);
            texbox2.Text = date.Year + "îN" + date.Month + "åéÇÃëÊ3èTÇÃì˙ójì˙ÇÕ" + day.ToString();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            DateTime date = dTP1.Value;

            tbout.Text = date.AddDays((Double)day.Value).ToString();

            var date2 = DateTime.Today;
            var week = Weeek(date2);
            texbox2.Text = date2.ToString() + "ÇÕëÊ" + week + "èT";
        }

        private void keisan_Click(object sender, EventArgs e)
        {
            DateTime birth = VARSE.Value;
            DateTime today = DateTime.Today;
            TimeSpan diff = today.Date - birth.Date;
            // var nen = diff / 365;
            //tbout.Text = diff.ToString();
            texbox.Text = diff.ToString();
            var age = Getage(today, birth);
            tbout.Text = age.ToString();
        }

        static int Getage(DateTime today, DateTime birth)
        {
            var age = today.Year - birth.Year;
            if (today < birth.AddYears(age)) { age--; }
            return age;
        }
        static int Weeek(DateTime date)
        {
            var firthday = new DateTime(date.Year, date.Month, 1);
            var firthweek = (int)(firthday.DayOfWeek);
            return (date.Day + firthweek - 1) / 7 + 1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        static DateTime dayweek(int year, int month, DayOfWeek dayofweek, int nth)
        {
            var firstday = Enumerable.Range(1, 7).Select(d => new DateTime(year, month, d)).First(b => b.DayOfWeek == dayofweek).Day;
            var day = firstday + (nth - 1) * 7;
            return new DateTime(year, month, day);

        }

        private void birthbt_Click(object sender, EventArgs e)
        {
            DateTime today = Datepit.Value;
            DateTime birth = birthdaypic.Value;
            if (birth.Year == today.Year)
            {
                if (birth.Month == today.Month)
                {
                    if (birth.Day == today.Day)
                    {
                        texbox2.Text = "ç°ì˙Ç™íaê∂ì˙";
                    }
                    else if (birth.Day > today.Day)
                    {
                        texbox2.Text = birth.Day - today.Day + "ì˙å„";
                    }
                    else
                    {
                        texbox2.Text = "óàîN";
                    }

                }
                else if (birth.Month > today.Month)
                {
                    texbox2.Text = birth.Month - today.Month + "Éñåéå„";
                }
                else texbox2.Text = "óàîN";
            }
            else if (birth.Year > today.Year)
            {
                texbox2.Text = "ãéîN";
            }
            else texbox2.Text = "óàîN";
        }

        

        

        private void bt5_Click(object sender, EventArgs e)
        {
            DateTime birth = dateTimePicker2.Value;
            DateTime today = DateTime.Today;
            TimeSpan diff = birth.Date - today.Date;
            if (today.Date > birth.Date)
            {
                int day = diff.Days+365;
                texBox6.Text = day.ToString()+"ì˙å„";
            }else texBox6.Text= diff.Days.ToString() + "ì˙å„";
        }
    }
}

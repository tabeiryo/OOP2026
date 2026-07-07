using System.Globalization;

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
            bt1 = new Button();
            tbout = new TextBox();
            day = new NumericUpDown();
            label1 = new Label();
            VARSE = new DateTimePicker();
            texbox = new TextBox();
            keisan = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)day).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            bt1.Text = "ŒvŽZ";
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
            label1.Location = new Point(430, 125);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "“úŒã";
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
            keisan.Text = "ŒvŽZ";
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
            // Form1
            // 
            ClientSize = new Size(624, 451);
            Controls.Add(numericUpDown1);
            Controls.Add(keisan);
            Controls.Add(texbox);
            Controls.Add(VARSE);
            Controls.Add(label1);
            Controls.Add(day);
            Controls.Add(tbout);
            Controls.Add(bt1);
            Controls.Add(dTP1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)day).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            DateTime date = dTP1.Value;

            tbout.Text = date.AddDays((Double)day.Value).ToString();
        }

        private void keisan_Click(object sender, EventArgs e)
        {
            DateTime birth = VARSE.Value;
            DateTime today = DateTime.Today;
            TimeSpan diff = today.Date - birth.Date;
            var nen = diff / 365;
            tbout.Text = diff.ToString();
            texbox.Text = nen.ToString();
        }
    }
}

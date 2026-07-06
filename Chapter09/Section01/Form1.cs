namespace Section01
{
    public partial class Form1 : Form
    {
        private void InitializeComponent()
        {
            dTP1 = new DateTimePicker();
            bt1 = new Button();
            tbout = new TextBox();
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
            bt1.Location = new Point(197, 228);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 29);
            bt1.TabIndex = 1;
            bt1.Text = "éÊìæ";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // tbout
            // 
            tbout.Location = new Point(178, 182);
            tbout.Name = "tbout";
            tbout.Size = new Size(119, 23);
            tbout.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new Size(624, 451);
            Controls.Add(tbout);
            Controls.Add(bt1);
            Controls.Add(dTP1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            DateTime dtp1 = dTP1.Value;
            DayOfWeek dayOfWeek = dtp1.DayOfWeek;
            if (DateTime.IsLeapYear(2024)) {
                Console.WriteLine("Ç§ÇÈÇ§îN");
            }else Console.WriteLine("Ç§ÇÈÇ§îNÇ≈ÇÕÇ»Ç¢");

           // switch (dayOfWeek) { 
           // case DayOfWeek.Saturday:
             //       tbout.Text = "ç°ì˙ÇÕìyójì˙";
             //       break;
             //       case DayOfWeek.Sunday:
              //      tbout.Text = "ç°ì˙ÇÕì˙ójì˙";
               //     break;
               //     case DayOfWeek.Monday:
                //    tbout.Text = "åé";
                //    break;
                //   case DayOfWeek.Tuesday:
                //    tbout.Text = "âŒ";
                //    break;
                 //   case DayOfWeek.Wednesday:
                 //   tbout.Text = "êÖ";
                 //   break;
                 //   case DayOfWeek.Thursday:
                 //   tbout.Text = "ñÿ";
                 //   break;
                  //  case DayOfWeek.Friday:
                  //  tbout.Text = "ã‡";
                 //   break;
            
           // }
            
        }
    }
}

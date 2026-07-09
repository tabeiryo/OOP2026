using System.Diagnostics;

namespace Exercise03 {
    public partial class Form1 : Form
    {
        TimeWatch tw;
        Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            // tw = new TimeWatch();
            // tw.Start();
            sw.Start();
            timer1_Tick(sender,e);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            // tw.Stop();
            // TimeSpan duration = tw.Stop();
            // lbTimeDisp.Text = $"{duration.TotalSeconds}•b";
            sw.Stop();
            lbTimeDisp.Text = sw.Elapsed.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimeDisp.Text= sw.Elapsed.ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw.Reset();
        }
    }
}

internal class TimeWatch {
    private DateTime _time;

    public void Start() {

        _time = DateTime.Now;
       
    }

    public TimeSpan Stop() {
       
        return DateTime.Now - _time;
       


       }
}




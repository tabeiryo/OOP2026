namespace Exercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            texbox1.Text = today.Year + "/" + today.Month + "/" + today.Day + " " + today.Hour + ":" + today.Minute.ToString();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            texbox2.Text = today.Year + "”N" + today.Month + "ŒŽ" + today.Day + "“ú " + today.Hour + "Žž" + today.Minute + "•ª" + today.Second + "•b".ToString();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int reiwa = today.Year - 2018;
            texbox3.Text = "—ß˜a " + reiwa + "”N " + today.Month + "ŒŽ " + today.Day + "“ú(" + today.DayOfWeek + ")".ToString();
        }
    }
}

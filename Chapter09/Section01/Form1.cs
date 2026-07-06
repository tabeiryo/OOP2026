namespace Section01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

            tboutput.Text = (num1.Value + num2.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdopen.ShowDialog();
            pbpic.ImageLocation = ofdopen.FileName;
        }
    }
}

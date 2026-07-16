using System.ComponentModel;
using System.Diagnostics.Metrics;
using static CarReportSystem.CarReport;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarReportSystem {
    public partial class Form1 : Form
    {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dgvRecords.DataSource = listCarReports;
        }
        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e)
        {

            if (cbAuthor.Text.Length == 0 || cbCarName.Text.Length == 0)
            {
                tsslb.Text = "記録者または車名が未登録です";
                return;
            }
            else
            {
                var carReport = new CarReport
                {
                    Date = dtpDate.Value,
                    Author = cbAuthor.Text,
                    Meker = GetMakerGroup(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image,
                };
                listCarReports.Add(carReport);
                btNewInput_Click(sender, e);
            }
        }
        private MakerGroup GetMakerGroup()
        {
            if (rbToyota.Checked == true) { return MakerGroup.トヨタ; }
            if (rbNissan.Checked == true) { return MakerGroup.日産; }
            if (rbHonda.Checked == true) { return MakerGroup.ホンダ; }
            if (rbSubaru.Checked == true) { return MakerGroup.スバル; }
            if (rbImport.Checked == true) { return MakerGroup.輸入車; }
            return MakerGroup.その他;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdOpen.FileName);
            }

        }

        private void btNewInput_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
        }
        private void Form1_Click(object sender, EventArgs e){}

        private void dgvRecords_Click(object sender, EventArgs e)
        {
            dtpDate.Value =(DateTime) dgvRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["author"].Value;
            SetRadioButtonMaker(dgvRecords.CurrentRow.Cells["Meker"].Value);
            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
            ;
        }
        private void SetRadioButtonMaker(object Maker) {
            if (Maker.ToString() == "トヨタ") { rbToyota.Checked = true; }
            if (Maker.ToString() == "日産") { rbNissan.Checked = true; }
            if (Maker.ToString() == "ホンダ") { rbHonda.Checked = true; }
            if (Maker.ToString() == "スバル") { rbSubaru.Checked = true; }
            if (Maker.ToString() == "輸入車") { rbImport.Checked = true; }
            if (Maker.ToString() == "その他") { rbOther.Checked = true; }
        }
    }
}

using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        int ID = 0;
        //カーレポート管理用リスト
        private readonly BindingList<CarReport> listCarReports = new();
        // DB操作を担当するRepository
        private readonly CarReportRepository _repository = new();


        //設定クラスのオブジェクトを生成
        // Settings settings = Settings.Instance;

        public Form1()
        {
            InitializeComponent();
            //dgv列を自動生成
            dgvRecords.AutoGenerateColumns = true;
            //Bindinglist設定
            dgvRecords.DataSource = listCarReports;
            ReloadProducts();
            //ステータスバーに表示
            tsslbMessage.Text = $"DB:{Database.FilePath}";
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
            //try
            //{
               // Settings.Instance.Load();
              //  BackColor = Color.FromArgb(Settings.Instance.MainFormBackColor);
             //   
           // }
            //catch (Exception ex)
            //{
              //  tsslbMessage.Text = "設定ファイル読み込みエラー";
            //    MessageBox.Show(ex.Message);//←より具体的なエラーを出力         
          //  }
            //設定ファイルを読み込み背景色を設定する（逆シリアル化）
        //}

        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e)
        {

            tsslbMessage.Text = String.Empty;   //メッセージ領域のクリア
                                                //入力値が不正なら終了
            if (!TryGetInput(out string Author, out string CarName))
                return;
            try
            {
                var carReport = new CarReport
                {
                    Id = ID,
                    Date = dtpDate.Value.Date,
                    Author = cbAuthor.Text.Trim(),
                    Maker = GetRadioButtonMaker(),
                    CarName = cbCarName.Text.Trim(),
                    Report = tbReport.Text,
                   // Picture = pbPicture.Image,
                };
                listCarReports.Add(carReport);
                CarReportRepository.Add(carReport);

                ReloadProducts();
                InputItemsAllClear(); ;

                tsslbMessage.Text = "商品を登録しました";
            }
            catch (Exception ex)
            {
                ShowError("登録エラー", ex);
            }
            ID++;

            //入力履歴を登録
            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgvRecords.ClearSelection(); //セルの選択を解除する
            InputItemsUpdate(); //データグリッドビューを更新したら呼ぶメソッド
        }

        private void ShowError(string title, Exception ex)
        {
            tsslbMessage.Text = title;
            MessageBox.Show(
                ex.Message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        //sqlite
        private void ReloadProducts()
        {
            listCarReports.Clear();

            foreach (var carReport in _repository.GetALL())
            {
                listCarReports.Add(carReport);
            }
            dgvRecords.ClearSelection();
        }

        private bool TryGetInput(out string Author, out string CarName)
        {
            Author = cbAuthor.Text.Trim();
            CarName = cbCarName.Text.Trim();

            if (string.IsNullOrWhiteSpace(Author))
            {
                tsslbMessage.Text = "記録者を入力してください。";
                cbAuthor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(CarName))
            {
                tsslbMessage.Text = "車名を入力してください。";
                cbCarName.Focus();
                return false;
            }

            return true;
        }

        private MakerGroup GetRadioButtonMaker()
        {
            if (rbToyota.Checked)
                return MakerGroup.トヨタ;
            if (rbNissan.Checked)
                return MakerGroup.日産;
            if (rbHonda.Checked)
                return MakerGroup.ホンダ;
            if (rbSubaru.Checked)
                return MakerGroup.スバル;
            if (rbImport.Checked)
                return MakerGroup.輸入車;

            return MakerGroup.その他;
        }
        private void btOpenPicture_Click(object sender, EventArgs e)
        {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }
        private void btNewInput_Click(object sender, EventArgs e)
        {
            InputItemsAllClear();
        }
        private void InputItemsAllClear()
        {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;

            dgvRecords.ClearSelection();//セルの選択を解除する
        }

        private void SetRadioButtonMaker(MakerGroup targetMaker)
        {

            switch (targetMaker)
            {

                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }
        //記録者の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbAuthor(string author)
        {
            //未登録なら登録【登録済みなら何もしない】
            if (!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }
        //車名の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbCarName(string carName)
        {
            //未登録なら登録【登録済みなら何もしない】
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);

        }
        private void btDeletePicture_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }
        private void btDeleteRecord_Click(object sender, EventArgs e)
        {
            if ((dgvRecords.CurrentRow is null)
                || (!dgvRecords.CurrentRow.Selected)) return;

            //削除したいインデックスを指定してリストから削除
            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
            {
                tsslbMessage.Text = "削除するレポートを選択してくっださい";
                return;
            }
            CarReportRepository.Delete(carReport.Id);
            
            listCarReports.Remove(carReport);


            InputItemsUpdate(); //データグリッドビューを更新したら呼ぶメソッド
        }
        //データグリッドビューを更新したら呼ぶメソッド
        private void InputItemsUpdate()
        {
            if (dgvRecords.CurrentRow is null
                || !dgvRecords.CurrentRow.Selected)
                InputItemsAllClear();
        }
        private void btModifyRecord_Click(object sender, EventArgs e)
        {

            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport selectedCarReport)
            {
                tsslbMessage.Text = "修正するレポートを選択してください";
                return;
            }

            if (!TryGetInput(out string author, out string carName))
                return;

            try
            {
                selectedCarReport.Author = author;
                selectedCarReport.CarName = carName;

                CarReportRepository.Update(selectedCarReport);

                ReloadProducts();
                InputItemsAllClear();

                tsslbMessage.Text = "商品を修正しました。";
            }
            catch (Exception ex)
            {
                ShowError("修正エラー", ex);
            }
        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e)
        {

            if ((dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
                    || (!dgvRecords.CurrentRow.Selected)) return;

            dtpDate.Value = carReport.Date;
            cbAuthor.Text = carReport.Author;
            SetRadioButtonMaker(carReport.Maker);
            cbCarName.Text = carReport.CarName;
            tbReport.Text = carReport.Report;
            pbPicture.Image = carReport.Picture;

            InputItemsUpdate(); //データグリッドビューを更新したら呼ぶメソッド
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                BackColor = cdColor.Color;
                //変更された色の情報を保存
                Settings.Instance.MainFormBackColor = cdColor.Color.ToArgb();

            }
        }

        //フォームが閉じたら呼ばれるイベントハンドラ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Instance.Save();
        }

        

         
        

        //ファイルセーブ処理
       

        //ファイルオープン処理
       

        

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbToyota_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

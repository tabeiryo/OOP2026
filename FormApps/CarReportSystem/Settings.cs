namespace CarReportSystem {
    public sealed class Settings
    {
        //唯一のSettingsOBJ
       private static readonly Settings _instance = new Settings();

        //メイン画面に設定した色情報
        public int MainFormBackColor { get; set; }
        =SystemColors.Control.ToArgb();

        //  唯一のobjを取得
        public static Settings Instance { get { return _instance; } }


        //外部からNEWできなくする
        private Settings() { }




    }
}

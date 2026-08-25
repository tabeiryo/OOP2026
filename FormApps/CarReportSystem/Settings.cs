using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public sealed class Settings
    {
        //唯一のSettingsOBJ
       private static readonly Settings _instance = new Settings();
        private Stream FileName;

        //メイン画面に設定した色情報
        public int MainFormBackColor { get; set; }
        =SystemColors.Control.ToArgb();

        //  唯一のobjを取得
        public static Settings Instance { get { return _instance; } }


        //外部からNEWできなくする
        private Settings() { }


        public void  Save() { 
        var date  = new SettingsDate{MainFormBackColor = MainFormBackColor };

            using var writer = XmlWriter.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsDate));
            serializer .Serialize(writer, date);
        }


        //保存用
        public　class SettingsDate { 
        public int MainFormBackColor { get; set; }
        }

    }
}

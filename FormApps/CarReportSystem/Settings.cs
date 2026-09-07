using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public sealed class Settings
    {
        private const string FileName = "setting.xml";
        
        //外部からNEWできなくする
        private Settings() { }

        //  唯一のobjを取得
        public static Settings Instance { get; } = new();

        //メイン画面に設定した色情報
        public int MainFormBackColor { get; set; }
        =SystemColors.Control.ToArgb();


        public void  Save() { 
        var date  = new SettingsDate{MainFormBackColor = MainFormBackColor };

            using var writer = XmlWriter.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsDate));
            serializer .Serialize(writer, date);
        }
        public void Load() {
            using var reader = XmlReader.Create(FileName) ;
            var serializer = new XmlSerializer(typeof(SettingsDate));

            if (serializer.Deserialize(reader) is SettingsDate date)
            {
                MainFormBackColor=date.MainFormBackColor;
            }
            }


        //保存用
        public　class SettingsDate { 
        public int MainFormBackColor { get; set; }

        }

    }
}

using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace FacebookLogic
{
    public sealed class AppSetting
    {
        private static readonly string sr_PathDirectoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string sr_FileName = @"\appSetting.xml";
        private static readonly string sr_PathDirectoryAndFileName = sr_PathDirectoryName + sr_FileName;
        private static AppSetting s_Appsetting;

        public static AppSetting Instance
        {
            get
            {
                if (s_Appsetting == null)
                {
                    s_Appsetting = LoadFromFile();
                }

                return s_Appsetting;
            }
        }

        public static void DeleteFileIfExist()
        {
            if (File.Exists(sr_PathDirectoryAndFileName))
            {
                File.Delete(sr_PathDirectoryAndFileName);
            }
        }

        public static AppSetting LoadFromFile()
        {
            AppSetting loadThis = null;

            if (File.Exists(sr_PathDirectoryAndFileName))
            {
                using (Stream stream = new FileStream(sr_PathDirectoryAndFileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                    loadThis = serializer.Deserialize(stream) as AppSetting;
                }
            }
            else
            {
                loadThis = new AppSetting();
            }

            return loadThis;
        }

        public void SaveToFile()
        {
            if (File.Exists(sr_PathDirectoryAndFileName))
            {
                using (Stream stream = new FileStream(sr_PathDirectoryAndFileName, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(sr_PathDirectoryAndFileName, FileMode.CreateNew))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }

        private AppSetting()
        {
        }

        public string AccessToken { get; set; }

    }
}

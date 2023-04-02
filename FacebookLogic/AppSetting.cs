using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace FacebookLogic
{
    public sealed class AppSetting
    {
        private static readonly string sr_PathDirectoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string sr_FileName = @"\appSetting.xml";
        private static readonly string sr_PathDirectoryAndFileName = sr_PathDirectoryName + sr_FileName;
        private static AppSetting s_Appsetting;

        private AppSetting()
        {
        }

        public string AccessToken { get; set; }

        public Facebook.FacebookOAuthResult FacebookOAuthResult { get; set; }

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

        public static AppSetting LoadFromFile()
        {
            AppSetting loadthis = null;

            if (File.Exists(sr_PathDirectoryAndFileName))
            {
                using (Stream stream = new FileStream(sr_PathDirectoryAndFileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                    loadthis = serializer.Deserialize(stream) as AppSetting;
                }
            }
            else
            {
                loadthis = new AppSetting();
            }

            return loadthis;
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

        public static void DeleteFileIfExist()
        {
            if (File.Exists(sr_PathDirectoryAndFileName))
            {
                File.Delete(sr_PathDirectoryAndFileName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace FacebookLogic
{
    public sealed class AppSetting
    {
        //private static readonly XmlSerializer sr_Serializer;
        private static readonly string sr_PathDirectoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string sr_FileName = @"\appSetting.xml";

        public string AccessToken { get; set; }

        public Facebook.FacebookOAuthResult FacebookOAuthResult { get; set; }

        public void saveToFile()
        {

            if (File.Exists(sr_PathDirectoryName + sr_FileName))
            {
                using (Stream stream = new FileStream(sr_PathDirectoryName + sr_FileName, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(sr_PathDirectoryName + sr_FileName, FileMode.CreateNew))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }

        public static AppSetting LoadFromFile()
        {
            AppSetting appSetting = new AppSetting();

            if (File.Exists(sr_PathDirectoryName + sr_FileName))
            {
                using (Stream stream = new FileStream(sr_PathDirectoryName + sr_FileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                    appSetting = serializer.Deserialize(stream) as AppSetting;
                }
            }


            return appSetting;
        }
       

    }
}

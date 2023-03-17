using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace FacebookLogic
{
    public sealed class AppSetting
    {
        private static readonly string sr_FileName;
        private static readonly XmlSerializer sr_Serializer;
        private static AppSetting s_ApplicationSettings;

        public void  saveToFile()
        {
            string pathDirectoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using (Stream stream = new FileStream(pathDirectoryName + @"\appSetting.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
       

    }
}

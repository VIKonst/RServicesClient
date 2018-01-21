using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DataAnalyzer.FileSaving
{
    class FileLoader
    {
        XmlSerializer serializer = new XmlSerializer(typeof(RServicesFileData));
        
        public void SaveRScript(String text)
        {
            SaveFile(text, "R|*.r");
        }

        public void SaveSqlScript(String text)
        {
            SaveFile(text, "SQL|*.sql");
        }

        public void SaveRServicesFile(String rScript, String sqlScript)
        {

            RServicesFileData rServicesFileData = new RServicesFileData
            {
                RScript = rScript,
                SqlScript = sqlScript,
            };

            MemoryStream mstream = new MemoryStream();

            serializer.Serialize(mstream, rServicesFileData);

            mstream.Seek(0, SeekOrigin.Begin);

            StreamReader streamReader = new StreamReader(mstream);

           
            SaveFile(streamReader.ReadToEnd(), "R SQL|*.rsql");
        }

        public String OpenRScript()
        {
           return OpenFile("R|*.r");
        }

        public String OpenSqlScript()
        {
            return OpenFile("SQL|*.sql");
        }


        public (String rScript, String sqlScript) OpenRServicesFile()
        {
            String s=  OpenFile("R SQL|*.rsql");

            if(s == null)
            {
                return (null, null);
            }

            var data = serializer.Deserialize(new StringReader(s)) as RServicesFileData;


            return (data.RScript, data.SqlScript);
        }


        private void SaveFile(String content, String filter)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = filter;

            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, content);
            }
        }



        private String OpenFile(String filter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = filter;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return File.ReadAllText(openFileDialog.FileName);
            }

            return null;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ConvertXml.Handlers;
using ConvertXml.Models;
using ConvertXml.Models.OriginalXml;
using ConvertXml.Models.TranslatedXml;

namespace ConvertXml
{
    public partial class Form1 : Form
    {
        private SophiaOrder _sophiaOrder;
        public Form1()
        {
            InitializeComponent();
            
            Company_ComboBox.DataSource = Enum.GetValues(typeof(Branches));
        }

        private void Open_Xml_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog  
            {  
                InitialDirectory = @":\",
                Title = "Browse Text Files",
  
                CheckFileExists = true,
                CheckPathExists = true,
  
                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,
  
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };  
  
            if (openFileDialog.ShowDialog() == DialogResult.OK)  
            {  
                Xml_FileName.Text = openFileDialog.FileName;
                
                XmlSerializer serializer = new XmlSerializer(typeof(SophiaOrder));
                using (XmlReader reader = XmlReader.Create(openFileDialog.FileName))
                {
                    _sophiaOrder = (SophiaOrder) serializer.Deserialize(reader);
                }
            }  
            
        }

        public void HenkPraat()
        {
            Console.WriteLine("Goeie");
        }

        private void Convert_Xml_Click(object sender, EventArgs e)
        {
            if (_sophiaOrder == null)
            {
                MessageBox.Show("Kies een XML bestand");
                return;
            }

            TranslatedSophiaOrder translatedSophiaOrder = new TranslatedSophiaOrder
            {
                Id = _sophiaOrder.Id,
                Reference = _sophiaOrder.Reference,
                Description = _sophiaOrder.Description,
                OrderDate = _sophiaOrder.OrderDate,
                DeliveryDate = _sophiaOrder.DeliveryDate,
                CertificatePrice = _sophiaOrder.CertificatePrice,
                PackagingPrice = _sophiaOrder.PackagingPrice,
                TransportPrice = _sophiaOrder.TransportPrice,
                TotalPrice = _sophiaOrder.TotalPrice,
                OrderLines = TranslateHandler.HandleOrderLinesTranslation(_sophiaOrder.OrderLine)
            };
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML-File | *.xml";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = false;
            saveFileDialog.RestoreDirectory = true;
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var serializer = new XmlSerializer(translatedSophiaOrder.GetType());
                using (var writer = XmlWriter.Create(saveFileDialog.FileName))
                {
                    serializer.Serialize(writer, translatedSophiaOrder);
                }
            }
        }


        private void Company_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
    
    
}

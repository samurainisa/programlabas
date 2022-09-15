using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static WindowsFormsApp3.Lango;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Language();
        }
        XmlDocument xDoc = new XmlDocument();

        private void Language()
        {
            var serializer = new XmlSerializer(typeof(Languages));
            var dataFromXml = new List<Lang>();
            
            using (var reader = new FileStream("C://Users/ads/source/repos/WindowsFormsApp3/WindowsFormsApp3/languages.xml", FileMode.Open))
            {
                dataFromXml = ((Languages)serializer.Deserialize(reader)).Langs;

                //show name attribute of lang element
            }
            //name в listBox1
            foreach (var item in dataFromXml)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }
    }
}

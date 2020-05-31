using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_Auto
{
    public partial class Delete : Form
    {
        private readonly TextBox textBox;
        public Delete(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
        }

        private void deleteIt_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteResult = DeleteElements(delTextBox.Text);
                Main.PrintElements(textBox, deleteResult);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
            Close();
        }

        public IEnumerable<XElement> DeleteElements(string name)
        {
            XDocument xdoc = XDocument.Load(Main.source);
            IEnumerable<XElement> deleteQuery = xdoc.Element("cars")
                .Elements("car")
                .Where(s => s.Element("surname").Value.ToLower() == name.ToLower());
            while (deleteQuery.Count() > 0)
            {
                deleteQuery.ElementAt(0).Remove();
                xdoc.Save(Main.source);
            }
            return xdoc.Element("cars").Elements("car");
        }
    }
}

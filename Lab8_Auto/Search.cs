using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_Auto
{
    public partial class Search : Form
    {
        private readonly TextBox textBox;
        public Search(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
        }

        private void searchIt_Click(object sender, EventArgs e)
        {
            List<XElement> searchResult;
            
            if (fuel.Checked) searchResult = SearchList("fuel", searchTextBox.Text);
            else if (power.Checked) searchResult = SearchList("power", searchTextBox.Text);
            else if (mark.Checked) searchResult = SearchList("mark", searchTextBox.Text);
            else searchResult = SearchList("surname", searchTextBox.Text);
            Main.PrintElements(textBox, searchResult);
            Close();
        }

        public List<XElement> SearchList(string param, string paramValue)
        {
            List<XElement> list = new List<XElement>();
            try
            {
                var res = XDocument.Load(Main.source)
                    .Element("cars")
                    .Elements("car")
                    .Where(s => s.Element(param).Value.ToLower().Contains(paramValue.ToLower()));
                foreach (XElement xe in res)
                {
                    list.Add(xe);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Произошла ошибка:\n" + e.Message, "Ошибка");
            }
            return list;
        }
    }
}

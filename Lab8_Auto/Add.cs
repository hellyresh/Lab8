using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_Auto
{
    public partial class Add : Form
    {
        private readonly TextBox textBox;
        public Add(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
        }

        private void addIt_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text != "" && idmarkTextBox.Text != ""
                && markTextBox.Text != "" && fuelTextBox.Text != ""
                && tankVolTextBox.Text != "" && powerTextBox.Text != ""
                && fuelRestTextBox.Text != "" && oilVolTextBox.Text != "" &&
                int.TryParse(idmarkTextBox.Text, out _) && float.TryParse(powerTextBox.Text, out _) &&
                float.TryParse(tankVolTextBox.Text, out _) && float.TryParse(fuelRestTextBox.Text, out _) && float.TryParse(oilVolTextBox.Text, out _))
            {
                try
                {
                    var addResult = AddElement(
                        surnameTextBox.Text,
                        idmarkTextBox.Text,
                        markTextBox.Text,
                        fuelTextBox.Text,
                        powerTextBox.Text,
                        tankVolTextBox.Text,
                        fuelRestTextBox.Text,
                        oilVolTextBox.Text);
                    Main.PrintElements(textBox, addResult);
                }
                catch
                {
                    MessageBox.Show("Ошибка записи в файл");
                }
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка! Необходимо верно заополнить все поля.");
            }
        }
        public IEnumerable<XElement> AddElement(
            string surname,
            string idmark,
            string mark,
            string fuel,
            string power,
            string tankVol,
            string fuelRest,
            string oilVol)
        {
            XDocument xdoc = XDocument.Load(Main.source);
            xdoc.Element("cars").Add(new XElement("car",
                new XElement("surname", surname),
                new XElement("idmark", idmark),
                new XElement("mark", mark),
                new XElement("fuel", fuel),
                new XElement("power", power),
                new XElement("tankVol", tankVol),
                new XElement("fuelRest", fuelRest),
                new XElement("oilVol", oilVol)));
            xdoc.Save(Main.source);
            return xdoc.Element("cars").Elements("car");
        }
    }
}

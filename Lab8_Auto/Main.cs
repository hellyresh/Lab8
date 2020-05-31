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
    public partial class Main : Form
    {
        public static int gasPrice = 0, oilPrice = 0;
        public static string source = "cars.xml";
        public Main()
        {
            InitializeComponent();
        }
        public void ShowAll(object sender, EventArgs e)
        {
            try
            {
                XDocument xdoc = XDocument.Load(source);
                var cars = xdoc.Element("cars");
                gasPrice = int.Parse(cars.Element("gasPrice").Value);
                oilPrice = int.Parse(cars.Element("oilPrice").Value);
                tableView.Text = "";
                foreach (XElement xe in cars.Elements("car"))
                {
                    tableView.Text += GetCarsInfo(xe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
            }
        }
        public static string GetCarsInfo(XElement xe)
        {
            string info = "";
            XElement surname = xe.Element("surname");
            XElement idmark = xe.Element("idmark");
            XElement mark = xe.Element("mark");
            XElement fuel = xe.Element("fuel");
            XElement power = xe.Element("power");
            XElement tankVol = xe.Element("tankVol");
            XElement fuelRest = xe.Element("fuelRest");
            XElement oilVol = xe.Element("oilVol");

            if (surname != null && idmark != null && mark != null && fuel != null && tankVol != null &&
                power != null && fuelRest != null && oilVol != null &&
                surname.Value != "" && idmark.Value != "" && mark.Value != "" && fuel.Value != "" &&
                power.Value != "" && fuelRest.Value != "" && oilVol.Value != "")
            {
                info = "Фамилия: " + surname.Value + Environment.NewLine +
                    "Код марки: " + idmark.Value + Environment.NewLine +
                    "Марка автомобиля: " + mark.Value + Environment.NewLine +
                    "Требуемая марка бензина: " + fuel.Value + Environment.NewLine +
                    "Мощность двигателя: " + power.Value + Environment.NewLine +
                    "Объём бака: " + tankVol.Value + Environment.NewLine +
                    "Остаток бензина: " + fuelRest.Value + Environment.NewLine +
                    "Объём масла: " + oilVol.Value + Environment.NewLine +
                    "Цена литра бензина: " + gasPrice + Environment.NewLine +
                    "Цена заливки масла: " + oilPrice + Environment.NewLine + Environment.NewLine;
            }
            return info;
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search(tableView);
            searchForm.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Delete delForm = new Delete(tableView);
            delForm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(tableView);
            addForm.Show();
        }

        public static void PrintElements(TextBox textBox, IEnumerable<XElement> xElements)
        {
            textBox.Text = "";
            foreach (XElement xe in xElements)
            {
                textBox.Text += Main.GetCarsInfo(xe);
            }
        }

        public void SetText(string str)
        {
            tableView.Text = str;
        }


    }
}

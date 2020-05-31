using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8_Auto;
using System.IO;
using System.Windows.Forms;

namespace Lab8_Test
{
    [TestClass]
    public class UnitTest1
    {
        private static string sourcesPath = "../../../Lab8_Test/sources/";

        [TestMethod]
        public void TestParseNoName()
        {
            string expected = "";
            Main.source = sourcesPath + "f4.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoBrandId()
        {
            string expected = "";
            Main m = new Main();
            Main.source = sourcesPath + "f5.xml";
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoBrand()
        {
            string expected = "";
            Main.source = sourcesPath + "f6.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestParseNoGasoline()
        {
            string expected = "";
            Main.source = sourcesPath + "f7.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestParseNoEnginePower()
        {
            string expected = "";
            Main.source = sourcesPath + "f8.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestParseNoVolumeTank()
        {
            string expected = "";
            Main.source = sourcesPath + "f9.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestParseNoVolumeOil()
        {
            string expected = "";
            Main.source = sourcesPath + "f10.xml";
            Main m = new Main();

            Assert.AreEqual(m.tableView.Text, expected);
        }
        [TestMethod]
        public void TestAddElement()
        {
            ClearIfExists("f11.xml");
            string expected = "Фамилия: 1" + Environment.NewLine +
                    "Код марки: 2" + Environment.NewLine +
                    "Марка автомобиля: 3" + Environment.NewLine +
                    "Требуемая марка бензина: 4" + Environment.NewLine +
                    "Мощность двигателя: 5" + Environment.NewLine +
                    "Объём бака: 6" + Environment.NewLine +
                    "Остаток бензина: 7" + Environment.NewLine +
                    "Объём масла: 8" + Environment.NewLine +
                    "Цена литра бензина: 0" + Environment.NewLine +
                    "Цена заливки масла: 0" + Environment.NewLine + Environment.NewLine;
            Main.source = sourcesPath + "f11.xml";
            TextBox textBox = new TextBox();
            Add addProperties = new Add(null);
            var addResult = addProperties.AddElement("1", "2", "3", "4", "5", "6", "7", "8");
            Main.PrintElements(textBox, addResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindTwoCars()
        {
            string expected = "Фамилия: Тупин" + Environment.NewLine +
                    "Код марки: 3" + Environment.NewLine +
                    "Марка автомобиля: Волга" + Environment.NewLine +
                    "Требуемая марка бензина: gas3" + Environment.NewLine +
                    "Мощность двигателя: 100" + Environment.NewLine +
                    "Объём бака: 60" + Environment.NewLine +
                    "Остаток бензина: 10" + Environment.NewLine +
                    "Объём масла: 4" + Environment.NewLine +
                    "Цена литра бензина: 0" + Environment.NewLine +
                    "Цена заливки масла: 0" + Environment.NewLine + Environment.NewLine +
                    "Фамилия: Тупин" + Environment.NewLine +
                    "Код марки: 3" + Environment.NewLine +
                    "Марка автомобиля: Волга" + Environment.NewLine +
                    "Требуемая марка бензина: gas4" + Environment.NewLine +
                    "Мощность двигателя: 100" + Environment.NewLine +
                    "Объём бака: 60" + Environment.NewLine +
                    "Остаток бензина: 10" + Environment.NewLine +
                    "Объём масла: 4" + Environment.NewLine +
                    "Цена литра бензина: 0" + Environment.NewLine +
                    "Цена заливки масла: 0" + Environment.NewLine + Environment.NewLine;
            Main.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            Search searchProperties = new Search(null);
            var searchResult = searchProperties.SearchList("surname", "Тупин");
            Main.PrintElements(textBox, searchResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindOneCars()
        {
            string expected = "Фамилия: Путин" + Environment.NewLine +
                    "Код марки: 3" + Environment.NewLine +
                    "Марка автомобиля: Волга" + Environment.NewLine +
                    "Требуемая марка бензина: gas5" + Environment.NewLine +
                    "Мощность двигателя: 100" + Environment.NewLine +
                    "Объём бака: 60" + Environment.NewLine +
                    "Остаток бензина: 10" + Environment.NewLine +
                    "Объём масла: 4" + Environment.NewLine +
                    "Цена литра бензина: 0" + Environment.NewLine +
                    "Цена заливки масла: 0" + Environment.NewLine + Environment.NewLine;
            Main.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            Search searchProperties = new Search(null);
            var searchResult = searchProperties.SearchList("fuel", "gas5");
            Main.PrintElements(textBox, searchResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindZeroCars()
        {
            string expected = "";
            Main.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            Search searchProperties = new Search(null);
            var searchResult = searchProperties.SearchList("surname", "LOL KEK");
            Main.PrintElements(textBox, searchResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestRemoveOneElements()
        {
            ClearIfExists("f13.xml");
            string expected = "";
            Main.source = sourcesPath + "f13.xml";
            TextBox textBox = new TextBox();
            new Add(null).AddElement("1", "2", "3", "4", "5", "6", "7", "8");
            Delete delete = new Delete(null);
            var deleteResult = delete.DeleteElements("1");
            Main.PrintElements(textBox, deleteResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestRemoveTwoElements()
        {
            ClearIfExists("f14.xml");
            string expected = "";
            Main.source = sourcesPath + "f14.xml";
            TextBox textBox = new TextBox();
            new Add(null).AddElement("1", "2", "3", "4", "5", "6", "7", "8");
            new Add(null).AddElement("1", "22", "33", "44", "55", "66", "77", "88");
            Delete delete = new Delete(null);
            var deleteResult = delete.DeleteElements("1");
            Main.PrintElements(textBox, deleteResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestRemoveZeroElements()
        {
            ClearIfExists("f15.xml");
            string expected = "";
            Main.source = sourcesPath + "f15.xml";
            TextBox textBox = new TextBox();
            Delete delete = new Delete(null);
            var deleteResult = delete.DeleteElements("1");
            Main.PrintElements(textBox, deleteResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        private void ClearIfExists(string fileName)
        {
            if (File.Exists(sourcesPath + fileName))
            {
                File.Delete(sourcesPath + fileName);
                var tw = new StreamWriter(sourcesPath + fileName, true);
                tw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                tw.WriteLine("<cars>");
                tw.WriteLine("</cars>");
            }
        }
    }
}

using Lab8_Auto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Windows.Forms;

namespace Lab8_Test
{
    [TestClass]
    public class MainTest
    {
        private static string sourcesPath = "../../../Lab8_Test/sources/";

        [TestMethod]
        public void TestParseOneCar()
        {
            string expected = "Фамилия: Смирнов" +
                    "\r\nКод марки: 3" +
                    "\r\nМарка автомобиля: Лада" +
                    "\r\nТребуемая марка бензина: e92" +
                    "\r\nМощность двигателя: 100" +
                    "\r\nОбъём бака: 60" +
                    "\r\nОстаток бензина: 10" +
                    "\r\nОбъём масла: 4" +
                    "\r\nЦена литра бензина: 50" +
                    "\r\nЦена заливки масла: 40\r\n\r\n";
            Main.source = sourcesPath + "f1.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseTwoCars()
        {
            string expected = "Фамилия: Смирнов" +
                    "\r\nКод марки: 3" +
                    "\r\nМарка автомобиля: Лада" +
                    "\r\nТребуемая марка бензина: e92" +
                    "\r\nМощность двигателя: 100" +
                    "\r\nОбъём бака: 60" +
                    "\r\nОстаток бензина: 10" +
                    "\r\nОбъём масла: 4" +
                    "\r\nЦена литра бензина: 50" +
                    "\r\nЦена заливки масла: 40\r\n\r\n" +
                     "Фамилия: Волков" +
                    "\r\nКод марки: 3" +
                    "\r\nМарка автомобиля: Волга" +
                    "\r\nТребуемая марка бензина: e95" +
                    "\r\nМощность двигателя: 100" +
                    "\r\nОбъём бака: 60" +
                    "\r\nОстаток бензина: 10" +
                    "\r\nОбъём масла: 4" +
                    "\r\nЦена литра бензина: 50" +
                    "\r\nЦена заливки масла: 40\r\n\r\n";
            Main.source = sourcesPath + "f2.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoCar()
        {
            string expected = "";
            Main.source = sourcesPath + "f3.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoName()
        {
            string expected = "";
            Main.source = sourcesPath + "f4.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoIdMark()
        {
            string expected = "";
            Main m = new Main();
            Main.source = sourcesPath + "f5.xml";
            Assert.AreEqual(m.tableView.Text, expected);
        }

        [TestMethod]
        public void TestParseNoFuel()
        {
            string expected = "";
            Main.source = sourcesPath + "f7.xml";
            Main m = new Main();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        
        [TestMethod]
        public void TestAddElement()
        {
            ClearIfExists("f11.xml");
            string expected = "Фамилия: 1" +
                    "\r\nКод марки: 2" +
                    "\r\nМарка автомобиля: 3" +
                    "\r\nТребуемая марка бензина: 4" +
                    "\r\nМощность двигателя: 5" +
                    "\r\nОбъём бака: 6" +
                    "\r\nОстаток бензина: 7" +
                    "\r\nОбъём масла: 8" +
                    "\r\nЦена литра бензина: 0" +
                    "\r\nЦена заливки масла: 0\r\n\r\n";
            Main.source = sourcesPath + "f11.xml";
            TextBox textBox = new TextBox();
            Add add = new Add(null);
            var addResult = add.AddElement("1", "2", "3", "4", "5", "6", "7", "8");
            Main.PrintElements(textBox, addResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindTwoCars()
        {
            string expected = "Фамилия: Смирнов" +
                    "\r\nКод марки: 3" +
                    "\r\nМарка автомобиля: Лада" +
                    "\r\nТребуемая марка бензина: e92" +
                    "\r\nМощность двигателя: 100" +
                    "\r\nОбъём бака: 60" +
                    "\r\nОстаток бензина: 10" +
                    "\r\nОбъём масла: 4" +
                    "\r\nЦена литра бензина: 0" +
                    "\r\nЦена заливки масла: 0\r\n\r\n" +
                     "Фамилия: Волков" +
                    "\r\nКод марки: 3" +
                    "\r\nМарка автомобиля: Волга" +
                    "\r\nТребуемая марка бензина: e95" +
                    "\r\nМощность двигателя: 100" +
                    "\r\nОбъём бака: 60" +
                    "\r\nОстаток бензина: 10" +
                    "\r\nОбъём масла: 4" +
                    "\r\nЦена литра бензина: 0" +
                    "\r\nЦена заливки масла: 0\r\n\r\n";
            Main.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            Search search = new Search(null);
            var searchResult = search.SearchList("power", "100");
            Main.PrintElements(textBox, searchResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindOneCars()
        {
            string expected = "Фамилия: Смирнов" +
                    "\r\nКод марки: 3" +
                    "\r\nМарка автомобиля: Лада" +
                    "\r\nТребуемая марка бензина: e92" +
                    "\r\nМощность двигателя: 100" +
                    "\r\nОбъём бака: 60" +
                    "\r\nОстаток бензина: 10" +
                    "\r\nОбъём масла: 4" +
                    "\r\nЦена литра бензина: 0" +
                    "\r\nЦена заливки масла: 0\r\n\r\n";
            Main.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            Search search = new Search(null);
            var searchResult = search.SearchList("fuel", "e92");
            Main.PrintElements(textBox, searchResult);
            Assert.AreEqual(textBox.Text, expected);
        }

        [TestMethod]
        public void TestFindZeroCars()
        {
            string expected = "";
            Main.source = sourcesPath + "f12.xml";
            TextBox textBox = new TextBox();
            Search search = new Search(null);
            var searchResult = search.SearchList("fuel", "aaaaa");
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
                using (var tw = new StreamWriter(sourcesPath + fileName, true))
                {
                    tw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    tw.WriteLine("<cars>");
                    tw.WriteLine("</cars>");
                }
            }
        }
    }
}

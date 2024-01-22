using NUnit.Framework;
using System;

namespace docoborot.Tests
{
    [TestFixture]
    public class DogovorTests
    {
        [Test]
        public void TestOpenFileOnNewForm_Success()
        {
            Dogovor form = new Dogovor();

            // Путь к существующему файлу
            string filePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\1.txt";

            // В этом тесте мы ожидаем успешного открытия файла
            Assert.DoesNotThrow(() => form.OpenFileOnNewForm(filePath));
        }

        [Test]
        public void TestOpenFileOnNewForm_Succes()
        {
            Dogovor form = new Dogovor();

            // Путь к существующему файлу
            string filePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Договор1.docx";

            // В этом тесте мы ожидаем успешного открытия файла
            Assert.DoesNotThrow(() => form.OpenFileOnNewForm(filePath));
        }


        [Test]
        public void TestButton1Click()
        {
            Dogovor form = new Dogovor();

            // В этом тесте мы ожидаем, что нажатие кнопки 1 не вызовет исключение
            Assert.DoesNotThrow(() => form.button1_Click(null, null));
        }

        [Test]
        public void TestButton2Click()
        {
            Dogovor form = new Dogovor();

            // В этом тесте мы ожидаем, что нажатие кнопки 2 не вызовет исключение
            Assert.DoesNotThrow(() => form.button2_Click(null, null));
        }

        [Test]
        public void TestCvitanceClick()
        {
            Dogovor form = new Dogovor();

            // В этом тесте мы ожидаем, что нажатие кнопки cvitance не вызовет исключение
            Assert.DoesNotThrow(() => form.cvitance_Click(null, null));
        }
    }
}












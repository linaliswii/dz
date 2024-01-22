using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace docoborot
{
    public partial class Dogovor : Form
    {
        public Dogovor(string username)
        {
            InitializeComponent();
            UpdateLoggedInUserLabel(username);
        }
        public Dogovor()
        {
            InitializeComponent();
        }
        private void UpdateLoggedInUserLabel(string username)
        {
            lblLoggedInUser.Text = $"Логин: {username}";
        }
        public void OpenFileOnNewForm(string filePath)
        {
            try
            {
                // Используем Process.Start для открытия файла с использованием программы по умолчанию
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal void button2_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Договор1.docx";
            OpenFileOnNewForm(filePath);
        }

        private void Dogovor_Load(object sender, EventArgs e)
        {

        }
        internal void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Договор1.txt";
            OpenFileOnNewForm(filePath);
        }

        internal void cvitance_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\liswi\\source\\repos\\docoborot\\docoborot\\bin\\Debug\\Квитанция1.docx";
            OpenFileOnNewForm(filePath);
        }
    }
}
